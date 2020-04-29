using System;
using Core.Entities;
using Core.Enums;

namespace Infrastructure.Data
{
    public static class InitialData
    {
        public static void Seed(this AppDbContext dbContext)
        {
            //if (!dbContext.Products.Any())
            //{
            dbContext.Products.Add(new Product
            {
                ProductName = "Mountain Walkers",
                Description = "Use these sturdy shoes to pass any mountain range with ease.",
                Price = 219.5m,
                Rating = 4,
                Type = ProductType.Boots,
                Stock = 12,
                PhotoName = "shutterstock_66842440.jpg",
                DateCreated = DateTimeOffset.Now.AddMonths(-1)
            });

            dbContext.Products.Add(new Product
            {
                ProductName = "Army Slippers",
                Description = "For your everyday marches in the army.",
                Price = 125.9m,
                Rating = 3,
                Type = ProductType.Boots,
                Stock = 56,
                PhotoName = "shutterstock_222721876.jpg",
                DateCreated = DateTimeOffset.Now.AddMonths(-1)
            });

            dbContext.Products.Add(new Product
            {
                ProductName = "Backpack Deluxe",
                Description = "This backpack can survive any tornado.",
                Price = 199.99m,
                Rating = 5,
                Type = ProductType.Pants,
                Stock = 66,
                PhotoName = "shutterstock_6170527.jpg",
                DateCreated = DateTimeOffset.Now.AddMonths(-1)
            });

            dbContext.Products.Add(new Product
            {
                ProductName = "Climbing Kit",
                Description = "Anything you need to climb the mount Everest.",
                Price = 299.5m,
                Rating = 5,
                Type = ProductType.Pants,
                Stock = 3,
                PhotoName = "shutterstock_48040747.jpg",
                DateCreated = DateTimeOffset.Now.AddMonths(-1)
            });

            dbContext.Products.Add(new Product
            {
                ProductName = "Blue Racer",
                Description = "Simply the fastest kayak on earth and beyond for 2 persons.",
                Price = 350m,
                Rating = 5,
                Type = ProductType.Shirts,
                Stock = 8,
                PhotoName = "shutterstock_441989509.jpg",
                DateCreated = DateTimeOffset.Now.AddMonths(-1)
            });

            dbContext.Products.Add(new Product
            {
                ProductName = "Orange Demon",
                Description = "One person kayak with hyper boost button.",
                Price = 450m,
                Rating = 2,
                Type = ProductType.Shirts,
                Stock = 1,
                PhotoName = "shutterstock_495259978.jpg",
                DateCreated = DateTimeOffset.Now.AddMonths(-1)
            });

            dbContext.SaveChanges();
        }
        //}

    }
}