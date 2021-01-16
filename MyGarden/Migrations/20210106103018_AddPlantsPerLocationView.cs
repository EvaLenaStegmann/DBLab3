using Microsoft.EntityFrameworkCore.Migrations;

namespace MyGarden.Migrations
{
    public partial class AddPlantsPerLocationView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                create view PlantsPerLocation as
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                drop view PlantsPerLocation;
            ");
        }
    }
}
