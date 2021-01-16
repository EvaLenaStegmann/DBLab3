using Microsoft.EntityFrameworkCore.Migrations;

namespace MyGarden.Migrations
{
    public partial class ChangeViewsForPerennials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@" create table Tally ( N smallint ); ");
            string sql = @" insert into Tally (n) " +
                         @" (SELECT ROW_NUMBER() OVER(ORDER BY(SELECT NULL)) " +
                         @" FROM(VALUES(0), (0), (0), (0), (0), (0), (0), (0), (0), (0)) a(n) " +
                         @" CROSS JOIN(VALUES(0),(0),(0),(0),(0),(0),(0),(0),(0),(0)) b(n) " +
                         @" CROSS JOIN(VALUES(0),(0),(0),(0),(0),(0),(0),(0),(0),(0)) c(n) " +
                         @" CROSS JOIN(VALUES(0),(0),(0),(0),(0),(0),(0),(0),(0),(0)) d(n) " +
                         @" ); ";
            migrationBuilder.Sql(sql);

            migrationBuilder.Sql(@"
                alter view PlantsPerLocation as
                select 
                    LocationName
                    ,HarvestSeason
                    ,string_agg(PlantName, ', ') as 'PlantNames'
                 from (select distinct
                         l.Name as 'LocationName'
                         , isnull(t.N, a.HarvestSeason) as 'HarvestSeason'
                         , p.Name as 'PlantName'
                     from Actions a
                        inner join Plants p on p.id = a.PlantId 
                        inner join PlantTypes pt on pt.Id = p.PlantTypeId
                        inner join Locations l on l.Id = a.LocationId
                        left outer join Tally t 
							on pt.Perennial = 1 
							and t.n between a.HarvestSeason 
							and (select max(a.HarvestSeason) from Actions a)
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
                         , isnull(t.N, a.HarvestSeason) as 'HarvestSeason'
                         , pt.Name as 'PlantTypeName'
                     from Actions a
                        inner join Plants p on p.id = a.PlantId 
                        inner join PlantTypes pt on pt.Id = p.PlantTypeId
                        inner join Locations l on l.Id = a.LocationId
                        left outer join Tally t 
							on pt.Perennial = 1 
							and t.n between a.HarvestSeason 
							and (select max(a.HarvestSeason) from Actions a)
                     ) as subquery
                 group by LocationName, HarvestSeason;
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.Sql(@" drop table Tally; ");
        }
    }
}
