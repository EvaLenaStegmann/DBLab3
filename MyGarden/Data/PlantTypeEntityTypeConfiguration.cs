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

            builder.HasData(
                 new PlantType() { Id = 1, Name = "Morot", Perennial = false, Soil = "Väldränerad", Info = "Täck gärna med fiberduk fra till ca midsommar för att slippa angrepp av morotslarver." },
                 new PlantType() { Id = 2, Name = "Vitlök", Perennial = false, Soil = "Lucker, väldränerad", Info = "Sätt strax innan tjälen för skörd sommaren efter. Kan även sättas på våren, de hinner kanske inte bilda klyftor men är goda ändå." },
                 new PlantType() { Id = 3, Name = "Lök", Perennial = false },
                 new PlantType() { Id = 4, Name = "Potatis", Perennial = false, Soil = "Lucker", Nutrition = "Ge inte för mycket kväve, då blir det mest blast", Info = "Kupas" },
                 new PlantType() { Id = 5, Name = "Paprika/Chili", Perennial = false },
                 new PlantType() { Id = 6, Name = "Tomat", Perennial = false },
                 new PlantType() { Id = 7, Name = "Sparris", Perennial = true }
             );

        }
    }
}
