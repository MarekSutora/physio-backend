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

        public AuthController(
                       IAuthService authService
                   )
        {
            _authService = authService;
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
    }
}
