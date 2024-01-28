﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entities
{
    public class ActivityType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal NormalCost { get; set; }
        public int Duration { get; set; }
        public string HexColor { get; set; }

        public List<AvailableAppointment> AvailableAppointments { get; } = [];
        public List<AvailableAppointmentActivityType> AvailableAppointmentActivityTypes { get; } = [];

        public ICollection<Appointment> Appointments { get; } = new List<Appointment>();
    }
}
