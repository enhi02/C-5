using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab4.Migrations
{
    public partial class lab401 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Skills = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TotalStudents = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<decimal>(type: "Money", nullable: false),
                    AddOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
