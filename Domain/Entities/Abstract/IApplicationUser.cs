
namespace diploma_thesis_backend.Models.Domain
{
    public interface IApplicationUser
    {
        string? Name { get; set; }
        DateTime DateCreated { get; set; }
    }
}