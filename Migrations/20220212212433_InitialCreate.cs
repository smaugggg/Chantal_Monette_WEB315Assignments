using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dreamcatcher.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    stageName = table.Column<string>(type: "TEXT", nullable: true),
                    fullName = table.Column<string>(type: "TEXT", nullable: true),
                    englishName = table.Column<string>(type: "TEXT", nullable: true),
                    birthday = table.Column<DateTime>(type: "TEXT", nullable: false),
                    role = table.Column<string>(type: "TEXT", nullable: true),
                    homeTown = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Member");
        }
    }
}
