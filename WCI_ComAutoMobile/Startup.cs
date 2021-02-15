using Application.Handlers.Common;
using Application.Handlers.Common.Interfaces;
using Application.Handlers.Customers;
using Application.Handlers.Customers.Interfaces;
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
using Repository.Common;
using Repository.Common.Interfaces;
using Repository.Customers;
using Repository.Customers.Interfaces;
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

            //var connectionString = MD5Encryption.Decode(settings.ConnectionString);

            services.AddDbContext<SolutionContext>(options =>
               options.UseSqlServer(settings.ConnectionString));

            services.AddIdentity<User, IdentityRole>()
               .AddEntityFrameworkStores<SolutionContext>()
               .AddDefaultTokenProviders();

            // Repositórios
            services.AddScoped<IRState, RState>();
            services.AddScoped<IRCity, RCity>();
            services.AddScoped<IRCustomer, RCustomer>();

            // Hanlders
            services.AddScoped<IStateHandler, StateHandler>();
            services.AddScoped<ICityHandler, CityHandler>();
            services.AddScoped<ICustomerHandler, CustomerHanlder>();

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

            app.UseCors(builder => builder
              .AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader());

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
