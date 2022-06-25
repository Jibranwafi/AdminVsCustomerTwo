using System;
namespace Iuli.Cse19.CarRental.WebApp.ViewModel
    
{
    public class RentedCarViewModel
    {
        public Guid RentId { get; set; }
        public string CarModel { get; set; }
        public string CarLicencePlate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public DateTime RentStart { get; set; }
        public DateTime RentEnd { get; set; }
        public string price { get; set; }

    }
}
