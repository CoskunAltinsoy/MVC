using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class arrangamentLandAndHome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Exchange",
                table: "Homes");

            migrationBuilder.RenameColumn(
                name: "ExchangeSatus",
                table: "Lands",
                newName: "ExchangeStatus");

            migrationBuilder.AddColumn<string>(
                name: "ExchangeStatus",
                table: "Homes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExchangeStatus",
                table: "Homes");

            migrationBuilder.RenameColumn(
                name: "ExchangeStatus",
                table: "Lands",
                newName: "ExchangeSatus");

            migrationBuilder.AddColumn<bool>(
                name: "Exchange",
                table: "Homes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
