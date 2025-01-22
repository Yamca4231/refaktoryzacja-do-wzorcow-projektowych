using Microsoft.Extensions.Hosting;
using MojBlogCMS.Data;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MojBlogCMS.Models;

namespace MojBlogCMS.Data

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