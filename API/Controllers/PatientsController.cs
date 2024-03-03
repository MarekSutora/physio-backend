
using Microsoft.AspNetCore.Mvc;
using Application.Services.Interfaces;

namespace diploma_thesis_backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Produces("application/json")]
    //[Authorize(Roles = "Admin")]
    public class PatientsController : Controller
    {
        private readonly IPatientsService _patientService;
        public readonly ILogger<PatientsController> _logger;

        public PatientsController(IPatientsService patientService, ILogger<PatientsController> logger)
        {
            _patientService = patientService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPatientsAsync()
        {
            try
            {
                var patients = await _patientService.GetAllPatientsAsync();
                return Ok(patients);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while getting all patients");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
