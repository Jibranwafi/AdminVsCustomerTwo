using Iuli.Cse19.CarRental.WebApp.Common;
using Iuli.Cse19.CarRental.WebApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace Iuli.Cse19.CarRental.WebApp.Infrastructure
{
#pragma warning disable CS8767 // Nullability of reference types in type of parameter doesn't match implicitly implemented member (possibly because of nullability attributes).
    public class AppDbContext : DbContext, IAppDbContext
#pragma warning restore CS8767 // Nullability of reference types in type of parameter doesn't match implicitly implemented member (possibly because of nullability attributes).
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Owner> Owner { get; set; }
        public DbSet<Car> Car { get; set; }

        public DbSet<RentedCarInformation> RentInfo { get; set; }
    }
}
