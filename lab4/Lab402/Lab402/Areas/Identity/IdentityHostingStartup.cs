using System;
using Lab402.Areas.Identity.Data;
using Lab402.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Lab402.Areas.Identity.IdentityHostingStartup))]
namespace Lab402.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<Lab402Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Lab402ContextConnection")));

                services.AddDefaultIdentity<Lab402User>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<Lab402Context>();
            });
        }
    }
}