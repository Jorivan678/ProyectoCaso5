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
    public class PartidoModel : PageModel
    {
        public IList<Partido> Partido { get; set; }
        public IList<Equipo> Equipo { get; set; }
        public IList<EquipoSub> EquipoSub { get; set; }
        public IList<ResultadoPartido> ResultadoPartido { get; set; }
        [BindProperty(SupportsGet = true)] 
        public string TeamPlayer { get; set; }
        public SelectList Player { get; set; }
        private readonly AppDBContext _context;

        public PartidoModel(AppDBContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Equipo = await _context.Equipos.ToListAsync();
            EquipoSub = await _context.EquipoSubs.Include(p => p.Equipo).ToListAsync();
            Partido = await _context.Partidos
                .Include(p => p.Equipo)
                .Include(p => p.EquipoSub).ToListAsync();
            IQueryable<string> JugQuery = from p in _context.ResultadoPartidos.Include(p => p.Partido).Include(p => p.Jugador)
                                          orderby p.Jugador.NomJug
                                         select p.Jugador.NomJug;

            var player = from p in _context.ResultadoPartidos.Include(x => x.Partido).Include(x => x.Jugador)
                         select p;
            if(!string.IsNullOrEmpty(TeamPlayer))
            {
                player = player.Where(x => x.Jugador.NomJug == TeamPlayer);
            }

            Player = new SelectList(await JugQuery.Distinct().ToListAsync());
            ResultadoPartido = await player.ToListAsync();
        }
    }
}