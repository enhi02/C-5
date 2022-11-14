using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Lab_6.Models;

namespace Lab_6.Models
{
    public class ReservationDBContext : DbContext
    {
        public ReservationDBContext(DbContextOptions<ReservationDBContext> options) : base(options) 
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration["ConnectionStrings:ReservationConnection"]);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
                entity.Property(e => e.StartLocation)
                   .HasMaxLength(250)
                   .IsUnicode(false);
                entity.Property(e => e.EndLocation)
                   .HasMaxLength(250)
                   .IsUnicode(false);
            });
        } 
        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<UserInfo> UserInfos { get; set; }
    }

}
