using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace MyGarden
{
    public class ActionEntityTypeConfiguration : IEntityTypeConfiguration<Action>
    {
        public void Configure(EntityTypeBuilder<Action> builder)
        {
            builder.ToTable("Actions")
                .HasKey(e => new { e.PlantId, e.LocationId, e.Id });

            builder.Property(e => e.LocationId)
                .IsRequired();

            builder.Property(e => e.PlantId)
                .IsRequired();

            builder.Property(e => e.Id)
                .UseIdentityColumn();

            builder.Property(e => e.ActionDate)
                .IsRequired();

            builder.Property(e => e.ActionTypeId)
                .IsRequired();

            builder.Property(e => e.HarvestSeason)
                .IsRequired();

            builder.HasOne(e => e.Plant)
                .WithMany(e => e.Actions)
                .HasForeignKey(e => e.PlantId)
                .HasConstraintName("FK_Actions_Plants");

            builder.HasOne(e => e.Location)
                .WithMany(e => e.Actions)
                .HasForeignKey(e => e.LocationId)
                .HasConstraintName("FK_Actions_Locations");

            builder.HasOne(e => e.ActionType)
                .WithMany(e => e.Actions)
                .HasForeignKey(e => e.ActionTypeId)
                .HasConstraintName("FK_Actions_ActionTypes");

            builder.HasCheckConstraint("CK_Actions_HarvestSeason","HarvestSeason >= year(ActionDate)");

            builder.HasData(
                 new Action() { PlantId = 1, LocationId = 2, Id = 1, ActionTypeId = 1, ActionDate = Convert.ToDateTime("2018-11-07"), HarvestSeason = 2019 },
                 new Action() { PlantId = 2, LocationId = 2, Id = 2, ActionTypeId = 1, ActionDate = Convert.ToDateTime("2018-11-07"), HarvestSeason = 2019 },
                 new Action() { PlantId = 1, LocationId = 1, Id = 3, ActionTypeId = 1, ActionDate = Convert.ToDateTime("2019-10-30"), HarvestSeason = 2020 },
                 new Action() { PlantId = 2, LocationId = 1, Id = 4, ActionTypeId = 1, ActionDate = Convert.ToDateTime("2019-10-30"), HarvestSeason = 2020 },
                 new Action() { PlantId = 10, LocationId = 1, Id = 5, ActionTypeId = 3, ActionDate = Convert.ToDateTime("2018-04-20"), HarvestSeason = 2019 },
                 new Action() { PlantId = 3, LocationId = 1, Id = 6, ActionTypeId = 1, ActionDate = Convert.ToDateTime("2019-05-02"), HarvestSeason = 2019 },
                 new Action() { PlantId = 4, LocationId = 1, Id = 7, ActionTypeId = 1, ActionDate = Convert.ToDateTime("2019-05-02"), HarvestSeason = 2019 },
                 new Action() { PlantId = 3, LocationId = 3, Id = 8, ActionTypeId = 1, ActionDate = Convert.ToDateTime("2020-04-23"), HarvestSeason = 2020 },
                 new Action() { PlantId = 4, LocationId = 3, Id = 9, ActionTypeId = 1, ActionDate = Convert.ToDateTime("2020-04-23"), HarvestSeason = 2020 },
                 new Action() { PlantId = 9, LocationId = 4, Id = 10, ActionTypeId = 3, ActionDate = Convert.ToDateTime("2019-05-02"), HarvestSeason = 2019 },
                 new Action() { PlantId = 9, LocationId = 4, Id = 11, ActionTypeId = 3, ActionDate = Convert.ToDateTime("2020-04-27"), HarvestSeason = 2020 },
                 new Action() { PlantId = 1, LocationId = 3, Id = 12, ActionTypeId = 1, ActionDate = Convert.ToDateTime("2020-11-03"), HarvestSeason = 2021 },
                 new Action() { PlantId = 2, LocationId = 3, Id = 13, ActionTypeId = 1, ActionDate = Convert.ToDateTime("2020-11-03"), HarvestSeason = 2021 }
             );

        }
    }
}
