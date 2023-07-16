using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Q2_P3.Models
{
    public partial class PRN292_Spr2020_B1Context : DbContext
    {
        public PRN292_Spr2020_B1Context()
        {
        }

        public PRN292_Spr2020_B1Context(DbContextOptions<PRN292_Spr2020_B1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<DailyReport> DailyReports { get; set; } = null!;
        public virtual DbSet<InfectedCase> InfectedCases { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DailyReport>(entity =>
            {
                entity.HasKey(e => new { e.Country, e.Date });

                entity.ToTable("DailyReport");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");
            });

            modelBuilder.Entity<InfectedCase>(entity =>
            {
                entity.Property(e => e.ConfirmationDate).HasColumnType("date");

                entity.Property(e => e.HistoryOfEpidemiology).HasColumnType("ntext");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Nationality).HasMaxLength(20);

                entity.Property(e => e.Province).HasMaxLength(20);

                entity.Property(e => e.TraveledFrom).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
