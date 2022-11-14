using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cc.Models
{
    public class CompanyContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-66U3G81;Initial Catalog=demoSlide2;Integrated Security=True");
            }
        }
        public DbSet<Flight> Flights { get; set; }
    }
}
