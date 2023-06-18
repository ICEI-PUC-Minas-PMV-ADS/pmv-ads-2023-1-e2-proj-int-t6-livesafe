using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Live_Safe_v02.Models;
using Microsoft.AspNetCore.Authorization;

namespace Live_Safe_v02.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class ExpostosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExpostosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Verificar
        [AllowAnonymous] // <--- Anotação para liberar o acesso sem login
        public IActionResult Verificar() {
            return View();
        }

        // Relatorio se o email informado está no banco de dados Expostos
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous] // <--- Anotação para liberar o acesso sem login
        public async Task<IActionResult> Verificar([Bind("Email")] Expostos exposto) {
            // Verificar se o email foi informado
            if (string.IsNullOrEmpty(exposto.Email)) {
                ViewBag.Error = "Por favor, informe um email!";
                return View();
            }

            // Verificar se o email informado está no banco de dados Expostos
            var user = await _context.Expostos
                .FirstOrDefaultAsync(m => m.Email == exposto.Email);
            if (user == null) {
                // Se não estiver, exibir mensagem de sucesso
                ViewBag.Error = "Boas notícias! Nenhum vazamento de informação foi encontrado!";
                return View();
            }
            // Se o usuário for encontrado, precisa carregar a propriedade "Origem" antes pra usá-la na exibição da mensagem de erro
            var origem = _context.Entry(user).Property(u => u.Origem).CurrentValue;
            ViewBag.Message = "Péssimo! Você encontrou um vazamento de informação! Em [" + user.Origem + "].";
            return View();
        }


        // GET: Expostos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Expostos.ToListAsync());
        }

        // GET: Expostos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expostos = await _context.Expostos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (expostos == null)
            {
                return NotFound();
            }

            return View(expostos);
        }

        // GET: Expostos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Expostos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Email,Origem")] Expostos expostos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(expostos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(expostos);
        }

        // GET: Expostos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expostos = await _context.Expostos.FindAsync(id);
            if (expostos == null)
            {
                return NotFound();
            }
            return View(expostos);
        }

        // POST: Expostos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Email,Origem")] Expostos expostos)
        {
            if (id != expostos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(expostos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExpostosExists(expostos.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(expostos);
        }

        // GET: Expostos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expostos = await _context.Expostos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (expostos == null)
            {
                return NotFound();
            }

            return View(expostos);
        }

        // POST: Expostos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var expostos = await _context.Expostos.FindAsync(id);
            _context.Expostos.Remove(expostos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExpostosExists(int id)
        {
            return _context.Expostos.Any(e => e.Id == id);
        }
    }
}
