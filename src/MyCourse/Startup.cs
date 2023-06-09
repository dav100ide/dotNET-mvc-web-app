﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace MyCourse
{
   public class Startup
   {
      // This method gets called by the runtime. Use this method to add services to the container.
      // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
      public void ConfigureServices(IServiceCollection services)
      {
         services.AddMvc();
      }

      // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
      public void Configure(IApplicationBuilder app, IHostingEnvironment env)
      {
         //if (env.IsDevelopment())
         if (env.IsEnvironment("Development"))
         {
            app.UseDeveloperExceptionPage();
         }
         app.UseStaticFiles();

         app.UseMvc(routeBuilder =>
         //può contenere più rotte semplicemente usa il primo conforme che trova 
         {
            //per esempio /courses/detail/69 oppure in caso di default: Home/Index/id(opzionale)
            routeBuilder.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");

            routeBuilder.MapRoute("search", "{controller}/{action=Search}/{title}");
         });
      }
   }
}
