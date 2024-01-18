using Application.Services.Interfaces;
using Azure;
using DataAccess.Model.Entities;
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

namespace Application.Services.Implementation
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly JwtSettings _jwtSettings;

        public AuthService(UserManager<ApplicationUser> userManager,
                IOptions<JwtSettings> jwtSettings,
                SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _jwtSettings = jwtSettings.Value;
            _signInManager = signInManager;
        }

        public Task<ConfirmEmailResult> ConfirmEmailAsync(ConfirmEmailRequestDto confirmEmailRequestDto)
        {
            throw new NotImplementedException();
        }

        public Task ForgotPasswordAsync(ForgotPasswordRequestDto forgotPasswordRequestDto)
        {
            throw new NotImplementedException();
        }

        public async Task<LoginUserResult> LoginUserAsync(LoginRequestDto loginRequestDto)
        {
            var user = await _userManager.FindByEmailAsync(loginRequestDto.Email);
            if (user == null)
            {
                return new LoginUserResult { Outcome = LoginUserOutcome.UserNotRegistered };
            }

            var result = await _signInManager.PasswordSignInAsync(user.Email, loginRequestDto.Password, false, lockoutOnFailure: false);
            if (!result.Succeeded)
            {
                return new LoginUserResult { Outcome = LoginUserOutcome.InvalidCredentials };
            }

            // Assuming GenerateJwtToken is a method that generates the JWT token
            var jwtSecurityToken = await GenerateJwtToken(user);

            return new LoginUserResult
            {
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
                return null; // Or throw an appropriate exception
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

        public async Task<RegisterUserResult> RegisterUserAsync(RegisterRequestDto registerRequestDto)
        {
            var userWithSameEmail = await _userManager.FindByEmailAsync(registerRequestDto.Email);
            if (userWithSameEmail != null)
            {
                return RegisterUserResult.EmailAlreadyInUse;
            }
            var user = new ApplicationUser
            {
                UserName = registerRequestDto.Email,
                Email = registerRequestDto.Email
            };

            var result = await _userManager.CreateAsync(user, registerRequestDto.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "Basic");
            }
            else
            {
                return RegisterUserResult.Failure;
            }

            return RegisterUserResult.Success;
        }

        public Task<Response<string>> ResetPassword(ResetPasswordRequestDto resetPasswordRequestDto)
        {
            throw new NotImplementedException();
        }

        public Task<ResetPasswordResult> ResetPasswordAsync(ResetPasswordRequestDto resetPasswordRequestDto)
        {
            throw new NotImplementedException();
        }

        private async Task<JwtSecurityToken> GenerateJwtToken(ApplicationUser user)
        {
            var userClaims = await _userManager.GetClaimsAsync(user);
            var roles = await _userManager.GetRolesAsync(user);

            var roleClaims = new List<Claim>();

            for (int i = 0; i < roles.Count; i++)
            {
                roleClaims.Add(new Claim("roles", roles[i]));
            }


            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("uid", user.Id),
            }
            .Union(userClaims)
            .Union(roleClaims);

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: null,
                audience: null,
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