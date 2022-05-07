using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using RadarLiterario.Models;

namespace RadarLiterario.Controllers
{
    public class ArquivosController : Controller
    { 
        ApplicationDbContext _context;

        public ArquivosController(ApplicationDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            var arquivos = _context.Arquivos.ToList();
            return View(arquivos);
        }
        [HttpPost]
        public IActionResult UploadEbook(IList<IFormFile> arquivos)
        {
            IFormFile ebookCarregado = arquivos.FirstOrDefault();

            if (ebookCarregado != null)
            {
                MemoryStream ms = new MemoryStream();
                ebookCarregado.OpenReadStream().CopyTo(ms);

                Arquivos arqui = new Arquivos()
                {
                    Descricao = ebookCarregado.FileName,
                    Dados = ms.ToArray(),
                    ContentType = ebookCarregado.ContentType
                };

                _context.Arquivos.Add(arqui);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Visualizar(int id)
        {
            var arquivosBanco = _context.Arquivos.FirstOrDefault(a => a.Id == id);

            return File(arquivosBanco.Dados, arquivosBanco.ContentType);
        }

    }
}
