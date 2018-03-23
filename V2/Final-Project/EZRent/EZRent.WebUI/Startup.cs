using EZRent.Data.Database;
using EZRent.Domain.Models;
using EZRent.Service.Implementation.EFCore;
using EZRent.Service.Implementation.Mock;
using EZRent.Service.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EZRent.WebUI
{
    public class Startup
    {

        public IConfiguration _configuration { get; }

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IBankServices, EFCoreBankServices>();
            services.AddScoped<ILandlordServices, MockLandlordServices>();
            services.AddScoped<ILeaseServices, EFCoreLeaseServices>();
            services.AddScoped<ILeaseTypeServices, EFCoreLeaseTypeServices>();
            services.AddScoped<IMaintenanceServices, EFCoreMaintenanceServices>();
            services.AddScoped<IMaintenanceStatusServices, EFCoreMaintenanceStatusServices>();
            services.AddScoped<IPaymentServices, EFCorePaymentServices>();
            services.AddScoped<IPaymentStatusServices, EFCorePaymentStatusServices>();
            services.AddScoped<IPropertyServices, EFCorePropertyServices>();
            services.AddScoped<IPropertyTypeServices, EFCorePropertyTypeServices>();
            services.AddScoped<ITenantServices, MockTenantServices>();

            //Connection String to SQL Server and DB Catalog
            services.AddDbContext<ApplicationUserDbContext>(options =>
            options.UseSqlServer(_configuration.GetConnectionString("AppIdentityConnection")));

            //Identity Configureation
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationUserDbContext>() // Store -> IMplementation of DB CRUD
                .AddDefaultTokenProviders();

            //DbCOntext for Application
            services.AddDbContext<EZRentDbContext>(options =>
            options.UseSqlServer(_configuration.GetConnectionString("EZRentConnection")));

            //Mvc Framework
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseAuthentication();
            app.UseMvcWithDefaultRoute();
        }
    }
}
