using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarden
{
    public partial class MyGardenContext : DbContext
    {
        public MyGardenContext()
        {
        }

        public MyGardenContext(DbContextOptions<MyGardenContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Växttyp> Växttyper { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=MyGarden;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new VäxttypEntityTypeConfiguration().Configure(modelBuilder.Entity<Växttyp>());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
