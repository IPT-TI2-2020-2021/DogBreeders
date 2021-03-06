using DogBreeders.Data;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogBreeders {

   public class Startup {
      public Startup(IConfiguration configuration) {
         Configuration = configuration;
      }

      public IConfiguration Configuration { get; }

      // This method gets called by the runtime. Use this method to add services to the container.
      public void ConfigureServices(IServiceCollection services) {

         // enablig the use of session variables
         services.AddDistributedMemoryCache();
         services.AddSession(options => {
            options.IdleTimeout = TimeSpan.FromSeconds(120);
            options.Cookie.HttpOnly = true;
            options.Cookie.IsEssential = true;
         });


         services.AddControllersWithViews();

         // define the engine of DataBase that we are going to use
         // we must install the using 'Microsoft.EntityFrameworkCore.SqlServer' package to use it
         services.AddDbContext<DogBreedersDB>(
            options => options.UseSqlServer(Configuration.GetConnectionString("DogBreedersDBConnection"))
            );

      }

      // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
      public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
         if (env.IsDevelopment()) {
            app.UseDeveloperExceptionPage();
         }
         else {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
         }
         app.UseHttpsRedirection();
         app.UseStaticFiles();

         app.UseRouting();

         // starting the use of session variables
         // this instruction must be write after 'app.UseRouting()' 
         // and before 'app.UseEndPoints()'
         app.UseSession();

         app.UseAuthorization();

         app.UseEndpoints(endpoints => {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
         });
      }
   }
}
