﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using slide1.Models;

namespace slide1.Migrations
{
    [DbContext(typeof(databasecontac))]
    [Migration("20220510140959_CompanyDB")]
    partial class CompanyDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("slide1.Models.product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<int>("Quantiny")
                        .HasColumnType("int");

                    b.Property<bool>("Satus")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasColumnType("varchar(250");

                    b.HasKey("id");

                    b.ToTable("products");
                });
#pragma warning restore 612, 618
        }
    }
}
