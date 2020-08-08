using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using プロジェクト5.Models;
using プロジェクト5.Services;

namespace プロジェクト5.Pages.Player.PlayerStatistics
{
    public class EditModel : PageModel
    {
        private readonly AppDBContext _context;

        public EditModel(AppDBContext context)
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
           ViewData["IdJugador"] = new SelectList(_context.Jugadores, "Id", "NomJug");
           ViewData["IdPartido"] = new SelectList(_context.Partidos, "Id", "Id");
            return Page();
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(EstadisticasJugador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstadisticasJugadorExists(EstadisticasJugador.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./EstadisticasJugador");
        }

        private bool EstadisticasJugadorExists(int id)
        {
            return _context.EstadisticasJugadores.Any(e => e.Id == id);
        }
    }
}
