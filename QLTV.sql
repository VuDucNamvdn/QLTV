Use QLTV
Go

CREATE TABLE dbo.DangNhap
(
	MaNguoiDung INT IDENTITY(1,1) NOT NULL,
	MatKhau NVARCHAR(100) NOT NULL,
	Quyen INT NOT NULL,
	PRIMARY KEY (MaNguoiDung),
)
--Quản lý đầu sách
CREATE TABLE dbo.TheLoai
(
	MaTheLoai INT IDENTITY(1,1) NOT NULL,
	TenTheLoai NVARCHAR(100) NOT NULL,
	PRIMARY KEY (MaTheLoai),
)
ALTER TABLE TheLoai
ADD UNIQUE (TenTheLoai); --Chống lặp tên thể loại

CREATE TABLE dbo.DauSach
(
	MaSach INT IDENTITY(1,1) NOT NULL,
	TenSach NVARCHAR(100) NOT NULL,
	MaTheLoai INT NOT NULL,
	Sl INT NOT NULL,
	PRIMARY KEY (MaSach),
    FOREIGN KEY (MaTheLoai) REFERENCES TheLoai(MaTheLoai)
)

--Quản lý độc giả
CREATE TABLE dbo.Docgia
(
	MaDocGia INT IDENTITY(1,1) NOT NULL,
	TenDocGia INT NOT NULL,
	NgayHetHan DateTime NOT NULL,
	PRIMARY KEY (MaDocGia),
)
--Quản lý mược trả
CREATE TABLE dbo.MuonTra
(
	MaMuonTra INT IDENTITY(1,1) NOT NULL,
	MaDocGia INT NOT NULL,
	NgayHetHan DateTime NOT NULL,
	PRIMARY KEY (MaMuonTra),
	FOREIGN KEY (MaDocGia) REFERENCES DocGia(MaDocGia),
)
CREATE TABLE dbo.D_MuonTra
(
	MaMuonTra INT REFERENCES MuonTra(MaMuonTra) NOT NULL,
    MaSach INT REFERENCES DauSach(MaSach) NOT NULL,
	SoLuongSach INT NOT NULL,
	HanTra DateTime NOT NULL,
	TinhTrang BIT NOT NULL,
    PRIMARY KEY (MaMuonTra, MaSach)
)