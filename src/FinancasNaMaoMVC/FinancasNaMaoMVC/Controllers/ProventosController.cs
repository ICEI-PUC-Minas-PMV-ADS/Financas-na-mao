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
    public class ProventosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Usuario> _userManager;

        public ProventosController(ApplicationDbContext context, UserManager<Usuario> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Proventos/IndexProvento
        public async Task<IActionResult> IndexProvento()
        {
            var userId = _userManager.GetUserId(this.User);
            var applicationDbContext = _context.Proventos.Include(l => l.Categoria).Include(l => l.Usuario);
            return View(await applicationDbContext.Where(l => l.UsuarioId == userId).ToListAsync());
        }

         // GET: Proventos/DetailsProvento/5
        public async Task<IActionResult> DetailsProvento(int? id)
        {
            if (id == null || _context.Proventos == null)
            {
                return NotFound();
            }

            var provento = await _context.Proventos
                .Include(l => l.Categoria)
                .Include(l => l.Usuario)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (provento == null)
            {
                return NotFound();
            }

            return View(provento);
        } 

        // GET: Proventos/CreateProvento
        public IActionResult CreateProvento()
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-br");
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
        // POST: Proventos/CreateProventos
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateProvento([Bind("ID,Valor,ValorReservado,Data,Nome,isFixo,Obs,Natureza,UsuarioId,CategoriaID")] Provento provento)
        {
            provento.UsuarioId = _userManager.GetUserId(this.User);

            if (ModelState.IsValid)
            {
                 double? saldoProvento = provento.Valor;
                string? naturezaProvento = provento.Natureza;
                decimal? valor = saldoProvento.HasValue ? Convert.ToDecimal(saldoProvento.Value) : (decimal?)null;
                decimal saldoProventoInt = valor ?? 0m;

                var usuario = await _context.Usuario.FindAsync(provento.UsuarioId);

                 if (naturezaProvento == "Conta Corrente") {
                    var saldoUsuario = usuario.Corrente;
                    decimal novoSaldoUsuario = saldoUsuario + saldoProventoInt;
                    usuario.Corrente = novoSaldoUsuario;
                }
                else{
                    var saldoUsuario = usuario.Poupanca;
                    decimal novoSaldoUsuario = saldoUsuario + saldoProventoInt;
                    usuario.Poupanca = novoSaldoUsuario;

                } 
                _context.Add(provento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexProvento));
            }



            ViewData["CategoriaID"] = new SelectList(_context.Categorias, "ID", "ID", provento.CategoriaID);
            ViewData["UsuarioId"] = new SelectList(_context.Users, "Id", "Id", provento.UsuarioId);
            return View(provento);
        }


        // GET: Proventos/EditProvento/5
        public async Task<IActionResult> EditProvento(int? id)
         {
             if (id == null || _context.Proventos == null)
             {
                 return NotFound();
             }

             var provento = await _context.Proventos.FindAsync(id);
             if (provento == null)
             {
                 return NotFound();
             }
             ViewData["CategoriaID"] = new SelectList(_context.Categorias, "ID", "ID", provento.CategoriaID);
             ViewData["UsuarioId"] = new SelectList(_context.Users, "Id", "Id", provento.UsuarioId);
             return View(provento);
         }

        // POST: Proventos/EditProvento/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
         [ValidateAntiForgeryToken]
         public async Task<IActionResult> EditProvento(int id, [Bind("ID,Valor,ValorReservado,Data,Nome,isFixo,Obs,Natureza,UsuarioId,CategoriaID")] Provento provento)
         {
             if (id != provento.ID)
             {
                 return NotFound();
             }

             if (ModelState.IsValid)
             {
                 try
                 {
                    provento.UsuarioId = _userManager.GetUserId(this.User);
                    _context.Update(provento);
                     await _context.SaveChangesAsync();
                 }
                 catch (DbUpdateConcurrencyException)
                 {
                     if (!ProventoExists(provento.ID))
                     {
                         return NotFound();
                     }
                     else
                     {
                         throw;
                     }
                 }
                 return RedirectToAction(nameof(IndexProvento));
             }
             ViewData["CategoriaID"] = new SelectList(_context.Categorias, "ID", "ID", provento.CategoriaID);
             ViewData["UsuarioId"] = new SelectList(_context.Users, "Id", "Id", provento.UsuarioId);
             return View(provento);
         }

        
    
         // GET: Proventos/Delete/5
         public async Task<IActionResult> DeleteProvento(int? id)
         {
             if (id == null || _context.Proventos == null)
             {
                 return NotFound();
             }

             var provento = await _context.Proventos
                 .Include(l => l.Categoria)
                 .Include(l => l.Usuario)
                 .FirstOrDefaultAsync(m => m.ID == id);
             if (provento == null)
             {
                 return NotFound();
             }

             return View(provento);
         }


        // POST: Proventos/Delete/5
        [HttpPost, ActionName("DeleteProvento")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Proventos == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Proventos'  is null.");
            }
            var provento = await _context.Proventos.FindAsync(id);
            double? saldoProvento = provento.Valor;
            string? naturezaProvento = provento.Natureza;
            decimal? valor = saldoProvento.HasValue ? Convert.ToDecimal(saldoProvento.Value) : (decimal?)null;
            decimal saldoProventoInt = valor ?? 0m;

            var usuario = await _context.Usuario.FindAsync(provento.UsuarioId);

            if (naturezaProvento == "Conta Corrente")
            {
                var saldoUsuario = usuario.Corrente;
                decimal novoSaldoUsuario = saldoUsuario - saldoProventoInt;
                usuario.Corrente = novoSaldoUsuario;
            }
            else
            {
                var saldoUsuario = usuario.Poupanca;
                decimal novoSaldoUsuario = saldoUsuario - saldoProventoInt;
                usuario.Poupanca = novoSaldoUsuario;

            }
            if (provento != null)
            {
                _context.Proventos.Remove(provento);
            }



            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexProvento));
        }

        private bool ProventoExists(int id)
        {
            return (_context.Proventos?.Any(e => e.ID == id)).GetValueOrDefault();
        }




    }
}

