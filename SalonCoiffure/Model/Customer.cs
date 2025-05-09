using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SalonCoiffure.Model
{
    public class Customer
    {
        private static int _id = 0;
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string Nom { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public ICollection<Facture> Factures { get; set; } = new List<Facture>();
        public Customer() 
        {
            Id = ++_id;
        }
    }
}
