using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using プロジェクト5.Models;
using プロジェクト5.Services;

namespace プロジェクト5.Pages.Team
{ 
    public class EquiposModel : PageModel
    {
        [BindProperty]
        public Equipo Equipo { get; set; }
        public IRepository<Equipo> Repository { get; }
        public IEnumerable<Equipo> Equipos { get; private set; }
        public EquiposModel(IRepository<Equipo> repository)
        {
            Repository = repository;
        }
        public IActionResult OnGet()
        {
            try
            {
                Equipos = Repository.GetAll();
                return Page();
            }
            catch(Exception ex)
            {
                return RedirectToPage($"/NotFound");
            }
        }
    }
}