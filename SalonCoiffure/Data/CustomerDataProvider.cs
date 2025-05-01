using System;
using System.Collections.Generic;
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
            await Task.Delay(1000);

            var customers = new List<Customer>()
            {
                new Customer { Nom = "Ikram", Telephone="123456789", Email="gmail@gmail.com" , Adresse= "123 rue test" },
                new Customer { Nom = "Sara", Telephone = "123456789", Email = "gmail@gmail.com", Adresse= "123 rue test"},
                new Customer { Nom = "Mehdi", Telephone = "123456789", Email = "gmail@gmail.com", Adresse = "123 rue test" }

            };
            return customers;
        }
    }
}
