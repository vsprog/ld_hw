using Microsoft.EntityFrameworkCore;
using System;
using Task4.Models;

namespace Task4.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder.Entity<User>().HasData(
                new User 
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Qwerty",
                    Surname = "Smith",
                    Age = 30
                },
                new User
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Another one",
                    Surname = "Smith",
                    Age = 31
                });
        }
    }
}
