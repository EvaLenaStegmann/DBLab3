using Microsoft.EntityFrameworkCore.Migrations;

namespace MyGarden.Migrations
{
    public partial class MakeHarvestSeasonRequiredAndAlterViews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "HarvestSeason",
                table: "Actions",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldNullable: true);

            migrationBuilder.Sql(@"
                alter view PlantsPerLocation as
                select 
                    LocationName
                    ,HarvestSeason
                    ,string_agg(PlantName, ', ') as 'PlantNames'
                 from (select distinct
                         l.Name as 'LocationName'
                         , a.HarvestSeason
                         , p.Name as 'PlantName'
                     from Actions a
                        inner join Plants p on p.id = a.PlantId 
                        inner join PlantTypes pt on pt.Id = p.PlantTypeId
                        inner join Locations l on l.Id = a.LocationId
                     ) as subquery
                 group by LocationName, HarvestSeason;
            ");

            migrationBuilder.Sql(@"
                alter view PlantTypesPerLocation as
                select 
                    LocationName
                    ,HarvestSeason
                    ,string_agg(PlantTypename, ', ') as 'PlantNames'
                 from (select distinct
                         l.Name as 'LocationName'
                         , a.HarvestSeason
                         , pt.Name as 'PlantTypeName'
                     from Actions a
                        inner join Plants p on p.id = a.PlantId 
                        inner join PlantTypes pt on pt.Id = p.PlantTypeId
                        inner join Locations l on l.Id = a.LocationId
                     ) as subquery
                 group by LocationName, HarvestSeason;
            ");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "HarvestSeason",
                table: "Actions",
                type: "smallint",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.Sql(@"
                alter view PlantsPerLocation as
                select 
                    LocationName
                    ,Season
                    ,string_agg(PlantName, ', ') as 'PlantNames'
                 from (select distinct
                         l.Name as 'LocationName'
                         , year(a.ActionDate) as 'Season'
                         , p.Name as 'PlantName'
                     from Actions a
                        inner join Plants p on p.id = a.PlantId 
                        inner join PlantTypes pt on pt.Id = p.PlantTypeId
                        inner join Locations l on l.Id = a.LocationId
                     ) as subquery
                 group by LocationName, Season;
            ");

            migrationBuilder.Sql(@"
                alter view PlantTypesPerLocation as
                select 
                    LocationName
                    ,Season
                    ,string_agg(PlantTypename, ', ') as 'PlantNames'
                 from (select distinct
                         l.Name as 'LocationName'
                         , year(a.ActionDate) as 'Season'
                         , pt.Name as 'PlantTypeName'
                     from Actions a
                        inner join Plants p on p.id = a.PlantId 
                        inner join PlantTypes pt on pt.Id = p.PlantTypeId
                        inner join Locations l on l.Id = a.LocationId
                     ) as subquery
                 group by LocationName, Season;
            ");
        }
    }
}
