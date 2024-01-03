﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EMS_Full_Stack_App_Requirement_project.Models
{
    public partial class EmpDeptDbContext : DbContext
    {
        public EmpDeptDbContext()
        {
        }

        public EmpDeptDbContext(DbContextOptions<EmpDeptDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-7E5H6QT; database=EmpDeptDb; trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DepCode)
                    .HasName("PK__Departme__7BBEB2281000B2A3");

                entity.ToTable("Department");

                entity.Property(e => e.DepCode).ValueGeneratedNever();

                entity.Property(e => e.DepName).HasMaxLength(50);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpCode)
                    .HasName("PK__Employee__7DA847CB45E1BD9D");

                entity.ToTable("Employee");

                entity.Property(e => e.EmpCode).ValueGeneratedNever();

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.DepartmentCode).HasColumnName("Department_Code");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EmpName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
