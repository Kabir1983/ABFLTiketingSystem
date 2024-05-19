using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ABFL.TicketSystemApp.Models;

public partial class AkijScmsdbContext : DbContext
{
    public AkijScmsdbContext()
    {
    }

    public AkijScmsdbContext(DbContextOptions<AkijScmsdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AddDailyMistake> AddDailyMistakes { get; set; }

    public virtual DbSet<SetMistakeType> SetMistakeTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=123.200.7.37;Database=AkijSCMSDB;User ID=sa;Password=ABlock***###; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AddDailyMistake>(entity =>
        {
            entity.ToTable("ADD_DailyMistake");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AreaId).HasColumnName("AreaID");
            entity.Property(e => e.AttachmentUrl).HasMaxLength(250);
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.ItofficerId).HasColumnName("ITOfficerID");
            entity.Property(e => e.ItofficerName)
                .HasMaxLength(100)
                .HasColumnName("ITOfficerName");
            entity.Property(e => e.ItofficerPhoneNo)
                .HasMaxLength(50)
                .HasColumnName("ITOfficerPhoneNo");
            entity.Property(e => e.MistakeReason).HasMaxLength(500);
            entity.Property(e => e.MistakeTypeId).HasColumnName("MistakeTypeID");
            entity.Property(e => e.ResPersonId).HasColumnName("ResPersonID");
            entity.Property(e => e.ResPersonName).HasMaxLength(50);
            entity.Property(e => e.ResPhoneNo).HasMaxLength(50);
            entity.Property(e => e.SoleDepotId).HasColumnName("SoleDepotID");
            entity.Property(e => e.SolutionGuideLine).HasMaxLength(500);
            entity.Property(e => e.UpdateAt).HasColumnType("datetime");

            entity.HasOne(d => d.MistakeType).WithMany(p => p.AddDailyMistakes)
                .HasForeignKey(d => d.MistakeTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ADD_DailyMistake_SET_MistakeType");
        });

        modelBuilder.Entity<SetMistakeType>(entity =>
        {
            entity.ToTable("SET_MistakeType");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TypeName).HasMaxLength(100);
        });
        modelBuilder.HasSequence("BanKPK").StartsAt(104L);
        modelBuilder.HasSequence("OrderDetailPK").StartsAt(9032582L);
        modelBuilder.HasSequence("OrderDetailPointPK").StartsAt(3333671L);
        modelBuilder.HasSequence("OrderPK").StartsAt(8114188L);
        modelBuilder.HasSequence("OrderPointPK").StartsAt(646600L);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
