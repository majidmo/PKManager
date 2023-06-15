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
            //modelBuilder.Entity<Participant>()
            //    .Property(p => p.DoublePrize)
            //    .HasComputedColumnSql("2 * PrizeMoney", stored: true);
              
            

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

            modelBuilder.Entity<TournamentResult>()
                .HasData(
                new TournamentResult { TournamentResultId = 1, TournamentId = 2, PlayerId = 1, RebuyCount = 0, FinishPosition = 1, PrizeMoney = 163 },
                new TournamentResult { TournamentResultId = 2, TournamentId = 2, PlayerId = 2, RebuyCount = 1, FinishPosition = 2, PrizeMoney = 97 },
                new TournamentResult { TournamentResultId = 3, TournamentId = 2, PlayerId = 3, RebuyCount = 1, FinishPosition = 3, PrizeMoney = 65 },
                new TournamentResult { TournamentResultId = 4, TournamentId = 2, PlayerId = 4, RebuyCount = 0, FinishPosition = 4 },
                new TournamentResult { TournamentResultId = 5, TournamentId = 2, PlayerId = 5, RebuyCount = 0, FinishPosition = 5 },
                new TournamentResult { TournamentResultId = 6, TournamentId = 2, PlayerId = 6, RebuyCount = 1, FinishPosition = 6 },
                new TournamentResult { TournamentResultId = 7, TournamentId = 2, PlayerId = 7, RebuyCount = 1, FinishPosition = 7 },
                new TournamentResult { TournamentResultId = 8, TournamentId = 2, PlayerId = 8, RebuyCount = 0, FinishPosition = 8 },
                new TournamentResult { TournamentResultId = 9, TournamentId = 2, PlayerId = 9, RebuyCount = 0, FinishPosition = 9 },

                new TournamentResult { TournamentResultId = 10, TournamentId = 3, PlayerId = 1, RebuyCount = 2, FinishPosition = 3, PrizeMoney = 85 },
                new TournamentResult { TournamentResultId = 11, TournamentId = 3, PlayerId = 3, RebuyCount = 1, FinishPosition = 2, PrizeMoney = 127 },
                new TournamentResult { TournamentResultId = 12, TournamentId = 3, PlayerId = 4, RebuyCount = 0, FinishPosition = 1, PrizeMoney = 213 },
                new TournamentResult { TournamentResultId = 13, TournamentId = 3, PlayerId = 5, RebuyCount = 0, FinishPosition = 9 },
                new TournamentResult { TournamentResultId = 14, TournamentId = 3, PlayerId = 7, RebuyCount = 1, FinishPosition = 8 },
                new TournamentResult { TournamentResultId = 15, TournamentId = 3, PlayerId = 8, RebuyCount = 2, FinishPosition = 7 },
                new TournamentResult { TournamentResultId = 16, TournamentId = 3, PlayerId = 9, RebuyCount = 0, FinishPosition = 4 },
                new TournamentResult { TournamentResultId = 17, TournamentId = 3, PlayerId = 12, RebuyCount = 0, FinishPosition = 5 },
                new TournamentResult { TournamentResultId = 18, TournamentId = 3, PlayerId = 14, RebuyCount = 0, FinishPosition = 6 },
                new TournamentResult { TournamentResultId = 19, TournamentId = 3, PlayerId = 15, RebuyCount = 1, FinishPosition = 10 },

                new TournamentResult { TournamentResultId = 20, TournamentId = 4, PlayerId = 11, RebuyCount = 0, FinishPosition = 1, PrizeMoney = 325},
                new TournamentResult { TournamentResultId = 21, TournamentId = 4, PlayerId = 12, RebuyCount = 1, FinishPosition = 2, PrizeMoney = 195 },
                new TournamentResult { TournamentResultId = 22, TournamentId = 4, PlayerId = 13, RebuyCount = 1, FinishPosition = 3, PrizeMoney = 130 },
                new TournamentResult { TournamentResultId = 23, TournamentId = 4, PlayerId = 4, RebuyCount = 0, FinishPosition = 4 },
                new TournamentResult { TournamentResultId = 24, TournamentId = 4, PlayerId = 15, RebuyCount = 0, FinishPosition = 5 },
                new TournamentResult { TournamentResultId = 25, TournamentId = 4, PlayerId = 16, RebuyCount = 1, FinishPosition = 6 },
                new TournamentResult { TournamentResultId = 26, TournamentId = 4, PlayerId = 7, RebuyCount = 1, FinishPosition = 7 },
                new TournamentResult { TournamentResultId = 27, TournamentId = 4, PlayerId = 18, RebuyCount = 0, FinishPosition = 8 },
                new TournamentResult { TournamentResultId = 28, TournamentId = 4, PlayerId = 19, RebuyCount = 0, FinishPosition = 9 }
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

            //modelBuilder.Entity<LeagueStanding>(
            //eb =>
            //{                
            //    eb.ToSqlQuery("SELECT ROW_NUMBER() OVER (ORDER BY (SELECT 1)) AS number, P.PlayerId, \tUserName [Name], Count(T.TournamentID) [Tournaments Played], " +
            //    "Sum(PrizeMoney - (BuyIn + BuyIn*RebuyCount)) [Points]" +
            //    "  FROM [Participants] P Inner Join Tournaments T on P.TournamentId = T.TournamentId" +
            //    "  Inner Join Players Pl on P.PlayerId = Pl.PlayerId" +
            //    "  Group By P.[PlayerId], UserName" +
            //    "  Order By [Points] desc");
            //    eb.Property(v => v.UserName).HasColumnName("Name");
            //});

        }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }        
        public DbSet<TournamentResult> TournamentResults { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
