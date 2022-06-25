using Iuli.Cse19.CarRental.WebApp.Infrastructure;

namespace Iuli.Cse19.CarRental.WebApp.Common
{
    public class BaseService
    {
        protected IAppDbContext ApplicationDbContext { get; set; }
    }
}
