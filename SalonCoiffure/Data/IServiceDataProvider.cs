using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalonCoiffure.Model;

namespace SalonCoiffure.Data
{
    public interface IServiceDataProvider
    {
        Task<IEnumerable<Service>?> GetAllAsync();
    }
}
