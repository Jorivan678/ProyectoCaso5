using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using プロジェクト5.Models;
using プロジェクト5.Services;

namespace プロジェクト5.Pages.Team
{
    public class ActualizarEquipoModel : PageModel
    {
        [BindProperty]
        public Equipo Equipo { get; set; }
        public IRepository<Equipo> Repository { get; }
        public IEnumerable<Equipo> Equipos { get; private set; }
        public IFormFile Logo { get; set; }
        public IWebHostEnvironment HostEnvironment { get; }

        public ActualizarEquipoModel(IRepository<Equipo> repository, IWebHostEnvironment hostEnvironment)
        {
            Repository = repository;
            HostEnvironment = hostEnvironment;
        }

        public IActionResult Actualizar(Equipo equipo)
        {
            if (!ModelState.IsValid)
                return Page();

            if (Logo != null)
            {
                if (!string.IsNullOrEmpty(equipo.Logo))
                {
                    var filePath = Path.Combine(HostEnvironment.WebRootPath, "images", equipo.Logo);
                    System.IO.File.Delete(filePath);
                }
                equipo.Logo = ProcessUploadFile();
            }

            var id = equipo.Id;

            Repository.Update(equipo);

            return RedirectToPage($"/Index");
        }

        private string ProcessUploadFile()
        {
            if (Logo == null)
                return string.Empty;

            var uploadFolder = Path.Combine(HostEnvironment.WebRootPath, "images");
            var fileName = $"{Guid.NewGuid()}_{Logo.FileName}";
            var filePath = Path.Combine(uploadFolder, fileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                Logo.CopyTo(stream);
            }
            return fileName;
        }

        public IActionResult OnGet()
        {
            try
            {
                Equipos = Repository.GetAll();
                return Page();
            }
            catch (Exception ex)
            {
                return RedirectToPage($"/NotFound");
            }
        }
    }
}