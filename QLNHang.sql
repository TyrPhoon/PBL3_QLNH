CREATE DATABASE QuanLyNhaHang1111
GO

USE QuanLyNhaHang1111

GO

CREATE TABLE BanAn
(
	idban INT IDENTITY PRIMARY KEY,
	ten NCHAR(100) NOT NULL,
	trangthai NVARCHAR(100),

)
GO
CREATE TABLE Ca
(
	idca INT IDENTITY PRIMARY KEY,
	tenca NVARCHAR(100) NOT NULL,
	giobatdau  time(7) NOT NULL,
	gioketthuc time(7) NOT NULL,
	
)
GO
CREATE TABLE NhanVien
(
	idnv INT IDENTITY PRIMARY KEY,
	tennv NVARCHAR(100) NOT NULL,
	ngaysinh NVARCHAR(100) NOT NULL ,
	diachi NVARCHAR(100) NOT NULL,
	luong INT NOT NULL,
	idca INT NOT NULL
	
	FOREIGN KEY (idca) REFERENCES dbo.Ca(idca)
)
GO

CREATE TABLE TaiKhoan
(
	--id INT IDENTITY PRIMARY KEY,
	tendangnhap NVARCHAR(100) PRIMARY KEY,
	tenhienthi NVARCHAR(100) NOT NULL ,
	matkhau NVARCHAR(1000) NOT NULL,
	vaitro INT NOT NULL,
	idnv INT ,
	FOREIGN KEY (idnv) REFERENCES dbo.NhanVien(idnv)
)
GO

CREATE TABLE DanhMucThucAn
(
	iddanhmucthucan INT IDENTITY PRIMARY KEY,
	ten NCHAR(100) NOT NULL
)
GO

CREATE TABLE ThucAn
(
	idthucan INT IDENTITY PRIMARY KEY,
	iddanhmucthucan INT NOT NULL,
	ten NCHAR(100) NOT NULL,
	dongia FLOAT NOT NULL DEFAULT 0

	FOREIGN KEY (iddanhmucthucan) REFERENCES dbo.DanhMucThucAn(iddanhmucthucan)
)
GO

CREATE TABLE HoaDon
(
	idhoadon INT IDENTITY PRIMARY KEY,
	ngayvao DATE NOT NULL DEFAULT GETDATE(),
	ngayra DATE,
	trangthai INT,
	tongtien INT,
	idnv INT NOT NULL,
    
	FOREIGN KEY (idnv) REFERENCES dbo.NhanVien(idnv)
)
CREATE TABLE BanSuDung
(
	
	idban INT NOT NULL,
	idhoadon INT NOT NULL,
    
	FOREIGN KEY (idban) REFERENCES dbo.BanAn(idban),
	FOREIGN KEY (idhoadon) REFERENCES dbo.HoaDon(idhoadon)
)

GO 

CREATE TABLE HoaDonChiTiet
(
	idhoadonchitiet INT IDENTITY PRIMARY KEY,
	idhoadon INT NOT NULL,
	idthucan INT NOT NULL,
	soluong INT NOT NULL DEFAULT 0,
	gia INT,

	FOREIGN KEY (idhoadon) REFERENCES dbo.HoaDon(idhoadon),
	FOREIGN KEY (idthucan) REFERENCES dbo.ThucAn(idthucan)
)

GO 




--ALTER TABLE dbo.Thucan ADD FOREIGN KEY (iddanhmuc) REFERENCES dbo.Danhmucthucan(id)
--ALTER TABLE dbo.HoaDon ADD FOREIGN KEY (idban) REFERENCES dbo.BanAn(id)
--ALTER TABLE dbo.HoaDonchitiet ADD FOREIGN KEY (idhoadon) REFERENCES dbo.HoaDon(id)
--ALTER TABLE dbo.HoaDonchitiet ADD FOREIGN KEY (idthucan) REFERENCES dbo.Thucan(id)