using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Q3_Spring23.Models
{
    public partial class Other_Spring23Context : DbContext
    {
        public Other_Spring23Context()
        {
        }

        public Other_Spring23Context(DbContextOptions<Other_Spring23Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<SchoolYear> SchoolYears { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(config.GetConnectionString("ApConStr"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>(entity =>
            {
                entity.ToTable("Class");

                entity.Property(e => e.Grade).HasColumnName("grade");

                entity.Property(e => e.Room)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("room");

                entity.Property(e => e.Schoolyear).HasColumnName("schoolyear");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.SchoolyearNavigation)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.Schoolyear)
                    .HasConstraintName("FK__Class__schoolyea__3A81B327");
            });

            modelBuilder.Entity<SchoolYear>(entity =>
            {
                entity.ToTable("SchoolYear");

                entity.Property(e => e.Enddate)
                    .HasColumnType("date")
                    .HasColumnName("enddate");

                entity.Property(e => e.Startdate)
                    .HasColumnType("date")
                    .HasColumnName("startdate");

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.Dob).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.Sex).HasMaxLength(10);

                entity.HasMany(d => d.Classes)
                    .WithMany(p => p.Students)
                    .UsingEntity<Dictionary<string, object>>(
                        "StudentClass",
                        l => l.HasOne<Class>().WithMany().HasForeignKey("ClassId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Student_C__class__3E52440B"),
                        r => r.HasOne<Student>().WithMany().HasForeignKey("StudentId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Student_C__stude__3D5E1FD2"),
                        j =>
                        {
                            j.HasKey("StudentId", "ClassId").HasName("PK__Student___BA46A57B1C6BD5F7");

                            j.ToTable("Student_Class");

                            j.IndexerProperty<int>("StudentId").HasColumnName("studentId");

                            j.IndexerProperty<int>("ClassId").HasColumnName("classId");
                        });
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
