using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Builder.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFremworkCore2.Models
{
    public static class SeedData
    {

        public static void Seed(IApplicationBuilder app)
        {

            AplicationDbContext context = app.ApplicationServices.GetRequiredService<AplicationDbContext>();

            context.Database.Migrate();


            //if (!context.Products.Any())
            //{
            //    context.Products.AddRange(
            //  new Product() { ProductId = 1, Name = "samsung1", Price = 2001, Category = "Telfon1" },
            //  new Product() { ProductId = 2, Name = "samsung2", Price = 2002, Category = "Telfon2" },
            //  new Product() { ProductId = 3, Name = "samsung3", Price = 2003, Category = "Telfon3" },
            //  new Product() { ProductId = 4, Name = "samsung4", Price = 2004, Category = "Telfon4" },
            //  new Product() { ProductId = 5, Name = "samsung5", Price = 2005, Category = "Telfon5" }

            //        );

            //    context.SaveChanges();
            //}


        }

        
    }
}
