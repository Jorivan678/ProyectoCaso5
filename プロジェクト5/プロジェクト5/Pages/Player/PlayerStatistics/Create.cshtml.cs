using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using プロジェクト5.Models;
using プロジェクト5.Services;

namespace プロジェクト5.Pages.Player.PlayerStatistics
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public EstadisticasJugador EstadisticasJugador { get; set; }
        private readonly AppDBContext _context;

        public CreateModel(AppDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
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

            _context.EstadisticasJugadores.Add(EstadisticasJugador);
            await _context.SaveChangesAsync();

            return RedirectToPage("./EstadisticasJugador");
        }
    }
}
