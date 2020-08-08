using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using プロジェクト5.Models;
using プロジェクト5.Services;

namespace プロジェクト5.Pages.GameResult
{
    [Authorize]
    public class EditModel : PageModel
    {
        [BindProperty]
        public EstadisticasPartido EstadisticaPartido { get; set; }
        private readonly AppDBContext _context;

        public EditModel(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EstadisticaPartido = await _context.EstadisticasPartidos
                .Include(r => r.Partido).FirstOrDefaultAsync(m => m.Id == id);

            if (EstadisticaPartido == null)
            {
                return NotFound();
            }
           ViewData["IdPartido"] = new SelectList(_context.Partidos, "Id", "Id");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(EstadisticaPartido).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstadisticaPartidoExists(EstadisticaPartido.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Estadisticas");
        }

        private bool EstadisticaPartidoExists(int id)
        {
            return _context.EstadisticasPartidos.Any(e => e.Id == id);
        }
    }
}
