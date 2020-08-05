using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using プロジェクト5.Models;
using プロジェクト5.Services;

namespace プロジェクト5.Pages.GameResult
{
    [Authorize]
    public class CreateModel : PageModel
    {
        [BindProperty]
        public ResultadoPartido ResultadoPartido { get; set; }
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

            _context.ResultadoPartidos.Add(ResultadoPartido);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Resultados");
        }
    }
}
