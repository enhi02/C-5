// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bai1.Models;

namespace bai1.Migrations
{
    [DbContext(typeof(CompanyContext))]
    [Migration("20220524124420_companyDB")]
    partial class companyDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Db")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("bai1.Models.Address", b =>
                {
                    b.Property<int>("Address_Id")
                        .HasColumnType("int");

                    b.Property<string>("Home_addr")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Home_Addr");

                    b.Property<string>("office_addr")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("office_addr");

                    b.HasKey("Address_Id");

                    b.ToTable("Address", "Dbo");
                });

            modelBuilder.Entity("bai1.Models.Client", b =>
                {
                    b.Property<int>("Address_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Name");

                    b.Property<string>("PhoneNo")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("PhoneNo");

                    b.HasKey("Address_Id");

                    b.ToTable("Client", "Dbo");
                });

            modelBuilder.Entity("bai1.Models.Address", b =>
                {
                    b.HasOne("bai1.Models.Client", "Client")
                        .WithMany("Address")
                        .HasForeignKey("Address_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("bai1.Models.Client", b =>
                {
                    b.Navigation("Address");
                });
#pragma warning restore 612, 618
        }
    }
}
