using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore
{
  public record Startup(IConfiguration Configuration)
  {

    //private IConfiguration Configuration { get; }

    //public Startup(IConfiguration Configuration)
    //{

    //}


    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
      //services.AddMvc
      services.AddControllersWithViews();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseStaticFiles();

      app.UseRouting();

      //var greet = Configuration["Greetings"];
      app.UseEndpoints(endpoints =>
      {
        //endpoints.MapGet("/g", async context =>
        //{
        //  await context.Response.WriteAsync("g");
        //});
        endpoints.MapGet("/", async context =>
              {
            await context.Response.WriteAsync(Configuration["Greetings"]);
          });

        endpoints.MapControllerRoute(
          "default",
          "{controller}/{action}/{id}"
          );

      });
    }
  }
}
