using ResumeManager.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeManager.BLL.Services
{
    public interface IApplicantService
    {
        Task<List<Applicant>> GetApplicants();
        Task<Applicant> GetApplicantById(int? Id);
        Task<int> Create(Applicant applicant);
    }
}
