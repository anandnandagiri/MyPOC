using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFCore.Models
{
    public partial class WFMContext : DbContext
    {
        public WFMContext()
        {
        }

        public WFMContext(DbContextOptions<WFMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EmpUserInfo> EmpUserInfo { get; set; }
        public virtual DbSet<EmpUtilization> EmpUtilization { get; set; }
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=WFM;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          

            modelBuilder.Entity<EmpUserInfo>(entity =>
            {
                entity.HasIndex(e => e.EmpID)
                    .HasName("UQ__EmpUserI__AF2DBA78FD205A64")
                    .IsUnique();

                entity.Property(e => e.AccessType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpLogin)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isactive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Location)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Process)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportAccess)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubProcess)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SupervisorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeamName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmpUtilization>(entity =>
            {
                entity.Property(e => e.ActiveWindow).HasMaxLength(500);

                entity.Property(e => e.Attendance).HasMaxLength(50);

                entity.Property(e => e.CurrentTask).HasMaxLength(50);

                entity.Property(e => e.LeaveCreated).HasMaxLength(50);

                entity.Property(e => e.Leavedate).HasColumnType("datetime");

                entity.Property(e => e.LoggedDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LoggedIN).HasColumnType("datetime");

                entity.Property(e => e.LoggedOut).HasColumnType("datetime");

                entity.Property(e => e.SecondStatus).HasMaxLength(20);

                entity.Property(e => e.SubTeam).HasMaxLength(25);

                entity.Property(e => e.Timesheet).HasMaxLength(5);

                entity.Property(e => e.Version)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.EmpUtilization)
                    .HasPrincipalKey(p => p.EmpID)
                    .HasForeignKey(d => d.EmpID)
                    .HasConstraintName("FK_EmpUtilization_EmpUserInfo");
            });
                                                

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
