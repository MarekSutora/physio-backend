using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Shared.DTO.Auth;
using Application.Services.Interfaces;
using Application.Common.Auth;
using System.IdentityModel.Tokens.Jwt;

namespace diploma_thesis_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IConfiguration _configuration;
        private readonly ILogger<AuthController> _logger;

        public AuthController(
                       IAuthService authService, IConfiguration configuration, ILogger<AuthController> logger
                   )
        {
            _authService = authService;
            _configuration = configuration;
            _logger = logger;
        }

        [HttpPost]
        [Route("RegisterPatient")]
        public async Task<IActionResult> RegisterPatientAsync([FromBody] RegisterRequestDto registerRequestDto)
        {
            var registrationResult = await _authService.RegisterPatientAsync(registerRequestDto);

            return registrationResult switch
            {
                RegisterUserResult.Success => Ok(new { message = "Registrácia prebehla úspešne." }),
                RegisterUserResult.EmailAlreadyInUse => BadRequest(new { message = "Email je už použítý." }),
                _ => BadRequest(new { message = "Registrácia zlyhala." }),
            };
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginRequestDto loginRequestDto)
        {
            var result = await _authService.LoginUserAsync(loginRequestDto);

            if (result.Outcome == LoginUserResult.LoginUserOutcome.Success)
            {
                return Ok(new
                {
                    User = new
                    {
                        UserId = result.UserId,
                        FullName = result.FullName,
                        Roles = result.roles,
                        ClientId = result.ClientId
                    },
                    BackendTokens = new
                    {
                        AccessToken = result.AccessToken,
                        RefreshToken = result.RefreshToken,
                        ExpirationDate = result.ExpiryDate
                    }
                });
            }
            else
            {
                return BadRequest("Nesprávne prihlasovacie údaje.");
            }
        }

        [HttpPost("RefreshToken")]
        public async Task<IActionResult> RefreshTokenAsync([FromBody] RefreshTokenRequestDto refreshTokenRequest)
        {
            var result = await _authService.RefreshTokenAsync(refreshTokenRequest.RefreshToken);

            if (result is null)
            {
                return Unauthorized("Invalid refresh token.");
            }

            return Ok(new
            {
                jwtToken = result.AccessToken,
                refreshToken = result.RefreshToken,
                expiryDate = result.ExpiryDate
            });
        }

        [HttpGet("ConfirmEmail")]
        public async Task<IActionResult> ConfirmEmailAsync([FromQuery] string userId, [FromQuery] string code)
        {
            try
            {
                var result = await _authService.ConfirmEmailAsync(userId, code);
                if (result)
                {
                    var frontendUrl = _configuration["Cors:AllowedOrigin"];

                    var loginUrl = $"{frontendUrl}/prihlasenie?emailConfirmed=success";
                    return Redirect(loginUrl);
                }
                else
                {
                    return BadRequest(new { message = "Email sa nepodarilo potvrdiť." });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPasswordAsync([FromBody] ResetPasswordRequestDto resetPasswordRequestDto)
        {
            var result = await _authService.ResetPasswordAsync(resetPasswordRequestDto);
            if (result)
            {
                return Ok(new { message = "Heslo bolo úspešne zmenené." });
            }
            else
            {
                return BadRequest(new { message = "Heslo sa nepodarilo zmeniť." });
            }
        }

        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPasswordAsync([FromBody] ForgotPasswordRequestDto forgotPasswordRequestDto)
        {
            try
            {
                await _authService.ForgotPasswordAsync(forgotPasswordRequestDto);
                return Ok(new { message = "Email s inštrukciami na resetovanie hesla bol odoslaný." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
