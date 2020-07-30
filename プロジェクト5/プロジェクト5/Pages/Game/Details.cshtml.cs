using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using プロジェクト5.Models;
using プロジェクト5.Services;

namespace プロジェクト5.Pages.Game
{
    public class DetailsModel : PageModel
    {
        private readonly プロジェクト5.Services.AppDBContext _context;

        public DetailsModel(プロジェクト5.Services.AppDBContext context)
        {
            _context = context;
        }

        public Partido Partido { get; set; }

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
    }
}
