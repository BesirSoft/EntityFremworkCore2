using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFremworkCore2.Migrations
{
    public partial class Addstocclomun : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Stok",
                table: "Products",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stok",
                table: "Products");
        }
    }
}
