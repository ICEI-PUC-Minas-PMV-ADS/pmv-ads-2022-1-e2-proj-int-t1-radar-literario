using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using RadarLiterario.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RadarLiterario.Controllers
{
    [Authorize]
    public class ArquivosController : Controller
    { 
        ApplicationDbContext _context;

        public ArquivosController(ApplicationDbContext context)
        {
            _context = context;

        }

        public IActionResult Upload(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewData["LivroId"] = id;
            return View();
        }

        [HttpPost]
        public IActionResult Upload(int livro_id, IList<IFormFile> arquivos)
        {
            IFormFile ebookCarregado = arquivos.FirstOrDefault();

            if (ebookCarregado != null)
            {
                MemoryStream ms = new MemoryStream();
                ebookCarregado.OpenReadStream().CopyTo(ms);

                Arquivos arqui = new Arquivos()
                {
                    LivroId = livro_id,
                    Descricao = ebookCarregado.FileName,
                    Dados = ms.ToArray(),
                    ContentType = ebookCarregado.ContentType
                };

                _context.Arquivos.Add(arqui);
                _context.SaveChanges();
            }

            return RedirectToAction("Details", "Livros", new { id = livro_id });
        }

        public IActionResult Visualizar(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arquivosBanco = _context.Arquivos.FirstOrDefault(a => a.Id.ToString() == id);

            return File(arquivosBanco.Dados, arquivosBanco.ContentType);
        }

    }
}
