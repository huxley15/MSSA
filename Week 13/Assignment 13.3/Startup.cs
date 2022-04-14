using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment12._1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
//step 28.6
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Assignment12._1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            
            //services.AddSingleton<IProductRepository, ProductRepository>();

            //step 6.2
            services.AddScoped<IProductRepository, DBProductRepository>();

            //step 9.2
            services.AddDbContext<ProductContext>(options => options.UseSqlServer("Server=LAPTOP-PPG329FS;Database= MSSAProducts;Trusted_Connection = true;MultipleActiveResultSets=true"));

            //step 29.6
            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 8;

            }).AddEntityFrameworkStores<UserContext>();

            //step 30.6
            services.AddDbContext<UserContext>(options => options.UseSqlServer("Server=LAPTOP-PPG329FS;Database= ProductUsers;Trusted_Connection = true;MultipleActiveResultSets=true"));
        }

        //step 37.6
        public async void CreateRoles(RoleManager<IdentityRole> roleManager)
        {
            string[] rolenames = { "Admin", "Customer" };
            foreach (var rolename in rolenames)
            {
                bool roleExists = await roleManager.RoleExistsAsync(rolename);
                if (!roleExists)
                {
                    IdentityRole role = new IdentityRole();
                    role.Name = rolename;
                    await roleManager.CreateAsync(role);
                }
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,ProductContext productContext, UserContext userContext, RoleManager<IdentityRole> roleManager) //step 7.2, //step 31.6, //step 38.6
        {
            //step 7.2 cont
            //productContext.Database.EnsureDeleted();
            productContext.Database.EnsureCreated();

            //step 31.6
            userContext.Database.EnsureCreated();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //else
            //{
            //    app.UseExceptionHandler("/Home/Error");
            //}

            //step 3.5
            else if (env.IsProduction())
            {
                app.UseExceptionHandler("/Error.html");
            }

            app.UseStaticFiles();

            //step 32.6
            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
