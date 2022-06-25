using System;

namespace Iuli.Cse19.CarRental.WebApp.ViewModel
{
    public class CarViewModel
    {
        public Guid CarId { get; set; }
        public string CarModel { get; set; }
        public string LicensePlate { get; set; }
        public string Color { get; set; }
        public int RentPrice { get; set; }
        
        public string OwnerName { get; set; }
        public string Description { get; set; }

    }
}

