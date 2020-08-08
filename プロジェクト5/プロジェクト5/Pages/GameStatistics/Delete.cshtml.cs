using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using プロジェクト5.Models;
using プロジェクト5.Services;

namespace プロジェクト5.Pages.GameResult
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public EstadisticasPartido EstadisticaPartido { get; set; }
        private readonly AppDBContext _context;

        public DeleteModel(AppDBContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EstadisticaPartido = await _context.EstadisticasPartidos.FindAsync(id);

            if (EstadisticaPartido != null)
            {
                _context.EstadisticasPartidos.Remove(EstadisticaPartido);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Estadisticas");
        }
    }
}
