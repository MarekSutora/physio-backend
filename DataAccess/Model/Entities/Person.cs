using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Title { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }

        public Patient? Patient { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }

        public int? AddressId { get; set; }
        public Address? Address { get; set; }
    }
}
