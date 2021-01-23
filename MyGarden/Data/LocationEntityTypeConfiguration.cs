using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyGarden
{
    public class LocationEntityTypeConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.ToTable("Locations")
                .HasKey(e => e.Id);

            builder.Property(e => e.Id).UseIdentityColumn();

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasData(
                 new Location() { Id = 1, Name = "Pallkrage längst bort" },
                 new Location() { Id = 2, Name = "Pallkrage i mitten" },
                 new Location() { Id = 3, Name = "Pallkrage närmast altanen" },
                 new Location() { Id = 4, Name = "Kruka 1" },
                 new Location() { Id = 5, Name = "Kruka 2" }
             );

        }
    }
}
