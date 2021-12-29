using LeagueOfRouletteAPI.Context;
using LeagueOfRouletteAPI.Extensions;
using LeagueOfRouletteAPI.Models;
using LeagueOfRouletteAPI.Repositories.Classes;
using LeagueOfRouletteAPI.Repositories.Interfaces;
using LeagueOfRouletteAPI.Settings;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI
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
            services.AddDbContext<LORContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<User, Role>(options =>
            {
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireDigit = true;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1d);
                options.Lockout.MaxFailedAccessAttempts = 5;
            })
                    .AddEntityFrameworkStores<LORContext>()
                    .AddDefaultTokenProviders();

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", p =>
                {
                    p.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
            });

            var jwtSettings = Configuration.GetSection("Jwt").Get<JwtSettings>();

            services.addAuth(jwtSettings);
             
            services.Configure<JwtSettings>(Configuration.GetSection("Jwt"));

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<IBackpackRepository, BackpackRepository>();
            services.AddScoped<ICardRepository, CardRepository>();
            services.AddScoped<IRarityCardRepository, RarityCardRepository>();
            services.AddScoped<IStatCardRepository, StatCardRepository>();
            services.AddScoped<ITypeCardRepository, TypeCardRepository>();

            services.AddControllers();

            services.AddSwagger();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseSwaggerAsHome();

            app.UseRouting();

            app.UseCors("AllowAll");

            app.UseAuth();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
