using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace SportsStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                if (!context.Products.Any())
                {
                    context.Products.AddRange(
                            new Product
                            {
                                Name = "Kayak",
                                Description = "A boat for one persone",
                                Category = "Watersport",
                                Price = 275
                            },
                            new Product
                            {
                                Name = "Lifejaket",
                                Description = "Protective and fashionable",
                                Category = "Watersport",
                                Price = 48.95m
                            },
                            new Product
                            {
                                Name = "Soccer ball",
                                Description = "FIFA-approved size and weight",
                                Category = "Soccer",
                                Price = 19.50m
                            },
                            new Product
                            {
                                Name = "Corner flag",
                                Description = "Bla bla bla",
                                Category = "Soccer",
                                Price = 34.95m
                            },
                            new Product
                            {
                                Name = "Item 1",
                                Description = "Bla bla bla",
                                Category = "Some category",
                                Price = 15
                            },
                            new Product
                            {
                                Name = "Item 2",
                                Description = "Bla bla bla",
                                Category = "Some category",
                                Price = 75
                            },
                            new Product
                            {
                                Name = "Item 3",
                                Description = "Bla bla bla",
                                Category = "Some category",
                                Price = 1200
                            }
                        );
                    context.SaveChanges();
                }
            }
                

            
        }
    }
}
