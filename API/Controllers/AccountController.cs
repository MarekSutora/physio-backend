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
    public class AccountController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AccountController(
                       IAuthService authService
                   )
        {
            _authService = authService;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDto registerRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid user data.");
            }

            var registrationResult = await _authService.RegisterUserAsync(registerRequestDto);

            return registrationResult switch
            {
                RegisterUserResult.Success => Ok(new { message = "User registered successfully." }),
                RegisterUserResult.EmailAlreadyInUse => BadRequest("Email already in use."),
                _ => BadRequest("Registration failed."),
            };
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto loginRequestDto)
        {
            var result = await _authService.LoginUserAsync(loginRequestDto);

            if (result.Outcome == LoginUserResult.LoginUserOutcome.Success)
            {
                return Ok(new
                {
                    jwtToken = result.AccessToken,
                    refreshToken = result.RefreshToken,
                    expiryDate = result.ExpiryDate
                });
            }
            else
            {
                return Unauthorized("Login Failed.");
            }
        }

        [HttpPost("RefreshToken")]
        public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenRequestDto refreshTokenRequest)
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
