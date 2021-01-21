using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyGarden
{
    public class PlantTypeEntityTypeConfiguration : IEntityTypeConfiguration<PlantType>
    {
        public void Configure(EntityTypeBuilder<PlantType> builder)
        {
            builder.ToTable("PlantTypes")
                .HasKey(e => e.Id);

            builder.Property(e => e.Id).UseIdentityColumn();

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Perennial)
                .IsRequired()
                ;

            builder.Property(e => e.Nutrition)
                .HasMaxLength(100);

            builder.Property(e => e.Info)
                .HasMaxLength(1000);

            builder.Property(e => e.Soil)
                .HasMaxLength(100);
            //TODO: mer testdata... (inte bara just planttypes)
            builder.HasData(
                 new PlantType() { Id = 1, Name = "Morot", Perennial = false },
                 new PlantType() { Id = 2, Name = "Vitlök", Perennial = false },
                 new PlantType() { Id = 3, Name = "Lök", Perennial = false },
                 new PlantType() { Id = 4, Name = "Potatis", Perennial = false },
                 new PlantType() { Id = 5, Name = "Paprika", Perennial = false },
                 new PlantType() { Id = 6, Name = "Tomat", Perennial = false },
                 new PlantType() { Id = 7, Name = "Sparris", Perennial = true },
                 new PlantType() { Id = 8, Name = "Sallat", Perennial = false },
                 new PlantType() { Id = 9, Name = "Rabarber", Perennial = true },
                 new PlantType() { Id = 10, Name = "Sockerärtor", Perennial = false }
             );

        }
    }
}
