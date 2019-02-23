using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EnglishEducomics.Models;

namespace EnglishEducomics.Controllers
{
    public class ObjectivesController : Controller
    {
        private readonly EnglishEducomicsContext _context;

        public ObjectivesController(EnglishEducomicsContext context)
        {
            _context = context;
        }

        // GET: Objectives
        public async Task<IActionResult> Index()
        {
            return View(await _context.Objective.ToListAsync());
        }

        // GET: Objectives/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var objective = await _context.Objective
                .FirstOrDefaultAsync(m => m.ID == id);
            if (objective == null)
            {
                return NotFound();
            }

            return View(objective);
        }

        // GET: Objectives/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Objectives/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,IsMastered,CourseID")] Objective objective)
        {
            if (ModelState.IsValid)
            {
                objective.ID = Guid.NewGuid();
                _context.Add(objective);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(objective);
        }

        // GET: Objectives/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var objective = await _context.Objective.FindAsync(id);
            if (objective == null)
            {
                return NotFound();
            }
            return View(objective);
        }

        // POST: Objectives/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ID,Name,IsMastered,CourseID")] Objective objective)
        {
            if (id != objective.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(objective);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ObjectiveExists(objective.ID))
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
            return View(objective);
        }

        // GET: Objectives/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var objective = await _context.Objective
                .FirstOrDefaultAsync(m => m.ID == id);
            if (objective == null)
            {
                return NotFound();
            }

            return View(objective);
        }

        // POST: Objectives/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var objective = await _context.Objective.FindAsync(id);
            _context.Objective.Remove(objective);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ObjectiveExists(Guid id)
        {
            return _context.Objective.Any(e => e.ID == id);
        }
    }
}
