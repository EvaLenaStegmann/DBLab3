using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

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

        public virtual DbSet<PlantType> PlantTypes { get; set; }
        public virtual DbSet<ActionType> ActionTypes { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Plant> Plants { get; set; }
        public virtual DbSet<Action> Actions { get; set; }
        public virtual DbSet<PlantsPerLocation> PlantsPerLocation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var connectionString = config.GetConnectionString("default");

            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new PlantTypeEntityTypeConfiguration().Configure(modelBuilder.Entity<PlantType>());
            new ActionTypeEntityTypeConfiguration().Configure(modelBuilder.Entity<ActionType>());
            new LocationEntityTypeConfiguration().Configure(modelBuilder.Entity<Location>());
            new PlantEntityTypeConfiguration().Configure(modelBuilder.Entity<Plant>());
            new ActionEntityTypeConfiguration().Configure(modelBuilder.Entity<Action>());

            modelBuilder.Entity<PlantsPerLocation>().ToView("PlantTypesPerLocation").HasNoKey();
            modelBuilder.Entity<PlantsPerLocation>().ToView("PlantsPerLocation").HasNoKey();
        }
    }
}
