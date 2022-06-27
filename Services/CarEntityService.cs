using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using Iuli.Cse19.CarRental.WebApp.Domain;
using Iuli.Cse19.CarRental.WebApp.ViewModel;
using AdminVsCustomerTwo.Areas.Identity.Data;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Iuli.Cse19.CarRental.WebApp.Services
{
    public class CarEntityService
    {
        private readonly AdminVsCustomerTwoIdentityDbContext _appDbContext;
        
        public CarEntityService(AdminVsCustomerTwoIdentityDbContext context)
        {
            _appDbContext = context;
        }

        // "SELECT * FROM car"
        public async Task<List<Owner>> GetAllOwners()
        {
            return await _appDbContext.Owner.ToListAsync();
        }

        public async Task<List<CarViewModel>> GetAllCars()
        {
            DbSet<Car> car = _appDbContext.Car;
            var obj = from r in car
                      .Include(c => c.Owner)
                      select new CarViewModel
                      {
                          CarId = r.CarId,
                          CarModel = r.CarModel,
                          LicensePlate = r.LicensePlate,
                          Color = r.Color,
                          RentPrice = r.RentPrice,
                          OwnerName = r.Owner.OwnerName,
                          //OwnerName = r.OwnerName,
                          Description = r.Description                     
                      };
         
            return await obj.ToListAsync();
        }

        // Create car
        // "INSERT INTO car ...."
        public async Task<bool> InsertCar(Car newCar)
        {
            await _appDbContext.Car.AddAsync(newCar);
            var result = await _appDbContext.SaveChangesAsync();

            return result > 0;
        }

        // Get car
        public async Task<Car> GetCarById(Guid guid)
        {
            return await _appDbContext.Car
                                .Include(c => c.Owner)
                                .FirstOrDefaultAsync(c => c.CarId == guid);
        }

        // Update car 
        public async Task<bool> UpdateCar(Car updatedCar)
        {
            _appDbContext.Car.Update(updatedCar);
            var result = await _appDbContext.SaveChangesAsync();

            return result > 0;
        }

        // Delete car 
        public async Task<bool> DeleteCar(Guid selectedId)
        {
            var InfotoDelete = _appDbContext.Car.Find(selectedId);
            if (InfotoDelete != null)
            {
                _appDbContext.Remove(InfotoDelete);
                var result = await _appDbContext.SaveChangesAsync();

                return result > 0;
            }
            
            return false;
           
        }

    }
}
