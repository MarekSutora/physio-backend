using Shared.DTO.Patients.Request;
using Shared.DTO.Patients.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IPatientsService
    {
        Task<IEnumerable<PatientDto>> GetAllPatientsAsync();

        Task<PatientDto> GetPatientByIdAsync(int patientId);

        Task<IEnumerable<PatientNoteDto>> GetAllNotesForPatient(int patientId);

        Task AddNoteToPatientAsync(CreatePatientNoteDto createPatientNoteDto);

        Task DeleteNoteAsync(int noteId);
    }
}
