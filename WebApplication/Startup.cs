using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplication.Services.Abstract;
using WebApplication.Services.Concrete;
using WebApplication.Services.Data;
using Microsoft.Extensions.Hosting;
namespace WebApplication
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));
            services.AddMvc(
                option => option.EnableEndpointRouting = false
                ).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddDbContext<DefaultContext>(opt =>

                    opt.UseInMemoryDatabase("Sample")
                    .UseLazyLoadingProxies()
                );
            services.AddScoped<IManufacturerService, ManufacturerService>();
            services.AddScoped<IDataProvider, DataProvider>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.UseHttpsRedirection();
        }
    }
}
