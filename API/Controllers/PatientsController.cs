
using Microsoft.AspNetCore.Mvc;
using Application.Services.Interfaces;

namespace diploma_thesis_backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    //[Authorize(Roles = "Admin")]
    public class PatientsController : Controller
    {
        private readonly IPatientsService _patientService;

        public PatientsController(IPatientsService patientService)
        {
            _patientService = patientService;
        }

        // GET: api/patients/patients-for-booked-reservation
        [HttpGet("patients-for-booked-reservation")]
        public async Task<IActionResult> GetPatientsForBookedReservation()
        {
            try
            {
                var patients = await _patientService.GetAllForBookedReservationAsync();
                return Ok(patients);
            }
            catch (Exception ex)
            {
                // Log the exception details
                // Return an appropriate error response
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }
    }
}
