using crudProduct.Models;
using crudProduct.Repositories;
using Microsoft.EntityFrameworkCore;

namespace crudProduct.data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }

       
        public DbSet<Product> Products => Set<Product>();
    }
}
