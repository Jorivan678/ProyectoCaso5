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

namespace プロジェクト5.Pages.Game
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Partido Partido { get; set; }
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

            Partido = await _context.Partidos
                .Include(p => p.Equipo)
                .Include(p => p.EquipoSub).FirstOrDefaultAsync(m => m.Id == id);

            if (Partido == null)
            {
                return NotFound();
            }
           ViewData["IdEquipo"] = new SelectList(_context.Equipos, "Id", "NomEquip");
           ViewData["IdEquipoSub"] = new SelectList(_context.EquipoSubs, "Id", "Equipo.NomEquip");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Partido).State = EntityState.Modified;

            try
            {
                _context.Entry(Partido).Property(P => P.CreatedAT).IsModified = false;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PartidoExists(Partido.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Partidos");
        }

        private bool PartidoExists(int id)
        {
            return _context.Partidos.Any(e => e.Id == id);
        }
    }
}
