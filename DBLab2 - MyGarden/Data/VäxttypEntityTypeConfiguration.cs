using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyGarden
{
    class VäxttypEntityTypeConfiguration : IEntityTypeConfiguration<Växttyp>
    {
        public void Configure(EntityTypeBuilder<Växttyp> builder)
        {
            builder.ToTable("växttyper").HasKey(växttyp => växttyp.Id);

            builder.Property(e => e.Id).UseIdentityColumn();

            builder.Property(e => e.Namn)
                .IsRequired()
                .HasMaxLength(100); 
        }
    }
}
