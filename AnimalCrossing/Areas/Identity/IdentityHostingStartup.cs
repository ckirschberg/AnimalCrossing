using System;
using AnimalCrossing.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(AnimalCrossing.Areas.Identity.IdentityHostingStartup))]
namespace AnimalCrossing.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AnimalCrossingIdentityDbContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("AnimalCrossingIdentityDbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.SignIn.RequireConfirmedEmail = false;
                    options.SignIn.RequireConfirmedPhoneNumber = false;

                    options.Password.RequiredLength = 8;
                    options.Password.RequireUppercase = false;
                })
                    .AddEntityFrameworkStores<AnimalCrossingIdentityDbContext>();

            });
        }

    }
}