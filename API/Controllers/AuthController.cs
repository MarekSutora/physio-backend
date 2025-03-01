﻿using Application.Common.Auth;
using Application.DTO.Auth;
using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace diploma_thesis_backend.Controllers
{
    [ApiController]
    [Route("auth")]
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

        [HttpGet("confirm-email")]
        public async Task<IActionResult> ConfirmEmailAsync([FromQuery] string userId, [FromQuery] string code)
        {
            _logger.LogInformation($"Confirming email for user with UserId = {userId}.");
            try
            {
                await _authService.ConfirmEmailAsync(userId, code);

                var frontendUrl = _configuration["Cors:AllowedOrigin"];

                var loginUrl = $"{frontendUrl}/prihlasenie?emailConfirmed=success";
                return Redirect(loginUrl);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error when confirming email for user with UserId = {userId}");
                return BadRequest(new { message = "Nastala chyba pri potvrdzovaní emailu." });
            }

        }

        [HttpPost("register-client")]
        public async Task<IActionResult> RegisterClientAsync([FromBody] RegisterRequestDto registerRequestDto)
        {
            _logger.LogInformation("Registering new client.");
            try
            {
                var registrationResult = await _authService.RegisterClientAsync(registerRequestDto);

                return registrationResult switch
                {
                    RegisterUserResult.Success => Ok("Registrácia prebehla úspešne."),
                    RegisterUserResult.EmailAlreadyInUse => BadRequest("Email už existuje."),
                    RegisterUserResult.Failure => BadRequest("Nastala chyba počas registrácie."),
                    _ => BadRequest("Nastala chyba počas registrácie."),
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred during client registration.");
                return BadRequest("Nastala chyba počas registrácie.");
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginUserAsync([FromBody] LoginRequestDto loginRequestDto)
        {
            _logger.LogInformation("Logging in user.");
            try
            {
                var result = await _authService.LoginUserAsync(loginRequestDto);

                if (result.Outcome == LoginUserResult.LoginUserOutcome.Success)
                {
                    _logger.LogInformation("User logged in successfully.");

                    return Ok(new
                    {

                        User = new
                        {
                            UserId = result.UserId,
                            FullName = result.FullName,
                            Roles = result.roles,
                            PersonId = result.PersonId
                        },
                        UserTokens = new
                        {
                            AccessToken = result.AccessToken,
                            RefreshToken = result.RefreshToken,
                            AccessTokenExpirationDate = result.ExpiryDate
                        }
                    });
                }
                else if (result.Outcome == LoginUserResult.LoginUserOutcome.EmailNotConfirmed)
                {
                    return BadRequest("Email nie je potvrdený.");
                }
                else if (result.Outcome == LoginUserResult.LoginUserOutcome.UserLockedOut)
                {
                    return BadRequest("Účet je zablokovaný. Skúste sa prihlásiť neskôr.");
                }
                else
                {
                    return BadRequest("Nesprávne prihlasovacie údaje.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error when logging in a user.");
                return BadRequest("Nastala chyba pri prihlasovaní.");
            }
        }

        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshTokenAsync([FromBody] RefreshTokenRequestDto refreshTokenRequest)
        {
            _logger.LogInformation("Refreshing JWT token.");
            try
            {
                var result = await _authService.RefreshTokenAsync(refreshTokenRequest.RefreshToken);

                if (result != null)
                {
                    return Ok(new
                    {
                        AccessToken = result.AccessToken,
                        RefreshToken = result.RefreshToken,
                        ExpirationDate = result.ExpiryDate
                    });
                }
                else
                {
                    return Unauthorized("Nevalidný refresh token.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error when refreshing token.");
                return BadRequest("Nastala chyba pri refreshovani tokenu.");
            }
        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPasswordAsync([FromBody] ResetPasswordRequestDto resetPasswordRequestDto)
        {
            _logger.LogInformation("Resetting user password.");
            try
            {
                await _authService.ResetPasswordAsync(resetPasswordRequestDto);

                return Ok("Heslo bolo úspešne zmenené.");

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error when resetting password.");
                return BadRequest("Nastala chyba pri zmene hesla.");
            }
        }

        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPasswordAsync([FromBody] ForgotPasswordRequestDto forgotPasswordRequestDto)
        {
            _logger.LogInformation("Sending email for password reset.");
            try
            {
                await _authService.ForgotPasswordAsync(forgotPasswordRequestDto);
                return Ok("Email s inštrukciami na obnovenie hesla bol odoslaný.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error when sending email.");
                return BadRequest("Nastala chyba pri odosielaní emailu na obnovenie hesla.");
            }
        }
    }
}
