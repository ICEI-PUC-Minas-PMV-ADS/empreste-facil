using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmpresteFacil.Context;
using EmpresteFacil.Models.Entities;

namespace EmpresteFacil.Controllers
{
    public class ParcelasController : Controller
    {
        private readonly DatabaseContext _context;

        public ParcelasController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Parcelas
        public async Task<IActionResult> Index()
        {
            var databaseContext = _context.Parcelas.Include(p => p.Emprestimo);
            return View(await databaseContext.ToListAsync());
        }

        // GET: Parcelas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Parcelas == null)
            {
                return NotFound();
            }

            var parcelas = await _context.Parcelas
                .Include(p => p.Emprestimo)
                .FirstOrDefaultAsync(m => m.ParcelaId == id);
            if (parcelas == null)
            {
                return NotFound();
            }

            return View(parcelas);
        }

        // GET: Parcelas/Create
        public IActionResult Create()
        {
            ViewData["EmprestimoId"] = new SelectList(_context.Emprestimos, "EmprestimoId", "EmprestimoId");
            return View();
        }

        // POST: Parcelas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ParcelaId,ValorParcela,DataVencimentoParcela,Juros,Amortizacao,DataPagamento,ValorMulta,StatusParcela,EmprestimoId")] Parcelas parcelas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(parcelas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmprestimoId"] = new SelectList(_context.Emprestimos, "EmprestimoId", "EmprestimoId", parcelas.EmprestimoId);
            return View(parcelas);
        }

        // GET: Parcelas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Parcelas == null)
            {
                return NotFound();
            }

            var parcelas = await _context.Parcelas.FindAsync(id);
            if (parcelas == null)
            {
                return NotFound();
            }
            ViewData["EmprestimoId"] = new SelectList(_context.Emprestimos, "EmprestimoId", "EmprestimoId", parcelas.EmprestimoId);
            return View(parcelas);
        }

        // POST: Parcelas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ParcelaId,ValorParcela,DataVencimentoParcela,Juros,Amortizacao,DataPagamento,ValorMulta,StatusParcela,EmprestimoId")] Parcelas parcelas)
        {
            if (id != parcelas.ParcelaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parcelas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParcelasExists(parcelas.ParcelaId))
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
            ViewData["EmprestimoId"] = new SelectList(_context.Emprestimos, "EmprestimoId", "EmprestimoId", parcelas.EmprestimoId);
            return View(parcelas);
        }

        // GET: Parcelas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Parcelas == null)
            {
                return NotFound();
            }

            var parcelas = await _context.Parcelas
                .Include(p => p.Emprestimo)
                .FirstOrDefaultAsync(m => m.ParcelaId == id);
            if (parcelas == null)
            {
                return NotFound();
            }

            return View(parcelas);
        }

        // POST: Parcelas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Parcelas == null)
            {
                return Problem("Entity set 'DatabaseContext.Parcelas'  is null.");
            }
            var parcelas = await _context.Parcelas.FindAsync(id);
            if (parcelas != null)
            {
                _context.Parcelas.Remove(parcelas);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParcelasExists(int id)
        {
          return _context.Parcelas.Any(e => e.ParcelaId == id);
        }
    }
}
