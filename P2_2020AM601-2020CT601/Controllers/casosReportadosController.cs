using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using P2_2020AM601_2020CT601.Models;

namespace P2_2020AM601_2020CT601.Controllers
{
    public class casosReportadosController : Controller
    {
        private readonly covidcontext _context;

        public casosReportadosController(covidcontext context)
        {
            _context = context;
        }

        // GET: casosReportados
        public async Task<IActionResult> Index()
        {
              return _context.casosReportados != null ? 
                          View(await _context.casosReportados.ToListAsync()) :
                          Problem("Entity set 'covidcontext.casosReportados'  is null.");
        }

        // GET: casosReportados/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.casosReportados == null)
            {
                return NotFound();
            }

            var casosReportados = await _context.casosReportados
                .FirstOrDefaultAsync(m => m.IdCasosconfirmados == id);
            if (casosReportados == null)
            {
                return NotFound();
            }

            return View(casosReportados);
        }

        // GET: casosReportados/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: casosReportados/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCasosconfirmados,numCasosconfirmados,numCasosrecuperados,numCasosfallecidos,Idgenero,Iddepartamento")] casosReportados casosReportados)
        {
            if (ModelState.IsValid)
            {
                _context.Add(casosReportados);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(casosReportados);
        }

        // GET: casosReportados/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.casosReportados == null)
            {
                return NotFound();
            }

            var casosReportados = await _context.casosReportados.FindAsync(id);
            if (casosReportados == null)
            {
                return NotFound();
            }
            return View(casosReportados);
        }

        // POST: casosReportados/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCasosconfirmados,numCasosconfirmados,numCasosrecuperados,numCasosfallecidos,Idgenero,Iddepartamento")] casosReportados casosReportados)
        {
            if (id != casosReportados.IdCasosconfirmados)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(casosReportados);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!casosReportadosExists(casosReportados.IdCasosconfirmados))
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
            return View(casosReportados);
        }

        // GET: casosReportados/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.casosReportados == null)
            {
                return NotFound();
            }

            var casosReportados = await _context.casosReportados
                .FirstOrDefaultAsync(m => m.IdCasosconfirmados == id);
            if (casosReportados == null)
            {
                return NotFound();
            }

            return View(casosReportados);
        }

        // POST: casosReportados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.casosReportados == null)
            {
                return Problem("Entity set 'covidcontext.casosReportados'  is null.");
            }
            var casosReportados = await _context.casosReportados.FindAsync(id);
            if (casosReportados != null)
            {
                _context.casosReportados.Remove(casosReportados);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool casosReportadosExists(int id)
        {
          return (_context.casosReportados?.Any(e => e.IdCasosconfirmados == id)).GetValueOrDefault();
        }
    }
}
