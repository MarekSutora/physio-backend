using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Shared.DTO.Auth;
using Application.Services.Interfaces;
using Application.Common.Auth;

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
                return Ok("Successfully logged in.");
            }
            else
            {
                return Unauthorized("Login Failed.");
            }
        }

        [HttpPost]
        [Route("Logout")]
        public async Task<IActionResult> Logout()
        {
            throw new NotImplementedException();
        }
    }
}
