using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ABFL.TicketSystemApp.Models;

namespace ABFL.TicketSystemApp.Controllers
{
    public class MistakeTypeController : Controller
    {
        private readonly AkijScmsdbContext _context;

        public MistakeTypeController(AkijScmsdbContext context)
        {
            _context = context;
        }

        // GET: MistakeType
        public async Task<IActionResult> Index()
        {
            return View(await _context.SetMistakeTypes.ToListAsync());
        }

        // GET: MistakeType/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var setMistakeType = await _context.SetMistakeTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (setMistakeType == null)
            {
                return NotFound();
            }

            return View(setMistakeType);
        }

        // GET: MistakeType/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MistakeType/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SetMistakeType setMistakeType)
        {
            if (setMistakeType != null)
            {
                int maxID = _context.SetMistakeTypes.Max(m => (int?)m.Id) ?? 0;
                setMistakeType.Id = maxID + 1;
                setMistakeType.IsActive = true;
                setMistakeType.LastUpdate = DateTime.Now;
            }

            if (ModelState.IsValid)
            {
                _context.Add(setMistakeType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(setMistakeType);
        }

        // GET: MistakeType/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var setMistakeType = await _context.SetMistakeTypes.FindAsync(id);
            if (setMistakeType == null)
            {
                return NotFound();
            }
            return View(setMistakeType);
        }

        // POST: MistakeType/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, SetMistakeType setMistakeType)
        {
            if (id != setMistakeType.Id)
            {
                return NotFound();
            }

            setMistakeType.LastUpdate= DateTime.Now;

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(setMistakeType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SetMistakeTypeExists(setMistakeType.Id))
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
            return View(setMistakeType);
        }

        // GET: MistakeType/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var setMistakeType = await _context.SetMistakeTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (setMistakeType == null)
            {
                return NotFound();
            }

            return View(setMistakeType);
        }

        // POST: MistakeType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var setMistakeType = await _context.SetMistakeTypes.FindAsync(id);
            if (setMistakeType != null)
            {
                _context.SetMistakeTypes.Remove(setMistakeType);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SetMistakeTypeExists(int id)
        {
            return _context.SetMistakeTypes.Any(e => e.Id == id);
        }
    }
}
