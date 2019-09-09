using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFremworkCore2.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EntityFremworkCore2
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
       
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.

            public IConfiguration Configuration { get; }


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }

        public void ConfigureServices(IServiceCollection services)
        {



            services.AddDbContext<AplicationDbContext>(options =>
                   //options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


          //  services.AddTransient<IProductRepository, FakProductRepository>();

            services.AddTransient<IProductRepository, EfProductRepostory>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

        }



        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
         {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseMvc(routes =>
            {
                routes.MapRoute(
               
                    name:"default",
                    template: "{controller=Product}/{action=List}/{id?}");
            });


               SeedData.Seed(app);

        }
    }
}
