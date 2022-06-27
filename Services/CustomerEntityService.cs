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
    public class CustomerEntityService
    {
        private readonly AppDbContext _appDbContext;

        public CustomerEntityService(AppDbContext context)
        {
            _appDbContext = context;
        }

        // Select all customers
        // "SELECT * FROM customer"
        public async Task<List<CustomerViewModel>> GetAllCustomersInfo()
        {
            var obj = from r in _appDbContext.Customer
                      select new CustomerViewModel
                      {
                          CustomerId = r.CustomerId,
                          CustomerName = r.CustomerName,
                          CustomerAddress = r.CustomerAddress,
                          CustomerCity = r.CustomerCity,
                          CustomerPhone = r.CustomerPhone,
                          CustomerEmail = r.CustomerEmail

                      };
            return await obj.ToListAsync();
        }

        public async Task<List<Customer>> GetAllCustomers()
        {
            return await _appDbContext.Customer.ToListAsync();
        }

        // create customer
        // "INSERT INTO customer ...."
        public async Task<bool> InsertCustomer(Customer newCustomer)
        {
            await _appDbContext.Customer.AddAsync(newCustomer);
            var result = await _appDbContext.SaveChangesAsync();

            return result > 0;
        }
        public async Task<Customer> GetCustomerById(Guid guid)
        {
            return await _appDbContext.Customer.FirstOrDefaultAsync(c => c.CustomerId == guid);
        }

        public async Task<bool> UpdateCustomer(Customer updatedCustomer)
        {
            _appDbContext.Customer.Update(updatedCustomer);
            var result = await _appDbContext.SaveChangesAsync();

            return result > 0;
        }

        public async Task<bool> DeleteCustomerById(Guid selectedId)
        {
            var InfotoDelete = _appDbContext.Customer.Find(selectedId);
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
