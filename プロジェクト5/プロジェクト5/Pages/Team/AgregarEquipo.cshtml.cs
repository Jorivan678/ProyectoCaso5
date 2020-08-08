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
    [Authorize]
    public class AgregarEquipoModel : PageModel
    {
        [BindProperty]
        public Equipo Equipo { get; set; }
        public IRepository<Equipo> Repository { get; }
        public IFormFile Logo { get; set; }
        public IWebHostEnvironment HostEnvironment { get; }
        
        public AgregarEquipoModel(IRepository<Equipo> repository, IWebHostEnvironment hostEnvironment)
        {
            Repository = repository;
            HostEnvironment = hostEnvironment;
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

        public IActionResult OnPost(Equipo equipo)
        {
            if (!ModelState.IsValid)
                return Page();

            if(Logo != null)
            {
                if(!string.IsNullOrEmpty(equipo.Logo))
                {
                    var filePath = Path.Combine(HostEnvironment.WebRootPath, "images", equipo.Logo);
                    System.IO.File.Delete(filePath);
                }
                equipo.Logo = ProcessUploadFile();
            }
            var id = Repository.Insert(equipo);

            return RedirectToPage($"./Equipos");
        }
    }
}