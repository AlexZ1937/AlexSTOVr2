using System.Data.Entity;

namespace AlexSTOv2.Models.Repository
{
    public class EFDBContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<Good> Goods { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Master> Masters { get; set; }

        public DbSet<Cart> Carts { get; set; }

    }
}