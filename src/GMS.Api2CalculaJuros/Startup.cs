using System;
using System.IO;
using GMS.Api2CalculaJuros.Business.Interfaces;
using GMS.Api2CalculaJuros.Business.Services;
using GMS.Api2CalculaJuros.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.OpenApi.Models;

namespace GMS.Api2CalculaJuros
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Calcular Juros Compostos",
                        Version = "v1",
                        Description = "API para calcular juros compostos.",
                        Contact = new OpenApiContact
                        {
                            Name = "Gislaine Salvatico",
                            Url = new Uri("https://github.com/gislainesalvatico")
                        }
                    });

                var xmlComments = Path.Combine(PlatformServices.Default.Application.ApplicationBasePath, $"{PlatformServices.Default.Application.ApplicationName}.xml");
                s.IncludeXmlComments(xmlComments);
            });

            services.AddScoped<ICalculaJurosService, CalculaJurosService>();
            services.AddScoped<IApi1TaxaJurosService, Api1TaxaJurosService>();
            services.AddScoped<IShowMeTheCodeService, ShowMeTheCodeService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json",
                    "Calcular Juros");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}