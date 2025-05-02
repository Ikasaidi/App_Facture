namespace SalonCoiffure.Model
{

        public class Facture
        {

        private static int _id = 0;

        public int Id { get; set; }

            public DateTime Date { get; set; }

            public decimal Montant { get; set; }

            // FK
            public int CustomerId { get; set; }

            
            public Customer Customer { get; set; }

            public ICollection<Service> Services { get; set; } = new List<Service>();


        public Facture()
        {
            Id = ++_id;

        }
        }
    
}
