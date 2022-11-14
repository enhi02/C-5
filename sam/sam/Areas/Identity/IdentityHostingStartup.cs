using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using sam.Areas.Identity.Data;
using sam.Data;

[assembly: HostingStartup(typeof(sam.Areas.Identity.IdentityHostingStartup))]
namespace sam.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<samContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("samContextConnection")));

                services.AddDefaultIdentity<samUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<samContext>();
            });
        }
    }
}