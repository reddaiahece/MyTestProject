using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Models;

public partial class TestDbContext : DbContext
{
    public TestDbContext()
    {
    }

    public TestDbContext(DbContextOptions<TestDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<School> Schools { get; set; } = null!;

    public virtual DbSet<Student> Students { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DGLAP934\\SQLEXPRESS;Database=TestDB;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<School>(entity =>
        {
            entity.Property(e => e.Id).HasColumnOrder(0);
            entity.Property(e => e.SchoolName)
                .HasColumnOrder(1)
                .HasColumnName("School_Name");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasIndex(e => e.SchoolId, "IX_FK_SchoolStudent");

            entity.Property(e => e.StudentId)
                .HasColumnOrder(0)
                .HasColumnName("Student_ID");
            entity.Property(e => e.SchoolId).HasColumnOrder(2);
            entity.Property(e => e.StudentName)
                .HasColumnOrder(1)
                .HasColumnName("Student_Name");

            entity.HasOne(d => d.School).WithMany(p => p.Students)
                .HasForeignKey(d => d.SchoolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SchoolStudent");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
