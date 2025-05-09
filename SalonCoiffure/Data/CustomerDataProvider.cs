using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalonCoiffure.Model;

namespace SalonCoiffure.Data
{
    class CustomerDataProvider : ICustomerDataProvider
    {
        public async Task<IEnumerable<Customer>?> GetAllAsync()
        {
            using var context = new AppDbContext();
            return await context.Customers.ToListAsync();
        }


        public async Task AddAsync(Customer customer)
        {
            using var context = new AppDbContext();
            context.Customers.Add(customer);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Customer customer)
        {
            using var context = new AppDbContext();
            context.Customers.Update(customer);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Customer customer)
        {
            using var context = new AppDbContext();
            context.Customers.Remove(customer);
            await context.SaveChangesAsync();
        }
    }
}
