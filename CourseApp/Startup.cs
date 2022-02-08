using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //mvc s�r�m�n� ekledim!
            services.AddMvc();
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            //aya�a kald�rmak i�in (1.y�ntem)
            //app.UseMvc(routes =>
            //{
            //routes.MapRoute(
            //name:"default";
            //template:"{controller}/{action}/{id?}");
            //});

            //2.y�ntem
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
              name: "default",
              pattern: "{controller=Home}/{action=Index}/{id?}"); //burada controller ismi verilip action verilmezse otomatik yukar�daki patterndeki yere atar(home/index ile ayn� yere).E�er home/about dersem oraya gider.
            });
        }
    }
}
