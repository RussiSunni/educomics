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
    public class AnswersController : Controller
    {
        private readonly EnglishEducomicsContext _context;

        public AnswersController(EnglishEducomicsContext context)
        {
            _context = context;
        }

        // GET: Answers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Answer.ToListAsync());
        }

        // GET: Answers/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var answer = await _context.Answer
                .FirstOrDefaultAsync(m => m.ID == id);
            if (answer == null)
            {
                return NotFound();
            }

            return View(answer);
        }

        // GET: Answers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Answers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Content,IsCorrectOption,QuestionID")] Answer answer)
        {
            if (ModelState.IsValid)
            {
                answer.ID = Guid.NewGuid();
                _context.Add(answer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(answer);
        }

        // GET: Answers/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var answer = await _context.Answer.FindAsync(id);
            if (answer == null)
            {
                return NotFound();
            }
            return View(answer);
        }

        // POST: Answers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ID,Content,IsCorrectOption,QuestionID")] Answer answer)
        {
            if (id != answer.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(answer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnswerExists(answer.ID))
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
            return View(answer);
        }

        // GET: Answers/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var answer = await _context.Answer
                .FirstOrDefaultAsync(m => m.ID == id);
            if (answer == null)
            {
                return NotFound();
            }

            return View(answer);
        }

        // POST: Answers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var answer = await _context.Answer.FindAsync(id);
            _context.Answer.Remove(answer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnswerExists(Guid id)
        {
            return _context.Answer.Any(e => e.ID == id);
        }
    }
}
