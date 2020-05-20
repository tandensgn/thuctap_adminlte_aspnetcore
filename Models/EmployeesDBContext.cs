using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AdminLTEASPNETEmployees.Models
{
    public partial class EmployeesDBContext : DbContext
    {
        public EmployeesDBContext()
        {
        }

        public EmployeesDBContext(DbContextOptions<EmployeesDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employees> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=TANDENSGN\\SQLEXPRESS;Database=EmployeesDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK__Employee__AFB3EC0DB0CF9599");

                entity.Property(e => e.EmpId).HasColumnName("empId");

                entity.Property(e => e.EmpAddress)
                    .IsRequired()
                    .HasColumnName("empAddress")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmpAvatar)
                    .IsRequired()
                    .HasColumnName("empAvatar")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmpEmail)
                    .IsRequired()
                    .HasColumnName("empEmail")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmpFullname)
                    .IsRequired()
                    .HasColumnName("empFullname")
                    .HasMaxLength(255);

                entity.Property(e => e.EmpPass)
                    .IsRequired()
                    .HasColumnName("empPass")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmpPhone)
                    .IsRequired()
                    .HasColumnName("empPhone")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmpRole)
                    .IsRequired()
                    .HasColumnName("empRole")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmpStatus)
                    .IsRequired()
                    .HasColumnName("empStatus")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmpUsername)
                    .IsRequired()
                    .HasColumnName("empUsername")
                    .HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
