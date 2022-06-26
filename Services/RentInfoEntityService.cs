using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

using Iuli.Cse19.CarRental.WebApp.Domain;
using Iuli.Cse19.CarRental.WebApp.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using AdminVsCustomerTwo.Areas.Identity.Data;

namespace Iuli.Cse19.CarRental.WebApp.Services
{
    public class RentInfoEntityService
    {
        private readonly AdminVsCustomerTwoIdentityDbContext _appDbContext;

        public RentInfoEntityService(AdminVsCustomerTwoIdentityDbContext context)
        {
            _appDbContext = context;
        }

        public async Task<List<Customer>> GetAllCustomers()
        {
            return await _appDbContext.Customer.ToListAsync();
        }

        public async Task<List<Car>> GetAllCars()
        {
            return await _appDbContext.Car.ToListAsync();
        }

        public async Task<List<RentedCarViewModel>> GetAllRentInfo()
        {
            var obj = from r in _appDbContext.RentInfo
                    .Include(c => c.Car)
                    .Include(c => c. Customer)
                      select new RentedCarViewModel
                      {
                          RentId = r.RentId,
                          CarModel = r.Car.CarModel,
                          CarLicencePlate = r.Car.LicensePlate,
                          CustomerName = r.Customer.CustomerName,
                          CustomerPhone = r.Customer.CustomerPhone,
                          RentStart = r.RentStart,
                          RentEnd = r.RentEnd,
                          price = r.price
                      };

            return await obj.ToListAsync();
        }

        public async Task<bool> InsertRentInfo(RentedCarInformation newRentInfo)
        {
            await _appDbContext.RentInfo.AddAsync(newRentInfo);
            var result = await _appDbContext.SaveChangesAsync();

            return result > 0;
        }

        public async Task<RentedCarInformation> GetRentInfoById(Guid guid)
        {
            return await _appDbContext.RentInfo
                                .Include(c => c.Car)
                                .Include(c => c. Customer)
                                .FirstOrDefaultAsync(c => c.RentId == guid);
        }

        public async Task<bool> UpdateRentInfo(RentedCarInformation updatedRentInfo)
        {
            _appDbContext.RentInfo.Update(updatedRentInfo);
            var result = await _appDbContext.SaveChangesAsync();

            return result > 0;
        }

        public async Task<bool> DeleteRentInfoById(Guid selectedId)
        {
            var InfotoDelete = _appDbContext.RentInfo.Find(selectedId);
            if (InfotoDelete is not null)
            {
                _appDbContext.Remove(InfotoDelete);
                var result = await _appDbContext.SaveChangesAsync();
                return result > 0;
            }

            return false;
        }

    }
}
