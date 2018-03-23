using EZRent.Data.Database;
using EZRent.Data.Seeding;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace EZRent.WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = BuildWebHost(args);

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    var appUserDbContext = services.GetRequiredService<ApplicationUserDbContext>();
                    var eZRentDbContext = services.GetRequiredService<EZRentDbContext>();

                    DBInitializer.Init(appUserDbContext, eZRentDbContext);
                }
                catch (Exception ex)
                {
                    //nada for now
                }
            }


                host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
