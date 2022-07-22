using EFCoreApp.Core.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCoreApp.Infrastructure.DB
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=CustomerDb;Username=postgres;Password=postgres");
        }
    }
}
