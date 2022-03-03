using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Homes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApartmentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfRoom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfBath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgeOfApartment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WhichFloor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeedStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WarmType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Facede = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FurnitureStatus = table.Column<bool>(type: "bit", nullable: false),
                    Lift = table.Column<bool>(type: "bit", nullable: false),
                    CarPark = table.Column<bool>(type: "bit", nullable: false),
                    Exchange = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdvertNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Square = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precedent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Template = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeedStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LandType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExchangeSatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdvertNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvertState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Square = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lands", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Homes");

            migrationBuilder.DropTable(
                name: "Lands");
        }
    }
}
