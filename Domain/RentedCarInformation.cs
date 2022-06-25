using System.ComponentModel.DataAnnotations;
using System;

namespace Iuli.Cse19.CarRental.WebApp.Domain
{
    public class RentedCarInformation
    {
        [Key]
        public Guid RentId { get; set; }
        public Car Car { get; set; }
        public Customer Customer { get; set; }
        public DateTime RentStart { get; set; }
        public DateTime RentEnd { get; set; }
        public string price { get; set; }
    }
}
