/*
-- Project: Quản lý đăng kí
-- 1. Phạm Minh Hiển - 15211TT2203
-- 2. Phạm Vũ Hoàng Phượng - 15211TT2295
-- 3. Lê Cẩm Tú - 15211TT2114
*/

/* Create Database*/
go
create Database db_quanlydangki

-- Su dung db_quanlydangki
go
use db_quanlydangki

 -- Create table Khoa
 create table khoa 
 (
	makhoa nvarchar(6)  not null primary key ,
	tenkhoa nvarchar(100) not null,
 )
 go 

-- Create table nganhhoc
 create table nganhhoc(
	manganh nvarchar(6) primary key not null,
	tennganh nvarchar(100) not null,
	makhoa nvarchar(6),
	foreign key (makhoa) references khoa(makhoa)
)
go

-- Create table monhoc
create table monhoc(
	mamonhoc nvarchar(15) primary key not null,
	tenmonhoc nvarchar(255) not null,
	sotinchi int not null,
	loaimon varchar(100) not null , 
	soluongsv int,
	phonghoc nvarchar(10) not null ,
	manganh nvarchar(6) not null ,
	makhoa nvarchar(6) not null,
	foreign key (manganh) references nganhhoc(manganh),
	foreign key (makhoa) references khoa(makhoa)
)
go

-- Create table giangvien
create table giangvien(
	magiangvien nvarchar(15) primary key not null,
	matkhau nvarchar(10) not null,
	tengiangvien nvarchar(100) not null,
	ngaysinh date not null,
	gioitinh nvarchar(5) not null,
	sodienthoai int not null,
	socmnd int not null,
	diachi nvarchar(255),
	email nvarchar(100) not null,
	makhoa nvarchar(6) not null,
	manganh nvarchar(6) not null,
	foreign key (manganh) references nganhhoc(manganh),
	foreign key (makhoa) references khoa(makhoa)
)
go

-- Create table lop
create table lop 
(
	malop nvarchar (10) not null primary key ,
	tenlop nvarchar(50) not null ,
	manganh nvarchar(6) not null,
	makhoa nvarchar(6) not null ,
	gvchunhiem nvarchar (15) not null,
	foreign key (manganh) references nganhhoc(manganh),
	foreign key (makhoa) references khoa(makhoa),
	foreign key (gvchunhiem) references giangvien(magiangvien)
)
go

-- Create table sinhvien 
create table sinhvien(
	masinhvien nvarchar(15) primary key not null,
	matkhau nvarchar(10) not null,
	tensinhvien nvarchar(100) not null,
	ngaysinh date not null,
	gioitinh nvarchar(3)check(gioitinh = 'Nam' OR gioitinh ='Nu') not null,
	sodienthoai int not null,
	socmnd int not null,
	diachi nvarchar(255) not null ,
	email nvarchar(100) not null,
	malop nvarchar (10) not null ,
	manganh nvarchar(6) not null,
	makhoa nvarchar(6) not null,
	foreign key (malop) references lop(malop),
	foreign key (manganh) references nganhhoc(manganh),
	foreign key (makhoa) references khoa(makhoa)
)
go

-- Create table phancong
create table phancong(
	maphancong int  primary key not null identity(1,1),
	magiangvien nvarchar(15),
	mamonhoc nvarchar(15),
	foreign key (magiangvien) references giangvien(magiangvien),
	foreign key (mamonhoc) references monhoc(mamonhoc)
)
go

-- Create table diem
create table diem
(
	makhoa nvarchar(6) not null,
	manganh nvarchar(6) not null,
	mamonhoc nvarchar(15) not null,
	masinhvien nvarchar(15) not null ,
	diem int not null,
	primary key (makhoa, manganh , mamonhoc, masinhvien) ,
	foreign key (makhoa) references khoa(makhoa),
	foreign key (mamonhoc) references monhoc(mamonhoc),
	foreign key (masinhvien) references sinhvien(masinhvien),
	foreign key (manganh) references nganhhoc(manganh)
)
go

create table chucvu(
	MaCV int  primary key not null identity(1,1),
	TenCV nvarchar(100)
)
go

create table nguoidung(
	id int  primary key not null identity(1,1),
	MaCV int,
	TenDangNhap nvarchar(50),
	MatKhau nvarchar(32),
	Foreign key(MaCV) References chucvu(MaCV)
);

/*******************************************************/

/*Lay tat ca sinh vien */
create proc layDanhSachSinhVien
as
begin
	select sv.masinhvien as 'Mã Sinh Viên',
		   sv.tensinhvien as 'Họ Tên',
		   sv.ngaysinh as 'Ngày Sinh',
		   sv.gioitinh as 'Giới Tính',
		   sv.sodienthoai as 'Số Điện Thoại',
		   sv.socmnd as 'Số CMND',
		   sv.diachi as 'Địa Chỉ',
		   sv.email as 'Email',
		   lop.malop as 'Mã Lớp',
		   nganhhoc.manganh as 'Mã Ngành',
		   khoa.makhoa as 'Mã Khoa'
	from sinhvien as sv inner join nganhhoc on sv.manganh=nganhhoc.manganh
						inner join lop on sv.malop = lop.malop
						inner join khoa on sv.makhoa = khoa.makhoa;
end;

go
create proc layDanhSachSinhVienBangMaNganh(@maNganh nvarchar(6))
as
begin
	select sv.masinhvien as 'Mã Sinh Viên',
		   sv.tensinhvien as 'Họ Tên',
		   sv.ngaysinh as 'Ngày Sinh',
		   sv.gioitinh as 'Giới Tính',
		   sv.sodienthoai as 'Số Điện Thoại',
		   sv.socmnd as 'Số CMND',
		   sv.DiaChi as 'Địa Chỉ',
		   sv.email as 'Email',
		   lop.malop as 'Mã Lớp',
		   nganhhoc.manganh as 'Mã Ngành',
		   khoa.makhoa as 'Mã Khoa'
	from sinhvien as sv inner join nganhhoc on sv.manganh=nganhhoc.manganh
						inner join lop on sv.malop = lop.malop
						inner join khoa on sv.makhoa = khoa.makhoa
	where nganhhoc.manganh=@maNganh
end;


/*Xoa sinh vien*/
go
create proc xoaSinhVien(@maSV nvarchar(15))
as
begin
	delete from sinhvien where masinhvien=@maSV
end;


/*Thêm sinh viên */
go
create proc themSinhVien(@MaSV nvarchar(15), @matkhau nvarchar(10), @hoTenSV nvarchar(100), @ngaySinh date, @gioiTinh nvarchar(3), @SDT int, @soCMND int, @diaChi nvarchar(255), @email nvarchar(100), @malop nvarchar(10), @manganh nvarchar(6), @makhoa nvarchar(6))
as
begin
	insert into sinhvien values(@MaSV, @matkhau, @hoTenSV, @ngaySinh, @gioiTinh, @SDT, @soCMND, @diaChi, @email, @malop, @maNganh, @makhoa);
end;
/*Lay tat nganh hoc */
go
create proc layDanhSachNganhHoc
as
begin
	select * from nganhhoc
end;





