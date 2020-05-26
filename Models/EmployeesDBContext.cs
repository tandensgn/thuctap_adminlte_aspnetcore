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
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=EmployeesDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>(entity =>
            {

                entity.ToTable("EMPLOYEES");

                entity.HasKey(e => e.EmpId)
                    .HasName("PK__Employee__AFB3EC0DB4E402AC");

                entity.Property(e => e.EmpId).HasColumnName("empId");

                entity.Property(e => e.EmpAddress)
                    .HasColumnName("empAddress")
                    .HasMaxLength(255);

                entity.Property(e => e.EmpAvatar)
                    .HasColumnName("empAvatar")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmpEmail)
                    .HasColumnName("empEmail")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmpFullname)
                    .HasColumnName("empFullname")
                    .HasMaxLength(255);

                entity.Property(e => e.EmpPass)
                    .HasColumnName("empPass")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmpPhone)
                    .HasColumnName("empPhone")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmpRole)
                    .HasColumnName("empRole")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmpStatus)
                    .HasColumnName("empStatus")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmpUsername)
                    .HasColumnName("empUsername")
                    .HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
