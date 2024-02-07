using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared.DTO.ServiceType;
using System;
using System.Threading.Tasks;

namespace diploma_thesis_backend.Controllers
{
    [Route("/service-types")]
    [ApiController]
    [Produces("application/json")]
    public class ServiceTypesController : Controller
    {
        private readonly IServiceTypeService _serviceTypeService;
        private readonly ILogger<ServiceTypesController> _logger;

        public ServiceTypesController(IServiceTypeService serviceTypeService, ILogger<ServiceTypesController> logger)
        {
            _serviceTypeService = serviceTypeService;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> CreateServiceType([FromBody] CreateNewServiceTypeDto createNewServiceTypeDto)
        {
            try
            {
                var result = await _serviceTypeService.CreateServiceTypeAsync(createNewServiceTypeDto);
                if (result)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest("Failed to create service type");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating service type");
                return StatusCode(500, "An error occurred while creating the service type");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateServiceType([FromBody] UpdateServiceTypeDto updateServiceTypeDto)
        {
            try
            {
                var result = await _serviceTypeService.UpdateServiceTypeAsync(updateServiceTypeDto);
                if (result)
                {
                    return Ok("Successfully updated ServiceType.");
                }
                else
                {
                    return BadRequest("Failed to update service type");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating service type");
                return StatusCode(500, "An error occurred while updating the service type");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllServiceTypes()
        {
            try
            {
                var serviceTypes = await _serviceTypeService.GetAllActiveServiceTypesAsync();
                return Ok(serviceTypes); // Always return OK with the list (even if it's empty)
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving service types");
                return StatusCode(500, "An error occurred while retrieving service types");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteServiceType(int id)
        {
            try
            {
                var success = await _serviceTypeService.SoftDeleteServiceTypeAsync(id);
                if (success)
                {
                    return Ok("Success");
                }
                else
                {
                    return BadRequest("Failed");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting service type with ID {ServiceTypeId}", id);
                return StatusCode(500, "An error occurred while deleting the service type");
            }
        }
    }
}
