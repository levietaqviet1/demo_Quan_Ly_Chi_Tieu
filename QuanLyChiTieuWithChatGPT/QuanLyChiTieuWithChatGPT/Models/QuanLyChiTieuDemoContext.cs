using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace QuanLyChiTieuWithChatGPT.Models
{
    public partial class QuanLyChiTieuDemoContext : DbContext
    {
        public QuanLyChiTieuDemoContext()
        {
        }

        public QuanLyChiTieuDemoContext(DbContextOptions<QuanLyChiTieuDemoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTieu> ChiTieus { get; set; } = null!;
        public virtual DbSet<GiaoDich> GiaoDiches { get; set; } = null!;
        public virtual DbSet<LoaiChiTieu> LoaiChiTieus { get; set; } = null!;
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server =localhost; database = QuanLyChiTieuDemo;uid=sa;pwd=123;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTieu>(entity =>
            {
                entity.HasKey(e => e.MaChiTieu)
                    .HasName("PK__ChiTieu__CDF0A1178D4611FD");

                entity.ToTable("ChiTieu");

                entity.Property(e => e.MoTa).HasMaxLength(200);

                entity.Property(e => e.NgayChi).HasColumnType("date");

                entity.Property(e => e.SoTien).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.MaLoaiNavigation)
                    .WithMany(p => p.ChiTieus)
                    .HasForeignKey(d => d.MaLoai)
                    .HasConstraintName("FK__ChiTieu__MaLoai__267ABA7A");
            });

            modelBuilder.Entity<GiaoDich>(entity =>
            {
                entity.HasKey(e => e.MaGiaoDich)
                    .HasName("PK__GiaoDich__0A2A24EBC631DEFF");

                entity.ToTable("GiaoDich");

                entity.Property(e => e.MaGiaoDich).ValueGeneratedNever();

                entity.Property(e => e.GhiChu).HasMaxLength(200);

                entity.Property(e => e.NgayGiaoDich).HasColumnType("date");

                entity.Property(e => e.SoTien).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.MaChiTieuNavigation)
                    .WithMany(p => p.GiaoDiches)
                    .HasForeignKey(d => d.MaChiTieu)
                    .HasConstraintName("FK__GiaoDich__MaChiT__2C3393D0");

                entity.HasOne(d => d.MaTaiKhoanNavigation)
                    .WithMany(p => p.GiaoDiches)
                    .HasForeignKey(d => d.MaTaiKhoan)
                    .HasConstraintName("FK__GiaoDich__MaTaiK__2B3F6F97");
            });

            modelBuilder.Entity<LoaiChiTieu>(entity =>
            {
                entity.HasKey(e => e.MaLoai)
                    .HasName("PK__LoaiChiT__730A5759BC4EFC2C");

                entity.ToTable("LoaiChiTieu");

                entity.Property(e => e.MaLoai).ValueGeneratedNever();

                entity.Property(e => e.TenLoai).HasMaxLength(50);
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.HasKey(e => e.MaTaiKhoan)
                    .HasName("PK__TaiKhoan__AD7C65293ED6C9F7");

                entity.ToTable("TaiKhoan");

                entity.Property(e => e.MaTaiKhoan).ValueGeneratedNever();

                entity.Property(e => e.SoDuTaiKhoan).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TenTaiKhoan).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
