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
            //mvc sürümünü ekledim!
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

            //ayaða kaldýrmak için (1.yöntem)
            //app.UseMvc(routes =>
            //{
            //routes.MapRoute(
            //name:"default";
            //template:"{controller}/{action}/{id?}");
            //});

            //2.yöntem
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
              name: "default",
              pattern: "{controller=Home}/{action=Index}/{id?}"); //burada controller ismi verilip action verilmezse otomatik yukarýdaki patterndeki yere atar(home/index ile ayný yere).Eðer home/about dersem oraya gider.
            });
        }
    }
}
