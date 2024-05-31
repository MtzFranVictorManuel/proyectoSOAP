using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.ServiceModel;

using SoapCore;
using Microsoft.Extensions.DependencyInjection.Extensions;

using IFacturaServiceNamespace;
using FacturaServiceNamespace;
using Microsoft.Extensions.Configuration;
using FacturaDbContextNamespace;
using Microsoft.EntityFrameworkCore;

namespace facturaServicio
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        // Add this line

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSoapCore();
            services.AddScoped<IFacturaService, FacturaService>();
            services.AddMvc();

            services.AddDbContext<FacturaDbContext>(options =>
                options.UseMySql(Configuration.GetConnectionString("DefaultConnection"), new MySqlServerVersion(new Version(8, 0, 21))));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            // app.UseEndpoints(endpoints =>
            // {
            //     endpoints.MapGet("/", async context =>
            //     {
            //          await context.Response.WriteAsync("Hello World!");
            //         //await context.Response.WriteAsync(Calculadora.suma(3,4));
            //     });
            // });

            app.UseEndpoints(endpoints =>
            {
                app.UseSoapEndpoint<IFacturaService>("/Facturas.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
            });
        }
    }
}