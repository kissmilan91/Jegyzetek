using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace _20220316_EF_Radiok_DB_First.Models
{
    public partial class radioadokContext : DbContext
    {
        public radioadokContext()
        {
        }

        public radioadokContext(DbContextOptions<radioadokContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Kioszta> Kiosztas { get; set; }
        public virtual DbSet<Regio> Regios { get; set; }
        public virtual DbSet<Telepule> Telepules { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=radioadok;uid=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.21-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            modelBuilder.Entity<Kioszta>(entity =>
            {
                entity.HasKey(e => e.Azon)
                    .HasName("PRIMARY");

                entity.ToTable("kiosztas");

                entity.HasIndex(e => e.Adohely, "adohely");

                entity.Property(e => e.Azon)
                    .HasColumnType("int(11)")
                    .HasColumnName("azon");

                entity.Property(e => e.Adohely)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("adohely");

                entity.Property(e => e.Cim)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("cim");

                entity.Property(e => e.Csatorna)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("csatorna");

                entity.Property(e => e.Frekvencia).HasColumnName("frekvencia");

                entity.Property(e => e.Teljesitmeny).HasColumnName("teljesitmeny");

                entity.HasOne(d => d.AdohelyNavigation)
                    .WithMany(p => p.Kioszta)
                    .HasForeignKey(d => d.Adohely)
                    .HasConstraintName("kiosztas_ibfk_1");
            });

            modelBuilder.Entity<Regio>(entity =>
            {
                entity.HasKey(e => e.Megye)
                    .HasName("PRIMARY");

                entity.ToTable("regio");

                entity.Property(e => e.Megye)
                    .HasMaxLength(100)
                    .HasColumnName("megye");

                entity.Property(e => e.Nev)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("nev");
            });

            modelBuilder.Entity<Telepule>(entity =>
            {
                entity.HasKey(e => e.Nev)
                    .HasName("PRIMARY");

                entity.ToTable("telepules");

                entity.HasIndex(e => e.Megye, "megye");

                entity.Property(e => e.Nev)
                    .HasMaxLength(100)
                    .HasColumnName("nev");

                entity.Property(e => e.Megye)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("megye");

                entity.HasOne(d => d.MegyeNavigation)
                    .WithMany(p => p.Telepules)
                    .HasForeignKey(d => d.Megye)
                    .HasConstraintName("telepules_ibfk_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
