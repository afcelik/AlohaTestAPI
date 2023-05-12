using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlohaTestAPI.Migrations
{
    public partial class FourthUpdateTableConnectionsEdited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Adresses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Adresses");
        }
    }
}
