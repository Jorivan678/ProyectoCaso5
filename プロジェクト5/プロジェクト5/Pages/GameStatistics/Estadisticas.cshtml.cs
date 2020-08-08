using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using プロジェクト5.Models;
using プロジェクト5.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualBasic.CompilerServices;
using System.Reflection;

namespace プロジェクト5.Pages.GameResult
{
    public class EstadisticasModel : PageModel
    {
        public IEnumerable<EstadisticasPartido> EstadisticaPartido { get; set; }
        private readonly AppDBContext _context;
        [BindProperty(SupportsGet = true)]
        public string InPartido { get; set; }
        public SelectList SelectPartido { get; set; }

        public EstadisticasModel(AppDBContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            IQueryable<int> PartQuery = from p in _context.EstadisticasPartidos.Include(p => p.Partido)
                                        orderby p.IdPartido
                                        select p.IdPartido;

            var Game = from p in _context.EstadisticasPartidos.Include(x => x.Partido)
                       select p;

            int var1 = Convert.ToInt32(InPartido);
            if (!string.IsNullOrEmpty(InPartido))
            {
               Game = Game.Where(x => x.IdPartido == var1);
            }

            SelectPartido = new SelectList(await PartQuery.Distinct().ToListAsync());
            EstadisticaPartido = await Game.ToListAsync();
        }
    }
}