using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }

        public DbSet<Teacher> Teachers { get; set; }
    }
}
