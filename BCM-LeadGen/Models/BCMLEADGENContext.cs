using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BCM_LeadGen.Models
{
    public partial class BCMLEADGENContext : DbContext
    {
        public BCMLEADGENContext()
        {
        }

        public BCMLEADGENContext(DbContextOptions<BCMLEADGENContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LeadGeneration> LeadGeneration { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=BCM-LEADGEN; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LeadGeneration>(entity =>
            {
                entity.ToTable("Lead_Generation");

                entity.Property(e => e.Branch).HasMaxLength(50);

                entity.Property(e => e.CarModel)
                    .HasColumnName("Car_Model")
                    .HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.LineId)
                    .HasColumnName("LINE_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NextCarTime)
                    .HasColumnName("Next_Car_Time")
                    .HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Surname).HasMaxLength(50);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
