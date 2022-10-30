using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmpresteFacil.Context;
using EmpresteFacil.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace EmpresteFacil.Controllers
{
    public class LoanRequestController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public LoanRequestController(DatabaseContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: LoanRequest
        public async Task<IActionResult> Index()
        {
            return View(await _context.LoanRequests.ToListAsync());
        }

        // GET: LoanRequest/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.LoanRequests == null)
            {
                return NotFound();
            }

            var loanRequest = await _context.LoanRequests
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
        public async Task<IActionResult> Create([Bind("Value")] LoanRequest loanRequest)
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
            if (id == null || _context.LoanRequests == null)
            {
                return NotFound();
            }

            var loanRequest = await _context.LoanRequests.FindAsync(id);
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,ApprovedAt,Value")] LoanRequest loanRequest)
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
            if (id == null || _context.LoanRequests == null)
            {
                return NotFound();
            }

            var loanRequest = await _context.LoanRequests
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
            if (_context.LoanRequests == null)
            {
                return Problem("Entity set 'DatabaseContext.LoanRequests'  is null.");
            }
            var loanRequest = await _context.LoanRequests.FindAsync(id);
            if (loanRequest != null)
            {
                _context.LoanRequests.Remove(loanRequest);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoanRequestExists(int id)
        {
            return _context.LoanRequests.Any(e => e.Id == id);
        }
    }
}
