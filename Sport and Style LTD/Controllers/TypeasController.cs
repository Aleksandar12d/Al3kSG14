using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sport_and_Style_LTD.Data;

namespace Sport_and_Style_LTD.Controllers
{
    public class TypeasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TypeasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Typeas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Typea.ToListAsync());
        }

        // GET: Typeas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typea = await _context.Typea
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typea == null)
            {
                return NotFound();
            }

            return View(typea);
        }

        // GET: Typeas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Typeas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TypeaName")] Typea typea)
        {
            if (ModelState.IsValid)
            {
                _context.Add(typea);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(typea);
        }

        // GET: Typeas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typea = await _context.Typea.FindAsync(id);
            if (typea == null)
            {
                return NotFound();
            }
            return View(typea);
        }

        // POST: Typeas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TypeaName")] Typea typea)
        {
            if (id != typea.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(typea);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypeaExists(typea.Id))
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
            return View(typea);
        }

        // GET: Typeas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typea = await _context.Typea
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typea == null)
            {
                return NotFound();
            }

            return View(typea);
        }

        // POST: Typeas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var typea = await _context.Typea.FindAsync(id);
            _context.Typea.Remove(typea);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TypeaExists(int id)
        {
            return _context.Typea.Any(e => e.Id == id);
        }
    }
}
