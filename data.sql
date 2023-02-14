-- CREATE DATABASE QuanLyChiTieuDemo;
GO
USE QuanLyChiTieuDemo;
CREATE TABLE LoaiChiTieu (
    MaLoai int PRIMARY KEY IDENTITY,
    TenLoai nvarchar(50)
);
GO
CREATE TABLE ChiTieu (
    MaChiTieu int PRIMARY KEY IDENTITY,
    MaLoai int FOREIGN KEY REFERENCES LoaiChiTieu(MaLoai),
    SoTien decimal(18, 2),
    NgayChi date,
    MoTa nvarchar(200)
);
GO
CREATE TABLE TaiKhoan (
    MaTaiKhoan int PRIMARY KEY IDENTITY,
    TenTaiKhoan nvarchar(50),
    SoDuTaiKhoan decimal(18, 2)
);
GO
CREATE TABLE GiaoDich (
    MaGiaoDich int PRIMARY KEY IDENTITY,
    MaTaiKhoan int FOREIGN KEY REFERENCES TaiKhoan(MaTaiKhoan),
    MaChiTieu int FOREIGN KEY REFERENCES ChiTieu(MaChiTieu),
    NgayGiaoDich date,
    SoTien decimal(18, 2),
    GhiChu nvarchar(200)
);
GO