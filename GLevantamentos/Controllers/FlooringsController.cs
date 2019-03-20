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
    public class FlooringsController : Controller
    {
        private readonly GLevantamentosContext _context;

        public FlooringsController(GLevantamentosContext context)
        {
            _context = context;
        }

        // GET: Floorings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Flooring.ToListAsync());
        }

        // GET: Floorings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flooring = await _context.Flooring
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flooring == null)
            {
                return NotFound();
            }

            return View(flooring);
        }

        // GET: Floorings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Floorings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,Created_at,Updated_at")] Flooring flooring)
        {
            if (ModelState.IsValid)
            {
                _context.Add(flooring);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(flooring);
        }

        // GET: Floorings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flooring = await _context.Flooring.FindAsync(id);
            if (flooring == null)
            {
                return NotFound();
            }
            return View(flooring);
        }

        // POST: Floorings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,Created_at,Updated_at")] Flooring flooring)
        {
            if (id != flooring.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flooring);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlooringExists(flooring.Id))
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
            return View(flooring);
        }

        // GET: Floorings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flooring = await _context.Flooring
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flooring == null)
            {
                return NotFound();
            }

            return View(flooring);
        }

        // POST: Floorings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var flooring = await _context.Flooring.FindAsync(id);
            _context.Flooring.Remove(flooring);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlooringExists(int id)
        {
            return _context.Flooring.Any(e => e.Id == id);
        }
    }
}
