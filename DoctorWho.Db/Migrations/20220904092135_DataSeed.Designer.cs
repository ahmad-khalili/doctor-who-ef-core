﻿// <auto-generated />
using System;
using DoctorWho.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    [DbContext(typeof(DoctorWhoCoreDbContext))]
    [Migration("20220904092135_DataSeed")]
    partial class DataSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DoctorWho.Db.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"), 1L, 1);

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Author");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            AuthorName = "Ben Aaronovitch"
                        },
                        new
                        {
                            AuthorId = 2,
                            AuthorName = "Douglas Adams"
                        },
                        new
                        {
                            AuthorId = 3,
                            AuthorName = "David Agnew"
                        },
                        new
                        {
                            AuthorId = 4,
                            AuthorName = "Maxine Alderton"
                        },
                        new
                        {
                            AuthorId = 5,
                            AuthorName = "Bob Baker"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Companion", b =>
                {
                    b.Property<int>("CompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanionId"), 1L, 1);

                    b.Property<string>("CompanionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhoPlayed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanionId");

                    b.ToTable("Companion");

                    b.HasData(
                        new
                        {
                            CompanionId = 1,
                            CompanionName = "Susan Foreman",
                            WhoPlayed = "Carole Ann Ford"
                        },
                        new
                        {
                            CompanionId = 2,
                            CompanionName = "Barbara Wright",
                            WhoPlayed = "Jacqueline Hill"
                        },
                        new
                        {
                            CompanionId = 3,
                            CompanionName = "Ian Chesterton",
                            WhoPlayed = "William Russell"
                        },
                        new
                        {
                            CompanionId = 4,
                            CompanionName = "Vicki",
                            WhoPlayed = "Maureen O'Brien"
                        },
                        new
                        {
                            CompanionId = 5,
                            CompanionName = "Steven Taylor",
                            WhoPlayed = "Peter Purves"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorId"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("FirstEpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastEpisodeDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctor");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            BirthDate = new DateTime(1908, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "William Hartnell",
                            DoctorNumber = 1,
                            FirstEpisodeDate = new DateTime(1963, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1966, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 2,
                            BirthDate = new DateTime(1920, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Patrick Troughton",
                            DoctorNumber = 2,
                            FirstEpisodeDate = new DateTime(1966, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1968, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 3,
                            BirthDate = new DateTime(1919, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Jon Pertwee",
                            DoctorNumber = 3,
                            FirstEpisodeDate = new DateTime(1968, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1972, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 4,
                            BirthDate = new DateTime(1934, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Tom Baker",
                            DoctorNumber = 4,
                            FirstEpisodeDate = new DateTime(1976, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1981, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 5,
                            BirthDate = new DateTime(1951, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Peter Davison",
                            DoctorNumber = 5,
                            FirstEpisodeDate = new DateTime(1982, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1984, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Enemy", b =>
                {
                    b.Property<int>("EnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnemyId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnemyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnemyId");

                    b.ToTable("Enemy");

                    b.HasData(
                        new
                        {
                            EnemyId = 1,
                            Description = "An old friend, and an old foe, The Master has faced the Doctor throughout several lifecycles",
                            EnemyName = "The Master"
                        },
                        new
                        {
                            EnemyId = 2,
                            Description = "Daleks are a perennial threat to our dual-hearted hero, and are the only villain so far to have faced every version of the Doctor",
                            EnemyName = "The Daleks"
                        },
                        new
                        {
                            EnemyId = 3,
                            Description = "First introduced way back in 1966, they were a part of the First Doctor William Hartnell''s final serial",
                            EnemyName = "The Cybermen"
                        },
                        new
                        {
                            EnemyId = 4,
                            Description = "These menacing looking statue-like humanoids can kill people with a single touch and can only move when they''re not being looked at, including when people blink",
                            EnemyName = "The Weeping Angels"
                        },
                        new
                        {
                            EnemyId = 5,
                            Description = "Round, brown, and great with butter, the Sontarans aren’t to be messed with",
                            EnemyName = "Sontarans"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Episode", b =>
                {
                    b.Property<int>("EpisodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeId"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EpisodeNumber")
                        .HasColumnType("int");

                    b.Property<string>("EpisodeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeriesNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EpisodeId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Episode");

                    b.HasData(
                        new
                        {
                            EpisodeId = 1,
                            AuthorId = 3,
                            DoctorId = 5,
                            EpisodeDate = new DateTime(2005, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 14,
                            EpisodeType = "Musical",
                            Notes = "Happy Christmas!",
                            SeriesNumber = 1,
                            Title = "The Christmas Invasion"
                        },
                        new
                        {
                            EpisodeId = 2,
                            AuthorId = 2,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(2005, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 15,
                            EpisodeType = "Historical",
                            Notes = "History party",
                            SeriesNumber = 1,
                            Title = "The Unquiet Dead"
                        },
                        new
                        {
                            EpisodeId = 3,
                            AuthorId = 4,
                            DoctorId = 2,
                            EpisodeDate = new DateTime(2006, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 7,
                            EpisodeType = "Adventure",
                            Notes = "Earth looks cool",
                            SeriesNumber = 2,
                            Title = "New Earth"
                        },
                        new
                        {
                            EpisodeId = 4,
                            AuthorId = 1,
                            DoctorId = 3,
                            EpisodeDate = new DateTime(2005, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 3,
                            EpisodeType = "Horror",
                            Notes = "Scary episode",
                            SeriesNumber = 2,
                            Title = "Cold Blood"
                        },
                        new
                        {
                            EpisodeId = 5,
                            AuthorId = 5,
                            DoctorId = 4,
                            EpisodeDate = new DateTime(2007, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "Action",
                            Notes = "Nice CGI",
                            SeriesNumber = 3,
                            Title = "Time Crash"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.EpisodeCompanion", b =>
                {
                    b.Property<int>("EpisodeCompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeCompanionId"), 1L, 1);

                    b.Property<int>("CompanionId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeCompanionId");

                    b.HasIndex("CompanionId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("EpisodeCompanion");

                    b.HasData(
                        new
                        {
                            EpisodeCompanionId = 1,
                            CompanionId = 4,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeCompanionId = 2,
                            CompanionId = 3,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeCompanionId = 3,
                            CompanionId = 2,
                            EpisodeId = 3
                        },
                        new
                        {
                            EpisodeCompanionId = 4,
                            CompanionId = 1,
                            EpisodeId = 4
                        },
                        new
                        {
                            EpisodeCompanionId = 5,
                            CompanionId = 5,
                            EpisodeId = 5
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.EpisodeEnemy", b =>
                {
                    b.Property<int>("EpisodeEnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeEnemyId"), 1L, 1);

                    b.Property<int>("EnemyId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeEnemyId");

                    b.HasIndex("EnemyId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("EpisodeEnemy");

                    b.HasData(
                        new
                        {
                            EpisodeEnemyId = 1,
                            EnemyId = 4,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeEnemyId = 2,
                            EnemyId = 3,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeEnemyId = 3,
                            EnemyId = 2,
                            EpisodeId = 3
                        },
                        new
                        {
                            EpisodeEnemyId = 4,
                            EnemyId = 1,
                            EpisodeId = 4
                        },
                        new
                        {
                            EpisodeEnemyId = 5,
                            EnemyId = 5,
                            EpisodeId = 5
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Episode", b =>
                {
                    b.HasOne("DoctorWho.Db.Models.Author", "Author")
                        .WithMany("Episodes")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Models.Doctor", "Doctor")
                        .WithMany("Episodes")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("DoctorWho.Db.Models.EpisodeCompanion", b =>
                {
                    b.HasOne("DoctorWho.Db.Models.Companion", "Companion")
                        .WithMany("EpisodeCompanions")
                        .HasForeignKey("CompanionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Models.Episode", "Episode")
                        .WithMany("EpisodeCompanions")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Companion");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWho.Db.Models.EpisodeEnemy", b =>
                {
                    b.HasOne("DoctorWho.Db.Models.Enemy", "Enemy")
                        .WithMany("EpisodesEnemies")
                        .HasForeignKey("EnemyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Models.Episode", "Episode")
                        .WithMany("EpisodeEnemies")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enemy");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Author", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Companion", b =>
                {
                    b.Navigation("EpisodeCompanions");
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Doctor", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Enemy", b =>
                {
                    b.Navigation("EpisodesEnemies");
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Episode", b =>
                {
                    b.Navigation("EpisodeCompanions");

                    b.Navigation("EpisodeEnemies");
                });
#pragma warning restore 612, 618
        }
    }
}
