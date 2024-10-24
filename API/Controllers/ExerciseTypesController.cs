﻿using Application.Services.Interfaces;
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
        public async Task<IActionResult> GetExerciseTypesAsync()
        {
            _logger.LogInformation("Getting all exercise types.");
            try
            {
                var exerciseTypes = await _exerciseTypesService.GetExerciseTypesAsync();

                if (exerciseTypes != null && exerciseTypes.Any())
                {
                    _logger.LogInformation("Exercise types successfully retrieved.");
                    return Ok(exerciseTypes);
                }
                else
                {
                    _logger.LogInformation("No exercise types found.");
                    return NotFound("Neboli nájdené žiadne typy cvičení.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting all exercise types.");
                return BadRequest("Chyba pri získavaní všetkých typov cvičení.");
            }
        }
    }
}
