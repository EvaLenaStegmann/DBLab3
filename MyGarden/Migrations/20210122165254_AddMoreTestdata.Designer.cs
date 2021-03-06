﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyGarden;

namespace MyGarden.Migrations
{
    [DbContext(typeof(MyGardenContext))]
    [Migration("20210122165254_AddMoreTestdata")]
    partial class AddMoreTestdata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("MyGarden.Action", b =>
                {
                    b.Property<int>("PlantId")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("ActionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ActionTypeId")
                        .HasColumnType("int");

                    b.Property<short>("HarvestSeason")
                        .HasColumnType("smallint");

                    b.HasKey("PlantId", "LocationId", "Id");

                    b.HasIndex("ActionTypeId");

                    b.HasIndex("LocationId");

                    b.ToTable("Actions");

                    b.HasCheckConstraint("CK_Actions_HarvestSeason", "HarvestSeason >= year(ActionDate)");

                    b.HasData(
                        new
                        {
                            PlantId = 1,
                            LocationId = 2,
                            Id = 1,
                            ActionDate = new DateTime(2018, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ActionTypeId = 1,
                            HarvestSeason = (short)2019
                        },
                        new
                        {
                            PlantId = 2,
                            LocationId = 2,
                            Id = 2,
                            ActionDate = new DateTime(2018, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ActionTypeId = 1,
                            HarvestSeason = (short)2019
                        },
                        new
                        {
                            PlantId = 1,
                            LocationId = 1,
                            Id = 3,
                            ActionDate = new DateTime(2019, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ActionTypeId = 1,
                            HarvestSeason = (short)2020
                        },
                        new
                        {
                            PlantId = 2,
                            LocationId = 1,
                            Id = 4,
                            ActionDate = new DateTime(2019, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ActionTypeId = 1,
                            HarvestSeason = (short)2020
                        },
                        new
                        {
                            PlantId = 10,
                            LocationId = 1,
                            Id = 5,
                            ActionDate = new DateTime(2018, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ActionTypeId = 3,
                            HarvestSeason = (short)2019
                        },
                        new
                        {
                            PlantId = 3,
                            LocationId = 1,
                            Id = 6,
                            ActionDate = new DateTime(2019, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ActionTypeId = 1,
                            HarvestSeason = (short)2019
                        },
                        new
                        {
                            PlantId = 4,
                            LocationId = 1,
                            Id = 7,
                            ActionDate = new DateTime(2019, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ActionTypeId = 1,
                            HarvestSeason = (short)2019
                        },
                        new
                        {
                            PlantId = 3,
                            LocationId = 3,
                            Id = 8,
                            ActionDate = new DateTime(2020, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ActionTypeId = 1,
                            HarvestSeason = (short)2020
                        },
                        new
                        {
                            PlantId = 4,
                            LocationId = 3,
                            Id = 9,
                            ActionDate = new DateTime(2020, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ActionTypeId = 1,
                            HarvestSeason = (short)2020
                        },
                        new
                        {
                            PlantId = 9,
                            LocationId = 4,
                            Id = 10,
                            ActionDate = new DateTime(2019, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ActionTypeId = 3,
                            HarvestSeason = (short)2019
                        },
                        new
                        {
                            PlantId = 9,
                            LocationId = 4,
                            Id = 11,
                            ActionDate = new DateTime(2020, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ActionTypeId = 3,
                            HarvestSeason = (short)2020
                        },
                        new
                        {
                            PlantId = 1,
                            LocationId = 3,
                            Id = 12,
                            ActionDate = new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ActionTypeId = 1,
                            HarvestSeason = (short)2021
                        },
                        new
                        {
                            PlantId = 2,
                            LocationId = 3,
                            Id = 13,
                            ActionDate = new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ActionTypeId = 1,
                            HarvestSeason = (short)2021
                        });
                });

            modelBuilder.Entity("MyGarden.ActionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("ActionTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sått/Satt"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Planterat om"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Planterat ut"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Beskurit"
                        });
                });

            modelBuilder.Entity("MyGarden.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pallkrage längst bort"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Pallkrage i mitten"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Pallkrage närmast altanen"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Kruka 1"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Kruka 2"
                        });
                });

            modelBuilder.Entity("MyGarden.Plant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("PlantTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlantTypeId");

                    b.ToTable("Plants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Unikat",
                            PlantTypeId = 2
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sabagold",
                            PlantTypeId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Flyaway",
                            PlantTypeId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "Rocket",
                            PlantTypeId = 4
                        },
                        new
                        {
                            Id = 5,
                            Name = "Amandine",
                            PlantTypeId = 4
                        },
                        new
                        {
                            Id = 6,
                            Name = "Sweet Banana",
                            PlantTypeId = 5
                        },
                        new
                        {
                            Id = 7,
                            Name = "Anaheim",
                            PlantTypeId = 5
                        },
                        new
                        {
                            Id = 8,
                            Name = "Estilo",
                            PlantTypeId = 5
                        },
                        new
                        {
                            Id = 9,
                            Name = "Vinbärstomat",
                            PlantTypeId = 6
                        },
                        new
                        {
                            Id = 10,
                            Name = "Primaverde",
                            PlantTypeId = 7
                        });
                });

            modelBuilder.Entity("MyGarden.PlantType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Info")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nutrition")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Perennial")
                        .HasColumnType("bit");

                    b.Property<string>("Soil")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("PlantTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Info = "Täck gärna med fiberduk fra till ca midsommar för att slippa angrepp av morotslarver.",
                            Name = "Morot",
                            Perennial = false,
                            Soil = "Väldränerad"
                        },
                        new
                        {
                            Id = 2,
                            Info = "Sätt strax innan tjälen för skörd sommaren efter. Kan även sättas på våren, de hinner kanske inte bilda klyftor men är goda ändå.",
                            Name = "Vitlök",
                            Perennial = false,
                            Soil = "Lucker, väldränerad"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Lök",
                            Perennial = false
                        },
                        new
                        {
                            Id = 4,
                            Info = "Kupas",
                            Name = "Potatis",
                            Nutrition = "Ge inte för mycket kväve, då blir det mest blast",
                            Perennial = false,
                            Soil = "Lucker"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Paprika/Chili",
                            Perennial = false
                        },
                        new
                        {
                            Id = 6,
                            Name = "Tomat",
                            Perennial = false
                        },
                        new
                        {
                            Id = 7,
                            Name = "Sparris",
                            Perennial = true
                        });
                });

            modelBuilder.Entity("MyGarden.PlantsPerLocation", b =>
                {
                    b.Property<short>("HarvestSeason")
                        .HasColumnType("smallint");

                    b.Property<string>("LocationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlantNames")
                        .HasColumnType("nvarchar(max)");

                    b.ToView("PlantsPerLocation");
                });

            modelBuilder.Entity("MyGarden.Action", b =>
                {
                    b.HasOne("MyGarden.ActionType", "ActionType")
                        .WithMany("Actions")
                        .HasForeignKey("ActionTypeId")
                        .HasConstraintName("FK_Actions_ActionTypes")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyGarden.Location", "Location")
                        .WithMany("Actions")
                        .HasForeignKey("LocationId")
                        .HasConstraintName("FK_Actions_Locations")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyGarden.Plant", "Plant")
                        .WithMany("Actions")
                        .HasForeignKey("PlantId")
                        .HasConstraintName("FK_Actions_Plants")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ActionType");

                    b.Navigation("Location");

                    b.Navigation("Plant");
                });

            modelBuilder.Entity("MyGarden.Plant", b =>
                {
                    b.HasOne("MyGarden.PlantType", "PlantType")
                        .WithMany("Plants")
                        .HasForeignKey("PlantTypeId")
                        .HasConstraintName("FK_Plants_PlantTypes")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PlantType");
                });

            modelBuilder.Entity("MyGarden.ActionType", b =>
                {
                    b.Navigation("Actions");
                });

            modelBuilder.Entity("MyGarden.Location", b =>
                {
                    b.Navigation("Actions");
                });

            modelBuilder.Entity("MyGarden.Plant", b =>
                {
                    b.Navigation("Actions");
                });

            modelBuilder.Entity("MyGarden.PlantType", b =>
                {
                    b.Navigation("Plants");
                });
#pragma warning restore 612, 618
        }
    }
}
