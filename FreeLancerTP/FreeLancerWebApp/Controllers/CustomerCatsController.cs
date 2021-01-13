using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FreeLancerWebApp.Data;
using FreeLancerWebApp.Models;

namespace FreeLancerWebApp.Controllers
{
    public class CustomerCatsController : Controller
    {
        private readonly FreeLancerDbContext _context;

        public CustomerCatsController(FreeLancerDbContext context)
        {
            _context = context;
        }

        // GET: CustomerCats
        public async Task<IActionResult> Index()
        {
            return View(await _context.CustomersCats.ToListAsync());
        }

        // GET: CustomerCats/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerCat = await _context.CustomersCats
                .FirstOrDefaultAsync(m => m.ID == id);
            if (customerCat == null)
            {
                return NotFound();
            }

            return View(customerCat);
        }

        // GET: CustomerCats/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CustomerCats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Description")] CustomerCat customerCat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customerCat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customerCat);
        }

        // GET: CustomerCats/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerCat = await _context.CustomersCats.FindAsync(id);
            if (customerCat == null)
            {
                return NotFound();
            }
            return View(customerCat);
        }

        // POST: CustomerCats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Description")] CustomerCat customerCat)
        {
            if (id != customerCat.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerCat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerCatExists(customerCat.ID))
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
            return View(customerCat);
        }

        // GET: CustomerCats/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerCat = await _context.CustomersCats
                .FirstOrDefaultAsync(m => m.ID == id);
            if (customerCat == null)
            {
                return NotFound();
            }

            return View(customerCat);
        }

        // POST: CustomerCats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customerCat = await _context.CustomersCats.FindAsync(id);
            _context.CustomersCats.Remove(customerCat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerCatExists(int id)
        {
            return _context.CustomersCats.Any(e => e.ID == id);
        }
    }
}
