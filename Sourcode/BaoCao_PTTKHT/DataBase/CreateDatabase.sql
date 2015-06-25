create database [PlaceHolder]
go
USE [PlaceHolder]
GO

create table NAMHOC
(
	MaNamHoc int primary key,
	NamHoc nvarchar(9) not null,
)

create table HOCKY
(
	MaHocKy int primary key,
	MaNamHoc int FOREIGN KEY REFERENCES NamHoc(MaNamHoc) ON DELETE CASCADE,
	HocKy nvarchar(10) not null,
	NgayBatDau datetime,
	NgayKetThuc datetime,
)

create table KHOA
(
	MaKhoa varchar(10) primary key,
	TenKhoa nvarchar(30) not null,
)

create table LOP
(
	MaLop varchar(10) primary key,
	TenLop nvarchar(30) not null,
	MaKhoa varchar(10) FOREIGN KEY REFERENCES Khoa(MaKhoa) ON DELETE CASCADE,
	MaNamHoc int FOREIGN KEY REFERENCES NamHoc(MaNamHoc) ON DELETE CASCADE,
)

create table SINHVIEN
(
	MSSV varchar(10) primary key,
	TenSinhVien nvarchar(50) not null,
	NgaySinh smalldatetime not null,
	DiaChi nvarchar(100) not null,
	GioiTinh varchar(5) not null,
	DienThoai varchar(12) not null,
	MaLop varchar(10) FOREIGN KEY REFERENCES LOP(MaLop) ON DELETE CASCADE,
)

create table GIANGVIEN
(
	MaGiangVien varchar(10) primary key,
	TenGiangVien nvarchar(50) not null,
	NgaySinh smalldatetime not null,
	DiaChi nvarchar(100) not null,
	GioiTinh varchar(5) not null,
	DienThoai nvarchar(50) null,
	ChucVu nvarchar(50) null,
	TrinhDo nvarchar(50) null,
	MaKhoa varchar(10) FOREIGN KEY REFERENCES KHOA(MaKhoa) ON DELETE CASCADE,
)

create table MONHOC
(
	MaMonHoc varchar(10) primary key,
	TenMonHoc nvarchar(30) not null,
	SoTinChi int not null,
	MaKhoa varchar(10) FOREIGN KEY REFERENCES KHOA(MaKhoa) ON DELETE CASCADE,
)

create table MONTIENQUYET
(
	MaMTQ int primary key,
	MaMonHoc varchar(10) FOREIGN KEY REFERENCES MONHOC(MaMonHoc) ON DELETE CASCADE,
	MaMonTienQuyet varchar(10) FOREIGN KEY REFERENCES MONHOC(MaMonHoc),
)

create table LOPHOC
(
	MaLopHoc int primary key,
	TenLopHoc nvarchar(50) not null,
	Tiet varchar(50) null,
	Thu nvarchar(30) null,
	MaMonHoc varchar(10) FOREIGN KEY REFERENCES MONHOC(MaMonHoc) ON DELETE CASCADE,
	MaHocKy int FOREIGN KEY REFERENCES HOCKY(MaHocKy),
)

create table GIANGDAY
(
	MaGiangDay int primary key,
	MaLopHoc int FOREIGN KEY REFERENCES LOPHOC(MaLopHoc) ON DELETE CASCADE,
	MaGiangVien varchar(10) FOREIGN KEY REFERENCES GIANGVIEN(MaGiangVien),
)

create table CHITIETLOPHOC
(
	MaCTLopHoc int primary key,
	MaLopHoc int FOREIGN KEY REFERENCES LOPHOC(MaLopHoc),
	MSSV varchar(10) FOREIGN KEY REFERENCES SINHVIEN(MSSV) ON DELETE CASCADE,
)

create table BANGDIEM
(
	MaBangDiem int primary key,
	MaLopHoc int FOREIGN KEY REFERENCES LOPHOC(MaLopHoc) ON DELETE CASCADE,
)

create table DIEM
(
	MaDiem int primary key,
	MaBangDiem int FOREIGN KEY REFERENCES BANGDIEM(MaBangDiem) ON DELETE CASCADE,
	SoDiem float not null,
	HeSo int not null,
)

create table TAIKHOAN
(
	TenTaiKhoan varchar(30) primary key,
	MatKhau varchar(100) not null,
	TenNguoiDung nvarchar(50),
	LoaiTaiKhoan int not null,
)

create table BODEM
(
	TenBang varchar(30) primary key,
	SoDem int,
)

GO
CREATE TRIGGER TRIGGER_MTQ ON MONTIENQUYET
FOR INSERT
AS
	UPDATE BODEM
	SET SoDem = SoDem + 1
	WHERE TenBang = 'MONTIENQUYET'

GO
CREATE TRIGGER TRIGGER_NH ON NAMHOC
FOR INSERT
AS
	UPDATE BODEM
	SET SoDem = SoDem + 1
	WHERE TenBang = 'NAMHOC'

GO
CREATE TRIGGER TRIGGER_HK ON HOCKY
FOR INSERT
AS
	UPDATE BODEM
	SET SoDem = SoDem + 1
	WHERE TenBang = 'HOCKY'

GO
CREATE TRIGGER TRIGGER_BD ON BANGDIEM
FOR INSERT
AS
	UPDATE BODEM
	SET SoDem = SoDem + 1
	WHERE TenBang = 'BANGDIEM'

GO
CREATE TRIGGER TRIGGER_D ON DIEM
FOR INSERT
AS
	UPDATE BODEM
	SET SoDem = SoDem + 1
	WHERE TenBang = 'DIEM'

GO
CREATE TRIGGER TRIGGER_GD ON GIANGDAY
FOR INSERT
AS
	UPDATE BODEM
	SET SoDem = SoDem + 1
	WHERE TenBang = 'GIANGDAY'

GO
CREATE TRIGGER TRIGGER_CTLH ON CHITIETLOPHOC
FOR INSERT
AS
	UPDATE BODEM
	SET SoDem = SoDem + 1
	WHERE TenBang = 'CHITIETLOPHOC'

GO
CREATE TRIGGER TRIGGER_LH ON LOPHOC
FOR INSERT
AS
	UPDATE BODEM
	SET SoDem = SoDem + 1
	WHERE TenBang = 'LOPHOC'

GO
CREATE TRIGGER TRIGGER_GV ON GIANGVIEN
FOR INSERT
AS
	UPDATE BODEM
	SET SoDem = SoDem + 1
	WHERE TenBang = 'GIANGVIEN'

GO
insert into BODEM values('MONTIENQUYET', 0)
insert into BODEM values('NAMHOC', 0)
insert into BODEM values('HOCKY', 0)
insert into BODEM values('BANGDIEM', 0)
insert into BODEM values('DIEM', 0)
insert into BODEM values('GIANGDAY', 0)
insert into BODEM values('CHITIETLOPHOC', 0)
insert into BODEM values('LOPHOC', 0)
insert into BODEM values('GIANGVIEN', 0)