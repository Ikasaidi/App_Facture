using SalonCoiffure.Model;

namespace SalonCoiffure.Data
{
    public static class Database
    {
        public static void InitializeDatabase()
        {
            using var context = new AppDbContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated(); // Crée la base si elle n'existe pas

            // Insère des comptes de test si la table est vide
            if (!context.Customers.Any())
            {
                context.Customers.AddRange(
                    new Customer { Username = "admin", Password = "123", Nom = "Chadi",Email="chadi123@col.com",Telephone = "5145556325",Adresse = "123 rue allo"},
                    new Customer { Username = "emp", Password = "emp123", Nom = "Chadi", Email = "chadi123@col.com", Telephone = "5145556325", Adresse = "123 rue allo" }

                );
                context.SaveChanges();
            }
        }

        public static bool ValidateLogin(string username, string password)
        {
            using var context = new AppDbContext();

            var client = context.Customers
                .FirstOrDefault(c => c.Username == username && c.Password == password);

            return client != null;
        }


    }
}
