using AdminVsCustomerTwo.Areas.Identity.Data;

namespace Iuli.Cse19.CarRental.WebApp.Common
{
    public class BaseService
    {
        protected IAppDbContext ApplicationDbContext { get; set; }
    }
}
