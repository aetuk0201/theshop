using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data
{
    public class InitialData
    {
        public static async Task Seed(AppDbContext dbContext, ILoggerFactory loggerFactory)
        {
            try
            {

                if (!dbContext.ProductBrands.Any())
                {
                    dbContext.ProductBrands.Add(new ProductBrand()
                    {
                        //Id = 1,
                        Name = "Angular"
                    });

                    dbContext.ProductBrands.Add(new ProductBrand()
                    {
                        //Id = 2,
                        Name = "NetCore"
                    });

                    dbContext.ProductBrands.Add(new ProductBrand()
                    {
                        //Id = 3,
                        Name = "VS Code"
                    });

                    dbContext.ProductBrands.Add(new ProductBrand()
                    {
                        //Id = 4,
                        Name = "React"
                    });

                    dbContext.ProductBrands.Add(new ProductBrand()
                    {
                        //Id = 5,
                        Name = "Typescript"
                    });


                    // var brandsData = File.ReadAllText("../Infrastructure/Data/SeedData/brands.json");

                    // var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);

                    // var count = 0;
                    // foreach (var item in brands)
                    // {
                    //     if (count == 1)
                    //     {
                    //         dbContext.ProductBrands.Add(item);
                    //     }
                    //     count++;
                    // }

                    await dbContext.SaveChangesAsync();
                }

                if (!dbContext.ProductTypes.Any())
                {
                    dbContext.ProductTypes.Add(new ProductType()
                    {
                        //Id = 1,
                        Name = "Boards"
                    });

                    dbContext.ProductTypes.Add(new ProductType()
                    {
                        //Id = 2,
                        Name = "Hats"
                    });

                    dbContext.ProductTypes.Add(new ProductType()
                    {
                        //Id = 3,
                        Name = "Boots"
                    });

                    dbContext.ProductTypes.Add(new ProductType()
                    {
                        //Id = 4,
                        Name = "Gloves"
                    });


                    // var typesData = File.ReadAllText("../Infrastructure/Data/SeedData/types.json");

                    // var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);

                    // var count = 0;
                    // foreach (var item in types)
                    // {
                    //     if (count == 1)
                    //     {
                    //         dbContext.ProductTypes.Add(item);
                    //     }
                    //     count++;

                    // }

                    await dbContext.SaveChangesAsync();
                }

                if (!dbContext.Products.Any())
                {
                    //var productsData = File.ReadAllText("../Infrastructure/Data/SeedData/products.json");

                    //var products = JsonSerializer.Deserialize<List<Product>>(productsData);

                    dbContext.Add(new Product()
                    {
                        ProductName = "Green React Woolen Hat",
                        Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                        Price = 8,
                        ImageUrl = "images/products/hat-react1.png",
                        ProductTypeId = 2,
                        ProductBrandId = 4
                    });
                    // foreach (var item in products)
                    // {
                    //     dbContext.Products.Add(item);
                    // }

                    dbContext.Add(new Product()
                    {
                        ProductName = "Core Blue Hat",
                        Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                        ImageUrl = "images/products/hat-core1.png",
                        ProductTypeId = 2,
                        ProductBrandId = 2
                    });

                    await dbContext.SaveChangesAsync();
                }


            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<InitialData>();
                logger.LogError(ex.Message);

                throw;
            }


            //if (!dbContext.Products.Any())
            //{
            //     dbContext.Products.Add(new Product
            //     {
            //         ProductName = "Mountain Walkers",
            //         Description = "Use these sturdy shoes to pass any mountain range with ease.",
            //         Price = 219.5m,
            //         Rating = 4,
            //         ProductType = new ProductType(),
            //         Stock = 12,
            //         PhotoName = "shutterstock_66842440.jpg",
            //         ImageUrl = "",
            //         DateCreated = DateTimeOffset.Now.AddMonths(-1)
            //     });

            //     dbContext.Products.Add(new Product
            //     {
            //         ProductName = "Army Slippers",
            //         Description = "For your everyday marches in the army.",
            //         Price = 125.9m,
            //         Rating = 3,
            //         ProductType = new ProductType(),
            //         Stock = 56,
            //         PhotoName = "shutterstock_222721876.jpg",
            //         ImageUrl = "",
            //         DateCreated = DateTimeOffset.Now.AddMonths(-1)
            //     });

            //     dbContext.Products.Add(new Product
            //     {
            //         ProductName = "Backpack Deluxe",
            //         Description = "This backpack can survive any tornado.",
            //         Price = 199.99m,
            //         Rating = 5,
            //         ProductType = new ProductType(),
            //         Stock = 66,
            //         PhotoName = "shutterstock_6170527.jpg",
            //         ImageUrl = "",
            //         DateCreated = DateTimeOffset.Now.AddMonths(-1)
            //     });

            //     dbContext.Products.Add(new Product
            //     {
            //         ProductName = "Climbing Kit",
            //         Description = "Anything you need to climb the mount Everest.",
            //         Price = 299.5m,
            //         Rating = 5,
            //         ProductType = new ProductType(),
            //         Stock = 3,
            //         PhotoName = "shutterstock_48040747.jpg",
            //         ImageUrl = "",
            //         DateCreated = DateTimeOffset.Now.AddMonths(-1)
            //     });

            //     dbContext.Products.Add(new Product
            //     {
            //         ProductName = "Blue Racer",
            //         Description = "Simply the fastest kayak on earth and beyond for 2 persons.",
            //         Price = 350m,
            //         Rating = 5,
            //         ProductType = new ProductType(),
            //         Stock = 8,
            //         PhotoName = "shutterstock_441989509.jpg",
            //         ImageUrl = "",
            //         DateCreated = DateTimeOffset.Now.AddMonths(-1)
            //     });

            //     dbContext.Products.Add(new Product
            //     {
            //         ProductName = "Orange Demon",
            //         Description = "One person kayak with hyper boost button.",
            //         Price = 450m,
            //         Rating = 2,
            //         ProductType = new ProductType(),
            //         Stock = 1,
            //         PhotoName = "shutterstock_495259978.jpg",
            //         ImageUrl = "",
            //         DateCreated = DateTimeOffset.Now.AddMonths(-1)
            //     });

            //     dbContext.SaveChanges();
            // }

        }
    }
}