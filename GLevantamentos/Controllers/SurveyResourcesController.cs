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
    public class SurveyResourcesController : Controller
    {
        private readonly GLevantamentosContext _context;

        public SurveyResourcesController(GLevantamentosContext context)
        {
            _context = context;
        }

        // GET: SurveyResources
        public async Task<IActionResult> Index()
        {
            var gLevantamentosContext = _context.SurveyResources.Include(s => s.Blocks).Include(s => s.Equipaments).Include(s => s.Floorings).Include(s => s.Surveys);
            return View(await gLevantamentosContext.ToListAsync());
        }

        // GET: SurveyResources/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surveyResources = await _context.SurveyResources
                .Include(s => s.Blocks)
                .Include(s => s.Equipaments)
                .Include(s => s.Floorings)
                .Include(s => s.Surveys)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (surveyResources == null)
            {
                return NotFound();
            }

            return View(surveyResources);
        }

        // GET: SurveyResources/Create
        public IActionResult Create()
        {
            ViewData["BlockId"] = new SelectList(_context.Block, "Id", "Id");
            ViewData["EquipamentId"] = new SelectList(_context.Equipament, "Id", "Id");
            ViewData["FlooringId"] = new SelectList(_context.Flooring, "Id", "Id");
            ViewData["SurveyId"] = new SelectList(_context.Survey, "Id", "Id");
            return View();
        }

        // POST: SurveyResources/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SurveyId,BlockId,FlooringId,EquipamentId")] SurveyResources surveyResources)
        {
            if (ModelState.IsValid)
            {
                _context.Add(surveyResources);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BlockId"] = new SelectList(_context.Block, "Id", "Id", surveyResources.BlockId);
            ViewData["EquipamentId"] = new SelectList(_context.Equipament, "Id", "Id", surveyResources.EquipamentId);
            ViewData["FlooringId"] = new SelectList(_context.Flooring, "Id", "Id", surveyResources.FlooringId);
            ViewData["SurveyId"] = new SelectList(_context.Survey, "Id", "Id", surveyResources.SurveyId);
            return View(surveyResources);
        }

        // GET: SurveyResources/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surveyResources = await _context.SurveyResources.FindAsync(id);
            if (surveyResources == null)
            {
                return NotFound();
            }
            ViewData["BlockId"] = new SelectList(_context.Block, "Id", "Id", surveyResources.BlockId);
            ViewData["EquipamentId"] = new SelectList(_context.Equipament, "Id", "Id", surveyResources.EquipamentId);
            ViewData["FlooringId"] = new SelectList(_context.Flooring, "Id", "Id", surveyResources.FlooringId);
            ViewData["SurveyId"] = new SelectList(_context.Survey, "Id", "Id", surveyResources.SurveyId);
            return View(surveyResources);
        }

        // POST: SurveyResources/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SurveyId,BlockId,FlooringId,EquipamentId")] SurveyResources surveyResources)
        {
            if (id != surveyResources.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(surveyResources);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SurveyResourcesExists(surveyResources.Id))
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
            ViewData["BlockId"] = new SelectList(_context.Block, "Id", "Id", surveyResources.BlockId);
            ViewData["EquipamentId"] = new SelectList(_context.Equipament, "Id", "Id", surveyResources.EquipamentId);
            ViewData["FlooringId"] = new SelectList(_context.Flooring, "Id", "Id", surveyResources.FlooringId);
            ViewData["SurveyId"] = new SelectList(_context.Survey, "Id", "Id", surveyResources.SurveyId);
            return View(surveyResources);
        }

        // GET: SurveyResources/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var surveyResources = await _context.SurveyResources
                .Include(s => s.Blocks)
                .Include(s => s.Equipaments)
                .Include(s => s.Floorings)
                .Include(s => s.Surveys)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (surveyResources == null)
            {
                return NotFound();
            }

            return View(surveyResources);
        }

        // POST: SurveyResources/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var surveyResources = await _context.SurveyResources.FindAsync(id);
            _context.SurveyResources.Remove(surveyResources);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SurveyResourcesExists(int id)
        {
            return _context.SurveyResources.Any(e => e.Id == id);
        }
    }
}
