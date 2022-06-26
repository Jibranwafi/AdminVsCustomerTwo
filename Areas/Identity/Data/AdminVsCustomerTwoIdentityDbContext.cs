using Iuli.Cse19.CarRental.WebApp.Common;
using Iuli.Cse19.CarRental.WebApp.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AdminVsCustomerTwo.Areas.Identity.Data;

public class AdminVsCustomerTwoIdentityDbContext : IdentityDbContext<IdentityUser>, IAppDbContext
{
    public AdminVsCustomerTwoIdentityDbContext(DbContextOptions<AdminVsCustomerTwoIdentityDbContext> options)
        : base(options)
    {
    }

    public DbSet<Customer> Customer { get; set; }

    public DbSet<Owner> Owner { get; set; }
    public DbSet<Car> Car { get; set; }

    public DbSet<RentedCarInformation> RentInfo { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
