using Microsoft.EntityFrameworkCore;
using Repozytorium.Models;

namespace Repozytorium.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
    }
}