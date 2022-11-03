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
    public class PessoaJuridicasController : Controller
    {
        private readonly DatabaseContext _context;

        public PessoaJuridicasController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: PessoaJuridicas
        public async Task<IActionResult> Index()
        {
              return View(await _context.PessoasJuridicas.ToListAsync());
        }

        // GET: PessoaJuridicas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PessoasJuridicas == null)
            {
                return NotFound();
            }

            var pessoaJuridica = await _context.PessoasJuridicas
                .FirstOrDefaultAsync(m => m.UsuarioId == id);
            if (pessoaJuridica == null)
            {
                return NotFound();
            }

            return View(pessoaJuridica);
        }

        // GET: PessoaJuridicas/Create
        public IActionResult Create(Usuario usuario)
        {
            PessoaJuridica pessoajuridica = new PessoaJuridica();
            pessoajuridica.Email = usuario.Email;
            pessoajuridica.Celular = usuario.Celular;
            pessoajuridica.TelefoneFixo = usuario.TelefoneFixo;
            pessoajuridica.Senha = usuario.Senha;

            return View(pessoajuridica);
        }

        // POST: PessoaJuridicas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CNPJ,RazaoSocial,DataConstituicao,UsuarioId,Email,Celular,TelefoneFixo,Senha,Perfil")] PessoaJuridica pessoaJuridica)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pessoaJuridica);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pessoaJuridica);
        }

        // GET: PessoaJuridicas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PessoasJuridicas == null)
            {
                return NotFound();
            }

            var pessoaJuridica = await _context.PessoasJuridicas.FindAsync(id);
            if (pessoaJuridica == null)
            {
                return NotFound();
            }
            return View(pessoaJuridica);
        }

        // POST: PessoaJuridicas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CNPJ,RazaoSocial,DataConstituicao,UsuarioId,Email,Celular,TelefoneFixo,Senha,Perfil")] PessoaJuridica pessoaJuridica)
        {
            if (id != pessoaJuridica.UsuarioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pessoaJuridica);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PessoaJuridicaExists(pessoaJuridica.UsuarioId))
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
            return View(pessoaJuridica);
        }

        // GET: PessoaJuridicas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PessoasJuridicas == null)
            {
                return NotFound();
            }

            var pessoaJuridica = await _context.PessoasJuridicas
                .FirstOrDefaultAsync(m => m.UsuarioId == id);
            if (pessoaJuridica == null)
            {
                return NotFound();
            }

            return View(pessoaJuridica);
        }

        // POST: PessoaJuridicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PessoasJuridicas == null)
            {
                return Problem("Entity set 'DatabaseContext.PessoasJuridicas'  is null.");
            }
            var pessoaJuridica = await _context.PessoasJuridicas.FindAsync(id);
            if (pessoaJuridica != null)
            {
                _context.PessoasJuridicas.Remove(pessoaJuridica);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PessoaJuridicaExists(int id)
        {
          return _context.PessoasJuridicas.Any(e => e.UsuarioId == id);
        }
    }
}
