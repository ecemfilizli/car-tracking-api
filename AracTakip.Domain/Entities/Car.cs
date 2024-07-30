using AracTakip.Domain.Entities.Common;

namespace AracTakip.Domain.Entities
{
    public class Car : BaseEntity
    {
        public string CarName { get; set; }
        public string CarLicensePlate { get; set; }
        public string CarModel { get; set; }
        public int CarKM { get; set; }
        public int CarFuelStatus { get; set; }
        public int CarCapacity { get; set; }
        public bool CarGearType { get; set; }
        public Guid CarTypeId { get; set; }
        public Guid CarEngineTypeId { get; set; }
        public Guid CompanyId { get; set; }
        public string CarIMEI { get; set; }
        public Company Company { get; set; }
        public CarEngineType CarEngineType { get; set; }
        public CarType CarType { get; set; }
        public ICollection<CarImageFile> CarImageFiles { get; set; }
    }
}
