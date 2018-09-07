using OnlineShopping.Models;
using System.Data.Entity;

namespace OnlineShopping.Context
{
    public class StoreContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}