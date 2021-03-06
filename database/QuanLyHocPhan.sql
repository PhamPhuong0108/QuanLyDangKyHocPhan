/*CREATE DATABASE db_QuanLyDangKyHocPhan
GO

/**Tao bang **/
CREATE TABLE nganhhoc(
	MaNganh NVARCHAR(15) PRIMARY KEY NOT NULL,
	TenNganh NVARCHAR(100) NOT NULL
);

GO

CREATE TABLE sinhvien(
	MaSinhVien NVARCHAR(15) PRIMARY KEY NOT NULL,
	TenSinhVien NVARCHAR(100) NOT NULL,
	NgaySinh DATE NOT NULL,
	GioiTinh NVARCHAR(5) NOT NULL,
	DiaChi NVARCHAR(255),
	SoDT NVARCHAR(15) NOT NULL,
	MaNganh NVARCHAR(15),
	FOREIGN KEY (MaNganh) REFERENCES nganhhoc(MaNganh)
);

GO

CREATE TABLE giangvien(
	MaGiangVien NVARCHAR(15) PRIMARY KEY NOT NULL,
	TenGiangVien NVARCHAR(100) NOT NULL,
	NgaySinh DATE NOT NULL,
	GioiTinh NVARCHAR(5) NOT NULL,
	DiaChi NVARCHAR(255),
	SoDT NVARCHAR(15) NOT NULL,
	MaNganh NVARCHAR(15),
	FOREIGN KEY (MaNganh) REFERENCES nganhhoc(MaNganh)
);

GO

CREATE TABLE monhoc(
	MaMonHoc NVARCHAR(15) PRIMARY KEY NOT NULL,
	TenMonHoc NVARCHAR(255) NOT NULL,
	SoTinChi INT NOT NULL,
	SoLuongSV INT,
	PhongHoc NVARCHAR(10),
	MaNganh NVARCHAR(15),
	FOREIGN KEY (MaNganh) REFERENCES nganhhoc(MaNganh)
);

GO

CREATE TABLE phancong(
	MaPhanCong INT  PRIMARY KEY NOT NULL IDENTITY(1,1),
	MaGiangVien NVARCHAR(15),
	MaMonHoc NVARCHAR(15),
	FOREIGN KEY (MaGiangVien) REFERENCES giangvien(MaGiangVien),
	FOREIGN KEY (MaMonHoc) REFERENCES monhoc(MaMonHoc)
);

GO

CREATE TABLE quyenhan(
	MaQuyenHan INT  PRIMARY KEY NOT NULL IDENTITY(1,1),
	TenQuyenHan nvarchar(100)
);

CREATE TABLE nguoidung(
	MaDangNhap INT  PRIMARY KEY NOT NULL IDENTITY(1,1),
	TenDangNhap NVARCHAR(50),
	MatKhau NVARCHAR(32),
	MaQuyenHan INT,
	Foreign key(MaQuyenHan) References quyenhan(MaQuyenHan)
);*/

/* STORED PROCEDURES */
create proc layDanhSachQuyenHan
as
begin
	select * from quyenhan
end;




