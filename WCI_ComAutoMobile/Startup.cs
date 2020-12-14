using Application.Handlers.General;
using Application.Handlers.General.Interfaces;
using Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Model.Models.General;
using Model.Models.Identity;
using Repository.General;
using Repository.General.Interfaces;
using System;
using System.IO;

namespace WCI_ComAutoMobile
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{environmentName}.json", optional: true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            Settings settings = new Settings();
            Configuration.GetSection("Settings").Bind(settings);

            services.Configure<Settings>(options => Configuration.GetSection("Settings").Bind(options));

            services.AddDbContext<SolutionContext>(options =>
               options.UseSqlServer(MD5Encryption.Decode(settings.ConnectionString)));

            services.AddIdentity<User, IdentityRole>()
               .AddEntityFrameworkStores<SolutionContext>()
               .AddDefaultTokenProviders();

            // Repositórios
            services.AddScoped<IRState, RState>();

            // Hanlders
            services.AddScoped<IStateHandler, StateHandler>();

            services.AddControllers();

            services.AddControllersWithViews().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "API WCI - Automação Comercial",
                        Version = "v1",
                        Description = "API WCI Automação Comercial - WCI criada com o ASP.NET Core",
                        Contact = new OpenApiContact
                        {
                            Name = "Samuel Apolion Benevenuto"
                        }
                    });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // Ativando middlewares para uso do Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json",
                    "API WCI - Automação Comercial");
            });
        }
    }
}
