using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bai3.Models
{
    public class CompanyContext : DbContext
    {
   
            public DbSet<Product> Product { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-66U3G81;Initial Catalog=bai3;Integrated Security=True");
                }
            }
    }
}
