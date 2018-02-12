using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using CableProvider.Data;
using CableProvider.UI.Services;

namespace CableProvider.UI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=CableProviderDatabase;Integrated Security=True;Pooling=False";
            services.AddDbContext<CableProviderDbContext>(option => option.UseSqlServer(connectionString));

            services.AddMvc();
            services.AddScoped<SessionServices>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

                app.UseMvcWithDefaultRoute();
        }
    }
}
