using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using プロジェクト5.Models;
using プロジェクト5.Services;

namespace プロジェクト5.Pages.Player.PlayerStatistics
{
    public class DeleteModel : PageModel
    {
        private readonly AppDBContext _context;

        public DeleteModel(AppDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public EstadisticasJugador EstadisticasJugador { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EstadisticasJugador = await _context.EstadisticasJugadores
                .Include(e => e.Jugador)
                .Include(e => e.Partido).FirstOrDefaultAsync(m => m.Id == id);

            if (EstadisticasJugador == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EstadisticasJugador = await _context.EstadisticasJugadores.FindAsync(id);

            if (EstadisticasJugador != null)
            {
                _context.EstadisticasJugadores.Remove(EstadisticasJugador);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./EstadisticasJugador");
        }
    }
}
