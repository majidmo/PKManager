using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerTournamentManager.Models
{    public class League
    {
        [Key]
        public int LeagueId { get; set; }

        [Required]
        [MaxLength(100)]
        public string LeagueName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public bool IsBuyinAmountConsideredForRating = false;
    }
}
