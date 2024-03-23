
namespace DataAccess.Entities
{
    public class ClientNote
    {
        public int Id { get; set; }
        public string Note { get; set; } = null!;
        public DateTime CreatedAt { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; } = null!;
    }
}
