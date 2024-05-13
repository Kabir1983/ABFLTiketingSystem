using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ResumeManager.Models.Models
{
    public partial class ResumeManagerContext : DbContext
    {
        public ResumeManagerContext()
        {
        }

        public ResumeManagerContext(DbContextOptions<ResumeManagerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Applicant> Applicants { get; set; } = null!;
        public virtual DbSet<Experience> Experiences { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-BQHFFBB;Database=ResumeManager;User Id=sa;Password=ABlock***###");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Applicant>(entity =>
            {
                entity.ToTable("Applicant");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Qualification)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Experience>(entity =>
            {
                entity.Property(e => e.ExperienceId).HasColumnName("ExperienceID");

                entity.Property(e => e.ApplicantId).HasColumnName("ApplicantID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Designation)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
