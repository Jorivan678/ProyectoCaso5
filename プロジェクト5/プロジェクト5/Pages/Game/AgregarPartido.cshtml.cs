using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using プロジェクト5.Models;
using プロジェクト5.Services;

namespace プロジェクト5.Pages.Game
{
    public class AgregarPartidoModel : PageModel
    {
        [BindProperty]
        public Partido Partido { get; set; }
        private readonly AppDBContext _context;

        public AgregarPartidoModel(AppDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
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

            _context.Partidos.Add(Partido);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Partidos");
        }
    }
}
