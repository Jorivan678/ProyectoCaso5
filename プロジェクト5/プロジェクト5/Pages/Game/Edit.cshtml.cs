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
        private readonly プロジェクト5.Services.AppDBContext _context;

        public EditModel(プロジェクト5.Services.AppDBContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["IdEquipo"] = new SelectList(_context.Equipos, "Id", "Id");
           ViewData["IdEquipoSub"] = new SelectList(_context.EquipoSubs, "Id", "Id");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Partido).State = EntityState.Modified;

            try
            {
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

            return RedirectToPage("./Index");
        }

        private bool PartidoExists(int id)
        {
            return _context.Partidos.Any(e => e.Id == id);
        }
    }
}
