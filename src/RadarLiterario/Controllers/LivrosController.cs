using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RadarLiterario.Models;

namespace RadarLiterario.Controllers
{
    [Authorize]
    public class LivrosController : Controller
    {
        private readonly ApplicationDbContext _context;

       public LivrosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Livros
        public async Task<IActionResult> Index(string id)
        {
            var livro = from m in _context.Livros
                        select m;

            if (!String.IsNullOrEmpty(id))
            {
                livro = livro.Where(s => s.titulo.Contains(id));
            }

            return View(await livro.ToListAsync());
        }

        // GET: Livros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livro = await _context.Livros
                .Include(t => t.Arquivos)
                .FirstOrDefaultAsync(m => m.id == id);
            if (livro == null)
            {
                return NotFound();
            }

            return View(livro);
        }

        // GET: Livros/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Livros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,titulo,ImagemCapa,genero,sinopse")] Livro livro)
        {
            if (ModelState.IsValid)
            {
                var livroExistente = await _context.Livros
                .FirstOrDefaultAsync(m => m.titulo == livro.titulo);

                if (livroExistente != null)
                {
                    ModelState.AddModelError("titulo", "Livro já cadastrado");
                }
                else
                {
                    HttpClient client = new HttpClient();

                    HttpResponseMessage res = await client.GetAsync(livro.ImagemCapa);

                    bool IsTypeImage = res.ToString().Contains("Content-Type: image");

                    if (IsTypeImage != true)
                    {
                        ModelState.AddModelError("ImagemCapa", "Verifique se o URL é de uma imagem");
                    }
                    else
                    {
                        _context.Add(livro);
                        await _context.SaveChangesAsync();

                        return RedirectToAction("Upload", "Arquivos", new { livro.id });
                    }
                }  
            }
            return View(livro);
        }

        // GET: Livros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livro = await _context.Livros.FindAsync(id);
            if (livro == null)
            {
                return NotFound();
            }
            return View(livro);
        }

        // POST: Livros/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,titulo,ImagemCapa,genero,sinopse")] Livro livro)
        {
            if (id != livro.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(livro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LivroExists(livro.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction("Details", new { livro.id });
            }
            return View(livro);
        }

        // GET: Livros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var livro = await _context.Livros
                .FirstOrDefaultAsync(m => m.id == id);
            if (livro == null)
            {
                return NotFound();
            }

            return View(livro);
        }

        // POST: Livros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var livro = await _context.Livros.FindAsync(id);
            _context.Livros.Remove(livro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LivroExists(int id)
        {
            return _context.Livros.Any(e => e.id == id);
        }
    }
}
