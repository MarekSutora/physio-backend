using Application.DTO.Appointments.Response;

namespace Application.Services.Interfaces
{
    public interface IExerciseTypesService
    {
        Task<IEnumerable<ExerciseTypeDto>> GetExerciseTypesAsync();
    }
}
