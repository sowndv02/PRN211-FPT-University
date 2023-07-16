using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace Q1_Spring23.Models
{
    public partial class Q1_SP23Context : DbContext
    {
        public Q1_SP23Context()
        {
        }

        public Q1_SP23Context(DbContextOptions<Q1_SP23Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Button> Buttons { get; set; } = null!;

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
            modelBuilder.Entity<Button>(entity =>
            {
                entity.Property(e => e.Color)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Text)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
