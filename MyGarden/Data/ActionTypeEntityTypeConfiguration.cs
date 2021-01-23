using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyGarden
{
    public class ActionTypeEntityTypeConfiguration : IEntityTypeConfiguration<ActionType>
    {
        public void Configure(EntityTypeBuilder<ActionType> builder)
        {
            builder.ToTable("ActionTypes")
                .HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .UseIdentityColumn();

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasData(
                 new ActionType() { Id = 1, Name = "Sått/Satt" },
                 new ActionType() { Id = 2, Name = "Planterat om" },
                 new ActionType() { Id = 3, Name = "Planterat ut" },
                 new ActionType() { Id = 4, Name = "Beskurit" }
             );
        }
    }
}
