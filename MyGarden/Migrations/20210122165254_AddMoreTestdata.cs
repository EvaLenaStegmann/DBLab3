using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyGarden.Migrations
{
    public partial class AddMoreTestdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActionTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ActionTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumns: new[] { "Id", "LocationId", "PlantId" },
                keyValues: new object[] { 3, 2, 3 });

            migrationBuilder.DeleteData(
                table: "PlantTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PlantTypes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PlantTypes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "ActionTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Sått/Satt");

            migrationBuilder.UpdateData(
                table: "ActionTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Planterat om");

            migrationBuilder.UpdateData(
                table: "ActionTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Planterat ut");

            migrationBuilder.UpdateData(
                table: "ActionTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Beskurit");

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumns: new[] { "Id", "LocationId", "PlantId" },
                keyValues: new object[] { 1, 2, 1 },
                columns: new[] { "ActionDate", "ActionTypeId", "HarvestSeason" },
                values: new object[] { new DateTime(2018, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, (short)2019 });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumns: new[] { "Id", "LocationId", "PlantId" },
                keyValues: new object[] { 2, 2, 2 },
                columns: new[] { "ActionDate", "ActionTypeId", "HarvestSeason" },
                values: new object[] { new DateTime(2018, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, (short)2019 });

            migrationBuilder.InsertData(
                table: "Actions",
                columns: new[] { "Id", "LocationId", "PlantId", "ActionDate", "ActionTypeId", "HarvestSeason" },
                values: new object[,]
                {
                    { 3, 1, 1, new DateTime(2019, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, (short)2020 },
                    { 13, 3, 2, new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, (short)2021 },
                    { 12, 3, 1, new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, (short)2021 },
                    { 8, 3, 3, new DateTime(2020, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, (short)2020 },
                    { 6, 1, 3, new DateTime(2019, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, (short)2019 },
                    { 4, 1, 2, new DateTime(2019, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, (short)2020 }
                });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Kruka 1");

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Kruka 2" });

            migrationBuilder.UpdateData(
                table: "PlantTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Info", "Soil" },
                values: new object[] { "Täck gärna med fiberduk fra till ca midsommar för att slippa angrepp av morotslarver.", "Väldränerad" });

            migrationBuilder.UpdateData(
                table: "PlantTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Info", "Soil" },
                values: new object[] { "Sätt strax innan tjälen för skörd sommaren efter. Kan även sättas på våren, de hinner kanske inte bilda klyftor men är goda ändå.", "Lucker, väldränerad" });

            migrationBuilder.UpdateData(
                table: "PlantTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Info", "Nutrition", "Soil" },
                values: new object[] { "Kupas", "Ge inte för mycket kväve, då blir det mest blast", "Lucker" });

            migrationBuilder.UpdateData(
                table: "PlantTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Paprika/Chili");

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "Id", "Name", "PlantTypeId" },
                values: new object[,]
                {
                    { 8, "Estilo", 5 },
                    { 7, "Anaheim", 5 },
                    { 6, "Sweet Banana", 5 },
                    { 5, "Amandine", 4 },
                    { 4, "Rocket", 4 },
                    { 10, "Primaverde", 7 },
                    { 9, "Vinbärstomat", 6 }
                });

            migrationBuilder.InsertData(
                table: "Actions",
                columns: new[] { "Id", "LocationId", "PlantId", "ActionDate", "ActionTypeId", "HarvestSeason" },
                values: new object[,]
                {
                    { 7, 1, 4, new DateTime(2019, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, (short)2019 },
                    { 9, 3, 4, new DateTime(2020, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, (short)2020 },
                    { 10, 4, 9, new DateTime(2019, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, (short)2019 },
                    { 11, 4, 9, new DateTime(2020, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, (short)2020 },
                    { 5, 1, 10, new DateTime(2018, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, (short)2019 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumns: new[] { "Id", "LocationId", "PlantId" },
                keyValues: new object[] { 3, 1, 1 });

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumns: new[] { "Id", "LocationId", "PlantId" },
                keyValues: new object[] { 12, 3, 1 });

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumns: new[] { "Id", "LocationId", "PlantId" },
                keyValues: new object[] { 4, 1, 2 });

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumns: new[] { "Id", "LocationId", "PlantId" },
                keyValues: new object[] { 13, 3, 2 });

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumns: new[] { "Id", "LocationId", "PlantId" },
                keyValues: new object[] { 6, 1, 3 });

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumns: new[] { "Id", "LocationId", "PlantId" },
                keyValues: new object[] { 8, 3, 3 });

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumns: new[] { "Id", "LocationId", "PlantId" },
                keyValues: new object[] { 7, 1, 4 });

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumns: new[] { "Id", "LocationId", "PlantId" },
                keyValues: new object[] { 9, 3, 4 });

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumns: new[] { "Id", "LocationId", "PlantId" },
                keyValues: new object[] { 10, 4, 9 });

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumns: new[] { "Id", "LocationId", "PlantId" },
                keyValues: new object[] { 11, 4, 9 });

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumns: new[] { "Id", "LocationId", "PlantId" },
                keyValues: new object[] { 5, 1, 10 });

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "ActionTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Förberett jorden");

            migrationBuilder.UpdateData(
                table: "ActionTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Lagt på förgroning");

            migrationBuilder.UpdateData(
                table: "ActionTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Sått/Satt");

            migrationBuilder.UpdateData(
                table: "ActionTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Planterat om");

            migrationBuilder.InsertData(
                table: "ActionTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "Planterat" },
                    { 6, "Beskurit" }
                });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumns: new[] { "Id", "LocationId", "PlantId" },
                keyValues: new object[] { 1, 2, 1 },
                columns: new[] { "ActionDate", "ActionTypeId", "HarvestSeason" },
                values: new object[] { new DateTime(2019, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, (short)2020 });

            migrationBuilder.UpdateData(
                table: "Actions",
                keyColumns: new[] { "Id", "LocationId", "PlantId" },
                keyValues: new object[] { 2, 2, 2 },
                columns: new[] { "ActionDate", "ActionTypeId", "HarvestSeason" },
                values: new object[] { new DateTime(2019, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, (short)2020 });

            migrationBuilder.InsertData(
                table: "Actions",
                columns: new[] { "Id", "LocationId", "PlantId", "ActionDate", "ActionTypeId", "HarvestSeason" },
                values: new object[] { 3, 2, 3, new DateTime(2020, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, (short)2020 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Krukor");

            migrationBuilder.UpdateData(
                table: "PlantTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Info", "Soil" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "PlantTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Info", "Soil" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "PlantTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Info", "Nutrition", "Soil" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "PlantTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Paprika");

            migrationBuilder.InsertData(
                table: "PlantTypes",
                columns: new[] { "Id", "Info", "Name", "Nutrition", "Perennial", "Soil" },
                values: new object[,]
                {
                    { 10, null, "Sockerärtor", null, false, null },
                    { 9, null, "Rabarber", null, true, null },
                    { 8, null, "Sallat", null, false, null }
                });
        }
    }
}
