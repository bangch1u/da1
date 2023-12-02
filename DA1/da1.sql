create database DBDA1
go
use DBDA1
go
create table Sach
(
	barCodeSach varchar(13) not null primary key,
	tenSach nvarchar(100),
	soLuong int,
	giaTien money,
	namXuatBan date
);
go
create table TacGia
(
	idTacGia varchar(13) not null primary key,
	hoTen nvarchar(100),
	ngaySinh date
);
go
create table TacGiaSach
(
	barCodeSach varchar(13) references Sach(barCodeSach),
	idTacGia varchar(13) references TacGia(idTacGia),
	moTa varchar(10),
	PRIMARY KEY (barCodeSach, idTacGia)
);
go
create table TheLoai
(
	idTheLoai varchar(13) primary key,
	tenTheLoai nvarchar(50),
	viTriKeSach varchar(10)
);
go
create table ChiTietTheLoai
(
	idTheLoai varchar(13) references TheLoai(idTheLoai),
	barCodeSach varchar(13) references Sach(barCodeSach),
	moTa varchar(10),
	primary key (idTheLoai, barCodeSach)
);
go
create table NhanVien
(
	idNhanVien varchar(10) primary key,
	hoTen nvarchar(50),
	gioiTinh bit,
	soDienThoai varchar(10),
	diaChi nvarchar(150),
	ngaySinh Date,
	email varchar(100),
	trangThai int ---1: ho?t �?ng, 0: ngh? vi?c
);
go
create table TaiKhoan
(
	idTaiKhoan uniqueidentifier primary key,
	userName varchar(50),
	[passWord] varchar(50),
	idNhanVien varchar(10) unique references NhanVien(idNhanVien),
	[role] bit ----1: nh�n vi�n, ---2: qu?n l?
);
go
create table TheThuVien 
(
	idTheThuVien varchar(10) primary key,
	hoTen nvarchar(50),
	soDienThoai varchar(10), 
	diemUyTin int,
	trangThai int, ---1: ho?t �?ng|| 0: kh�a th? || 2: ng�ng ho?t �?ng||
);
go
create table LichSuNap
(
	idLichSu int identity(1,1) primary key,
	soTienNap money,
	diemCongUyTin int,
	ngayNap date,
	idTheThuVien varchar(10) references TheThuVien(idTheThuVien)
);
go
create table MucDiemCong
(
	id int identity(1,1) primary key,
	mucTien money,
	soDiemCong int
);
go
create table PhieuMuon
(	
	idPhieuMuon varchar(10) primary key,
	idTheThuVien varchar(10) unique references TheThuVien(idTheThuVien),
	tongSachMuon int, 
	ngayTaoPhieu date,
	trangThai bit --0: full s�ch kh�ng th? m�?n|| 1: c?n c� th? m�?n s�ch
);
go
create table NhaXuatBan
(
	idNXB varchar(10) primary key,
	tenNXB nvarchar(100),
	diaChi nvarchar(150),
	soDienThoai nvarchar(10)
);
go
create table SachChiTiet
(
	barCodeMaSach varchar(13) primary key,
	barCodeSach varchar(13) references Sach(barCodeSach),
	tinhTrangSach nvarchar(50),
	lanTaiBan int,
	kichCo varchar(20),
	namTaiBan int,
	diemUyTinMin int,
	trangThai int,
	idNXB varchar(10) references NhaXuatBan(idNXB)
);
go
create table PhieuMuonChiTiet
(
	idPhieuMuonChiTiet int identity(1,1) primary key,
	idPhieuMuon varchar(10) references PhieuMuon(idPhieuMuon),
	idNhanVien varchar(10) references NhanVien(idNhanVien),
	barCodeMaSach varchar(13) references SachChiTiet(barCodeMaSach),
	soLuongSach int,
	ngayMuonSach date,
	ngayTraSach date,
	soLanGiaHan int,
	trangThai int ---0: m�?n th�nh c�ng, -1: m�?n th?t b?i, 2: gia h?n th�nh c�ng, 3: qu� s? l?n gia h?n
);
go
create table PhieuTraSach
(
	idPhieuTra varchar(10) primary key,
	soLuongTra int,
	thoiGianTraSach date,
	tinhTrangSach nvarchar(50),
	barCodeMaSach varchar(13) references SachChiTiet(barCodeMaSach),
	idPhieuMuon varchar(10) references PhieuMuon(idPhieuMuon),
	trangThai bit
);
go
create table ThietHai
(
	idThietHai varchar(10) primary key,
	tenThietHai nvarchar(50),
	diemTruUyTin int
);
go
create table ThietHaiChiTiet
(
	idThietHai varchar(10) references ThietHai(idThietHai),
	idPhieuTra varchar(10) references PhieuTraSach(idPhieuTra),
	moTa nvarchar(100),
	primary key ( idThietHai, idPhieuTra)
);

go