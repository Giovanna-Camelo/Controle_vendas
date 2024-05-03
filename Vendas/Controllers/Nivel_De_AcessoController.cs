using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Controle_Vendas.Models;
using Vendas.Data;

namespace Controle_Vendas.Controllers
{
    public class Nivel_De_AcessoController : Controller
    {
        private readonly VendasContext _context;

        public Nivel_De_AcessoController(VendasContext context)
        {
            _context = context;
        }

        // GET: Nivel_De_Acesso
        public async Task<IActionResult> Index()
        {
            return View(await _context.Nivel_De_Acesso.ToListAsync());
        }

        // GET: Nivel_De_Acesso/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nivel_De_Acesso = await _context.Nivel_De_Acesso
                .FirstOrDefaultAsync(m => m.Nivel_De_AcessoId == id);
            if (nivel_De_Acesso == null)
            {
                return NotFound();
            }

            return View(nivel_De_Acesso);
        }

        // GET: Nivel_De_Acesso/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Nivel_De_Acesso/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nivel_De_AcessoId,nome,Nivel")] Nivel_De_Acesso nivel_De_Acesso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nivel_De_Acesso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nivel_De_Acesso);
        }

        // GET: Nivel_De_Acesso/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nivel_De_Acesso = await _context.Nivel_De_Acesso.FindAsync(id);
            if (nivel_De_Acesso == null)
            {
                return NotFound();
            }
            return View(nivel_De_Acesso);
        }

        // POST: Nivel_De_Acesso/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Nivel_De_AcessoId,nome,Nivel")] Nivel_De_Acesso nivel_De_Acesso)
        {
            if (id != nivel_De_Acesso.Nivel_De_AcessoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nivel_De_Acesso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Nivel_De_AcessoExists(nivel_De_Acesso.Nivel_De_AcessoId))
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
            return View(nivel_De_Acesso);
        }

        // GET: Nivel_De_Acesso/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nivel_De_Acesso = await _context.Nivel_De_Acesso
                .FirstOrDefaultAsync(m => m.Nivel_De_AcessoId == id);
            if (nivel_De_Acesso == null)
            {
                return NotFound();
            }

            return View(nivel_De_Acesso);
        }

        // POST: Nivel_De_Acesso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nivel_De_Acesso = await _context.Nivel_De_Acesso.FindAsync(id);
            if (nivel_De_Acesso != null)
            {
                _context.Nivel_De_Acesso.Remove(nivel_De_Acesso);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Nivel_De_AcessoExists(int id)
        {
            return _context.Nivel_De_Acesso.Any(e => e.Nivel_De_AcessoId == id);
        }
    }
}
