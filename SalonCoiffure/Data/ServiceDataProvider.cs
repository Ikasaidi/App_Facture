using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalonCoiffure.Model;

namespace SalonCoiffure.Data
{
    public class ServiceDataProvider : IServiceDataProvider
    {
        public async Task<IEnumerable<Service>?> GetAllAsync()
        {
            await Task.Delay(1000);

            var services = new List<Service>
            {
                new Service { Nom = "Coupe cheveux", Prix = 25.00m },
                new Service { Nom = "Coloration", Prix = 50.00m },
                new Service { Nom = "Soin capillaire", Prix = 40.00m }
            };
           
            return services;

        }
    }
}
