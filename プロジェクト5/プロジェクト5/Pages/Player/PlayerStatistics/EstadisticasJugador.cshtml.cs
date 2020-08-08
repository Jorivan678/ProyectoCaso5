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

namespace プロジェクト5.Pages.Player.PlayerStatistics
{
    public class EstadisticasJugadorModel : PageModel
    {
        public IList<EstadisticasJugador> EstadisticasJugador { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Player { get; set; }
        public SelectList SelectPlayer { get; set; }
        private readonly AppDBContext _context;

        public EstadisticasJugadorModel(AppDBContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            IQueryable<string> JugQuery = from p in _context.EstadisticasJugadores.Include(p => p.Jugador).Include(p => p.Partido)
                                       orderby p.Jugador.NomJug
                                       select p.Jugador.NomJug;

            var Jug = from p in _context.EstadisticasJugadores.Include(x => x.Jugador).Include(x => x.Partido)
                       select p;
            if (!string.IsNullOrEmpty(Player))
            {
                Jug = Jug.Where(x => x.Jugador.NomJug == Player);
            }

            SelectPlayer = new SelectList(await JugQuery.Distinct().ToListAsync());
            EstadisticasJugador = await Jug.ToListAsync();
        }
    }
}
