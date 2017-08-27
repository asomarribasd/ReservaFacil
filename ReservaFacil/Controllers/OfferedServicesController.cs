using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ReservaFacil.Data;
using ReservaFacil.Models;

namespace ReservaFacil.Controllers
{
    public class OfferedServicesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OfferedServicesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: OfferedServices
        public async Task<IActionResult> Index()
        {
            return View(await _context.OfferedService.ToListAsync());
        }

        // GET: OfferedServices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offeredService = await _context.OfferedService
                .SingleOrDefaultAsync(m => m.Id == id);
            if (offeredService == null)
            {
                return NotFound();
            }

            return View(offeredService);
        }

        // GET: OfferedServices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OfferedServices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ServiceName,Description,BasePrice")] OfferedService offeredService)
        {
            if (ModelState.IsValid)
            {
                _context.Add(offeredService);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(offeredService);
        }

        // GET: OfferedServices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offeredService = await _context.OfferedService.SingleOrDefaultAsync(m => m.Id == id);
            if (offeredService == null)
            {
                return NotFound();
            }
            return View(offeredService);
        }

        // POST: OfferedServices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ServiceName,Description,BasePrice")] OfferedService offeredService)
        {
            if (id != offeredService.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(offeredService);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OfferedServiceExists(offeredService.Id))
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
            return View(offeredService);
        }

        // GET: OfferedServices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offeredService = await _context.OfferedService
                .SingleOrDefaultAsync(m => m.Id == id);
            if (offeredService == null)
            {
                return NotFound();
            }

            return View(offeredService);
        }

        // POST: OfferedServices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var offeredService = await _context.OfferedService.SingleOrDefaultAsync(m => m.Id == id);
            _context.OfferedService.Remove(offeredService);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OfferedServiceExists(int id)
        {
            return _context.OfferedService.Any(e => e.Id == id);
        }
    }
}
