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
    [Migration("20210106103736_ChangePlantTypesPerLocationView")]
    partial class ChangePlantTypesPerLocationView
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

                    b.HasKey("PlantId", "LocationId", "Id");

                    b.HasIndex("ActionTypeId");

                    b.HasIndex("LocationId");

                    b.ToTable("Actions");

                    b.HasData(
                        new
                        {
                            PlantId = 1,
                            LocationId = 2,
                            Id = 1,
                            ActionDate = new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ActionTypeId = 3
                        },
                        new
                        {
                            PlantId = 2,
                            LocationId = 2,
                            Id = 2,
                            ActionDate = new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ActionTypeId = 3
                        },
                        new
                        {
                            PlantId = 3,
                            LocationId = 2,
                            Id = 3,
                            ActionDate = new DateTime(2020, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ActionTypeId = 3
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
                            Name = "Förberett jorden"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Lagt på förgroning"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sått/Satt"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Planterat om"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Planterat"
                        },
                        new
                        {
                            Id = 6,
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
                            Name = "Krukor"
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
                            Name = "Morot",
                            Perennial = false
                        },
                        new
                        {
                            Id = 2,
                            Name = "Vitlök",
                            Perennial = false
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
                            Name = "Potatis",
                            Perennial = false
                        },
                        new
                        {
                            Id = 5,
                            Name = "Paprika",
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
                        },
                        new
                        {
                            Id = 8,
                            Name = "Sallat",
                            Perennial = false
                        },
                        new
                        {
                            Id = 9,
                            Name = "Rabarber",
                            Perennial = true
                        },
                        new
                        {
                            Id = 10,
                            Name = "Sockerärtor",
                            Perennial = false
                        });
                });

            modelBuilder.Entity("MyGarden.PlantsPerLocation", b =>
                {
                    b.Property<string>("LocationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlantNames")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Season")
                        .HasColumnType("int");

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
