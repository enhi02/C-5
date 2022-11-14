using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace bai1.Models
{
    public class CompanyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);
        }
        public DbSet<Address> Addresss { get; set; }
        public DbSet<Client> Clients { get; set; }


        //câu C
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Db");
            modelBuilder.Entity<Address>().HasKey(e => e.Address_Id);
            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.Home_addr).HasColumnName("Home_Addr")
                .HasColumnType("varchar(50)");
                entity.Property(e => e.office_addr).HasColumnName("office_addr")
               .HasColumnType("varchar(50)");
            });
            modelBuilder.Entity<Client>().HasKey(n => n.Address_Id);
            modelBuilder.Entity<Client>(entityy =>
            {
                entityy.Property(e => e.Name).HasColumnName("Name")
               .HasColumnType("varchar(50)");
                entityy.Property(e => e.PhoneNo).HasColumnName("PhoneNo")
               .HasColumnType("varchar(50)");
            });
                }

    }
}
