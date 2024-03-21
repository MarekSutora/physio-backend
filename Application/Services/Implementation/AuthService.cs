using Application.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Shared.DTO.Auth;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Application.Common.Auth;
using static Application.Common.Auth.LoginUserResult;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using DataAccess;
using Application.Common.Email;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using AutoMapper.Internal;
using Microsoft.Extensions.Logging;
using Azure;
using DataAccess.Entities;

namespace Application.Services.Implementation
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly JwtSettings _jwtSettings;
        private readonly ApplicationDbContext _context;
        private readonly IEmailService _emailService;
        private readonly IConfiguration _configuration;

        public AuthService(UserManager<ApplicationUser> userManager,
                IOptions<JwtSettings> jwtSettings,
                SignInManager<ApplicationUser> signInManager,
                ApplicationDbContext dbContext,
                IEmailService emailService,
                IConfiguration configuration,
                ILogger<AuthService> logger)
        {
            _userManager = userManager;
            _jwtSettings = jwtSettings.Value;
            _signInManager = signInManager;
            _context = dbContext;
            _emailService = emailService;
            _configuration = configuration;
            _logger = logger;
        }

        public async Task<LoginUserResult> LoginUserAsync(LoginRequestDto loginRequestDto)
        {
            var user = await _userManager.FindByEmailAsync(loginRequestDto.Email);

            if (user == null)
            {
                return new LoginUserResult { Outcome = LoginUserOutcome.UserNotRegistered };
            }

            var person = await _context.Persons.FirstOrDefaultAsync(p => p.Id == user.PersonId);

            if (person == null)
            {
                return new LoginUserResult { Outcome = LoginUserOutcome.UserNotRegistered };
            }

            var result = await _signInManager.PasswordSignInAsync(user.Email, loginRequestDto.Password, false, lockoutOnFailure: false);
            if (!result.Succeeded)
            {
                return new LoginUserResult { Outcome = LoginUserOutcome.InvalidCredentials };
            }

            var roles = await _userManager.GetRolesAsync(user);

            var jwtSecurityToken = await GenerateJwtToken(user);

            return new LoginUserResult
            {
                roles = roles,
                FullName = $"{person.FirstName} {person.LastName}",
                ClientId = person.Id,
                UserId = user.Id,
                Outcome = LoginUserOutcome.Success,
                AccessToken = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
                RefreshToken = await GenerateRefreshToken(user),
                ExpiryDate = jwtSecurityToken.ValidTo
            };
        }

        public async Task<LoginUserResult> RefreshTokenAsync(string refreshToken)
        {
            var user = await GetUserByRefreshTokenAsync(refreshToken);
            if (user == null || user.RefreshToken != refreshToken || user.RefreshTokenExpiryTime <= DateTime.UtcNow)
            {
                throw new Exception("Error when refreshing access token.");
            }

            var newJwtToken = await GenerateJwtToken(user);
            var newRefreshToken = await GenerateRefreshToken(user);

            return new LoginUserResult
            {
                Outcome = LoginUserOutcome.Success,
                AccessToken = new JwtSecurityTokenHandler().WriteToken(newJwtToken),
                RefreshToken = newRefreshToken,
                ExpiryDate = newJwtToken.ValidTo
            };
        }

        public async Task<RegisterUserResult> RegisterClientAsync(RegisterRequestDto registerRequestDto)
        {
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    var userWithSameEmail = await _userManager.FindByEmailAsync(registerRequestDto.Email);
                    if (userWithSameEmail != null)
                    {
                        return RegisterUserResult.EmailAlreadyInUse;
                    }

                    // Create a new Person entity
                    var person = new Person
                    {
                        FirstName = registerRequestDto.FirstName,
                        LastName = registerRequestDto.LastName,
                        PhoneNumber = registerRequestDto.PhoneNumber
                    };

                    await _context.Persons.AddAsync(person);
                    await _context.SaveChangesAsync();

                    var user = new ApplicationUser
                    {
                        UserName = registerRequestDto.Email,
                        Email = registerRequestDto.Email,
                        PersonId = person.Id,
                        RegisteredDate = DateTime.Now
                    };

                    var userCreationResult = await _userManager.CreateAsync(user, registerRequestDto.Password);
                    if (!userCreationResult.Succeeded)
                    {
                        await transaction.RollbackAsync();
                        return RegisterUserResult.Failure;
                    }

                    var emailSent = await SendVerificationEmail(user);
                    if (!emailSent)
                    {
                        await transaction.RollbackAsync();
                        return RegisterUserResult.Failure;
                    }

                    var addToRoleResult = await _userManager.AddToRoleAsync(user, "Client");
                    if (!addToRoleResult.Succeeded)
                    {
                        await transaction.RollbackAsync();
                        return RegisterUserResult.Failure;
                    }

                    // If all operations succeeded, commit the transaction
                    await transaction.CommitAsync();
                    return RegisterUserResult.Success;
                }
                catch
                {
                    // If an exception is thrown, roll back all database operations
                    await transaction.RollbackAsync();
                    throw;
                }
            }
        }

        private async Task SendVerificationEmail(ApplicationUser user)
        {
            var origin = _configuration["Cors:AllowedOrigin"];
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            var route = "apinet/auth/confirmEmail";
            var _enpointUri = new Uri(string.Concat($"{origin}/", route));
            var verificationUri = QueryHelpers.AddQueryString(_enpointUri.ToString(), "userId", user.Id);
            verificationUri = QueryHelpers.AddQueryString(verificationUri, "code", code);

            var emailRequest = new EmailRequest
            {
                ToEmail = user.Email,
                Subject = "Potvrdenie registrácie",
                Body = $"Prosím potvrďte svoju registráciu kliknutím na <a href='{verificationUri}'>tento odkaz</a>",
            };

            await _emailService.SendEmailAsync(emailRequest);
        }

        public async Task ConfirmEmailAsync(string userId, string code)
        {

            var user = await _userManager.FindByIdAsync(userId);
            code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
            var result = await _userManager.ConfirmEmailAsync(user, code);

            if (!result.Succeeded)
            {
                throw new Exception("Error confirming email.");
            }
        }

        public async Task<bool> VerifyClientByIdAsync(int clientId, string userId)
        {

            var client = await _context.Clients
                                .Include(p => p.Person)
                                .ThenInclude(p => p.ApplicationUser)
                                .FirstOrDefaultAsync(p => p.PersonId == clientId);

            if (client != null && client.Person.ApplicationUser.Id == userId)
            {
                return true;
            }

            return false;
        }

        public async Task ForgotPasswordAsync(ForgotPasswordRequestDto forgotPasswordRequestDto)
        {

            var user = await _userManager.FindByEmailAsync(forgotPasswordRequestDto.Email);

            if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
            {
                return;
            }

            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            var encodedToken = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

            var origin = _configuration["Cors:AllowedOrigin"];
            var route = "obnovenie-hesla"; // This should match the client-side route
            var endpointUri = new Uri(string.Concat($"{origin}/", route));
            var passwordResetUrl = QueryHelpers.AddQueryString(endpointUri.ToString(), "token", encodedToken);

            // Add email to the query string
            passwordResetUrl = QueryHelpers.AddQueryString(passwordResetUrl, "email", forgotPasswordRequestDto.Email);

            var emailRequest = new EmailRequest()
            {
                Body = $"If you requested a password reset for {origin}, please follow the link below: <a href='{passwordResetUrl}'>Reset Password</a>",
                ToEmail = forgotPasswordRequestDto.Email,
                Subject = "Password Reset Request",
            };

            await _emailService.SendEmailAsync(emailRequest);
        }

        public async Task ResetPasswordAsync(ResetPasswordRequestDto resetPasswordRequestDto)
        {
            var user = await _userManager.FindByEmailAsync(resetPasswordRequestDto.Email);
            if (user == null) throw new Exception($"No Accounts Registered with {resetPasswordRequestDto.Email}.");
            var result = await _userManager.ResetPasswordAsync(user, Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(resetPasswordRequestDto.Token)), resetPasswordRequestDto.Password);

            if (!result.Succeeded)
            {
                throw new Exception("Error resetting password.");
            }
        }

        private async Task<JwtSecurityToken> GenerateJwtToken(ApplicationUser user)
        {
            var userClaims = await _userManager.GetClaimsAsync(user);
            var roles = await _userManager.GetRolesAsync(user);

            var roleClaims = roles.Select(role => new Claim(ClaimTypes.Role, role)).ToList();

            var claims = new List<Claim>
                {
                    new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Email, user.Email),
                    new Claim("userId", user.Id)
                }
            .Union(userClaims)
            .Union(roleClaims);

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(_jwtSettings.DurationInMinutes),
                signingCredentials: signingCredentials);
            return jwtSecurityToken;
        }

        private async Task<string> GenerateRefreshToken(ApplicationUser user)
        {
            var refreshToken = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64));
            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(7);
            await _userManager.UpdateAsync(user);
            return refreshToken;
        }

        private async Task<ApplicationUser> GetUserByRefreshTokenAsync(string refreshToken)
        {
            return await _userManager.Users
                .FirstOrDefaultAsync(u => u.RefreshToken == refreshToken && u.RefreshTokenExpiryTime > DateTime.UtcNow);
        }
    }
}