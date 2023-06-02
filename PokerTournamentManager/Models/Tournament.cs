using System.ComponentModel.DataAnnotations;

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
        public double BuyIn { get; set; }

        /// <summary>
        /// This is the amount paid after losing all your money in order to receive more chips and stay in. If zero, rebuy is not allowed
        /// </summary>
        public double Rebuy { get; set; } = 0;
        public double AddOn { get; set; } = 0;
        public int MaxAddOnCount { get; set; } = 0;
        
        /// <summary>
        /// This money is not part of winning pool.
        /// </summary>
        public double Bounty { get; set; } = 0;
        public int StackSizeStarting { get; set; }
        public int StackSizeAddon { get; set; }
        public int StackSizeRebuy { get; set; }
         

        public int[] PrizeSplitSmallTourny = { 50, 35, 15 };
        public int[] PrizeSplitMediumTourny = { 35, 25, 15, 10, 8, 5, 2 };

        public ICollection<Participant> Participants { get; set; } = new List<Participant> { };
    }

}