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
        public ResultadoPartido ResultadoPartido { get; set; }
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

            ResultadoPartido = await _context.ResultadoPartidos
                .Include(r => r.Jugador)
                .Include(r => r.Partido).FirstOrDefaultAsync(m => m.Id == id);

            if (ResultadoPartido == null)
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

            ResultadoPartido = await _context.ResultadoPartidos.FindAsync(id);

            if (ResultadoPartido != null)
            {
                _context.ResultadoPartidos.Remove(ResultadoPartido);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Resultados");
        }
    }
}
