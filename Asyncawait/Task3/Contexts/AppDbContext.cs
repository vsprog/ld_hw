using Microsoft.EntityFrameworkCore;
using System;
using Task3.Models;

namespace Task3.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Brew",
                    Description = "Gatorade Classic Thirst Quencher, Variety Pack, 12 Fl Oz",
                    Price = 18.02m
                },
                new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Chips",
                    Description = "Pringles Potato Crisps Chips, Lunch Snacks, Office and Kids Snacks, Snack Stacks, Variety Pack, 19.5oz Box (27 Cups)",
                    Price = 20.8m
                },
                new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Roasted Pecans",
                    Description = "PLANTERS Roasted Pecans, 7.25 oz. Resealable Canister - Salted Pecans - Snacks for Adults - Kids Snacks - Vegan Snacks, Kosher",
                    Price = 5.98m
                },
                new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Jam",
                    Description = "Bonne Maman Advent Calendar 2021 with Mini Fruit Jams and Spreads Assorted, 23 x 30g",
                    Price = 78.49m
                },
                new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Candy Canes",
                    Description = "Mini Candy Canes Peppermint Flavored | Red & White Stripes - Individually Wrapped Gift Pack | Holiday Christmas Candy Plus Free Creative Idea Booklet Included - (200 Pieces)",
                    Price = 48.89m
                },
                new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Nutrition",
                    Description = "Similac Pro-Total Comfort Non-GMO with 2'-FL HMO Infant Formula with Iron, Easy-to-Digest, Gentle Formula, for Immune Support, Baby Formula 36 Oz, Pack of 3",
                    Price = 133.95m
                },
                new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "White Bread",
                    Description = "White Bread: Arnold Country White",
                    Price = 4
                },
                new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Maple Syrup",
                    Description = "Maple Syrup: Coombs Family Farms",
                    Price = 25
                },
                new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Pork",
                    Description = "Bone-In Pork Loin Rib Chop, Non-GMO, Raised w/o Antibiotics",
                    Price = 12.99m
                });
        }
    }
}
