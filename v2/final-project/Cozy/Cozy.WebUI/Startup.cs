using Cozy.Data.Database;
using Cozy.Domain.Models;
using Cozy.Service.Implementation.Mock;
using Cozy.Service.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Cozy.WebUI
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
            //Dependency Injection
            services.AddScoped<IPropertyServices, MockPropertyServices>();
            services.AddScoped<ITenantServices, MockTenantServices>();
            services.AddScoped<ILeaseServices, MockLeaseServices>();
            services.AddScoped<IPropertyServices, MockPropertyServices>();
            services.AddScoped<IBankServices, MockBankServices>();
            services.AddScoped<ILandlordServices, MockLandlordServices>();
            services.AddScoped<IPaymentServices, MockPaymentServices>();

            // DbContext Information
            services.AddDbContext<ApplicationUserDbContext>(options =>
            options.UseSqlServer(_configuration.GetConnectionString("AppIdentityConnection")));


            // Identity
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationUserDbContext>()
                .AddDefaultTokenProviders();


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
