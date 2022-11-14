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
    public class PessoaFisicasController : Controller
    {
        private readonly DatabaseContext _context;

        public PessoaFisicasController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: PessoaFisicas
        public async Task<IActionResult> Index()
        {
              return View(await _context.PessoasFisicas.ToListAsync());
        }

        // GET: PessoaFisicas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PessoasFisicas == null)
            {
                return NotFound();
            }

            var pessoaFisica = await _context.PessoasFisicas
                .FirstOrDefaultAsync(m => m.UsuarioId == id);
            if (pessoaFisica == null)
            {
                return NotFound();
            }

            return View(pessoaFisica);
        }

        // GET: PessoaFisicas/Create
        public IActionResult Create(Usuario usuario)
        {
            PessoaFisica pessoafisica1 = new PessoaFisica();
            pessoafisica1.Email = usuario.Email;
            pessoafisica1.Celular = usuario.Celular;
            pessoafisica1.TelefoneFixo = usuario.TelefoneFixo;
            pessoafisica1.Senha = usuario.Senha;

            return View(pessoafisica1);
        }

        // POST: PessoaFisicas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Cpf,Nome,Sobrenome,Rg,GrauEscolaridade,DataNascimento,UsuarioId,Email,Celular,TelefoneFixo,Senha,Perfil")] PessoaFisica pessoaFisica)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pessoaFisica);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pessoaFisica);
        }

        // GET: PessoaFisicas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PessoasFisicas == null)
            {
                return NotFound();
            }

            var pessoaFisica = await _context.PessoasFisicas.FindAsync(id);
            if (pessoaFisica == null)
            {
                return NotFound();
            }
            return View(pessoaFisica);
        }

        // POST: PessoaFisicas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Cpf,Nome,Sobrenome,Rg,GrauEscolaridade,DataNascimento,UsuarioId,Email,Celular,TelefoneFixo,Senha,Perfil")] PessoaFisica pessoaFisica)
        {
            if (id != pessoaFisica.UsuarioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pessoaFisica);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PessoaFisicaExists(pessoaFisica.UsuarioId))
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
            return View(pessoaFisica);
        }

        // GET: PessoaFisicas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PessoasFisicas == null)
            {
                return NotFound();
            }

            var pessoaFisica = await _context.PessoasFisicas
                .FirstOrDefaultAsync(m => m.UsuarioId == id);
            if (pessoaFisica == null)
            {
                return NotFound();
            }

            return View(pessoaFisica);
        }

        // POST: PessoaFisicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PessoasFisicas == null)
            {
                return Problem("Entity set 'DatabaseContext.PessoasFisicas'  is null.");
            }
            var pessoaFisica = await _context.PessoasFisicas.FindAsync(id);
            if (pessoaFisica != null)
            {
                _context.PessoasFisicas.Remove(pessoaFisica);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PessoaFisicaExists(int id)
        {
          return _context.PessoasFisicas.Any(e => e.UsuarioId == id);
        }
    }
}
