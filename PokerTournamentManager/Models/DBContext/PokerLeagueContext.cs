using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PokerTournamentManager.Models;

namespace PokerLeague.DBContext
{
    public class PokerLeagueContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public PokerLeagueContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("PokerTournamentDatabase"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Player>().HasIndex(x => x.UserName).IsUnique();
            modelBuilder.Entity<League>()
                .HasData(
                new League { LeagueId = 1, LeagueName = "Freiburg's Tavern Poker Club", StartTime = new DateTime(2023, 1, 1), EndTime = new DateTime(2023, 12, 30) },
                new League { LeagueId = 3, LeagueName = "Raleigh Persian Club Poker League", StartTime = new DateTime(2023, 1, 1), EndTime = new DateTime(2023, 12, 30) },
                new League { LeagueId = 2, LeagueName = "Gabe's Poker League", StartTime = new DateTime(2023, 1,1), EndTime= new DateTime(2023,12,30)}
            );

            modelBuilder.Entity<Tournament>()
                .HasData(
                new Tournament { TournamentId = 1, Name="Gabe Fenton Openning $600 No Limit Holdem", LeagueId = 2,  BuyIn = 600, Rebuy = 600, MaxAddOnCount = 0, Venue = "Saeid's House",  StartTime = new DateTime(2023, 1, 5)},
                new Tournament { TournamentId = 2, Name = "Saeid #1 $25 No Limit Holdem", LeagueId = 1, BuyIn = 25, Rebuy = 25, MaxAddOnCount = 0, Venue = "Saeid's House", StartTime = new DateTime(2023, 1, 5) },
                new Tournament { TournamentId = 3, Name = "Saeid #2 $25 No Limit Holdem", LeagueId = 1, BuyIn = 25, Rebuy = 25, MaxAddOnCount = 0, Venue = "Saeid's House", StartTime = new DateTime(2023, 2, 7) },
                new Tournament { TournamentId = 4, Name = "Saeid #3 $50 No Limit Holdem", LeagueId = 1, BuyIn = 50, Rebuy = 50, MaxAddOnCount = 0, Venue = "Saeid's House", StartTime = new DateTime(2023, 3, 4) }
                );

            modelBuilder.Entity<Participant>()
                .HasData(
                new Participant { ParticipantId = 1, TournamentId = 2, PlayerId = 1, RebuyCount = 0, FinishPosition = 1 },
                new Participant { ParticipantId = 2, TournamentId = 2, PlayerId = 2, RebuyCount = 1, FinishPosition = 2 },
                new Participant { ParticipantId = 3, TournamentId = 2, PlayerId = 3, RebuyCount = 1, FinishPosition = 3 },
                new Participant { ParticipantId = 4, TournamentId = 2, PlayerId = 4, RebuyCount = 0, FinishPosition = 4 },
                new Participant { ParticipantId = 5, TournamentId = 2, PlayerId = 5, RebuyCount = 0, FinishPosition = 5 },
                new Participant { ParticipantId = 6, TournamentId = 2, PlayerId = 6, RebuyCount = 1, FinishPosition = 6 },
                new Participant { ParticipantId = 7, TournamentId = 2, PlayerId = 7, RebuyCount = 1, FinishPosition = 7 },
                new Participant { ParticipantId = 8, TournamentId = 2, PlayerId = 8, RebuyCount = 0, FinishPosition = 8 },
                new Participant { ParticipantId = 9, TournamentId = 2, PlayerId = 9, RebuyCount = 0, FinishPosition = 9 },

                new Participant { ParticipantId = 10, TournamentId = 3, PlayerId = 1, RebuyCount = 1, FinishPosition = 3 },
                new Participant { ParticipantId = 11, TournamentId = 3, PlayerId = 3, RebuyCount = 1, FinishPosition = 2 },
                new Participant { ParticipantId = 12, TournamentId = 3, PlayerId = 4, RebuyCount = 0, FinishPosition = 1 },
                new Participant { ParticipantId = 13, TournamentId = 3, PlayerId = 5, RebuyCount = 0, FinishPosition = 9 },
                new Participant { ParticipantId = 14, TournamentId = 3, PlayerId = 7, RebuyCount = 1, FinishPosition = 8 },
                new Participant { ParticipantId = 15, TournamentId = 3, PlayerId = 8, RebuyCount = 1, FinishPosition = 7 },
                new Participant { ParticipantId = 16, TournamentId = 3, PlayerId = 9, RebuyCount = 0, FinishPosition = 4 },
                new Participant { ParticipantId = 17, TournamentId = 3, PlayerId = 12, RebuyCount = 0, FinishPosition = 5 },
                new Participant { ParticipantId = 18, TournamentId = 3, PlayerId = 14, RebuyCount = 0, FinishPosition = 6 },
                new Participant { ParticipantId = 19, TournamentId = 3, PlayerId = 15, RebuyCount = 0, FinishPosition = 10 },

                new Participant { ParticipantId = 20, TournamentId = 4, PlayerId = 11, RebuyCount = 0, FinishPosition = 1 },
                new Participant { ParticipantId = 21, TournamentId = 4, PlayerId = 12, RebuyCount = 1, FinishPosition = 2 },
                new Participant { ParticipantId = 22, TournamentId = 4, PlayerId = 13, RebuyCount = 1, FinishPosition = 3 },
                new Participant { ParticipantId = 23, TournamentId = 4, PlayerId = 4, RebuyCount = 0, FinishPosition = 4 },
                new Participant { ParticipantId = 24, TournamentId = 4, PlayerId = 15, RebuyCount = 0, FinishPosition = 5 },
                new Participant { ParticipantId = 25, TournamentId = 4, PlayerId = 16, RebuyCount = 1, FinishPosition = 6 },
                new Participant { ParticipantId = 26, TournamentId = 4, PlayerId = 7, RebuyCount = 1, FinishPosition = 7 },
                new Participant { ParticipantId = 27, TournamentId = 4, PlayerId = 18, RebuyCount = 0, FinishPosition = 8 },
                new Participant { ParticipantId = 28, TournamentId = 4, PlayerId = 19, RebuyCount = 0, FinishPosition = 9 }
                );

            modelBuilder.Entity<Player>()
                .HasData(
                new Player { PlayerId=1, UserName = "Saeid" },
                new Player { PlayerId = 2, UserName = "Masoud" },
                new Player { PlayerId = 3, UserName = "Nikolai" },
                new Player { PlayerId = 4, UserName = "Michael" },
                new Player { PlayerId = 5, UserName = "Silvia" },
                new Player { PlayerId = 6, UserName = "Simon" },
                new Player { PlayerId = 7, UserName = "Andreas" },
                new Player { PlayerId = 8, UserName = "Isabela" },
                new Player { PlayerId = 9, UserName = "Klaus" },
                new Player { PlayerId = 10, UserName = "Eva" },
                new Player { PlayerId = 11, UserName = "Vika" },
                new Player { PlayerId = 12, UserName = "Majid" },
                new Player { PlayerId = 13, UserName = "Sebastian" },
                new Player { PlayerId = 14, UserName = "Pedram" },
                new Player { PlayerId = 15, UserName = "Thomas" },
                new Player { PlayerId = 16, UserName = "Kiril" },
                new Player { PlayerId = 17, UserName = "Christoph" },
                new Player { PlayerId = 18, UserName = "Konstantin" },
                new Player { PlayerId = 19, UserName = "Mehdi" }
            );

        }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Player> Players { get; set; }   
        public DbSet<Participant> Participants { get; set; }        
    }
}
