using Microsoft.EntityFrameworkCore;
using OnlineWSModel.Entities;

namespace OnlineWS.DateAccess.EF.Contexts
{
    public class ECommerceContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Server=Monster;Database=ECommerceDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ProductPhoto> ProductsPhoto { get; set; }

    }
}
