using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace quanly.Models
{
    public partial class quanlyquanContext : DbContext
    {
        public quanlyquanContext()
        {
        }

        public quanlyquanContext(DbContextOptions<quanlyquanContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bangluong> Bangluongs { get; set; } = null!;
        public virtual DbSet<Chamcong> Chamcongs { get; set; } = null!;
        public virtual DbSet<Chucvu> Chucvus { get; set; } = null!;
        public virtual DbSet<Nhanvien> Nhanviens { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-DOAE4G1\\DANG;Initial Catalog=quanlyquan;User ID=sa;Password=Dangnguyen1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bangluong>(entity =>
            {
                entity.ToTable("bangluong");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Emailnv)
                    .HasMaxLength(50)
                    .HasColumnName("emailnv");

                entity.Property(e => e.Idnv).HasColumnName("idnv");

                entity.Property(e => e.Mucluongnv).HasColumnName("mucluongnv");

                entity.Property(e => e.Namsinhnv)
                    .HasColumnType("date")
                    .HasColumnName("namsinhnv");

                entity.Property(e => e.Ngaytra)
                    .HasColumnType("date")
                    .HasColumnName("ngaytra");

                entity.Property(e => e.Sdtnv)
                    .HasMaxLength(50)
                    .HasColumnName("sdtnv");

                entity.Property(e => e.Taikhoangnv)
                    .HasMaxLength(50)
                    .HasColumnName("taikhoangnv");

                entity.Property(e => e.Tennv)
                    .HasMaxLength(100)
                    .HasColumnName("tennv");

                entity.Property(e => e.Thoigianglam).HasColumnName("thoigianglam");

                entity.Property(e => e.Tiengluong).HasColumnName("tiengluong");
            });

            modelBuilder.Entity<Chamcong>(entity =>
            {
                entity.ToTable("chamcong");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Checkin)
                    .HasColumnType("datetime")
                    .HasColumnName("checkin");

                entity.Property(e => e.Chekout)
                    .HasColumnType("datetime")
                    .HasColumnName("chekout");

                entity.Property(e => e.IdNv).HasColumnName("id_nv");
            });

            modelBuilder.Entity<Chucvu>(entity =>
            {
                entity.HasKey(e => e.IdCv);

                entity.ToTable("chucvu");

                entity.Property(e => e.IdCv).HasColumnName("IdCV");

                entity.Property(e => e.TenCv)
                    .HasMaxLength(50)
                    .HasColumnName("tenCV");
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.HasKey(e => e.Idnv)
                    .HasName("PK__Nhanvien__9DB74554C0C1732F");

                entity.ToTable("Nhanvien");

                entity.Property(e => e.Idnv).HasColumnName("idnv");

                entity.Property(e => e.Chucvu).HasColumnName("chucvu");

                entity.Property(e => e.Gmail)
                    .HasMaxLength(50)
                    .HasColumnName("gmail");

                entity.Property(e => e.HoTen)
                    .HasMaxLength(100)
                    .HasColumnName("ho_ten");

                entity.Property(e => e.Matkhau)
                    .HasMaxLength(50)
                    .HasColumnName("matkhau");

                entity.Property(e => e.Mucluong).HasColumnName("mucluong");

                entity.Property(e => e.Namsinh)
                    .HasColumnType("date")
                    .HasColumnName("namsinh");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .HasColumnName("sdt")
                    .IsFixedLength();

                entity.Property(e => e.Taikhoan)
                    .HasMaxLength(50)
                    .HasColumnName("taikhoan");

                entity.Property(e => e.Thoigian).HasColumnName("thoigian");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
