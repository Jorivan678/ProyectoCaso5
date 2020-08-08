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
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using プロジェクト5.Models;
using プロジェクト5.Services;

namespace プロジェクト5.Pages.Team
{
    [Authorize]
    public class EditModel : PageModel
    {
        [BindProperty]
        public Equipo Equipo { get; set; }
        public IFormFile Logo { get; set; }
        public IWebHostEnvironment HostEnvironment { get; }
        private readonly AppDBContext _context;

        public EditModel(AppDBContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            HostEnvironment = hostEnvironment;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Equipo = await _context.Equipos.FirstOrDefaultAsync(m => m.Id == id);

            if (Equipo == null)
            {
                return NotFound();
            }
            return Page();
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

        public async Task<IActionResult> OnPostAsync(Equipo equipo)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(equipo).State = EntityState.Modified;

            try
            { 
                if (Logo != null)
                {
                    if (!string.IsNullOrEmpty(equipo.Logo))
                    {
                        var filePath = Path.Combine(HostEnvironment.WebRootPath, "images", equipo.Logo);
                        System.IO.File.Delete(filePath);
                    }
                    equipo.Logo = ProcessUploadFile();
                }
                _context.Entry(equipo).Property(x => x.NomEquip).IsModified = true;
                _context.Entry(equipo).Property(x => x.Status).IsModified = true;
                _context.Entry(equipo).Property(x => x.Logo).IsModified = true;
                _context.Entry(equipo).Property(x => x.CreatedAT).IsModified = false;
                _context.Entry(equipo).Property(x => x.UpdatedAT).IsModified = true;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EquipoExists(equipo.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Equipos");
        }

        private bool EquipoExists(int id)
        {
            return _context.Equipos.Any(e => e.Id == id);
        }
    }
}
