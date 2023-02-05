using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Cong_agile_sm22.DomainClass;

#nullable disable

namespace Cong_agile_sm22.Context
{
    public partial class FpolyDBContext : DbContext
    {
        public FpolyDBContext()
        {
        }

        public FpolyDBContext(DbContextOptions<FpolyDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chucvu> Chucvus { get; set; }
        public virtual DbSet<Cthd> Cthds { get; set; }
        public virtual DbSet<Giohang> Giohangs { get; set; }
        public virtual DbSet<Giohangct> Giohangcts { get; set; }
        public virtual DbSet<Hoadon> Hoadons { get; set; }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }
        public virtual DbSet<Nhanvien> Nhanviens { get; set; }
        public virtual DbSet<Sp> Sps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=CONGPC;Initial Catalog=Agile_sm22;Persist Security Info=True;User ID=cong_agile;Password=1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Chucvu>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Macv).IsUnicode(false);
            });

            modelBuilder.Entity<Cthd>(entity =>
            {
                entity.HasKey(e => new { e.Idhd, e.Idsp })
                    .HasName("pk");

                entity.HasOne(d => d.IdhdNavigation)
                    .WithMany(p => p.Cthds)
                    .HasForeignKey(d => d.Idhd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__cthd__idhd__412EB0B6");

                entity.HasOne(d => d.IdspNavigation)
                    .WithMany(p => p.Cthds)
                    .HasForeignKey(d => d.Idsp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__cthd__idsp__4222D4EF");
            });

            modelBuilder.Entity<Giohang>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Sdtngnhan).IsUnicode(false);

                entity.Property(e => e.Trangthai).IsUnicode(false);

                entity.HasOne(d => d.IdkhNavigation)
                    .WithMany(p => p.Giohangs)
                    .HasForeignKey(d => d.Idkh)
                    .HasConstraintName("FK__giohang__idkh__44FF419A");

                entity.HasOne(d => d.IdnvNavigation)
                    .WithMany(p => p.Giohangs)
                    .HasForeignKey(d => d.Idnv)
                    .HasConstraintName("FK__giohang__idnv__45F365D3");
            });

            modelBuilder.Entity<Giohangct>(entity =>
            {
                entity.HasOne(d => d.IdgiohangNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idgiohang)
                    .HasConstraintName("FK__giohangct__idgio__47DBAE45");

                entity.HasOne(d => d.IdspNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idsp)
                    .HasConstraintName("FK__giohangct__idsp__48CFD27E");
            });

            modelBuilder.Entity<Hoadon>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Mahd).IsUnicode(false);

                entity.Property(e => e.Sdtngnhan).IsUnicode(false);

                entity.HasOne(d => d.IdkhNavigation)
                    .WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.Idkh)
                    .HasConstraintName("FK__hoadon__idkh__3D5E1FD2");

                entity.HasOne(d => d.IdnvNavigation)
                    .WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.Idnv)
                    .HasConstraintName("FK__hoadon__idnv__3E52440B");
            });

            modelBuilder.Entity<Khachhang>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Makh).IsUnicode(false);

                entity.Property(e => e.Sdt).IsUnicode(false);
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Manv).IsUnicode(false);

                entity.Property(e => e.Sdt).IsUnicode(false);

                entity.HasOne(d => d.IdcvNavigation)
                    .WithMany(p => p.Nhanviens)
                    .HasForeignKey(d => d.Idcv)
                    .HasConstraintName("FK__nhanvien__idcv__36B12243");
            });

            modelBuilder.Entity<Sp>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Masp).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
