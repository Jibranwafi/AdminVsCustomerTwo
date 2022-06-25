using Iuli.Cse19.CarRental.WebApp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Diagnostics.CodeAnalysis;

namespace Iuli.Cse19.CarRental.WebApp.Common
{
    public interface IAppDbContext
    {
        int SaveChanges();
        EntityEntry Remove([NotNull] object entity);

        DbSet<Customer> Customer { get; set; }

        DbSet<Owner> Owner { get; set; }
        DbSet<Car> Car { get; set; }

        DbSet<RentedCarInformation> RentInfo { get; set; }

    }
}
