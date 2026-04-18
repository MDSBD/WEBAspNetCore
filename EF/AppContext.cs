using G1WEB.Models;
using Microsoft.EntityFrameworkCore;

namespace G1WEB.EF
{
    public class AppContext:DbContext
    {
        public AppContext() { }


        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=localhost;Database=isga2026;User=root";
            optionsBuilder.UseMySQL(connectionString);
          //  optionsBuilder.LogTo(Console.WriteLine);

        }


        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Produit> Produits { get; set; }
    }
}
