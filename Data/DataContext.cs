using Microsoft.EntityFrameworkCore;
using EF.Models;

namespace EF.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}