﻿using Microsoft.AspNetCore.Authentication.Cookies;
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

        [HttpPost("register-client")]
        public async Task<IActionResult> RegisterClientAsync([FromBody] RegisterRequestDto registerRequestDto)
        {
            try
            {
                var registrationResult = await _authService.RegisterClientAsync(registerRequestDto);

                return registrationResult switch
                {
                    RegisterUserResult.Success => Ok(new { message = "Registrácia prebehla úspešne." }),
                    RegisterUserResult.EmailAlreadyInUse => BadRequest(new { message = "Email je už použítý." }),
                    _ => BadRequest(new { message = "Nastala chyba počas registrácie." }),
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Nastala chyba počas registrácie.");
                return BadRequest(new { message = "Nastala chyba počas registrácie." });
            }
        }

        [HttpPost("Login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginRequestDto loginRequestDto)
        {
            try
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
            catch (Exception ex)
            {
                _logger.LogError(ex, "Nastala chyba pri prihlasovaní.");
                return BadRequest(new { message = "Nastala chyba pri prihlasovaní." });
            }
        }

        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshTokenAsync([FromBody] RefreshTokenRequestDto refreshTokenRequest)
        {
            try
            {
                var result = await _authService.RefreshTokenAsync(refreshTokenRequest.RefreshToken);

                if (result is null)
                {
                    return Unauthorized("Nevalídny refresh token.");
                }

                return Ok(new
                {
                    jwtToken = result.AccessToken,
                    refreshToken = result.RefreshToken,
                    expiryDate = result.ExpiryDate
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Nastala chyba pri získavaní refresh tokenu.");
                return BadRequest(new { message = "Nastala chyba pri získavaní refresh tokenu." });
            }
        }

        [HttpGet("confirm-email")]
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
                    return BadRequest(new { message = "Nastala chyba pri potvrdzovaní emailu." });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Nastala chyba pri potvrdzovaní emailu.");
                return BadRequest(new { message = "Nastala chyba pri potvrdzovaní emailu." });
            }

        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPasswordAsync([FromBody] ResetPasswordRequestDto resetPasswordRequestDto)
        {
            try
            {
                var result = await _authService.ResetPasswordAsync(resetPasswordRequestDto);
                if (result)
                {
                    return Ok(new { message = "Heslo bolo úspešne zmenené." });
                }
                else
                {
                    return BadRequest(new { message = "Nastala chyba pri zmene hesla." });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Nastala chyba pri zmene hesla.");
                return BadRequest(new { message = "Nastala chyba pri zmene hesla." });
            }
        }

        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPasswordAsync([FromBody] ForgotPasswordRequestDto forgotPasswordRequestDto)
        {
            try
            {
                await _authService.ForgotPasswordAsync(forgotPasswordRequestDto);
                return Ok(new { message = "Email s inštrukciami na obnovenie hesla bol odoslaný." });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Nastala chyba pri odosielaní emailu na obnovenie hesla.");
                return BadRequest(new { message = "Nastala chyba pri odosielaní emailu na obnovenie hesla." });
            }
        }
    }
}
