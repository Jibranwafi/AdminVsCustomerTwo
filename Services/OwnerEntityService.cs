using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Iuli.Cse19.CarRental.WebApp.Domain;
using Iuli.Cse19.CarRental.WebApp.ViewModel;
using System;
using AdminVsCustomerTwo.Areas.Identity.Data;
using static AdminVsCustomerTwo.Areas.Identity.Data.AdminVsCustomerTwoIdentityDbContext;

namespace Iuli.Cse19.CarRental.WebApp.Services
{
    public class OwnerEntityService
    {
        private readonly AppDbContext _appDbContext;

        public OwnerEntityService(AppDbContext context)
        {
            _appDbContext = context;
        }

        // Select all customers
        // "SELECT * FROM customer"
        public async Task<List<OwnerViewModel>> GetAllOwnersInfo()
        {
            var obj = from r in _appDbContext.Owner
                      select new OwnerViewModel
                      {
                          OwnerId = r.OwnerId,
                          OwnerName = r.OwnerName,
                          OwnerAddress = r.OwnerAddress,
                          OwnerCity = r.OwnerCity,
                          OwnerPhone = r.OwnerPhone,
                          OwnerEmail = r.OwnerEmail

                      };
            return await obj.ToListAsync();
        }

        public async Task<List<Owner>> GetAllOwners()
        {
            return await _appDbContext.Owner.ToListAsync();
        }

        // create customer
        // "INSERT INTO customer ...."
        public async Task<bool> InsertOwner(Owner newOwner)
        {
            await _appDbContext.Owner.AddAsync(newOwner);
            var result = await _appDbContext.SaveChangesAsync();

            return result > 0;
        }
        public async Task<Owner> GetOwnerById(Guid guid)
        {
            return await _appDbContext.Owner.FirstOrDefaultAsync(c => c.OwnerId == guid);
        }

        public async Task<bool> UpdateOwner(Owner updatedOwner)
        {
            _appDbContext.Owner.Update(updatedOwner);
            var result = await _appDbContext.SaveChangesAsync();

            return result > 0;
        }

        public async Task<bool> DeleteOwnerById(Guid selectedId)
        {
            var InfotoDelete = _appDbContext.Owner.Find(selectedId);
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
