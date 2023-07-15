using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using APPPRACTICAL.Models;


namespace APPPRACTICAL.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Item> Items { get; set; }
    }
}
