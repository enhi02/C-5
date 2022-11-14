using Microsoft.EntityFrameworkCore.Migrations;

namespace bai1.Migrations
{
    public partial class companyDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Dbo");

            migrationBuilder.CreateTable(
                name: "Client",
                schema: "Dbo",
                columns: table => new
                {
                    Address_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", nullable: true),
                    PhoneNo = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Address_Id);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                schema: "Dbo",
                columns: table => new
                {
                    Address_Id = table.Column<int>(type: "int", nullable: false),
                    Home_Addr = table.Column<string>(type: "varchar(50)", nullable: true),
                    office_addr = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Address_Id);
                    table.ForeignKey(
                        name: "FK_Address_Client_Address_Id",
                        column: x => x.Address_Id,
                        principalSchema: "Dbo",
                        principalTable: "Client",
                        principalColumn: "Address_Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address",
                schema: "Dbo");

            migrationBuilder.DropTable(
                name: "Client",
                schema: "Dbo");
        }
    }
}
