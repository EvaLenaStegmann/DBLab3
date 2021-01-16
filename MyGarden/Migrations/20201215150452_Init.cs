using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyGarden.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlantTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PlantTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plants_PlantTypes",
                        column: x => x.PlantTypeId,
                        principalTable: "PlantTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Actions",
                columns: table => new
                {
                    PlantId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionTypeId = table.Column<int>(type: "int", nullable: false),
                    ActionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actions", x => new { x.PlantId, x.LocationId, x.Id });
                    table.ForeignKey(
                        name: "FK_Actions_ActionTypes",
                        column: x => x.ActionTypeId,
                        principalTable: "ActionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Actions_Locations",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Actions_Plants",
                        column: x => x.PlantId,
                        principalTable: "Plants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ActionTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Förberett jorden" },
                    { 2, "Lagt på förgroning" },
                    { 3, "Sått/Satt" },
                    { 4, "Planterat om" },
                    { 5, "Planterat" },
                    { 6, "Beskurit" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "Pallkrage närmast altanen" },
                    { 4, "Krukor" },
                    { 1, "Pallkrage längst bort" },
                    { 2, "Pallkrage i mitten" }
                });

            migrationBuilder.InsertData(
                table: "PlantTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 9, "Rabarber" },
                    { 1, "Morot" },
                    { 2, "Vitlök" },
                    { 3, "Lök" },
                    { 4, "Potatis" },
                    { 5, "Paprika" },
                    { 6, "Tomat" },
                    { 7, "Sparris" },
                    { 8, "Sallat" },
                    { 10, "Sockerärtor" }
                });

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "Id", "Name", "PlantTypeId" },
                values: new object[] { 3, "Flyaway", 1 });

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "Id", "Name", "PlantTypeId" },
                values: new object[] { 1, "Unikat", 2 });

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "Id", "Name", "PlantTypeId" },
                values: new object[] { 2, "Sabagold", 2 });

            migrationBuilder.InsertData(
                table: "Actions",
                columns: new[] { "Id", "LocationId", "PlantId", "ActionDate", "ActionTypeId" },
                values: new object[] { 3, 2, 3, new DateTime(2020, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Actions",
                columns: new[] { "Id", "LocationId", "PlantId", "ActionDate", "ActionTypeId" },
                values: new object[] { 1, 2, 1, new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Actions",
                columns: new[] { "Id", "LocationId", "PlantId", "ActionDate", "ActionTypeId" },
                values: new object[] { 2, 2, 2, new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Actions_ActionTypeId",
                table: "Actions",
                column: "ActionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Actions_LocationId",
                table: "Actions",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Plants_PlantTypeId",
                table: "Plants",
                column: "PlantTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actions");

            migrationBuilder.DropTable(
                name: "ActionTypes");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Plants");

            migrationBuilder.DropTable(
                name: "PlantTypes");
        }
    }
}
