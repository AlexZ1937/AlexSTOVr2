using System.Data.Entity;

namespace AlexSTOv2.Models.Repository
{
    public class EFDBContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

    }
}