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
using Microsoft.Extensions.FileProviders;
using System.IO;
using Microsoft.AspNetCore.Routing;

namespace CourseApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //mvc s?r?m?n? ekledim!
            services.AddMvc();
            services.AddControllersWithViews();
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseStaticFiles(); //wwwroot klas?r?n? d??ar?ya a?ar!

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseStaticFiles();
            //daha spesifik routelar? yukar? yaz!
            //aya?a kald?rmak i?in (1.y?ntem)
            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        "CoursesByReleased",
            //        "courses/released/{year}/{month}",
            //        new { controller = "Course", action = "ByReleased" },
            //        new { year = @"\d{4}", month = @"\d{2}" } //y?l 4 haneli ay 2 haneli olacak dedim!
            //        ); 
            //    routes.MapRoute(
            //    name: "default",
            //    template: "{controller}/{action}/{id?}");              
            //});

            //2.y?ntem
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
              name: "default",
              pattern: "{controller=Course}/{action=Index}/{id?}"); //burada controller ismi verilip action verilmezse otomatik yukar?daki patterndeki yere atar(home/index ile ayn? yere).E?er home/about dersem oraya gider.
            });



        }
    }
}
