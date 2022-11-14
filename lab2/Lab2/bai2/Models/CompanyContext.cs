using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace bai2.Models
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
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<ThanNhan> ThanNhans { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Db");
            modelBuilder.Entity<NhanVien>().HasKey(e => e.MaNV);
            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.Property(e => e.HoNV).HasColumnName("Ho_NV")
                .HasColumnType("nvarchar(15)");
                entity.Property(e => e.TenLot).HasColumnName("TenLot")
               .HasColumnType("nvarchar(15)");
                entity.Property(e => e.TenNV).HasColumnName("TenNV")
              .HasColumnType("nvarchar(15)");
                entity.Property(e => e.MaNV).HasColumnName("MaNV")
              .HasColumnType("char(9)").IsRequired();
                entity.Property(e => e.NgaySinh).HasColumnName("NgaySinh")
              .HasColumnType("datetime");
                entity.Property(e => e.DiaChi).HasColumnName("DiaChi")
              .HasColumnType("nchar(30)");
                entity.Property(e => e.Phai).HasColumnName("Phai")
             .HasColumnType("nchar(3)");
                entity.Property(e => e.luong).HasColumnName("luong")
             .HasColumnType("float");
                entity.Property(e => e.Ma_NQL).HasColumnName("Ma_NQL")
             .HasColumnType("nchar(9)");
                entity.Property(e => e.PHG).HasColumnName("PHG")
          .HasColumnType("int").IsRequired();
            });
            modelBuilder.Entity<ThanNhan>().HasKey(n =>new { n.MaNVien,n.TenTN } );
            modelBuilder.Entity<ThanNhan>(entityy =>
            {
                entityy.Property(e => e.MaNVien).HasColumnName("MaNVien")
               .HasColumnType("char(9)").IsRequired();
                entityy.Property(e => e.TenTN).HasColumnName("TenTN")
               .HasColumnType("nvarchar(15)");
                entityy.Property(e => e.Phai).HasColumnName("Phai")
               .HasColumnType("nchar(3)");
                entityy.Property(e => e.NgSinh).HasColumnName("NgSinh")
               .HasColumnType("datetime");
                entityy.Property(e => e.QuanHe).HasColumnName("QuanHe")
               .HasColumnType("nvarchar(15)").IsRequired();
            });
        }
    }
}
