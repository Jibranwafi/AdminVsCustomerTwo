using System.ComponentModel.DataAnnotations;
using System;

namespace Iuli.Cse19.CarRental.WebApp.Domain
{
    public class Owner
    {
        [Key]
        public Guid OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string OwnerAddress { get; set; }
        public string OwnerCity { get; set; }
        public string OwnerPhone { get; set; }
        public string OwnerEmail { get; set; }
    }
}
