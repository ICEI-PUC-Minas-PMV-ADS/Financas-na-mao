using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinancasNaMaoMVC.Areas.Identity.Data;
using FinancasNaMaoMVC.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Globalization;
using System.Net.NetworkInformation;

namespace FinancasNaMaoMVC.Controllers
{
    public class LancamentosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Usuario> _userManager;

        public LancamentosController(ApplicationDbContext context, UserManager<Usuario> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Lancamentos
        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(this.User);
            var applicationDbContext = _context.Lancamentos.Include(l => l.Categoria).Include(l => l.Usuario);
            return View(await applicationDbContext.Where(l => l.UsuarioId == userId).ToListAsync());
        }

        // GET: Lancamentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Lancamentos == null)
            {
                return NotFound();
            }

            var lancamento = await _context.Lancamentos
                .Include(l => l.Categoria)
                .Include(l => l.Usuario)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (lancamento == null)
            {
                return NotFound();
            }

            return View(lancamento);
        }

        // GET: Lancamentos/Create
        public IActionResult Create()
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            var userId = _userManager.GetUserId(this.User);
            List<Categoria> categorias = new List<Categoria>();
            foreach (var categoria in _context.Categorias)
            {
                if (categoria.UsuarioId == userId)
                {
                    categorias.Add(categoria);
                }
            }
            ViewData["CategoriaID"] = new SelectList(categorias, "ID", "Nome");
            return View();
        }

        // POST: Lancamentos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Valor,ValorReservado,Data,Nome,isFixo,Obs,Natureza,UsuarioId,CategoriaID")] Lancamento lancamento)
        {
            lancamento.UsuarioId = _userManager.GetUserId(this.User);

            if (ModelState.IsValid)
            {
                _context.Add(lancamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaID"] = new SelectList(_context.Categorias, "ID", "ID", lancamento.CategoriaID);
            ViewData["UsuarioId"] = new SelectList(_context.Users, "Id", "Id", lancamento.UsuarioId);
            return View(lancamento);
        }

        // GET: Lancamentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Lancamentos == null)
            {
                return NotFound();
            }

            var lancamento = await _context.Lancamentos.FindAsync(id);
            if (lancamento == null)
            {
                return NotFound();
            }
            ViewData["CategoriaID"] = new SelectList(_context.Categorias, "ID", "ID", lancamento.CategoriaID);
            ViewData["UsuarioId"] = new SelectList(_context.Users, "Id", "Id", lancamento.UsuarioId);
            return View(lancamento);
        }

        // POST: Lancamentos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Valor,ValorReservado,Data,Nome,isFixo,Obs,Natureza,UsuarioId,CategoriaID")] Lancamento lancamento)
        {
            if (id != lancamento.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lancamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LancamentoExists(lancamento.ID))
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
            ViewData["CategoriaID"] = new SelectList(_context.Categorias, "ID", "ID", lancamento.CategoriaID);
            ViewData["UsuarioId"] = new SelectList(_context.Users, "Id", "Id", lancamento.UsuarioId);
            return View(lancamento);
        }

        // GET: Lancamentos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Lancamentos == null)
            {
                return NotFound();
            }

            var lancamento = await _context.Lancamentos
                .Include(l => l.Categoria)
                .Include(l => l.Usuario)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (lancamento == null)
            {
                return NotFound();
            }

            return View(lancamento);
        }

        // POST: Lancamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Lancamentos == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Lancamentos'  is null.");
            }
            var lancamento = await _context.Lancamentos.FindAsync(id);
            if (lancamento != null)
            {
                _context.Lancamentos.Remove(lancamento);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LancamentoExists(int id)
        {
            return (_context.Lancamentos?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
