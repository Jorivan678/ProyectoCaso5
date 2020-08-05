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

namespace プロジェクト5.Pages.Game
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Partido Partido { get; set; }
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

            Partido = await _context.Partidos
                .Include(p => p.Equipo)
                .Include(p => p.EquipoSub).FirstOrDefaultAsync(m => m.Id == id);

            if (Partido == null)
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

            Partido = await _context.Partidos.FindAsync(id);

            if (Partido != null)
            {
                _context.Partidos.Remove(Partido);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Partidos");
        }
    }
}
