﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime ReservationCreatedDate { get; set; }
        public DateTime ReservationDoneDate { get; set; }
        public string Description { get; set; }

        public int? AvailableReservationId { get; set; }
        public AvailableReservation? AvailableReservation { get; set; }

        public int? PaymentId { get; set; }
        public Payment? Payment { get; set; }


        public int? PatientId { get; set; }
        public Patient? Patient { get; set; }


        public int? ActivityTypeId { get; set; }
        public ActivityType? ActivityType { get; set; }
    }
}