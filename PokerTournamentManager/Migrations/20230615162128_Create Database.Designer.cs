﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PokerLeague.DBContext;

#nullable disable

namespace PokerTournamentManager.Migrations
{
    [DbContext(typeof(PokerLeagueContext))]
    [Migration("20230615162128_Create Database")]
    partial class CreateDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PokerTournamentManager.Models.League", b =>
                {
                    b.Property<int>("LeagueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LeagueId"), 1L, 1);

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("LeagueName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("LeagueId");

                    b.ToTable("Leagues");

                    b.HasData(
                        new
                        {
                            LeagueId = 1,
                            EndTime = new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LeagueName = "Freiburg's Tavern Poker Club",
                            StartTime = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            LeagueId = 3,
                            EndTime = new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LeagueName = "Raleigh Persian Club Poker League",
                            StartTime = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            LeagueId = 2,
                            EndTime = new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LeagueName = "Gabe's Poker League",
                            StartTime = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("PokerTournamentManager.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlayerId"), 1L, 1);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("PlayerId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            PlayerId = 1,
                            UserName = "Saeid"
                        },
                        new
                        {
                            PlayerId = 2,
                            UserName = "Masoud"
                        },
                        new
                        {
                            PlayerId = 3,
                            UserName = "Nikolai"
                        },
                        new
                        {
                            PlayerId = 4,
                            UserName = "Michael"
                        },
                        new
                        {
                            PlayerId = 5,
                            UserName = "Silvia"
                        },
                        new
                        {
                            PlayerId = 6,
                            UserName = "Simon"
                        },
                        new
                        {
                            PlayerId = 7,
                            UserName = "Andreas"
                        },
                        new
                        {
                            PlayerId = 8,
                            UserName = "Isabela"
                        },
                        new
                        {
                            PlayerId = 9,
                            UserName = "Klaus"
                        },
                        new
                        {
                            PlayerId = 10,
                            UserName = "Eva"
                        },
                        new
                        {
                            PlayerId = 11,
                            UserName = "Vika"
                        },
                        new
                        {
                            PlayerId = 12,
                            UserName = "Majid"
                        },
                        new
                        {
                            PlayerId = 13,
                            UserName = "Sebastian"
                        },
                        new
                        {
                            PlayerId = 14,
                            UserName = "Pedram"
                        },
                        new
                        {
                            PlayerId = 15,
                            UserName = "Thomas"
                        },
                        new
                        {
                            PlayerId = 16,
                            UserName = "Kiril"
                        },
                        new
                        {
                            PlayerId = 17,
                            UserName = "Christoph"
                        },
                        new
                        {
                            PlayerId = 18,
                            UserName = "Konstantin"
                        },
                        new
                        {
                            PlayerId = 19,
                            UserName = "Mehdi"
                        });
                });

            modelBuilder.Entity("PokerTournamentManager.Models.Tournament", b =>
                {
                    b.Property<int>("TournamentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TournamentId"), 1L, 1);

                    b.Property<decimal>("AddOn")
                        .HasColumnType("money");

                    b.Property<decimal>("Bounty")
                        .HasColumnType("money");

                    b.Property<decimal>("BuyIn")
                        .HasColumnType("money");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("LeagueId")
                        .HasColumnType("int");

                    b.Property<int>("MaxAddOnCount")
                        .HasColumnType("int");

                    b.Property<int>("MaxParticipants")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Rebuy")
                        .HasColumnType("money");

                    b.Property<int>("StackSizeAddon")
                        .HasColumnType("int");

                    b.Property<int>("StackSizeRebuy")
                        .HasColumnType("int");

                    b.Property<int>("StackSizeStarting")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Venue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TournamentId");

                    b.ToTable("Tournaments");

                    b.HasData(
                        new
                        {
                            TournamentId = 1,
                            AddOn = 0m,
                            Bounty = 0m,
                            BuyIn = 600m,
                            EndTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LeagueId = 2,
                            MaxAddOnCount = 0,
                            MaxParticipants = 0,
                            Name = "Gabe Fenton Openning $600 No Limit Holdem",
                            Rebuy = 600m,
                            StackSizeAddon = 0,
                            StackSizeRebuy = 0,
                            StackSizeStarting = 0,
                            StartTime = new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Venue = "Saeid's House"
                        },
                        new
                        {
                            TournamentId = 2,
                            AddOn = 0m,
                            Bounty = 0m,
                            BuyIn = 25m,
                            EndTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LeagueId = 1,
                            MaxAddOnCount = 0,
                            MaxParticipants = 0,
                            Name = "Saeid #1 $25 No Limit Holdem",
                            Rebuy = 25m,
                            StackSizeAddon = 0,
                            StackSizeRebuy = 0,
                            StackSizeStarting = 0,
                            StartTime = new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Venue = "Saeid's House"
                        },
                        new
                        {
                            TournamentId = 3,
                            AddOn = 0m,
                            Bounty = 0m,
                            BuyIn = 25m,
                            EndTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LeagueId = 1,
                            MaxAddOnCount = 0,
                            MaxParticipants = 0,
                            Name = "Saeid #2 $25 No Limit Holdem",
                            Rebuy = 25m,
                            StackSizeAddon = 0,
                            StackSizeRebuy = 0,
                            StackSizeStarting = 0,
                            StartTime = new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Venue = "Saeid's House"
                        },
                        new
                        {
                            TournamentId = 4,
                            AddOn = 0m,
                            Bounty = 0m,
                            BuyIn = 50m,
                            EndTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LeagueId = 1,
                            MaxAddOnCount = 0,
                            MaxParticipants = 0,
                            Name = "Saeid #3 $50 No Limit Holdem",
                            Rebuy = 50m,
                            StackSizeAddon = 0,
                            StackSizeRebuy = 0,
                            StackSizeStarting = 0,
                            StartTime = new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Venue = "Saeid's House"
                        });
                });

            modelBuilder.Entity("PokerTournamentManager.Models.TournamentResult", b =>
                {
                    b.Property<int>("TournamentResultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TournamentResultId"), 1L, 1);

                    b.Property<int>("AddOnCount")
                        .HasColumnType("int");

                    b.Property<int>("BountiesWon")
                        .HasColumnType("int");

                    b.Property<int?>("FinishPosition")
                        .HasColumnType("int");

                    b.Property<bool>("IsPlayerEligibleForPrize")
                        .HasColumnType("bit");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<decimal>("PrizeMoney")
                        .HasColumnType("money");

                    b.Property<int>("RebuyCount")
                        .HasColumnType("int");

                    b.Property<int>("TournamentId")
                        .HasColumnType("int");

                    b.HasKey("TournamentResultId");

                    b.HasIndex("PlayerId");

                    b.HasIndex("TournamentId");

                    b.ToTable("TournamentResults");

                    b.HasData(
                        new
                        {
                            TournamentResultId = 1,
                            AddOnCount = 0,
                            BountiesWon = 0,
                            FinishPosition = 1,
                            IsPlayerEligibleForPrize = true,
                            PlayerId = 1,
                            PrizeMoney = 163m,
                            RebuyCount = 0,
                            TournamentId = 2
                        },
                        new
                        {
                            TournamentResultId = 2,
                            AddOnCount = 0,
                            BountiesWon = 0,
                            FinishPosition = 2,
                            IsPlayerEligibleForPrize = true,
                            PlayerId = 2,
                            PrizeMoney = 97m,
                            RebuyCount = 1,
                            TournamentId = 2
                        },
                        new
                        {
                            TournamentResultId = 3,
                            AddOnCount = 0,
                            BountiesWon = 0,
                            FinishPosition = 3,
                            IsPlayerEligibleForPrize = true,
                            PlayerId = 3,
                            PrizeMoney = 65m,
                            RebuyCount = 1,
                            TournamentId = 2
                        },
                        new
                        {
                            TournamentResultId = 4,
                            AddOnCount = 0,
                            BountiesWon = 0,
                            FinishPosition = 4,
                            IsPlayerEligibleForPrize = true,
                            PlayerId = 4,
                            PrizeMoney = 0m,
                            RebuyCount = 0,
                            TournamentId = 2
                        },
                        new
                        {
                            TournamentResultId = 5,
                            AddOnCount = 0,
                            BountiesWon = 0,
                            FinishPosition = 5,
                            IsPlayerEligibleForPrize = true,
                            PlayerId = 5,
                            PrizeMoney = 0m,
                            RebuyCount = 0,
                            TournamentId = 2
                        },
                        new
                        {
                            TournamentResultId = 6,
                            AddOnCount = 0,
                            BountiesWon = 0,
                            FinishPosition = 6,
                            IsPlayerEligibleForPrize = true,
                            PlayerId = 6,
                            PrizeMoney = 0m,
                            RebuyCount = 1,
                            TournamentId = 2
                        },
                        new
                        {
                            TournamentResultId = 7,
                            AddOnCount = 0,
                            BountiesWon = 0,
                            FinishPosition = 7,
                            IsPlayerEligibleForPrize = true,
                            PlayerId = 7,
                            PrizeMoney = 0m,
                            RebuyCount = 1,
                            TournamentId = 2
                        },
                        new
                        {
                            TournamentResultId = 8,
                            AddOnCount = 0,
                            BountiesWon = 0,
                            FinishPosition = 8,
                            IsPlayerEligibleForPrize = true,
                            PlayerId = 8,
                            PrizeMoney = 0m,
                            RebuyCount = 0,
                            TournamentId = 2
                        },
                        new
                        {
                            TournamentResultId = 9,
                            AddOnCount = 0,
                            BountiesWon = 0,
                            FinishPosition = 9,
                            IsPlayerEligibleForPrize = true,
                            PlayerId = 9,
                            PrizeMoney = 0m,
                            RebuyCount = 0,
                            TournamentId = 2
                        },
                        new
                        {
                            TournamentResultId = 10,
                            AddOnCount = 0,
                            BountiesWon = 0,
                            FinishPosition = 3,
                            IsPlayerEligibleForPrize = true,
                            PlayerId = 1,
                            PrizeMoney = 85m,
                            RebuyCount = 2,
                            TournamentId = 3
                        },
                        new
                        {
                            TournamentResultId = 11,
                            AddOnCount = 0,
                            BountiesWon = 0,
                            FinishPosition = 2,
                            IsPlayerEligibleForPrize = true,
                            PlayerId = 3,
                            PrizeMoney = 127m,
                            RebuyCount = 1,
                            TournamentId = 3
                        },
                        new
                        {
                            TournamentResultId = 12,
                            AddOnCount = 0,
                            BountiesWon = 0,
                            FinishPosition = 1,
                            IsPlayerEligibleForPrize = true,
                            PlayerId = 4,
                            PrizeMoney = 213m,
                            RebuyCount = 0,
                            TournamentId = 3
                        },
                        new
                        {
                            TournamentResultId = 13,
                            AddOnCount = 0,
                            BountiesWon = 0,
                            FinishPosition = 9,
                            IsPlayerEligibleForPrize = true,
                            PlayerId = 5,
                            PrizeMoney = 0m,
                            RebuyCount = 0,
                            TournamentId = 3
                        },
                        new
                        {
                            TournamentResultId = 14,
                            AddOnCount = 0,
                            BountiesWon = 0,
                            FinishPosition = 8,
                            IsPlayerEligibleForPrize = true,
                            PlayerId = 7,
                            PrizeMoney = 0m,
                            RebuyCount = 1,
                            TournamentId = 3
                        },
                        new
                        {
                            TournamentResultId = 15,
                            AddOnCount = 0,
                            BountiesWon = 0,
                            FinishPosition = 7,
                            IsPlayerEligibleForPrize = true,
                            PlayerId = 8,
                            PrizeMoney = 0m,
                            RebuyCount = 2,
                            TournamentId = 3
                        },
                        new
                        {
                            TournamentResultId = 16,
                            AddOnCount = 0,
                            BountiesWon = 0,
                            FinishPosition = 4,
                            IsPlayerEligibleForPrize = true,
                            PlayerId = 9,
                            PrizeMoney = 0m,
                            RebuyCount = 0,
                            TournamentId = 3
                        },
                        new
                        {
                            TournamentResultId = 17,
                            AddOnCount = 0,
                            BountiesWon = 0,
                            FinishPosition = 5,
                            IsPlayerEligibleForPrize = true,
                            PlayerId = 12,
                            PrizeMoney = 0m,
                            RebuyCount = 0,
                            TournamentId = 3
                        },
                        new
                        {
                            TournamentResultId = 18,
                            AddOnCount = 0,
                            BountiesWon = 0,
                            FinishPosition = 6,
                            IsPlayerEligibleForPrize = true,
                            PlayerId = 14,
                            PrizeMoney = 0m,
                            RebuyCount = 0,
                            TournamentId = 3
                        },
                        new
                        {
                            TournamentResultId = 19,
                            AddOnCount = 0,
                            BountiesWon = 0,
                            FinishPosition = 10,
                            IsPlayerEligibleForPrize = true,
                            PlayerId = 15,
                            PrizeMoney = 0m,
                            RebuyCount = 1,
                            TournamentId = 3
                        },
                        new
                        {
                            TournamentResultId = 20,
                            AddOnCount = 0,
                            BountiesWon = 0,
                            FinishPosition = 1,
                            IsPlayerEligibleForPrize = true,
                            PlayerId = 11,
                            PrizeMoney = 325m,
                            RebuyCount = 0,
                            TournamentId = 4
                        },
                        new
                        {
                            TournamentResultId = 21,
                            AddOnCount = 0,
                            BountiesWon = 0,
                            FinishPosition = 2,
                            IsPlayerEligibleForPrize = true,
                            PlayerId = 12,
                            PrizeMoney = 195m,
                            RebuyCount = 1,
                            TournamentId = 4
                        },
                        new
                        {
                            TournamentResultId = 22,
                            AddOnCount = 0,
                            BountiesWon = 0,
                            FinishPosition = 3,
                            IsPlayerEligibleForPrize = true,
                            PlayerId = 13,
                            PrizeMoney = 130m,
                            RebuyCount = 1,
                            TournamentId = 4
                        },
                        new
                        {
                            TournamentResultId = 23,
                            AddOnCount = 0,
                            BountiesWon = 0,
                            FinishPosition = 4,
                            IsPlayerEligibleForPrize = true,
                            PlayerId = 4,
                            PrizeMoney = 0m,
                            RebuyCount = 0,
                            TournamentId = 4
                        },
                        new
                        {
                            TournamentResultId = 24,
                            AddOnCount = 0,
                            BountiesWon = 0,
                            FinishPosition = 5,
                            IsPlayerEligibleForPrize = true,
                            PlayerId = 15,
                            PrizeMoney = 0m,
                            RebuyCount = 0,
                            TournamentId = 4
                        },
                        new
                        {
                            TournamentResultId = 25,
                            AddOnCount = 0,
                            BountiesWon = 0,
                            FinishPosition = 6,
                            IsPlayerEligibleForPrize = true,
                            PlayerId = 16,
                            PrizeMoney = 0m,
                            RebuyCount = 1,
                            TournamentId = 4
                        },
                        new
                        {
                            TournamentResultId = 26,
                            AddOnCount = 0,
                            BountiesWon = 0,
                            FinishPosition = 7,
                            IsPlayerEligibleForPrize = true,
                            PlayerId = 7,
                            PrizeMoney = 0m,
                            RebuyCount = 1,
                            TournamentId = 4
                        },
                        new
                        {
                            TournamentResultId = 27,
                            AddOnCount = 0,
                            BountiesWon = 0,
                            FinishPosition = 8,
                            IsPlayerEligibleForPrize = true,
                            PlayerId = 18,
                            PrizeMoney = 0m,
                            RebuyCount = 0,
                            TournamentId = 4
                        },
                        new
                        {
                            TournamentResultId = 28,
                            AddOnCount = 0,
                            BountiesWon = 0,
                            FinishPosition = 9,
                            IsPlayerEligibleForPrize = true,
                            PlayerId = 19,
                            PrizeMoney = 0m,
                            RebuyCount = 0,
                            TournamentId = 4
                        });
                });

            modelBuilder.Entity("PokerTournamentManager.Models.TournamentResult", b =>
                {
                    b.HasOne("PokerTournamentManager.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokerTournamentManager.Models.Tournament", "Tournament")
                        .WithMany("Participants")
                        .HasForeignKey("TournamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");

                    b.Navigation("Tournament");
                });

            modelBuilder.Entity("PokerTournamentManager.Models.Tournament", b =>
                {
                    b.Navigation("Participants");
                });
#pragma warning restore 612, 618
        }
    }
}
