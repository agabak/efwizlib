using Microsoft.EntityFrameworkCore.Migrations;

namespace Wizlib.DataAccess.Migrations
{
    public partial class addColumnToGenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DisplayOrder",
                table: "Genres",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "Genres");
        }
    }
}
