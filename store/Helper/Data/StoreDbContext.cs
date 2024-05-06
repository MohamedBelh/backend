using Microsoft.EntityFrameworkCore;
using store.Models;

namespace store.Helper.Data
{
    public class StoreDbContext : DbContext
    {
       public StoreDbContext(DbContextOptions <StoreDbContext> options)
       : base(options)
        {
        }
        public virtual DbSet<Product> Products { get; set; }
    }
}
