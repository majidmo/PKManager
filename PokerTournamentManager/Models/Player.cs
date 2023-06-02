using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerTournamentManager.Models
{
    [Index(nameof(UserName), IsUnique = true)]
    public class Player
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlayerId { get; set; }

        [Required]
        [MaxLength(100)]       
        public string UserName { get; set; }

    }
}
