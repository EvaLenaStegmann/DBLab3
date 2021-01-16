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
                 new Action() { PlantId = 1, LocationId = 2, Id = 1, ActionTypeId = 3, ActionDate = Convert.ToDateTime("2019-11-07"), HarvestSeason = 2020 },
                 new Action() { PlantId = 2, LocationId = 2, Id = 2, ActionTypeId = 3, ActionDate = Convert.ToDateTime("2019-11-07"), HarvestSeason = 2020 },
                 new Action() { PlantId = 3, LocationId = 2, Id = 3, ActionTypeId = 3, ActionDate = Convert.ToDateTime("2020-04-18"), HarvestSeason = 2020 }
             );

        }
    }
}
