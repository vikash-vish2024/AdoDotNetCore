using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CodeFirstApporachCore.Models;

namespace CodeFirstApporachCore.Controllers
{
    public class MedsDescriptionsController : Controller
    {
        private readonly MedicineStoreContext _context;

        public MedsDescriptionsController(MedicineStoreContext context)
        {
            _context = context;
        }

        // GET: MedsDescriptions
        public async Task<IActionResult> Index()
        {
            return View(await _context.medsDescriptions.ToListAsync());
        }

        // GET: MedsDescriptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medsDescription = await _context.medsDescriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (medsDescription == null)
            {
                return NotFound();
            }

            return View(medsDescription);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Manufacturer,Price,ManufacturingDate,ExpiryDate")] MedsDescription medsDescription)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medsDescription);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(medsDescription);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medsDescription = await _context.medsDescriptions.FindAsync(id);
            if (medsDescription == null)
            {
                return NotFound();
            }
            return View(medsDescription);
        }

 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Manufacturer,Price,ManufacturingDate,ExpiryDate")] MedsDescription medsDescription)
        {
            if (id != medsDescription.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medsDescription);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedsDescriptionExists(medsDescription.Id))
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
            return View(medsDescription);
        }

        // GET: MedsDescriptions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medsDescription = await _context.medsDescriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (medsDescription == null)
            {
                return NotFound();
            }

            return View(medsDescription);
        }

        // POST: MedsDescriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var medsDescription = await _context.medsDescriptions.FindAsync(id);
            if (medsDescription != null)
            {
                _context.medsDescriptions.Remove(medsDescription);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedsDescriptionExists(int id)
        {
            return _context.medsDescriptions.Any(e => e.Id == id);
        }
    }
}
