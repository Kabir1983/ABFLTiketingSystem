using Microsoft.EntityFrameworkCore;
using ResumeManager.Models;

namespace ResumeManager.Data
{
    public class ResumeDbContext : DbContext
    {


        public ResumeDbContext(DbContextOptions<ResumeDbContext> options) : base(options) { }

        public virtual DbSet<Applicant> Applicants { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<City> Cities { get; set; }

    }
}
