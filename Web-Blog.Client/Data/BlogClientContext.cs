using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Web_Blog.Client.Models;

public class BlogClientContext : IdentityDbContext
    {
        public BlogClientContext (DbContextOptions<BlogClientContext> options)
            : base(options)
        {
        }

        public DbSet<BlogPost> BlogPost { get; set; } = default!;
    }
