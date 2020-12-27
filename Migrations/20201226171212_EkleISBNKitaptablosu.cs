using Microsoft.EntityFrameworkCore.Migrations;

namespace Kitaplisteleme.Migrations
{
    public partial class EkleISBNKitaptablosu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ISBN",
                table: "Kitap",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ISBN",
                table: "Kitap");
        }
    }
}
