using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerTournamentManager.Models
{
    /// <summary>
    /// This class is to track a player participation in a specific tournament game
    /// </summary>
    public class Participant
    {        
        //public Participant(Tournament tournament, Player player) {
        //    Tournament = tournament;
        //    Player = player;
        //}

        [Key]
        public int ParticipantId { get; set; }
        [Required]
        public int TournamentId { get; set; }
        public Tournament Tournament { get; set; }
        [Required]
        public int PlayerId { get; set; }
        public Player Player { get; set; }
        public bool IsPlayerEligibleForPrize { get; set; } = true;
        public int? FinishPosition { get; set; }
        public int RebuyCount { get; set; } = 0;
        public int AddOnCount { get; set; } = 0;
        public int BountiesWon { get; set; } = 0;

        //public double PrizeWon {

        //    get {
        //        double moneySpent = Tournament.BuyIn + Tournament.Rebuy * RebuyCount + Tournament.AddOn * AddOnCount;

        //        if (Tournament.Participants.Count < 10)
        //        {
        //            if (FinishPosition < 4)
        //            {
        //                return Tournament.PrizeSplitSmallTourny[FinishPosition];
        //            }                    
        //        }
        //        else
        //        {
        //            if (FinishPosition < 8)
        //            {
        //                return Tournament.PrizeSplitMediumTourny[FinishPosition];
        //            }
        //        }

        //        return -(moneySpent);
        //    }
        //}
   
    }
}
