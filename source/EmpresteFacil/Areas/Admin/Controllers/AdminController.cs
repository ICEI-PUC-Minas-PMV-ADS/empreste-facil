using EmpresteFacil.Context;
using EmpresteFacil.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace EmpresteFacil.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly DatabaseContext _context;

        public AdminController(DatabaseContext context) {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Usuarios.ToListAsync());
        }

        public async Task<IActionResult> EmprestimosAAprovar()
        {
            var emprestimos = await _context.Emprestimos.Where(e => e.Status == Status.EmAnalise).Include(e => e.Usuario).ToListAsync();
            return View(emprestimos);
        }

        public async Task<IActionResult> AprovarEmprestimo(int? id)
        {
            if (id == null || _context.Emprestimos == null)
            {
                return NotFound();
            }

            var emprestimo = await _context.Emprestimos.FindAsync(id);
            if (emprestimo == null)
            {
                return NotFound();
            }
            return View(emprestimo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Aprovar(int id, [Bind("TaxaJuros, Status")] Emprestimo atualizacao)
        {
            var emprestimo = await _context.Emprestimos.FirstOrDefaultAsync(m => m.Id ==  id);
            if(emprestimo != null)
            {
                emprestimo.TaxaJuros = atualizacao.TaxaJuros;
                emprestimo.Status = atualizacao.Status;
                _context.Update(emprestimo);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Reprovar(int id)
        {
            var emprestimo = await _context.Emprestimos.FirstOrDefaultAsync(m => m.Id == id);
            emprestimo.Status = (Status)2;
            _context.Update(emprestimo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
