using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication2.Models
{
    public partial class HallContext : DbContext
    {
        public HallContext()
        {
        }

        public HallContext(DbContextOptions<HallContext> abc)
            : base(abc)
        {
        }

        public virtual DbSet<Cinema> Cinema { get; set; }
        public virtual DbSet<Movie> Movie { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=FATIMA-SHAKEEL;Database=Hall;Trusted_Connection=True; User ID=sa; Password=fatima;");
            }
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cinema>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.HallNo)
                    .HasColumnName("Hall_No")
                    .HasMaxLength(50);

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Owner).HasMaxLength(50);
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Actor).HasMaxLength(50);

                entity.Property(e => e.Actress).HasMaxLength(50);

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.Director).HasMaxLength(50);

                entity.Property(e => e.Language).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Producer).HasMaxLength(50);

                entity.Property(e => e.ReleaseDate)
                    .HasColumnName("Release_Date")
                    .HasMaxLength(50);

                entity.Property(e => e.Writer).HasMaxLength(50);
            });
        }
    }
}
