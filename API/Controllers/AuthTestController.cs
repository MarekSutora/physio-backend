using DataAccess.Model.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks; // Replace with your actual namespace where ApplicationUser is defined

namespace diploma_thesis_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthTestController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AuthTestController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        // Endpoint accessible by Admin role
        [HttpGet("test-admin")]
        [Authorize(Policy = "Admin")]
        public IActionResult TestAdminRole()
        {
            return Ok("Endpoint accessible by Admin role.");
        }

        // Endpoint accessible by Physiotherapist role
        [HttpGet("test-physio")]
        [Authorize(Policy = "Physiotherapist")] // Assuming you've named the policy "Employee" for Physiotherapists
        public IActionResult TestPhysiotherapistRole()
        {
            return Ok("Endpoint accessible by Physiotherapist role.");
        }

        // Endpoint accessible by Patient role
        [HttpGet("test-patient")]
        [Authorize(Policy = "Patient")]
        public IActionResult TestPatientRole()
        {
            return Ok("Endpoint accessible by Patient role.");
        }

        // Endpoint to test user accessing their own data
        [HttpGet("user-data/{userId}")]
        [Authorize] // All authenticated users have access
        public IActionResult UserData(string userId)
        {
            var id = User.FindFirst("uid")?.Value;
            if (id != userId)
            {
                return Forbid("You are not allowed to access someone else's data.");
            }

            // Assuming you have a method to get user data
            var userData = GetUserData(userId);
            return Ok(userData);
        }

        private object GetUserData(string userId)
        {
            // Placeholder for the actual logic to get user data
            return new { Message = "User data for user with ID: " + userId };
        }
    }
}
