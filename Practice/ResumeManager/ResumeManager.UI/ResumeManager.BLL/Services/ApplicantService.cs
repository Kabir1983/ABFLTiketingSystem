using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumeManager.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeManager.BLL.Services
{
    public class ApplicantService : IApplicantService
    {
        private readonly ResumeManagerContext _context;
        public ApplicantService(ResumeManagerContext context)
        {
            _context = context;
        }
        public Task<List<Applicant>> GetApplicants()
        {
            return _context.Applicants.ToListAsync();
        }

        public Task<Applicant> GetApplicantById(int? Id)
        {
            return _context.Applicants.FirstOrDefaultAsync(m => m.Id == Id);
        }

        public async Task<int> Create(Applicant applicant)
        {
            //string uniqueFileName = GetUploadedFileName(applicant);
            //applicant.PhotoUrl = uniqueFileName;
            _context.Add(applicant);
            return await _context.SaveChangesAsync();
        }

        //private string GetUploadedFileName(Applicant applicant)
        //{
        //    string uniqueFileName = null;

        //    if (applicant.ProfilePhoto != null)
        //    {
        //        string uploadsFolder = Path.Combine(_webHost.WebRootPath, "images");
        //        uniqueFileName = Guid.NewGuid().ToString() + "_" + applicant.ProfilePhoto.FileName;
        //        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
        //        using (var fileStream = new FileStream(filePath, FileMode.Create))
        //        {
        //            applicant.ProfilePhoto.CopyTo(fileStream);
        //        }
        //    }
        //    return uniqueFileName;
        //}

        public Task<List<Experience>> GetExperiences()
        {
            return _context.Experiences.ToListAsync();
        }
        
    }
}
