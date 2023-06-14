using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace PokerTournamentManager.Models
{
    [Keyless]
    public class LeagueStanding
    { 
        public int PlayerId { get; set; }
        
        [DisplayName("Player")]
        public string UserName { get; set; }
        
        [DisplayName("Tournaments Played")]
        public int TournamentsPlayed { get; set; }
        
        public decimal Points { get; set; }
    }
}
