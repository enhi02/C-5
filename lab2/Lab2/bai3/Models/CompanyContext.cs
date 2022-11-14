using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace bai3.Models
{
    public class CompanyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);
        }
        public DbSet<PersonCompanies> PersonCompaniess { get; set; }
        public DbSet<Companies> Companiess { get; set; }
        public DbSet<People> peoples { get; set; }


        //    protected override void OnModelCreating(ModelBuilder modelBuilder)
        //    {
        //        modelBuilder.HasDefaultSchema("Db");
        //        modelBuilder.Entity<PersonCompanies>().HasKey(e => e.Id);
        //        modelBuilder.Entity<PersonCompanies>(entity =>
        //        {
        //            entity.Property(e => e.FromYear).HasColumnName("FromYear")
        //            .HasColumnType("datetime");
        //            entity.Property(e => e.ToYear).HasColumnName("ToYear")
        //           .HasColumnType("datetime");
        //            entity.Property(e => e.Position).HasColumnName("Position")
        //          .HasColumnType("nvarchar(50)");
        //            entity.Property(e => e.Company_Id).HasColumnName("Company_Id")
        //          .HasColumnType("int").IsRequired();
        //            entity.Property(e => e.Person_Id).HasColumnName("Person_Id")
        //          .HasColumnType("int").IsRequired(); ;

        //        });
        //        modelBuilder.Entity<Companies>().HasKey(n => n.Id);
        //        modelBuilder.Entity<Companies>(entityy =>
        //        {
        //            entityy.Property(e => e.Id).HasColumnName("Id")
        //           .HasColumnType("int").IsRequired();
        //            entityy.Property(e => e.Name).HasColumnName("Name")
        //           .HasColumnType("nvarchar(100)");

        //        });
        //        modelBuilder.Entity<People>().HasKey(n => n.Id);
        //        modelBuilder.Entity<People>(entityyy =>
        //        {
        //            entityyy.Property(e => e.Id).HasColumnName("Id")
        //           .HasColumnType("int").IsRequired();
        //            entityyy.Property(e => e.FirstName).HasColumnName("FirstName")
        //           .HasColumnType("nvarchar(100)");
        //            entityyy.Property(e => e.lastName).HasColumnName("lastName")
        //          .HasColumnType("nvarchar(100)");
        //        });
        //    }
        //}
    }
}
