using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyGarden.Migrations
{
    public partial class AddHarvestSeason : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<short>(
                name: "HarvestSeason",
                table: "Actions",
                type: "smallint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumns: new[] { "Id", "LocationId", "PlantId" },
                keyValues: new object[] { 1, 2, 1 },
                columns: new[] { "ActionDate", "HarvestSeason" },
                values: new object[] { new DateTime(2019, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), (short)2020 });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumns: new[] { "Id", "LocationId", "PlantId" },
                keyValues: new object[] { 2, 2, 2 },
                columns: new[] { "ActionDate", "HarvestSeason" },
                values: new object[] { new DateTime(2019, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), (short)2020 });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumns: new[] { "Id", "LocationId", "PlantId" },
                keyValues: new object[] { 3, 2, 3 },
                columns: new[] { "ActionDate", "HarvestSeason" },
                values: new object[] { new DateTime(2020, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), (short)2020 });

            migrationBuilder.AddCheckConstraint(
                name: "CK_Actions_HarvestSeason",
                table: "Actions",
                sql: "HarvestSeason >= year(ActionDate)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Actions_HarvestSeason",
                table: "Actions");

            migrationBuilder.DropColumn(
                name: "HarvestSeason",
                table: "Actions");

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumns: new[] { "Id", "LocationId", "PlantId" },
                keyValues: new object[] { 1, 2, 1 },
                column: "ActionDate",
                value: new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumns: new[] { "Id", "LocationId", "PlantId" },
                keyValues: new object[] { 2, 2, 2 },
                column: "ActionDate",
                value: new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumns: new[] { "Id", "LocationId", "PlantId" },
                keyValues: new object[] { 3, 2, 3 },
                column: "ActionDate",
                value: new DateTime(2020, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
