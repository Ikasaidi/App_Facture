using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonCoiffure.Model
{
    public class Service
    {
        private static int _id = 0;
        public int Id { get; set; }
        public string Nom { get; set; }
        public decimal Prix { get; set; }
        public int FactureId { get; set; }
        public Facture Facture { get; set; }
        public Service()
        {
            Id = ++_id;
        }
    }
}
