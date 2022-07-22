using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFCoreApp.DB
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
