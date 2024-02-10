using Shared.DTO.Reservations.Response;

public class AvailableReservationDto
{
    public int Id { get; set; }
    public DateTime StartTime { get; set; }
    public int Capacity { get; set; }
    public int ReservedAmount { get; set; }
    public List<ServiceTypeWithCostDto> ServiceTypesWithCosts { get; set; } = new List<ServiceTypeWithCostDto>();
}