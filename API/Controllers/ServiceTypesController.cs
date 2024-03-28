using Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Application.DTO.ServiceType.Request;
using System;
using System.Threading.Tasks;
using Application.Utilities;

namespace diploma_thesis_backend.Controllers
{
    [Route("/service-types")]
    [ApiController]
    [Produces("application/json")]
    public class ServiceTypesController : ControllerBase
    {
        private readonly IServiceTypesService _serviceTypesService;
        private readonly ILogger<ServiceTypesController> _logger;

        public ServiceTypesController(IServiceTypesService serviceTypeService, ILogger<ServiceTypesController> logger)
        {
            _serviceTypesService = serviceTypeService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetActiveServiceTypesAsync()
        {
            _logger.LogInformation("Retrieving all service types.");
            try
            {
                var serviceTypes = await _serviceTypesService.GetActiveServiceTypesAsync();

                if (serviceTypes != null && serviceTypes.Any())
                {
                    _logger.LogInformation("Service types successfully retrieved");
                    return Ok(serviceTypes);
                }
                else
                {
                    _logger.LogInformation("No service types found");
                    return NotFound("No service types found");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving service types");
                return BadRequest("An error occurred while retrieving service types");
            }
        }

        [HttpGet("{slug}")]
        public async Task<IActionResult> GetServiceTypeBySlugAsync(string slug)
        {
            _logger.LogInformation($"Retrieving service type by slug {slug}");
            try
            {
                var serviceType = await _serviceTypesService.GetServiceTypeBySlugAsync(slug);

                if (serviceType != null)
                {
                    _logger.LogInformation($"Service type with slug {slug} successfully retrieved");
                    return Ok(serviceType);
                }
                else
                {
                    _logger.LogInformation($"Service type with slug {slug} not found");
                    return NotFound("Service type not found");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving service type by slug {ServiceTypeSlug}", slug);
                return BadRequest("An error occurred while retrieving the service type");
            }
        }

        [Authorize(Policy = "Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateServiceTypeAsync([FromBody] CreateServiceTypeDto createNewServiceTypeDto)
        {
            _logger.LogInformation("Creating new service type");
            try
            {
                await _serviceTypesService.CreateServiceTypeAsync(createNewServiceTypeDto);

                _logger.LogInformation("Service type created or reactivated successfully.");
                return Ok("Service type created or reactivated successfully");
            }
            catch (AlreadyExistsException ex)
            {
                _logger.LogError(ex, "Error creating service type");
                return BadRequest("Service type with this name already exists.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating service type");
                return BadRequest("An error occurred while creating the service type");
            }
        }

        [Authorize(Policy = "Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateServiceTypeAsync([FromBody] UpdateServiceTypeDto updateServiceTypeDto)
        {
            _logger.LogInformation($"Updating service type with ID {updateServiceTypeDto.Id}");
            try
            {
                await _serviceTypesService.UpdateServiceTypeAsync(updateServiceTypeDto);

                _logger.LogInformation($"Service type updated successfully with ID {updateServiceTypeDto.Id}");
                return Ok("Service type updated successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating service type");
                return BadRequest("An error occurred while updating the service type");
            }
        }

        [Authorize(Policy = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteServiceTypeAsync(int id)
        {
            _logger.LogInformation($"Deleting service type with ID {id}");
            try
            {
                await _serviceTypesService.SoftDeleteServiceTypeAsync(id);

                _logger.LogInformation($"Service type with ID {id} successfully deleted");
                return Ok("Service type successfully deleted");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting service type with ID {ServiceTypeId}", id);
                return BadRequest("An error occurred while deleting the service type");
            }
        }
    }
}
