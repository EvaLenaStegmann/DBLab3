using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyGarden
{
    public class PlantEntityTypeConfiguration : IEntityTypeConfiguration<Plant>
    {
        public void Configure(EntityTypeBuilder<Plant> builder)
        {
            builder.ToTable("Plants")
                .HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .UseIdentityColumn();

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.PlantTypeId)
                .IsRequired();

            builder.HasOne(e => e.PlantType)
                .WithMany(e => e.Plants)
                .HasForeignKey(e => e.PlantTypeId)
                .HasConstraintName("FK_Plants_PlantTypes");

            builder.HasData(
                 new Plant() { Id = 1, Name = "Unikat", PlantTypeId = 2 },
                 new Plant() { Id = 2, Name = "Sabagold", PlantTypeId = 2 },
                 new Plant() { Id = 3, Name = "Flyaway", PlantTypeId = 1 }
             );
        }
    }
}
