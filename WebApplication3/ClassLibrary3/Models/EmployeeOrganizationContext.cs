using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDB.Models;

public partial class EmployeeOrganizationContext : DbContext
{
    public EmployeeOrganizationContext()
    {
    }

    public EmployeeOrganizationContext(DbContextOptions<EmployeeOrganizationContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Branch> Branches { get; set; } = null!;

    public virtual DbSet<InnerJoinDatum> InnerJoinData { get; set; } = null!;

    public virtual DbSet<Organization> Organizations { get; set; } = null!;

    public virtual DbSet<OrganizationMain> OrganizationMains { get; set; } = null!;

    public virtual DbSet<Student> Students { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DGLAP934\\SQLEXPRESS;Database=Employee_Organization;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Branch>(entity =>
        //{
        //    entity.HasKey(e => e.BranchId).HasName("PK__Branch__12CEB041C494B19A");

        //    entity.HasIndex(e => e.BranchId, "Index_Name");

        //    entity.Property(e => e.BranchId)
        //        .ValueGeneratedNever()
        //        .HasColumnOrder(0)
        //        .HasColumnName("Branch_ID");
        //    entity.Property(e => e.BranchName)
        //        .HasMaxLength(255)
        //        .IsUnicode(false)
        //        .HasColumnOrder(1)
        //        .HasColumnName("Branch_Name");
        //    entity.Property(e => e.OrganizationId)
        //        .HasColumnOrder(2)
        //        .HasColumnName("Organization_ID");
        //});

        //modelBuilder.Entity<InnerJoinDatum>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToView("INNER_JOIN_DATA");

        //    entity.Property(e => e.BranchName)
        //        .HasMaxLength(255)
        //        .IsUnicode(false)
        //        .HasColumnOrder(2)
        //        .HasColumnName("Branch_Name");
        //    entity.Property(e => e.OrganizationId)
        //        .HasColumnOrder(0)
        //        .HasColumnName("Organization_ID");
        //    entity.Property(e => e.OrganizationName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnOrder(1)
        //        .HasColumnName("Organization_NAME");
        //});

        //modelBuilder.Entity<Organization>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("Organization");

        //    entity.Property(e => e.OrganizationId)
        //        .ValueGeneratedOnAdd()
        //        .HasColumnOrder(0)
        //        .HasColumnName("Organization_ID");
        //    entity.Property(e => e.OrganizationName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnOrder(1)
        //        .HasColumnName("Organization_Name");
        //});

        //modelBuilder.Entity<OrganizationMain>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("Organization_Main");

        //    entity.Property(e => e.OrganizationId)
        //        .ValueGeneratedOnAdd()
        //        .HasColumnOrder(0)
        //        .HasColumnName("Organization_ID");
        //    entity.Property(e => e.OrganizationName)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnOrder(1)
        //        .HasColumnName("Organization_Name");
        //});

        //modelBuilder.Entity<Student>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__Student__3214EC079A9591B7");

        //    entity.ToTable("Student");

        //    entity.Property(e => e.Id).HasColumnOrder(0);
        //    entity.Property(e => e.Email)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnOrder(2);
        //    entity.Property(e => e.Mobile)
        //        .HasMaxLength(50)
        //        .IsUnicode(false)
        //        .HasColumnOrder(3);
        //    entity.Property(e => e.Name)
        //        .HasMaxLength(100)
        //        .IsUnicode(false)
        //        .HasColumnOrder(1);
        //});

       // OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
