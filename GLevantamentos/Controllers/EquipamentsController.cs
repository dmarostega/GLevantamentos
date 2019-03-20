using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GLevantamentos.Data;
using GLevantamentos.Models;

namespace GLevantamentos.Controllers
{
    public class EquipamentsController : Controller
    {
        private readonly GLevantamentosContext _context;

        public EquipamentsController(GLevantamentosContext context)
        {
            _context = context;
        }

        // GET: Equipaments
        public async Task<IActionResult> Index()
        {
            return View(await _context.Equipament.ToListAsync());
        }

        // GET: Equipaments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipament = await _context.Equipament
                .FirstOrDefaultAsync(m => m.Id == id);
            if (equipament == null)
            {
                return NotFound();
            }

            return View(equipament);
        }

        // GET: Equipaments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Equipaments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,TypeEquipament,Status,Created_at,Updated_at")] Equipament equipament)
        {
            if (ModelState.IsValid)
            {
                _context.Add(equipament);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(equipament);
        }

        // GET: Equipaments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipament = await _context.Equipament.FindAsync(id);
            if (equipament == null)
            {
                return NotFound();
            }
            return View(equipament);
        }

        // POST: Equipaments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,TypeEquipament,Status,Created_at,Updated_at")] Equipament equipament)
        {
            if (id != equipament.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(equipament);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EquipamentExists(equipament.Id))
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
            return View(equipament);
        }

        // GET: Equipaments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipament = await _context.Equipament
                .FirstOrDefaultAsync(m => m.Id == id);
            if (equipament == null)
            {
                return NotFound();
            }

            return View(equipament);
        }

        // POST: Equipaments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var equipament = await _context.Equipament.FindAsync(id);
            _context.Equipament.Remove(equipament);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EquipamentExists(int id)
        {
            return _context.Equipament.Any(e => e.Id == id);
        }
    }
}
