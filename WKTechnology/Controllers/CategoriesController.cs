using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WKTechnology.Data;
using WKTechnology.Models;

namespace WKTechnology.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly Context _context;

        public CategoriesController(Context context)
        {
            _context = context;
        }
      
        // GET: Categories
        public async Task<IActionResult> Index()
        {

             return _context.Categories != null ?    
                          View(await _context.Categories.ToListAsync()) :
                          Problem("Entity set 'Context.Categories'  is null.");
        }

        // GET: Categories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var categories = await _context.Categories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categories == null)
            {
                return NotFound();
            }

            return View(categories);
        }

        // GET: Categories/Create
        public IActionResult Create()
        {
            var list = new SelectList(_context.Categories.ToList(), "Id", "NameCategory");
            ViewBag.List = list;
            return View();
        }

        // POST: Categories/Create  
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameCategory")] Categories categories)
        {                         
                _context.Add(categories);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
          
                return View(categories);
        }

        // GET: Categories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }
            
            var categories = await _context.Categories.FindAsync(id);

            if (categories == null)
            {
                return NotFound();
            }
            return View(categories);
        }

        // POST: Categories/Edit/5    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NameCategory")] Categories categories)
        {
            if (id != categories.Id)
            {
                return NotFound();
            }
          
                try
                {
                    _context.Update(categories);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoriesExists(categories.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            
            return View(categories);
        }

        // GET: Categories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Categories == null)
            {
                return NotFound();
            }

            var categories = await _context.Categories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categories == null)
            {
                return NotFound();
            }

            return View(categories);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Categories == null)
            {
                return Problem("Entity set 'Context.Categories'  is null.");
            }
            var categories = await _context.Categories.FindAsync(id);
            if (categories != null)
            {
                _context.Categories.Remove(categories);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoriesExists(int id)
        {
          return (_context.Categories?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
