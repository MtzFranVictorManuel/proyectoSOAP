using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

using SoapCore;

using IFacturaServiceNamespace;
using FacturaServiceNamespace;
using Microsoft.Extensions.Configuration;
using FacturaDbContextNamespace;

using Microsoft.AspNetCore.Http; 

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
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection"),
                    sqlServerOptions => sqlServerOptions.EnableRetryOnFailure(
                        maxRetryCount: 10,
                        maxRetryDelay: TimeSpan.FromSeconds(30),
                        errorNumbersToAdd: null // Add the errorNumbersToAdd argument here
                    )
                )
            );
        }

        // public void ConfigureServices(IServiceCollection services)
        // {
        //     services.AddSoapCore();
        //     services.AddScoped<IFacturaService, FacturaService>();
        //     services.AddMvc();

        //     services.AddDbContext<FacturaDbContext>(options =>
        //         options.UseMySql(
        //             Configuration.GetConnectionString("DefaultConnection"),
        //             new MySqlServerVersion(new Version(8, 0, 21)), // especifica la versión del servidor aquí
        //             mysqlOptions => mysqlOptions.EnableRetryOnFailure(
        //                 maxRetryCount: 10, 
        //                 maxRetryDelay: TimeSpan.FromSeconds(30), 
        //                 errorNumbersToAdd: null)));
        // }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Add this line

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
                        //     });
                        // });

            app.UseEndpoints(endpoints =>
            {
                app.UseSoapEndpoint<IFacturaService>("/Facturas.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
            });
        }
    }
}