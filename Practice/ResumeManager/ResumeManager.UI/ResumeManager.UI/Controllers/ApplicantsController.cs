using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ResumeManager.BLL.Services;
using ResumeManager.Models.Models;

namespace ResumeManager.UI.Controllers
{
    public class ApplicantsController : Controller
    {
        private readonly IApplicantService _applicantService = null;

        public ApplicantsController(IApplicantService applicantService)
        {
            _applicantService ??= applicantService;
        }

        // GET: Applicants
        public async Task<IActionResult> Index()
        {
            var applicants = _applicantService.GetApplicants();
            return applicants != null ? View(await applicants) : Problem("Entity set 'ResumeManagerContext.Applicants'  is null.");
        }

        // GET: Applicants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var applicant = _applicantService.GetApplicantById(id);
            if (id == null || applicant == null)
            {
                return NotFound();
            }

            return View(applicant);
        }

        // GET: Applicants/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Applicants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Applicant applicant)
        {
            int id = await _applicantService.Create(applicant);
            return id > 0 ? RedirectToAction(nameof(Index)) : Problem("Entity set 'ResumeManagerContext.Applicants'  is null.");

        }

        //// GET: Applicants/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.Applicants == null)
        //    {
        //        return NotFound();
        //    }

        //    var applicant = await _context.Applicants.FindAsync(id);
        //    if (applicant == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(applicant);
        //}

        //// POST: Applicants/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Gender,Age,Qualification,TotalExperience,PhotoUrl")] Applicant applicant)
        //{
        //    if (id != applicant.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(applicant);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!ApplicantExists(applicant.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(applicant);
        //}

        //// GET: Applicants/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.Applicants == null)
        //    {
        //        return NotFound();
        //    }

        //    var applicant = await _context.Applicants
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (applicant == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(applicant);
        //}

        //// POST: Applicants/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.Applicants == null)
        //    {
        //        return Problem("Entity set 'ResumeManagerContext.Applicants'  is null.");
        //    }
        //    var applicant = await _context.Applicants.FindAsync(id);
        //    if (applicant != null)
        //    {
        //        _context.Applicants.Remove(applicant);
        //    }

        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool ApplicantExists(int id)
        //{
        //    return (_context.Applicants?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
