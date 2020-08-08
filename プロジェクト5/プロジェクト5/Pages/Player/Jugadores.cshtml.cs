using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using プロジェクト5.Models;
using プロジェクト5.Services;

namespace プロジェクト5.Pages.Player
{
    public class JugadoresModel : PageModel
    {
        [BindProperty]
        public Equipo Equipo { get; set; }
        [BindProperty]
        public Jugador Jugador { get; set; }
        private readonly IRepository<Jugador> repository;
        public IEnumerable<Jugador> Jugadores { get; private set; }
        private readonly IRepository<Equipo> consult;
        public IEnumerable<Equipo> Equipos { get; private set; }
        public JugadoresModel(IRepository<Jugador> repository, IRepository<Equipo> Consult)
        {
            this.repository = repository;

            consult = Consult;
        }

        public IActionResult OnGet()
        {
            try
            {
                Equipos = consult.GetAll();
                Jugadores = repository.GetAll();
                return Page();
            }
            catch (Exception ex)
            {
                return RedirectToPage($"/NotFound");
            }
        }
    }
}