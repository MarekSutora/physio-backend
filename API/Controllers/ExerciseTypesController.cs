using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace diploma_thesis_backend.Controllers
{

    [ApiController]
    [Route("exercise-types/")]
    [Produces("application/json")]
    public class ExerciseTypesController : ControllerBase
    {
        public readonly ILogger<ExerciseTypesController> _logger;
        public readonly IExerciseTypesService _exerciseTypesService;

        public ExerciseTypesController(ILogger<ExerciseTypesController> logger, IExerciseTypesService exerciseTypesService)
        {
            _logger = logger;
            _exerciseTypesService = exerciseTypesService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllExerciseTypesAsync()
        {
            try
            {
                var exerciseTypes = await _exerciseTypesService.GetAllExerciseTypesAsync();
                return Ok(exerciseTypes);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting all exercise types");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
