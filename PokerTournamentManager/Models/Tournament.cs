using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace PokerTournamentManager.Models
{      
    /// <summary>
    /// This class represents a specific tournament game
    /// </summary>
    public class Tournament
    {
        [Key]
        public int TournamentId { get; set; }
        public int LeagueId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string Venue { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        /// <summary>
        /// This is the total number of seats available but this number can be smaller than TotalParticipants if there are waiting players to 
        /// fill up seats after some players are out
        /// </summary>
        public int MaxParticipants { get; set; }
        public int TotalParticipants
        {
            get {
                return Participants.Count;
            }
        }

        /// <summary>
        /// This is the initial amount paid to get a seat in tournament
        /// </summary>
        [Column(TypeName = "money")]
        public decimal BuyIn { get; set; }

        /// <summary>
        /// This is the amount paid after losing all your money in order to receive more chips and stay in. If zero, rebuy is not allowed
        /// </summary>
        [Column(TypeName="money")]
        public decimal Rebuy { get; set; } = 0;

        [Column(TypeName = "money")]
        public decimal AddOn { get; set; } = 0;
        public int MaxAddOnCount { get; set; } = 0;

        /// <summary>
        /// This money is not part of winning pool.
        /// </summary>
        [Column(TypeName="money")]
        public decimal Bounty { get; set; } = 0;
        public int StackSizeStarting { get; set; }
        public int StackSizeAddon { get; set; }
        public int StackSizeRebuy { get; set; }
         
        public ICollection<TournamentResult> Participants { get; set; } = new List<TournamentResult> { };
    }

}