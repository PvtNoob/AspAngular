using Microsoft.EntityFrameworkCore.Migrations;

namespace AspAngular.Migrations
{
    public partial class Plz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Plz",
                table: "User",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Plz",
                table: "User");
        }
    }
}
