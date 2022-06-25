using System;
using System.ComponentModel.DataAnnotations;

namespace Iuli.Cse19.CarRental.WebApp.Domain
{
    public class Car
    {
        [Key]
        public Guid CarId { get; set; }
        public string CarModel { get; set; }
        public string LicensePlate { get; set; }
        
        public Owner Owner { get; set; }

        //public string OwnerName { get; set; }
        public string Color { get; set; }
        public int RentPrice { get; set; }
        public string Description { get; set; }

    }
}
