using Microsoft.EntityFrameworkCore.Migrations;

namespace MyGarden.Migrations
{
    public partial class ChangePlantTypesPerLocationView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
