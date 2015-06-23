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

)

create table KHOA
(
	MaKhoa int primary key,
	TenKhoa nvarchar(30) not null,
)

create table LOP
(
	MaLop int primary key,
	TenLop nvarchar(30) not null,
	MaKhoa int FOREIGN KEY REFERENCES Khoa(MaKhoa) ON DELETE CASCADE,
)

create table SINHVIEN
(
	MSSV varchar(10) primary key,
	TenSinhVien nvarchar(50) not null,
	NgaySinh smalldatetime not null,
	DiaChi nvarchar(100) not null,
	GioiTinh varchar(5) not null,
	DienThoai varchar(12) not null,
	MaLop int FOREIGN KEY REFERENCES LOP(MaLop) ON DELETE CASCADE,
)

create table GIANGVIEN
(
	MaGiangVien varchar(10) primary key,
	TenGiangVien nvarchar(50) not null,
	NgaySinh smalldatetime not null,
	DiaChi nvarchar(100) not null,
	GioiTinh varchar(5) not null,
	ChucVu varchar(50) not null,
	MaKhoa int FOREIGN KEY REFERENCES KHOA(MaKhoa) ON DELETE CASCADE,
)

create table MONHOC
(
	MaMonHoc varchar(10) primary key,
	TenMonHoc nvarchar(30) not null,
	SoTinChi int not null,
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
	Tiet int null,
	Thu nvarchar(30) null,
	MaMonHoc varchar(10) FOREIGN KEY REFERENCES MONHOC(MaMonHoc) ON DELETE CASCADE,
	MaHocKy int FOREIGN KEY REFERENCES HOCKY(MaHocKy),
)

create table GIANGDAY
(
	MaGiangDay int primary key,
	MaLopHoc int FOREIGN KEY REFERENCES LOPHOC(MaLopHoc) ON DELETE CASCADE,
	MaGiangVien varchar(10) FOREIGN KEY REFERENCES GIANGVIEN(MaGiangVien) ON DELETE CASCADE,
)

create table CHITIETLOPHOC
(
	MaCTLopHoc int primary key,
	MaLopHoc int FOREIGN KEY REFERENCES LOPHOC(MaLopHoc),
	MSSV varchar(10) FOREIGN KEY REFERENCES SINHVIEN(MSSV) ON DELETE CASCADE,
)

create table DIEM
(
	MaDiem int primary key,
	SoDiem float not null,
	HeSo int not null,
)

create table BANGDIEM
(
	MaBangDiem int primary key,
	MaLopHoc int FOREIGN KEY REFERENCES LOPHOC(MaLopHoc) ON DELETE CASCADE,
)

create table CHITIETBANGDIEM
(
	MaCTBangDiem int primary key,
	MaBangDiem int FOREIGN KEY REFERENCES BANGDIEM(MaBangDiem) ON DELETE CASCADE,
	MaDiem int FOREIGN KEY REFERENCES DIEM(MaDiem) ON DELETE CASCADE,
)

create table TAIKHOAN
(
	TenTaiKhoan varchar(30) primary key,
	MatKhau varchar(100) not null,
	TenNguoiDung nvarchar(50),
	LoaiTaiKhoan int not null,
)

