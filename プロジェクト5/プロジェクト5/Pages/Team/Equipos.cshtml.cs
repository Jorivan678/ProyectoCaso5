using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using プロジェクト5.Models;
using プロジェクト5.Services;

namespace プロジェクト5.Pages.Team
{
    public class EquiposModel : PageModel
    {
        private readonly IRepository<Equipo> repository;
        public IEnumerable<Equipo> Equipos { get; private set; }
        public EquiposModel(IRepository<Equipo> repository)
        {
            this.repository = repository;
        }
        public IActionResult OnGet()
        {
            try
            {
                Equipos = repository.GetAll();
                return Page();
            }
            catch(Exception ex)
            {
                return RedirectToPage($"/NotFound");
            }
        }
    }
}