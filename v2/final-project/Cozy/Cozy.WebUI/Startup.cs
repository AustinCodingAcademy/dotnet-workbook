using Cozy.Service.Implementation.Mock;
using Cozy.Service.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Cozy.WebUI
{
    public class Startup
    {
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
            app.UseMvcWithDefaultRoute();
        }
    }
}
