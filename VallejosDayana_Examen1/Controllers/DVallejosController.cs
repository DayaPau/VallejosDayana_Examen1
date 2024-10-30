using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VallejosDayana_Examen1.Data;
using VallejosDayana_Examen1.Models;

namespace VallejosDayana_Examen1.Controllers
{
    public class DVallejosController : Controller
    {
        private readonly VallejosDayana_Examen1Context _context;

        public DVallejosController(VallejosDayana_Examen1Context context)
        {
            _context = context;
        }

        // GET: DVallejos
        public async Task<IActionResult> Index()
        {
            return View(await _context.DVallejos.ToListAsync());
        }

        // GET: DVallejos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dVallejos = await _context.DVallejos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dVallejos == null)
            {
                return NotFound();
            }

            return View(dVallejos);
        }

        // GET: DVallejos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DVallejos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Edad,Nombre,Estatura,EsSoltero,Fecha")] DVallejos dVallejos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dVallejos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dVallejos);
        }

        // GET: DVallejos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dVallejos = await _context.DVallejos.FindAsync(id);
            if (dVallejos == null)
            {
                return NotFound();
            }
            return View(dVallejos);
        }

        // POST: DVallejos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Edad,Nombre,Estatura,EsSoltero,Fecha")] DVallejos dVallejos)
        {
            if (id != dVallejos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dVallejos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DVallejosExists(dVallejos.Id))
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
            return View(dVallejos);
        }

        // GET: DVallejos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dVallejos = await _context.DVallejos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dVallejos == null)
            {
                return NotFound();
            }

            return View(dVallejos);
        }

        // POST: DVallejos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dVallejos = await _context.DVallejos.FindAsync(id);
            if (dVallejos != null)
            {
                _context.DVallejos.Remove(dVallejos);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DVallejosExists(int id)
        {
            return _context.DVallejos.Any(e => e.Id == id);
        }
    }
}
