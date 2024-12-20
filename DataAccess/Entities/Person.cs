﻿namespace DataAccess.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public ICollection<ClientNote> ClientNotes { get; } = new List<ClientNote>();
        public ICollection<BookedAppointment> BookedAppointments { get; } = new List<BookedAppointment>();
    }
}
