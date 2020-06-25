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

        public virtual DbSet<EmpRole> EmpRole { get; set; }
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
            modelBuilder.Entity<EmpRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__EmpRole__CD98462AA05B8DBE");

                entity.Property(e => e.RoleId)
                    .HasColumnName("roleId")
                    .ValueGeneratedNever();

                entity.Property(e => e.RoleName)
                    .HasColumnName("roleName")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK__Employee__AFB3EC0DC3E55E4C");

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

                entity.Property(e => e.EmpSalt)
                    .HasColumnName("empSalt")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmpStatus)
                    .HasColumnName("empStatus")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmpUsername)
                    .HasColumnName("empUsername")
                    .HasMaxLength(255);

                entity.Property(e => e.RoleId).HasColumnName("roleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_EmployeesDb_EmpRole");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
