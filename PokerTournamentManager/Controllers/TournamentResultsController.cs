using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using PokerLeague.DBContext;
using PokerTournamentManager.Models;
using Microsoft.Data.SqlClient;

using Dapper;
using System.Numerics;
using System.Text.RegularExpressions;

namespace PokerTournamentManager.Controllers
{
    public class TournamentResultsController : Controller
    {
        private readonly PokerLeagueContext _context;

        public TournamentResultsController(PokerLeagueContext context)
        {
            _context = context;
        }

        // GET: TournamentResults
        [Route("TournamentResults/Index/{id?}")]
        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                var pokerLeagueContext = _context.TournamentResults.Include(p => p.Player).Include(p => p.Tournament).ToList()
                    .OrderBy(p => p.Tournament.LeagueId).OrderByDescending(p => p.Tournament.StartTime).ThenByDescending(p => p.PointsEarned);
                
                return View(pokerLeagueContext.ToList());
            }
            else
            {
                var pokerLeagueContext = _context.TournamentResults.Include(p => p.Player).Include(p => p.Tournament)
                 .Where(p => p.PlayerId == id).OrderByDescending(p => p.Tournament.StartTime);
                return View(pokerLeagueContext.ToList());
            }                     
        }


        public IActionResult Standing()
        {
            using (var connection = new SqlConnection(_context.Database.GetConnectionString()))
            {
                // Create a query that retrieves all books with an author name of "John Smith"    
                var sql = "SELECT L.LeagueId, L.LeagueName, R.PlayerId, P.UserName, Count(T.TournamentID) [TournamentsPlayed], Sum(PrizeMoney - (BuyIn + BuyIn * RebuyCount))[Points] FROM TournamentResults R " +
                          "Inner Join Tournaments T on R.TournamentId = T.TournamentId Inner Join Players P on R.PlayerId = P.PlayerId Inner Join Leagues L on T.LeagueId = L.LeagueId " +
                          "Group By L.LeagueId, L.LeagueName, R.PlayerId, UserName Order By LeagueName, [Points] desc";
                
                // Use the Query method to execute the query and return a list of objects                    
                return View(connection.Query<LeagueStanding>(sql).ToList());
            }
        }

        // GET: TournamentResults/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TournamentResults == null)
            {
                return NotFound();
            }

            var participant = await _context.TournamentResults
                .Include(p => p.Player)
                .Include(p => p.Tournament)
                .FirstOrDefaultAsync(m => m.TournamentResultId == id);
            if (participant == null)
            {
                return NotFound();
            }

            return View(participant);
        }

        // GET: TournamentResults/Create
        public IActionResult Create()
        {
            ViewData["PlayerId"] = new SelectList(_context.Players, "PlayerId", "UserName");
            ViewData["TournamentId"] = new SelectList(_context.Tournaments, "TournamentId", "Name");
            return View();
        }

        // POST: TournamentResults/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ParticipantId,TournamentId,PlayerId,IsPlayerEligibleForPrize,PrizeMoney,FinishPosition,RebuyCount,AddOnCount,BountiesWon")] TournamentResult participant)
        {
            if (ModelState.IsValid)
            {
                _context.Add(participant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PlayerId"] = new SelectList(_context.Players, "PlayerId", "UserName", participant.PlayerId);
            ViewData["TournamentId"] = new SelectList(_context.Tournaments, "TournamentId", "Name", participant.TournamentId);
            return View(participant);
        }

        // GET: TournamentResults/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TournamentResults == null)
            {
                return NotFound();
            }

            var participant = await _context.TournamentResults.FindAsync(id);
            if (participant == null)
            {
                return NotFound();
            }
            ViewData["PlayerId"] = new SelectList(_context.Players, "PlayerId", "UserName", participant.PlayerId);
            ViewData["TournamentId"] = new SelectList(_context.Tournaments, "TournamentId", "Name", participant.TournamentId);
            return View(participant);
        }

        // POST: TournamentResults/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ParticipantId,TournamentId,PlayerId,IsPlayerEligibleForPrize,PrizeMoney,FinishPosition,RebuyCount,AddOnCount,BountiesWon")] TournamentResult participant)
        {
            if (id != participant.TournamentResultId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(participant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TournamentResultExists(participant.TournamentResultId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["PlayerId"] = new SelectList(_context.Players, "PlayerId", "UserName", participant.PlayerId);
            ViewData["TournamentId"] = new SelectList(_context.Tournaments, "TournamentId", "Name", participant.TournamentId);
            return View(participant);
        }

        // GET: TournamentResults/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TournamentResults == null)
            {
                return NotFound();
            }

            var tournamentResult = await _context.TournamentResults
                .Include(p => p.Player)
                .Include(p => p.Tournament)
                .FirstOrDefaultAsync(m => m.TournamentResultId == id);
            if (tournamentResult == null)
            {
                return NotFound();
            }

            return View(tournamentResult);
        }

        // POST: TournamentResults/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TournamentResults == null)
            {
                return Problem("Entity set 'PokerLeagueContext.TournamentResults'  is null.");
            }
            var tournamentResult = await _context.TournamentResults.FindAsync(id);
            if (tournamentResult != null)
            {
                _context.TournamentResults.Remove(tournamentResult);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TournamentResultExists(int id)
        {
          return (_context.TournamentResults?.Any(e => e.TournamentResultId == id)).GetValueOrDefault();
        }
    }
}
