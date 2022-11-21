using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmpresteFacil.Context;
using EmpresteFacil.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace EmpresteFacil.Controllers
{
    public class PedidoDeEmprestimoController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public PedidoDeEmprestimoController(DatabaseContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: LoanRequest
        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return View(await _context.PedidoDeEmprestimo.Where(loanRequest => loanRequest.UserId == userId).ToListAsync());
        }

        // GET: LoanRequest/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PedidoDeEmprestimo == null)
            {
                return NotFound();
            }

            var loanRequest = await _context.PedidoDeEmprestimo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loanRequest == null)
            {
                return NotFound();
            }

            return View(loanRequest);
        }

        // GET: LoanRequest/Create
        public IActionResult Create()
        {
            return View();
        }
        // POST: LoanRequest/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Value")] PedidoDeEmprestimo loanRequest)
        {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                loanRequest.UserId = userId;
                _context.Add(loanRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
        }

        // GET: LoanRequest/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PedidoDeEmprestimo == null)
            {
                return NotFound();
            }

            var loanRequest = await _context.PedidoDeEmprestimo.FindAsync(id);
            if (loanRequest == null)
            {
                return NotFound();
            }
            return View(loanRequest);
        }

        // POST: LoanRequest/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,ApprovedAt,Value")] PedidoDeEmprestimo loanRequest)
        {
            if (id != loanRequest.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loanRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoanRequestExists(loanRequest.Id))
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
            return View(loanRequest);
        }

        // GET: LoanRequest/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PedidoDeEmprestimo == null)
            {
                return NotFound();
            }

            var loanRequest = await _context.PedidoDeEmprestimo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loanRequest == null)
            {
                return NotFound();
            }

            return View(loanRequest);
        }

        // POST: LoanRequest/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PedidoDeEmprestimo == null)
            {
                return Problem("Entity set 'DatabaseContext.PedidoDeEmprestimo'  is null.");
            }
            var loanRequest = await _context.PedidoDeEmprestimo.FindAsync(id);
            if (loanRequest != null)
            {
                _context.PedidoDeEmprestimo.Remove(loanRequest);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoanRequestExists(int id)
        {
            return _context.PedidoDeEmprestimo.Any(e => e.Id == id);
        }
    }
}
