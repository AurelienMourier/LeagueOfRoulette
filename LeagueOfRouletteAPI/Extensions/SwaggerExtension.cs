using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.Extensions
{
    public static class SwaggerExtension
    {
        public static IServiceCollection AddSwagger(
            this IServiceCollection services)
        {
            services.AddSwaggerGen(setupAction =>
            {
                setupAction.SwaggerDoc("LeagueOfRoulette.APIOpenAPISpecification", new Microsoft.OpenApi.Models.OpenApiInfo()
                {
                    Title = "LeagueOfRoulette.API",
                    Version = "0.1"
                });

                var xmlCommentsFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlCommentsFullPath = Path.Combine(AppContext.BaseDirectory, xmlCommentsFile);

                setupAction.IncludeXmlComments(xmlCommentsFullPath);
            });

            return services;
        }

        public static IApplicationBuilder UseSwaggerAsHome(this IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(setupAction =>
            {
                setupAction.SwaggerEndpoint("/swagger/LeagueOfRoulette.APIOpenAPISpecification/swagger.json", "API pour l'application web LeagueOfRoulette");
                setupAction.RoutePrefix = string.Empty;
            });
            return app;
        }
    }
}
