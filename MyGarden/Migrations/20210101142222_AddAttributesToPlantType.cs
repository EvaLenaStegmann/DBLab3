using Microsoft.EntityFrameworkCore.Migrations;

namespace MyGarden.Migrations
{
    public partial class AddAttributesToPlantType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Info",
                table: "PlantTypes",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nutrition",
                table: "PlantTypes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Perennial",
                table: "PlantTypes",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Soil",
                table: "PlantTypes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "PlantTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Perennial",
                value: false);

            migrationBuilder.UpdateData(
                table: "PlantTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Perennial",
                value: false);

            migrationBuilder.UpdateData(
                table: "PlantTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Perennial",
                value: false);

            migrationBuilder.UpdateData(
                table: "PlantTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Perennial",
                value: false);

            migrationBuilder.UpdateData(
                table: "PlantTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Perennial",
                value: false);

            migrationBuilder.UpdateData(
                table: "PlantTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Perennial",
                value: false);

            migrationBuilder.UpdateData(
                table: "PlantTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Perennial",
                value: true);

            migrationBuilder.UpdateData(
                table: "PlantTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "Perennial",
                value: false);

            migrationBuilder.UpdateData(
                table: "PlantTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "Perennial",
                value: true);

            migrationBuilder.UpdateData(
                table: "PlantTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "Perennial",
                value: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Info",
                table: "PlantTypes");

            migrationBuilder.DropColumn(
                name: "Nutrition",
                table: "PlantTypes");

            migrationBuilder.DropColumn(
                name: "Perennial",
                table: "PlantTypes");

            migrationBuilder.DropColumn(
                name: "Soil",
                table: "PlantTypes");
        }
    }
}
