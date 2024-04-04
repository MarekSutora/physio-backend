using System.ComponentModel.DataAnnotations;

namespace Application.DTO.Appointments.Response
{
    public class ExerciseTypeDto
    {
        [Required(ErrorMessage = "Attribute Id is required.")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Attribute Name is required.")]
        [StringLength(100, ErrorMessage = "Name must be less than or equal to 100 characters.")]
        public string Name { get; set; }
    }
}
