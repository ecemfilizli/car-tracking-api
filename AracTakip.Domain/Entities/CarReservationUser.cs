﻿using AracTakip.Domain.Entities.Common;

namespace AracTakip.Domain.Entities
{
    public class CarReservationUser : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TC { get; set; }
        public string Sicil { get; set; }
        public bool IsDriver { get; set; }
        public Guid CarReservationId { get; set; }
        public CarReservation CarReservation { get; set; }
    }
}
