using FirstOnionDomain.Entity;
using Microsoft.EntityFrameworkCore;

namespace FirstOnionPersistance.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        
        public DbSet<Product> Products { get; set; }
    }
}
