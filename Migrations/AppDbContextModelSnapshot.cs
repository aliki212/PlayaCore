﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlayaCore.Models;

namespace PlayaCore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PlayaCore.Models.Playa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsNotInjured")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PositionId");

                    b.HasIndex("TeamId");

                    b.ToTable("Playas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Gianluigi",
                            ImageUrl = "https://s.hs-data.com/bilder/spieler/gross/1337.jpg",
                            IsNotInjured = true,
                            LastName = "Buffon",
                            PositionId = 1,
                            TeamId = 1
                        });
                });

            modelBuilder.Entity("PlayaCore.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "He keeps the gates safe...",
                            Name = "GoalKeeper"
                        },
                        new
                        {
                            Id = 2,
                            Description = "He defends until they drop...",
                            Name = "Defender"
                        },
                        new
                        {
                            Id = 3,
                            Description = "He stays in the middle...",
                            Name = "Midfielder"
                        },
                        new
                        {
                            Id = 4,
                            Description = "He attacks with full wrath...",
                            Name = "Forward"
                        });
                });

            modelBuilder.Entity("PlayaCore.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Juventus"
                        });
                });

            modelBuilder.Entity("PlayaCore.Models.Playa", b =>
                {
                    b.HasOne("PlayaCore.Models.Position", "Position")
                        .WithMany("Playas")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PlayaCore.Models.Team", "Team")
                        .WithMany("TeamPlayas")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
