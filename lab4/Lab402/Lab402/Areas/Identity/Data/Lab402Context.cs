using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab402.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab402.Data
{
    public class Lab402Context : IdentityDbContext<Lab402User>
    {
        public Lab402Context(DbContextOptions<Lab402Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public DbSet<Lab402User> lab402Users { get; set; }
    }
}
