using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PS18441_PTH_thibaove.Migrations
{
    public partial class baovec5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roots",
                columns: table => new
                {
                    RootID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TextID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Head = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PublishTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HitCount = table.Column<int>(type: "int", nullable: false),
                    CommentCount = table.Column<int>(type: "int", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    ChannelID = table.Column<int>(type: "int", nullable: false),
                    HeadImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ArticleType = table.Column<int>(type: "int", nullable: false),
                    ThumbImageUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roots", x => x.RootID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Roots");
        }
    }
}
