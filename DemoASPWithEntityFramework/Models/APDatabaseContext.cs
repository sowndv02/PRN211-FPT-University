using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DemoASPWithEntityFramework.Models
{
    public partial class APDatabaseContext : DbContext
    {
        public APDatabaseContext()
        {
        }

        public APDatabaseContext(DbContextOptions<APDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<CourseSchedule> CourseSchedules { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Instructor> Instructors { get; set; } = null!;
        public virtual DbSet<RollCallBook> RollCallBooks { get; set; } = null!;
        public virtual DbSet<Room> Rooms { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Subject> Subjects { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=COOKIE\\MONSTER;database=APDatabase;uid=sa;password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("COURSES");

                entity.Property(e => e.CampusId).HasColumnName("CampusID");

                entity.Property(e => e.CourseCode).HasMaxLength(50);

                entity.Property(e => e.CourseDescription).HasMaxLength(300);

                entity.HasOne(d => d.Instructor)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.InstructorId)
                    .HasConstraintName("FK_COURSES_INSTRUCTORS");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COURSES_SUBJECTS");

                entity.HasMany(d => d.Students)
                    .WithMany(p => p.Courses)
                    .UsingEntity<Dictionary<string, object>>(
                        "StudentCourse",
                        l => l.HasOne<Student>().WithMany().HasForeignKey("StudentId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_STUDENT_COURSE_STUDENTS"),
                        r => r.HasOne<Course>().WithMany().HasForeignKey("CourseId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_STUDENT_COURSE_COURSES"),
                        j =>
                        {
                            j.HasKey("CourseId", "StudentId");

                            j.ToTable("STUDENT_COURSE");
                        });
            });

            modelBuilder.Entity<CourseSchedule>(entity =>
            {
                entity.HasKey(e => e.TeachingScheduleId)
                    .HasName("PK_TEACHING_SCHEDULES");

                entity.ToTable("COURSE_SCHEDULES");

                entity.Property(e => e.Description).HasMaxLength(300);

                entity.Property(e => e.TeachingDate).HasColumnType("date");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseSchedules)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_COURSE_SCHEDULES_COURSES");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.CourseSchedules)
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("FK_COURSE_SCHEDULES_ROOMS");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("DEPARTMENTS");

                entity.Property(e => e.DepartmentName).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(300);
            });

            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.ToTable("INSTRUCTORS");

                entity.Property(e => e.InstructorFirstName).HasMaxLength(50);

                entity.Property(e => e.InstructorLastName).HasMaxLength(50);

                entity.Property(e => e.InstructorMidName).HasMaxLength(50);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Instructors)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_INSTRUCTORS_DEPARTMENTS");
            });

            modelBuilder.Entity<RollCallBook>(entity =>
            {
                entity.ToTable("ROLL_CALL_BOOKS");

                entity.Property(e => e.Comment).HasMaxLength(300);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.RollCallBooks)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_ROLL_CALL_BOOKS_STUDENTS");

                entity.HasOne(d => d.TeachingSchedule)
                    .WithMany(p => p.RollCallBooks)
                    .HasForeignKey(d => d.TeachingScheduleId)
                    .HasConstraintName("FK_ROLL_CALL_BOOKS_COURSE_SCHEDULES");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.ToTable("ROOMS");

                entity.Property(e => e.RoomId).ValueGeneratedNever();

                entity.Property(e => e.Cap2acity).HasColumnName("CAP2acity");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.RoomCode).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("STUDENTS");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MidName).HasMaxLength(50);

                entity.Property(e => e.Roll)
                    .HasMaxLength(50)
                    .HasColumnName("Roll#");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.ToTable("SUBJECTS");

                entity.Property(e => e.SubjectCode).HasMaxLength(50);

                entity.Property(e => e.SubjectName).HasMaxLength(50);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Subjects)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_SUBJECTS_DEPARTMENTS");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
