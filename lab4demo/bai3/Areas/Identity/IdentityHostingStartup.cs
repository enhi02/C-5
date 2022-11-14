using System;
using bai3.Areas.Identity.Data;
using bai3.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(bai3.Areas.Identity.IdentityHostingStartup))]
namespace bai3.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<bai3Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("bai3ContextConnection")));

                services.AddDefaultIdentity<bai3User>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<bai3Context>();
            });
        }
    }
}