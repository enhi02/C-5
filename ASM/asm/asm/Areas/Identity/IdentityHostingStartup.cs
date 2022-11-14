using System;
using asm.Areas.Identity.Data;
using asm.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(asm.Areas.Identity.IdentityHostingStartup))]
namespace asm.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<asmContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("asmContextConnection")));

                services.AddDefaultIdentity<asmUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<asmContext>();
            });
        }
    }
}