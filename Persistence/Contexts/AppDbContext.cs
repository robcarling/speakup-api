using Microsoft.EntityFrameworkCore;
using Speakup.API.Domain.Models;

namespace Speakup.API.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Comment> Comments { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.Entity<Comment>().ToTable("Comments");
            builder.Entity<Comment>().HasKey(p => p.Id);
            builder.Entity<Comment>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Comment>().Property(p => p.CommentBody).IsRequired().HasMaxLength(200);
            builder.Entity<Comment>().Property(p => p.Name).IsRequired().HasMaxLength(30);

            builder.Entity<Comment>().HasData
            (
                new Comment { Id = 101, Name = "Michael Jordan", CommentBody = "The greatest of all time." }, // Id set manually due to in-memory provider
                new Comment { Id = 102, Name = "Lebron James", CommentBody = "Probably second best all time." }
            );
        }
    }
}