using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using プロジェクト5.Models;
using プロジェクト5.Services;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace プロジェクト5.Pages.GameResult
{
    public class ResultadosModel : PageModel
    {
        public IEnumerable<ResultadoPartido> ResultadoPartido { get; set; }
        private readonly AppDBContext _context;
        private readonly IWebHostEnvironment HostEnvironment;

        public ResultadosModel(AppDBContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            HostEnvironment = hostEnvironment;
        }

        public async Task OnGetAsync()
        {
                ResultadoPartido = await _context.ResultadoPartidos
                .Include(r => r.Jugador)
                .Include(r => r.Partido).ToListAsync();
        }
    }
}