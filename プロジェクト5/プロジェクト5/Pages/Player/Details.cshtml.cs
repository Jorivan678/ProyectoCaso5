using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using プロジェクト5.Models;
using プロジェクト5.Services;

namespace プロジェクト5.Pages.Player
{
    public class DetailsModel : PageModel
    {
        public Jugador Jugador { get; set; }
        private readonly AppDBContext _context;

        public DetailsModel(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Jugador = await _context.Jugadores
                .Include(j => j.Equipo).FirstOrDefaultAsync(m => m.Id == id);

            if (Jugador == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
