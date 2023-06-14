using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerTournamentManager.Models
{
    /// <summary>
    /// This class is to track a player participation in a specific tournament game
    /// </summary>
    public class TournamentResult
    {  
        [Key]
        public int TournamentResultId { get; set; }
        [Required]
        public int TournamentId { get; set; }
        public Tournament Tournament { get; set; }
        [Required]
        public int PlayerId { get; set; }
        public Player Player { get; set; }
        public bool IsPlayerEligibleForPrize { get; set; } = true;
        [Column(TypeName = "money")]
        public decimal PrizeMoney { get; set; } = 0;
        //public decimal DoublePrize { get; set; } = 0;
        public int? FinishPosition { get; set; }
        public int RebuyCount { get; set; } = 0;
        public int AddOnCount { get; set; } = 0;
        public int BountiesWon { get; set; } = 0;

        [DisplayName("Points Earned")]
        public decimal PointsEarned
        {

            get
            {
                decimal moneySpent = Tournament.BuyIn + Tournament.Rebuy * RebuyCount + Tournament.AddOn * AddOnCount;
                return (BountiesWon * Tournament.Bounty) + PrizeMoney - moneySpent;                
            }
        }

        public decimal PointsEarnedTest
        {

            get
            {
                return 8;
            }            
        }
    }
}
