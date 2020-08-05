using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using プロジェクト5.Models;
using プロジェクト5.Services;

namespace プロジェクト5.Pages.Player
{
    [Authorize]
    public class AgregarJugadorModel : PageModel
    {
        [BindProperty]
        public Jugador Jugador { get; set; }
        private readonly IRepository<Equipo> consult;
        public IEnumerable<Equipo> Equipos { get; private set; }
        public IRepository<Jugador> Repository { get; }
        public IFormFile Foto { get; set; }
        public IWebHostEnvironment HostEnvironment { get; }

        public AgregarJugadorModel(IRepository<Jugador> repository, IWebHostEnvironment hostEnvironment, IRepository<Equipo> Consult)
        {
            Repository = repository;
            HostEnvironment = hostEnvironment;

            consult = Consult;
        }
        public IActionResult OnGet()
        {
           try
           {
                Equipos = consult.GetAll();
                return Page();
           }
           catch (Exception ex)
           {
              return RedirectToPage($"/NotFound");
           }
        }

        private string ProcessUploadFile()
        {
            if (Foto == null)
                return string.Empty;

            var uploadFolder = Path.Combine(HostEnvironment.WebRootPath, "images");
            var fileName = $"{Guid.NewGuid()}_{Foto.FileName}";
            var filePath = Path.Combine(uploadFolder, fileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                Foto.CopyTo(stream);
            }
            return fileName;
        }

        public IActionResult OnPost(Jugador jugador)
        {
            if (!ModelState.IsValid)
                return Page();

            if (Foto != null)
            {
                if (!string.IsNullOrEmpty(jugador.FotoJug))
                {
                    var filePath = Path.Combine(HostEnvironment.WebRootPath, "images", jugador.FotoJug);
                    System.IO.File.Delete(filePath);
                }
                jugador.FotoJug = ProcessUploadFile();
            }
            var id = Repository.Insert(jugador);

            return RedirectToPage($"./Jugadores");
        }
    }
}