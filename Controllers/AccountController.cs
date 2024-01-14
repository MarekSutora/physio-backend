using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

namespace diploma_thesis_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
   
        public AccountController()
        {

        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDto registerRequestDto)
        {
            if (ModelState.IsValid)
            {
                // Check if the email already exists
                var existingUser = await _userManager.FindByEmailAsync(registerRequestDto.Email);
                if (existingUser != null)
                {
                    return BadRequest("Email already in use.");
                }

                // Create a new user
                var user = new ApplicationUser { 
                    UserName = registerRequestDto.Email,
                    Email = registerRequestDto.Email,
                    Name = "test",
                    DateCreated = DateTime.Now
                };
                var result = await _userManager.CreateAsync(user, registerRequestDto.Password);

                if (result.Succeeded)
                {
                    // User creation successful, proceed with additional tasks like sending a confirmation email
                    return Ok(new { message = "User registered successfully." });
                }
                else
                {
                    // Return errors (e.g., password complexity)
                    return BadRequest(result.Errors);
                }
            }
            // Invalid model state
            return BadRequest("Invalid user data.");
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO loginRequestDto)
        {
            var user = await _userManager.FindByEmailAsync(loginRequestDto.Email);
            if (user != null)
            {
                var signInResult = await _userManager.CheckPasswordAsync(user, loginRequestDto.Password);
                if (signInResult)
                {
                    var claimsPrincipal = await _signInManager.CreateUserPrincipalAsync(user);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal, new AuthenticationProperties
                    {
                        IsPersistent = true
                    });
                    
                    return Ok("Successfully logged in.");
                }
            }
            return Unauthorized();
        }

        [HttpPost]
        [Route("Logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Ok();
        }
    }
}
