using AracTakip.Domain.Entities.Common;
using AracTakip.Domain.Entities.Identity;

namespace AracTakip.Domain.Entities
{
    public class CarReservation : BaseEntity
    {
        public Guid CarId { get; set; }
        //public Guid AppUserId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string RouteStart { get; set; }
        public string RouteEnd { get; set; }
        public string Description { get; set; }
        public bool ReservationStatus { get; set; } = false;
        public AppUser AppUser { get; set; }
        public Car Car { get; set; }
        public ICollection<CarReservationUser> CarReservationUsers { get; set; }

    }
}
