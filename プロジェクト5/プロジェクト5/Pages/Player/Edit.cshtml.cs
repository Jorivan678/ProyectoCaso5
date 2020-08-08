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

namespace プロジェクト5.Pages.Player
{
    [Authorize]
    public class EditModel : PageModel
    {
        [BindProperty]
        public Jugador Jugador { get; set; }
        public IFormFile Foto { get; set; }
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

            Jugador = await _context.Jugadores
                .Include(j => j.Equipo).FirstOrDefaultAsync(m => m.Id == id);

            if (Jugador == null)
            {
                return NotFound();
            }
            ViewData["IdEquipo"] = new SelectList(_context.Equipos, "Id", "NomEquip");
            return Page();
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Jugador).State = EntityState.Modified;

            try
            {
                if (Foto != null)
                {
                    if (!string.IsNullOrEmpty(Jugador.FotoJug))
                    {
                        var filePath = Path.Combine(HostEnvironment.WebRootPath, "images", Jugador.FotoJug);
                        System.IO.File.Delete(filePath);
                    }
                    Jugador.FotoJug = ProcessUploadFile();
                }

                _context.Entry(Jugador).Property(x => x.CreatedAT).IsModified = false;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JugadorExists(Jugador.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Jugadores");
        }

        private bool JugadorExists(int id)
        {
            return _context.Jugadores.Any(e => e.Id == id);
        }
    }

}
