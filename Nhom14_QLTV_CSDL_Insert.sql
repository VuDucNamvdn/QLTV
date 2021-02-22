CREATE DATABASE QuanLyThuVien
 ON  PRIMARY 
( NAME = N'QuanLyThuVien', FILENAME = N'E:\ThucTapNhom\QLTV\QuanLyThuVien.mdf' , SIZE = 100 , MAXSIZE = 2GB, FILEGROWTH = 10 )
 LOG ON 
( NAME = N'QuanLyThuVien_log', FILENAME = N'E:\ThucTapNhom\QLTV\QuanLyThuVien_log.ldf' , SIZE = 200 , MAXSIZE = UNLIMITED , FILEGROWTH = 20)
go
use QuanLyThuVien
go
Create table Nhaxuatban
(
IDNhaxuatban int primary key ,
Tennhaxuatban nvarchar(50),
Diachilienhe nvarchar(50),
SDT numeric(18, 0),
Email nvarchar(50),

)
Create table Theloai
(
IDTheloai int primary key,
Tentheloai nvarchar(50),
Gioithieu  text,
)
Create table Tacgia
(
IDTacgia int primary key,
Tentacgia nvarchar(50),
Lienhe nvarchar(50),
Thongtintacgia text,

)
Create table Kho
(
IDKho int primary key,
Tenkho nvarchar(50),
Diachikho nvarchar(50),
)
Create table Sach
(
IDSach int primary key,
TenSach nvarchar(50),
IDNhaxuatban int,
IDTheloai int,
IDTacgia int,
Giatien float,
Sotrang int,
Namxuatban datetime,
Ghichu text,
Tinhtrang bit,
)
Create table KhovsSach
(
IDKho int,
IDSach int,
primary key(IDKho,IDSach),
Soluongsachtrongkho int,
Soluongsachchomon int,
Vitri_Ke int,
Vitri_Ngan int,
Ghichu text,
Soluongsachtrungbay int,
)
Create table Quyen
(
IDQuyen int primary key,
IDNhomquyen int,
Tenquyen nvarchar(50),
)
Create table Nhomquyen
(
IDNhomquyen int primary key,
Tennhomquyen nvarchar(50),
)
Create table Nhanvien
(
IDNhanvien int primary key,
Tennhanvien nvarchar(50),
Ngaysinh datetime,
Diachi nvarchar(50),
SDT numeric(18, 0),
Tendangnhap nvarchar(50),
 Matkhau nvarchar(50),
)
Create table NhanvienvsNhomquyen
(
IDNhanvien int,
IDNhomquyen int,
Ngayvaonhom datetime,
Ghichu text,
primary key(IDNhanvien,IDNhomquyen),
)
Create table Chucvu
(
IDChucvu int primary key,
Tenchucvu nvarchar(50),
Ghichucongviec text,
)
Create table NhanvienvsChucvu
( 
IDNhanvien int,
IDChucvu int,
Ngaybatdau datetime,
Ngayketthuc datetime,
Ghichu text,
primary key(IDNhanvien,IDChucvu),
)
Create table Docgia
(
IDDocgia int primary key,
Tendocgia nvarchar(50),
Donvi nvarchar(50),
Chucvu nvarchar(50),
SDT numeric(18, 0),
Diachi nvarchar(50),
Ngaybatdau datetime,
Ngayhethan datetime,

)
Create table Muontrasach
(
IDMuontrasach int primary key ,
IDNhanvien int not null,
IDDocgia int not null,
Ngaymuon datetime not null,
)
Create table Chitietmuontrasach
(
IDChitietmuontrasach int primary key,
IDMuontrasach int not null,
IDSach int not null,
IDKho int not null,
Hangia  datetime not null,
Trangthaigia bit not null,
Ngaygia datetime,
Tienphathongsach float,
Tienphatmatsach float,
Tienphatgiasachcham float,
Ghichu nvarchar(MAX),

)
go
create table Thanhlysach
(
IDThanhlysach int primary key,
IDSach int not null,
IDKho int not null,
Ngaythanhly datetime not null,
Soluongsachthanhly int not null,
Giatrithanhly float not null,
)
--Khoa

ALTER TABLE dbo.Sach ADD FOREIGN KEY(IDNhaxuatban) REFERENCES dbo.Nhaxuatban(IDNhaxuatban)
go
ALTER TABLE dbo.Sach ADD FOREIGN KEY(IDTacgia) REFERENCES dbo.Tacgia(IDTacgia)
go
ALTER TABLE dbo.Sach ADD FOREIGN KEY(IDTheloai) REFERENCES dbo.Theloai(IDTheloai)
go
ALTER TABLE dbo.KhovsSach ADD FOREIGN KEY(IDKho) REFERENCES dbo.Kho(IDKho)
ALTER TABLE dbo.KhovsSach ADD FOREIGN KEY(IDSach) REFERENCES dbo.Sach(IDSach)

ALTER TABLE dbo.Quyen ADD FOREIGN KEY(IDNhomquyen) REFERENCES dbo.Nhomquyen(IDNhomquyen)

ALTER TABLE dbo.NhanvienvsNhomquyen ADD FOREIGN KEY(IDNhomquyen) REFERENCES dbo.Nhomquyen(IDNhomquyen)

ALTER TABLE dbo.NhanvienvsNhomquyen ADD FOREIGN KEY(IDNhanvien) REFERENCES dbo.Nhanvien(IDNhanvien)

ALTER TABLE dbo.NhanvienvsChucvu ADD FOREIGN KEY(IDChucvu) REFERENCES dbo.Chucvu(IDChucvu)
ALTER TABLE dbo.NhanvienvsChucvu ADD FOREIGN KEY(IDNhanvien) REFERENCES dbo.Nhanvien(IDNhanvien)

ALTER TABLE dbo.Muontrasach ADD FOREIGN KEY(IDNhanvien) REFERENCES dbo.Nhanvien(IDNhanvien)

ALTER TABLE dbo.Muontrasach ADD FOREIGN KEY(IDDocgia) REFERENCES dbo.Docgia(IDDocgia)

ALTER TABLE dbo.Chitietmuontrasach ADD FOREIGN KEY(IDMuontrasach) REFERENCES dbo.Muontrasach(IDMuontrasach)
ALTER TABLE dbo.Chitietmuontrasach ADD FOREIGN KEY(IDKho,IDSach) REFERENCES dbo.KhovsSach(IDKho,IDSach)
ALTER TABLE dbo.Thanhlysach ADD FOREIGN KEY(IDKho,IDSach) REFERENCES dbo.KhovsSach(IDKho,IDSach)
go
/*Kho*/
INSERT INTO Kho(IDKho, Tenkho, Diachikho)
VALUES ('0', 'Kho A', N'1 Hàng Bài');
INSERT INTO Kho(IDKho, Tenkho, Diachikho)
VALUES ('1', 'Kho B', N'1 Hàng Mành');
INSERT INTO Kho(IDKho, Tenkho, Diachikho)
VALUES ('2', 'Kho C', N'1 Hàng Bưởi');
INSERT INTO Kho(IDKho, Tenkho, Diachikho)
VALUES ('3', 'Kho D', N'1 Hàng Bí');
INSERT INTO Kho(IDKho, Tenkho, Diachikho)
VALUES ('4', 'Kho E', N'1 Hàng Bột');
/*Thể loại*/
INSERT INTO Theloai(IDTheloai, Tentheloai, Gioithieu)
VALUES ('0', N'Quân sự', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit');
INSERT INTO Theloai(IDTheloai, Tentheloai, Gioithieu)
VALUES ('1', N'Đô thị', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit');
INSERT INTO Theloai(IDTheloai, Tentheloai, Gioithieu)
VALUES ('2', N'Tiên hiệp', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit');
INSERT INTO Theloai(IDTheloai, Tentheloai, Gioithieu)
VALUES ('3', N'Kiếm hiệp', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit');
INSERT INTO Theloai(IDTheloai, Tentheloai, Gioithieu)
VALUES ('4', N'Ngôn tình', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit');

/*Nhà xuất bản*/
INSERT INTO Nhaxuatban(IDNhaxuatban, Tennhaxuatban, Diachilienhe,SDT,Email)
VALUES ('0', N'Hồng Hà', N'2 Hàng Bài', '8498888888','hongha@gmail.com');
INSERT INTO Nhaxuatban(IDNhaxuatban, Tennhaxuatban, Diachilienhe,SDT,Email)
VALUES ('1', N'Trẻ', N'2 Hàng Than', '8498888887','tre@gmail.com');
INSERT INTO Nhaxuatban(IDNhaxuatban, Tennhaxuatban, Diachilienhe,SDT,Email)
VALUES ('2', N'Kim Đồng', N'2 Hàng Mã', '8498788888','kimdong@gmail.com');
INSERT INTO Nhaxuatban(IDNhaxuatban, Tennhaxuatban, Diachilienhe,SDT,Email)
VALUES ('3', N'Điệp Biên', N'2 Điệp Biên', '8494888887','diepbien@gmail.com');
INSERT INTO Nhaxuatban(IDNhaxuatban, Tennhaxuatban, Diachilienhe,SDT,Email)
VALUES ('4', N'Đô thị', N'2 Hàng Lá', '8498888188','dothi@gmail.com');
INSERT INTO Nhaxuatban(IDNhaxuatban, Tennhaxuatban, Diachilienhe,SDT,Email)
VALUES ('5', N'Hồng Sâm', N'2 Bạch', '8498888887','sam@gmail.com');
/*Tác giả*/
INSERT INTO Tacgia(IDTacgia, Tentacgia, Lienhe,Thongtintacgia)
VALUES ('0', N'Lý Bạch', 'a@gmail.com','Lorem ipsum dolor sit amet, consectetur adipiscing elit');
INSERT INTO Tacgia(IDTacgia, Tentacgia, Lienhe,Thongtintacgia)
VALUES ('1', N'Nguyễn Du', 'b@gmail.com','Lorem ipsum dolor sit amet, consectetur adipiscing elit');
INSERT INTO Tacgia(IDTacgia, Tentacgia, Lienhe,Thongtintacgia)
VALUES ('2', N'Nguyễn Trãi', 'c@gmail.com','Lorem ipsum dolor sit amet, consectetur adipiscing elit');
INSERT INTO Tacgia(IDTacgia, Tentacgia, Lienhe,Thongtintacgia)
VALUES ('3', N'Khánh Hỷ', 'd@gmail.com','Lorem ipsum dolor sit amet, consectetur adipiscing elit');
INSERT INTO Tacgia(IDTacgia, Tentacgia, Lienhe,Thongtintacgia)
VALUES ('4', N'Nguyễn Khuyến', 'e@gmail.com','Lorem ipsum dolor sit amet, consectetur adipiscing elit');
INSERT INTO Tacgia(IDTacgia, Tentacgia, Lienhe,Thongtintacgia)
VALUES ('5', N'Nguyễn Bỉnh Khiêm', 'g@gmail.com','Lorem ipsum dolor sit amet, consectetur adipiscing elit');
INSERT INTO Tacgia(IDTacgia, Tentacgia, Lienhe,Thongtintacgia)
VALUES ('6', N'La Tấn', 'h@gmail.com','Lorem ipsum dolor sit amet, consectetur adipiscing elit');
INSERT INTO Tacgia(IDTacgia, Tentacgia, Lienhe,Thongtintacgia)
VALUES ('7', N'Đức Anh', 'i@gmail.com','Lorem ipsum dolor sit amet, consectetur adipiscing elit');
INSERT INTO Tacgia(IDTacgia, Tentacgia, Lienhe,Thongtintacgia)
VALUES ('8', N'Lý Tĩnh', 'a@gmail.com','Lorem ipsum dolor sit amet, consectetur adipiscing elit');
INSERT INTO Tacgia(IDTacgia, Tentacgia, Lienhe,Thongtintacgia)
VALUES ('9', N'NaTra', 'b@gmail.com','Lorem ipsum dolor sit amet, consectetur adipiscing elit');
INSERT INTO Tacgia(IDTacgia, Tentacgia, Lienhe,Thongtintacgia)
VALUES ('10', N'Ngọc Hoàng', 'c@gmail.com','Lorem ipsum dolor sit amet, consectetur adipiscing elit');
INSERT INTO Tacgia(IDTacgia, Tentacgia, Lienhe,Thongtintacgia)
VALUES ('11', N'Jesus', 'd@gmail.com','Lorem ipsum dolor sit amet, consectetur adipiscing elit');
INSERT INTO Tacgia(IDTacgia, Tentacgia, Lienhe,Thongtintacgia)
VALUES ('12', N'Ông Giả Nôen', 'e@gmail.com','Lorem ipsum dolor sit amet, consectetur adipiscing elit');
INSERT INTO Tacgia(IDTacgia, Tentacgia, Lienhe,Thongtintacgia)
VALUES ('13', N'Cố Mạn', 'g@gmail.com','Lorem ipsum dolor sit amet, consectetur adipiscing elit');
INSERT INTO Tacgia(IDTacgia, Tentacgia, Lienhe,Thongtintacgia)
VALUES ('14', N'Bạch Mạnh', 'h@gmail.com','Lorem ipsum dolor sit amet, consectetur adipiscing elit');
INSERT INTO Tacgia(IDTacgia, Tentacgia, Lienhe,Thongtintacgia)
VALUES ('15', N'Mạnh Hải', 'i@gmail.com','Lorem ipsum dolor sit amet, consectetur adipiscing elit');
/*Sách*/
INSERT INTO Sach(IDSach, TenSach, IDNhaxuatban,IDTheloai,IDTacgia,Giatien,Sotrang,Namxuatban,Ghichu,Tinhtrang)
VALUES ('0', N'Tam quốc', '0','0','0','90000','900','2000','Lorem ipsum dolor sit amet, consectetur adipiscing elit','0');
INSERT INTO Sach(IDSach, TenSach, IDNhaxuatban,IDTheloai,IDTacgia,Giatien,Sotrang,Namxuatban,Ghichu,Tinhtrang)
VALUES ('1', N'Hoàng Lê Nhất Thống Chí', '2','0','3','90500','9000','1998','Lorem ipsum dolor sit amet, consectetur adipiscing elit','1');
INSERT INTO Sach(IDSach, TenSach, IDNhaxuatban,IDTheloai,IDTacgia,Giatien,Sotrang,Namxuatban,Ghichu,Tinhtrang)
VALUES ('2', N'Đại Việt Sử Ký', '0','0','1','9000000','90000','1999','Lorem ipsum dolor sit amet, consectetur adipiscing elit','1');
INSERT INTO Sach(IDSach, TenSach, IDNhaxuatban,IDTheloai,IDTacgia,Giatien,Sotrang,Namxuatban,Ghichu,Tinhtrang)
VALUES ('3', N'Đại Đường : Ta Ngả Bài ,Ta Là Lý Thế Dân', '2','0','2','90500','9000','1998','Lorem ipsum dolor sit amet, consectetur adipiscing elit','1');
INSERT INTO Sach(IDSach, TenSach, IDNhaxuatban,IDTheloai,IDTacgia,Giatien,Sotrang,Namxuatban,Ghichu,Tinhtrang)
VALUES ('4', N'Đế Chế Đại Việt', '2','0','2','90500','9000','2012','Lorem ipsum dolor sit amet, consectetur adipiscing elit','1');

INSERT INTO Sach(IDSach, TenSach, IDNhaxuatban,IDTheloai,IDTacgia,Giatien,Sotrang,Namxuatban,Ghichu,Tinhtrang)
VALUES ('5', N'Bác Sĩ Mở Hack', '4','1','11','90000','900','2014','Lorem ipsum dolor sit amet, consectetur adipiscing elit','1');
INSERT INTO Sach(IDSach, TenSach, IDNhaxuatban,IDTheloai,IDTacgia,Giatien,Sotrang,Namxuatban,Ghichu,Tinhtrang)
VALUES ('6', N'Chung Cực Toàn Năng Học Sinh', '3','1','13','90500','9000','2018','Lorem ipsum dolor sit amet, consectetur adipiscing elit','1');
INSERT INTO Sach(IDSach, TenSach, IDNhaxuatban,IDTheloai,IDTacgia,Giatien,Sotrang,Namxuatban,Ghichu,Tinhtrang)
VALUES ('7', N'Đô thị Siêu cấp y thánh', '2','1','1','9000000','90000','2020','Lorem ipsum dolor sit amet, consectetur adipiscing elit','1');
INSERT INTO Sach(IDSach, TenSach, IDNhaxuatban,IDTheloai,IDTacgia,Giatien,Sotrang,Namxuatban,Ghichu,Tinhtrang)
VALUES ('8', N'Lão Bản Của Ta Thực Sự Quá Có Tiền', '5','1','12','90500','9000','2019','Lorem ipsum dolor sit amet, consectetur adipiscing elit','1');

INSERT INTO Sach(IDSach, TenSach, IDNhaxuatban,IDTheloai,IDTacgia,Giatien,Sotrang,Namxuatban,Ghichu,Tinhtrang)
VALUES ('9', N'Không có gì lạ Đại Sư Huynh', '4','2','4','90000','900','2014','Lorem ipsum dolor sit amet, consectetur adipiscing elit','1');
INSERT INTO Sach(IDSach, TenSach, IDNhaxuatban,IDTheloai,IDTacgia,Giatien,Sotrang,Namxuatban,Ghichu,Tinhtrang)
VALUES ('10', N'Vĩnh Hằng Thánh Vương', '3','2','9','90500','9000','2018','Lorem ipsum dolor sit amet, consectetur adipiscing elit','1');
INSERT INTO Sach(IDSach, TenSach, IDNhaxuatban,IDTheloai,IDTacgia,Giatien,Sotrang,Namxuatban,Ghichu,Tinhtrang)
VALUES ('11', N'Ta Sư Huynh Thật Sự Quá Vững Vàng', '2','2','7','9000000','90000','2020','Lorem ipsum dolor sit amet, consectetur adipiscing elit','1');
INSERT INTO Sach(IDSach, TenSach, IDNhaxuatban,IDTheloai,IDTacgia,Giatien,Sotrang,Namxuatban,Ghichu,Tinhtrang)
VALUES ('12', N'Bắt Đầu Sáng Tạo Tu Tiên Công Pháp', '5','2','5','90500','9000','2019','Lorem ipsum dolor sit amet, consectetur adipiscing elit','1');
INSERT INTO Sach(IDSach, TenSach, IDNhaxuatban,IDTheloai,IDTacgia,Giatien,Sotrang,Namxuatban,Ghichu,Tinhtrang)
VALUES ('13', N'Nghịch Thiên Tà Thần', '4','2','6','90500','9000','2009','Lorem ipsum dolor sit amet, consectetur adipiscing elit','1');

INSERT INTO Sach(IDSach, TenSach, IDNhaxuatban,IDTheloai,IDTacgia,Giatien,Sotrang,Namxuatban,Ghichu,Tinhtrang)
VALUES ('14', N'Kiếm chủ Bát Hoang', '4','3','14','90000','900','2014','Lorem ipsum dolor sit amet, consectetur adipiscing elit','1');
INSERT INTO Sach(IDSach, TenSach, IDNhaxuatban,IDTheloai,IDTacgia,Giatien,Sotrang,Namxuatban,Ghichu,Tinhtrang)
VALUES ('15', N'Nhân ma Chi Lộ', '3','3','11','90500','9000','2018','Lorem ipsum dolor sit amet, consectetur adipiscing elit','1');
INSERT INTO Sach(IDSach, TenSach, IDNhaxuatban,IDTheloai,IDTacgia,Giatien,Sotrang,Namxuatban,Ghichu,Tinhtrang)
VALUES ('16', N'Thiếu niên Ca Hành', '2','3','9','9000000','90000','2020','Lorem ipsum dolor sit amet, consectetur adipiscing elit','1');
INSERT INTO Sach(IDSach, TenSach, IDNhaxuatban,IDTheloai,IDTacgia,Giatien,Sotrang,Namxuatban,Ghichu,Tinhtrang)
VALUES ('17', N'Độc bộ giang hồ', '5','3','8','90500','9000','2019','Lorem ipsum dolor sit amet, consectetur adipiscing elit','1');
INSERT INTO Sach(IDSach, TenSach, IDNhaxuatban,IDTheloai,IDTacgia,Giatien,Sotrang,Namxuatban,Ghichu,Tinhtrang)
VALUES ('18', N'Cực võ', '4','3','14','90500','9000','2009','Lorem ipsum dolor sit amet, consectetur adipiscing elit','1');

INSERT INTO Sach(IDSach, TenSach, IDNhaxuatban,IDTheloai,IDTacgia,Giatien,Sotrang,Namxuatban,Ghichu,Tinhtrang)
VALUES ('19', N'Cuộc đời ngột ngào khi có em', '4','4','14','90000','900','2014','Lorem ipsum dolor sit amet, consectetur adipiscing elit','1');
INSERT INTO Sach(IDSach, TenSach, IDNhaxuatban,IDTheloai,IDTacgia,Giatien,Sotrang,Namxuatban,Ghichu,Tinhtrang)
VALUES ('20', N'Nhà Ta Thái Tử Phi Siêu Hung', '3','4','11','90500','9000','2018','Lorem ipsum dolor sit amet, consectetur adipiscing elit','1');
INSERT INTO Sach(IDSach, TenSach, IDNhaxuatban,IDTheloai,IDTacgia,Giatien,Sotrang,Namxuatban,Ghichu,Tinhtrang)
VALUES ('21', N'Nghịch đồ chớ làm loạn', '2','4','9','9000000','90000','2020','Lorem ipsum dolor sit amet, consectetur adipiscing elit','1');
INSERT INTO Sach(IDSach, TenSach, IDNhaxuatban,IDTheloai,IDTacgia,Giatien,Sotrang,Namxuatban,Ghichu,Tinhtrang)
VALUES ('22', N'Xuyên Nhanh: Nam Thần, Có Chút Cháy!', '5','4','8','90500','9000','2019','Lorem ipsum dolor sit amet, consectetur adipiscing elit','1');
INSERT INTO Sach(IDSach, TenSach, IDNhaxuatban,IDTheloai,IDTacgia,Giatien,Sotrang,Namxuatban,Ghichu,Tinhtrang)
VALUES ('23', N'Xuyên Nhanh: Nữ Phối, Bình Tĩnh Một Chút', '4','4','14','90500','9000','2009','Lorem ipsum dolor sit amet, consectetur adipiscing elit','1');
INSERT INTO Sach(IDSach, TenSach, IDNhaxuatban,IDTheloai,IDTacgia,Giatien,Sotrang,Namxuatban,Ghichu,Tinhtrang)
VALUES ('24', N'Nhanh xuyên toàn năng nữ thần', '4','4','15','90500','9000','2009','Lorem ipsum dolor sit amet, consectetur adipiscing elit','1');

/*KhovsSach*/
INSERT INTO KhovsSach(IDSach,IDKho,Soluongsachtrongkho,Soluongsachchomon,Vitri_Ke,Vitri_Ngan,Soluongsachtrungbay)
VALUES ('0','0','0','2','0','0','0')
INSERT INTO KhovsSach(IDSach,IDKho,Soluongsachtrongkho,Soluongsachchomon,Vitri_Ke,Vitri_Ngan,Soluongsachtrungbay)
VALUES ('1','1','10','0','1','0','5')
INSERT INTO KhovsSach(IDSach,IDKho,Soluongsachtrongkho,Soluongsachchomon,Vitri_Ke,Vitri_Ngan,Soluongsachtrungbay)
VALUES ('2','2','5','0','0','1','3')
INSERT INTO KhovsSach(IDSach,IDKho,Soluongsachtrongkho,Soluongsachchomon,Vitri_Ke,Vitri_Ngan,Soluongsachtrungbay)
VALUES ('3','3','16','0','0','5','6')
INSERT INTO KhovsSach(IDSach,IDKho,Soluongsachtrongkho,Soluongsachchomon,Vitri_Ke,Vitri_Ngan,Soluongsachtrungbay)
VALUES ('4','4','10','0','0','2','2')
INSERT INTO KhovsSach(IDSach,IDKho,Soluongsachtrongkho,Soluongsachchomon,Vitri_Ke,Vitri_Ngan,Soluongsachtrungbay)
VALUES ('5','1','10','0','1','3','6')
INSERT INTO KhovsSach(IDSach,IDKho,Soluongsachtrongkho,Soluongsachchomon,Vitri_Ke,Vitri_Ngan,Soluongsachtrungbay)
VALUES ('6','2','1','0','0','1','1')

INSERT INTO KhovsSach(IDSach,IDKho,Soluongsachtrongkho,Soluongsachchomon,Vitri_Ke,Vitri_Ngan,Soluongsachtrungbay)
VALUES ('7','0','0','0','0','8','0')
INSERT INTO KhovsSach(IDSach,IDKho,Soluongsachtrongkho,Soluongsachchomon,Vitri_Ke,Vitri_Ngan,Soluongsachtrungbay)
VALUES ('8','1','10','0','0','8','5')
INSERT INTO KhovsSach(IDSach,IDKho,Soluongsachtrongkho,Soluongsachchomon,Vitri_Ke,Vitri_Ngan,Soluongsachtrungbay)
VALUES ('9','2','5','0','0','4','3')
INSERT INTO KhovsSach(IDSach,IDKho,Soluongsachtrongkho,Soluongsachchomon,Vitri_Ke,Vitri_Ngan,Soluongsachtrungbay)
VALUES ('10','3','16','0','0','4','6')
INSERT INTO KhovsSach(IDSach,IDKho,Soluongsachtrongkho,Soluongsachchomon,Vitri_Ke,Vitri_Ngan,Soluongsachtrungbay)
VALUES ('11','4','10','0','0','11','2')
INSERT INTO KhovsSach(IDSach,IDKho,Soluongsachtrongkho,Soluongsachchomon,Vitri_Ke,Vitri_Ngan,Soluongsachtrungbay)
VALUES ('12','1','10','1','1','12','6')
INSERT INTO KhovsSach(IDSach,IDKho,Soluongsachtrongkho,Soluongsachchomon,Vitri_Ke,Vitri_Ngan,Soluongsachtrungbay)
VALUES ('13','4','1','0','1','8','1')

INSERT INTO KhovsSach(IDSach,IDKho,Soluongsachtrongkho,Soluongsachchomon,Vitri_Ke,Vitri_Ngan,Soluongsachtrungbay)
VALUES ('14','0','0','0','0','18','0')
INSERT INTO KhovsSach(IDSach,IDKho,Soluongsachtrongkho,Soluongsachchomon,Vitri_Ke,Vitri_Ngan,Soluongsachtrungbay)
VALUES ('15','1','10','0','4','2','5')
INSERT INTO KhovsSach(IDSach,IDKho,Soluongsachtrongkho,Soluongsachchomon,Vitri_Ke,Vitri_Ngan,Soluongsachtrungbay)
VALUES ('16','2','5','0','4','1','3')
INSERT INTO KhovsSach(IDSach,IDKho,Soluongsachtrongkho,Soluongsachchomon,Vitri_Ke,Vitri_Ngan,Soluongsachtrungbay)
VALUES ('17','3','16','0','4','5','6')
INSERT INTO KhovsSach(IDSach,IDKho,Soluongsachtrongkho,Soluongsachchomon,Vitri_Ke,Vitri_Ngan,Soluongsachtrungbay)
VALUES ('18','4','10','0','4','4','2')
INSERT INTO KhovsSach(IDSach,IDKho,Soluongsachtrongkho,Soluongsachchomon,Vitri_Ke,Vitri_Ngan,Soluongsachtrungbay)
VALUES ('19','1','10','0','3','3','6')
INSERT INTO KhovsSach(IDSach,IDKho,Soluongsachtrongkho,Soluongsachchomon,Vitri_Ke,Vitri_Ngan,Soluongsachtrungbay)
VALUES ('20','2','1','0','2','2','1')

INSERT INTO KhovsSach(IDSach,IDKho,Soluongsachtrongkho,Soluongsachchomon,Vitri_Ke,Vitri_Ngan,Soluongsachtrungbay)
VALUES ('21','0','0','0','2','0','0')
INSERT INTO KhovsSach(IDSach,IDKho,Soluongsachtrongkho,Soluongsachchomon,Vitri_Ke,Vitri_Ngan,Soluongsachtrungbay)
VALUES ('22','1','10','0','2','1','5')
INSERT INTO KhovsSach(IDSach,IDKho,Soluongsachtrongkho,Soluongsachchomon,Vitri_Ke,Vitri_Ngan,Soluongsachtrungbay)
VALUES ('23','2','5','0','0','1','3')
INSERT INTO KhovsSach(IDSach,IDKho,Soluongsachtrongkho,Soluongsachchomon,Vitri_Ke,Vitri_Ngan,Soluongsachtrungbay)
VALUES ('24','3','16','1','3','5','6')

/*Độc giả*/
INSERT INTO Docgia(IDDocgia,Tendocgia,Donvi,Chucvu,SDT,Diachi,Ngaybatdau,Ngayhethan)
VALUES ('0',N'Hồ Băng Khánh','1',N'Luyện Khí','84999999999',N'1 Hàng Cơm','2009-2-17','2050-2-17')
INSERT INTO Docgia(IDDocgia,Tendocgia,Donvi,Chucvu,SDT,Diachi,Ngaybatdau,Ngayhethan)
VALUES ('1',N'Nam Đàn','1',N'Tông Sư','84999999998',N'1 Hàng CHáo','2009-2-17','2050-2-17')
INSERT INTO Docgia(IDDocgia,Tendocgia,Donvi,Chucvu,SDT,Diachi,Ngaybatdau,Ngayhethan)
VALUES ('2',N'Lý Công','1',N'Trúc Cơ','84979999999',N'108 Hàng Cơm','2009-2-17','2050-2-17')
INSERT INTO Docgia(IDDocgia,Tendocgia,Donvi,Chucvu,SDT,Diachi,Ngaybatdau,Ngayhethan)
VALUES ('3',N'Trí Lý','1',N'Kim Đan','84969999999',N'15 Hàng Cơm','2009-2-17','2050-2-17')
INSERT INTO Docgia(IDDocgia,Tendocgia,Donvi,Chucvu,SDT,Diachi,Ngaybatdau,Ngayhethan)
VALUES ('4',N'Không Trí Lý','3',N'Trúc Cơ','84959999999',N'14 Hàng Cơm','2009-2-17','2050-2-17')
INSERT INTO Docgia(IDDocgia,Tendocgia,Donvi,Chucvu,SDT,Diachi,Ngaybatdau,Ngayhethan)
VALUES ('5',N'Bạch Hà','2',N'Luyện khí','84949999999',N'15 Hàng Cơm','2009-2-17','2050-2-17')
INSERT INTO Docgia(IDDocgia,Tendocgia,Donvi,Chucvu,SDT,Diachi,Ngaybatdau,Ngayhethan)
VALUES ('6',N'Lâm Chí Linh','5',N'Luyện Khí','84939999999',N'16 Hàng Cơm','2009-2-17','2050-2-17')
INSERT INTO Docgia(IDDocgia,Tendocgia,Donvi,Chucvu,SDT,Diachi,Ngaybatdau,Ngayhethan)
VALUES ('7',N'Trần Phi','6',N'Trúc Cơ','84929999999',N'12 Hàng Cơm','2009-2-17','2050-2-17')
INSERT INTO Docgia(IDDocgia,Tendocgia,Donvi,Chucvu,SDT,Diachi,Ngaybatdau,Ngayhethan)
VALUES ('8',N'Trần Phầm','7',N'Nguyên Anh','84909999999',N'22 Hàng Cơm','2009-2-17','2050-2-17')
INSERT INTO Docgia(IDDocgia,Tendocgia,Donvi,Chucvu,SDT,Diachi,Ngaybatdau,Ngayhethan)
VALUES ('9',N'Nạp La Yên Nhiên','8',N'Đấu Vương','84991999999',N'33 Hàng Cơm','2009-2-17','2050-2-17')
INSERT INTO Docgia(IDDocgia,Tendocgia,Donvi,Chucvu,SDT,Diachi,Ngaybatdau,Ngayhethan)
VALUES ('10',N'Đường Tam','9',N'Phong Hào Đấu La','84199999999',N'45 Hàng Cơm','2009-2-17','2050-2-17')
INSERT INTO Docgia(IDDocgia,Tendocgia,Donvi,Chucvu,SDT,Diachi,Ngaybatdau,Ngayhethan)
VALUES ('11',N'Trần Bắc Huyền','4',N'Tiên Tôn','84299999999',N'46 Hàng Cơm','2009-2-17','2050-2-17')
INSERT INTO Docgia(IDDocgia,Tendocgia,Donvi,Chucvu,SDT,Diachi,Ngaybatdau,Ngayhethan)
VALUES ('12',N'Diệp Tinh Hà','5',N'Chân Nhân Tầng 7','84399999999',N'47 Hàng Cơm','2009-2-17','2050-2-17')
INSERT INTO Docgia(IDDocgia,Tendocgia,Donvi,Chucvu,SDT,Diachi,Ngaybatdau,Ngayhethan)
VALUES ('13',N'Cổ Hà','1',N'Đan Vương','84499999999',N'18 Hàng Cơm','2009-2-17','2050-2-17')
INSERT INTO Docgia(IDDocgia,Tendocgia,Donvi,Chucvu,SDT,Diachi,Ngaybatdau,Ngayhethan)
VALUES ('14',N'Tiêu Viêm','1',N'Đấu Hoàng','84599999999',N'29 Hàng Cơm','2009-2-17','2050-2-17')
/* NHÂN VIÊN */
INSERT INTO Nhanvien(IDNhanvien,Tennhanvien, Ngaysinh, Diachi,SDT ,Tendangnhap, Matkhau  )
VALUES ('0', N'A đẹp trai','1/1/1998',N' Hà Nội', '01234567', 'a111','123456');
INSERT INTO Nhanvien(IDNhanvien,Tennhanvien, Ngaysinh, Diachi,SDT ,Tendangnhap, Matkhau  )
VALUES ('1', N'B đẹp trai','2/1/1998',N' Thường tín', '01234577', 'b111','123456');
INSERT INTO Nhanvien(IDNhanvien,Tennhanvien, Ngaysinh, Diachi,SDT ,Tendangnhap, Matkhau  )
VALUES ('2', N'C đẹp trai','3/1/1998',N' Hà Đông', '01235567', 'c111','123456');
INSERT INTO Nhanvien(IDNhanvien,Tennhanvien, Ngaysinh, Diachi,SDT ,Tendangnhap, Matkhau  )
VALUES ('3', N'D đẹp trai','1/1/1998',N' Hà Nội', '01236667', 'a111','123456');
INSERT INTO Nhanvien(IDNhanvien,Tennhanvien, Ngaysinh, Diachi,SDT ,Tendangnhap, Matkhau  )
VALUES ('4', N'E xinh gái','1/1/1998',N' Huế', '01634567', 'a111','123456');
INSERT INTO Nhanvien(IDNhanvien,Tennhanvien, Ngaysinh, Diachi,SDT ,Tendangnhap, Matkhau  )
VALUES ('5', N'A đẹp trai','1/1/1998',N' Hà Nam', '01232767', 'a111','123456');

INSERT INTO Nhanvien(IDNhanvien,Tennhanvien, Ngaysinh, Diachi,SDT ,Tendangnhap, Matkhau  )
VALUES ('6', N'A đẹp trai','1/1/1998',N' Vinh', '01231567', 'a111','123456');
INSERT INTO Nhanvien(IDNhanvien,Tennhanvien, Ngaysinh, Diachi,SDT ,Tendangnhap, Matkhau  )
VALUES ('7', N'A đẹp trai','1/1/1998',N' Đông Lào', '01634567', 'a111','123456');
INSERT INTO Nhanvien(IDNhanvien,Tennhanvien, Ngaysinh, Diachi,SDT ,Tendangnhap, Matkhau  )
VALUES ('8', N'A đẹp trai','1/1/1998',N'Tây lào', '01225567', 'a111','123456');
INSERT INTO Nhanvien(IDNhanvien,Tennhanvien, Ngaysinh, Diachi,SDT ,Tendangnhap, Matkhau  )
VALUES ('9', N'A đẹp trai','1/1/1998',N' Demacia', '01344567', 'a111','123456');
INSERT INTO Nhanvien(IDNhanvien,Tennhanvien, Ngaysinh, Diachi,SDT ,Tendangnhap, Matkhau  )
VALUES ('10', N'A đẹp trai','1/1/1998',N' Tung Của', '01265477', 'a111','123456');

INSERT INTO Nhanvien(IDNhanvien,Tennhanvien, Ngaysinh, Diachi,SDT ,Tendangnhap, Matkhau  )
VALUES ('11', N'A nhiều thế ','1/6/1988',N' Lai Lai ', '01255477', 'z111','123456');
INSERT INTO Nhanvien(IDNhanvien,Tennhanvien, Ngaysinh, Diachi,SDT ,Tendangnhap, Matkhau  )
VALUES ('12', N'B đẹp trai','9/6/1996',N' Tung Của', '01265477', 'a111','123456');
INSERT INTO Nhanvien(IDNhanvien,Tennhanvien, Ngaysinh, Diachi,SDT ,Tendangnhap, Matkhau  )
VALUES ('13', N'Lai Lai','1/1/1997',N' Tung Của', '01785477', 't111','123456');
INSERT INTO Nhanvien(IDNhanvien,Tennhanvien, Ngaysinh, Diachi,SDT ,Tendangnhap, Matkhau  )
VALUES ('14', N'Lô conc','6/1/1998',N' Tây phi', '01263677', 'a112','123456');
INSERT INTO Nhanvien(IDNhanvien,Tennhanvien, Ngaysinh, Diachi,SDT ,Tendangnhap, Matkhau  )
VALUES ('15', N'A G H','1/9/1988',N' Lào', '05457524', 'q111','123456');

INSERT INTO Nhanvien(IDNhanvien,Tennhanvien, Ngaysinh, Diachi,SDT ,Tendangnhap, Matkhau  )
VALUES ('16', N'Tà lằng','1/1/1998',N' Tung Của', '01265747', 'l111','123456');
INSERT INTO Nhanvien(IDNhanvien,Tennhanvien, Ngaysinh, Diachi,SDT ,Tendangnhap, Matkhau  )
VALUES ('17', N'A B C ','3/6/1988',N' Tung Của', '01335477', 'e111','123456');
INSERT INTO Nhanvien(IDNhanvien,Tennhanvien, Ngaysinh, Diachi,SDT ,Tendangnhap, Matkhau  )
VALUES ('18', N'Nhiều vlin','6/3/1968',N' Demacia', '02222222', 'j111','123456');
INSERT INTO Nhanvien(IDNhanvien,Tennhanvien, Ngaysinh, Diachi,SDT ,Tendangnhap, Matkhau  )
VALUES ('19', N'Mai Tài phến','1/3/1996',N' Hà Nội', '01222222', 'g111','123456');
INSERT INTO Nhanvien(IDNhanvien,Tennhanvien, Ngaysinh, Diachi,SDT ,Tendangnhap, Matkhau  )
VALUES ('20', N'Huấn Hoa hồng','5/1/1988',N' Tung Của', '03365477', 'H111','123456');
/*Mượn Trả Sách*/
INSERT INTO Muontrasach(IDMuontrasach,IDDocgia,IDNhanvien,Ngaymuon)
VALUES('0','2','1','2020-2-17')
INSERT INTO Muontrasach(IDMuontrasach,IDDocgia,IDNhanvien,Ngaymuon)
VALUES('1','0','1','2020-2-17')
INSERT INTO Muontrasach(IDMuontrasach,IDDocgia,IDNhanvien,Ngaymuon)
VALUES('2','5','2','2019-1-17')
INSERT INTO Muontrasach(IDMuontrasach,IDDocgia,IDNhanvien,Ngaymuon)
VALUES('3','14','2','2019-1-17')
INSERT INTO Muontrasach(IDMuontrasach,IDDocgia,IDNhanvien,Ngaymuon)
VALUES('4','11','0','2019-1-17')
INSERT INTO Muontrasach(IDMuontrasach,IDDocgia,IDNhanvien,Ngaymuon)
VALUES('5','6','0','2019-1-17')

/*Chi tiết mượn sách*/
INSERT INTO Chitietmuontrasach(IDChitietmuontrasach,IDMuontrasach,IDSach,IDKho,Hangia,Trangthaigia,Ngaygia,Tienphathongsach,Tienphatmatsach,Tienphatgiasachcham,Ghichu)
VALUES ('0','0','0','0','2020-12-17','0',Null,'0.0','0.0','0.0',Null)
INSERT INTO Chitietmuontrasach(IDChitietmuontrasach,IDMuontrasach,IDSach,IDKho,Hangia,Trangthaigia,Ngaygia,Tienphathongsach,Tienphatmatsach,Tienphatgiasachcham,Ghichu)
VALUES ('1','1','1','1','2020-12-17','0',Null,'0.0','0.0','0.0',Null)
INSERT INTO Chitietmuontrasach(IDChitietmuontrasach,IDMuontrasach,IDSach,IDKho,Hangia,Trangthaigia,Ngaygia,Tienphathongsach,Tienphatmatsach,Tienphatgiasachcham,Ghichu)
VALUES ('2','1','2','2','2020-12-17','0',Null,'0.0','0.0','0.0',Null)
INSERT INTO Chitietmuontrasach(IDChitietmuontrasach,IDMuontrasach,IDSach,IDKho,Hangia,Trangthaigia,Ngaygia,Tienphathongsach,Tienphatmatsach,Tienphatgiasachcham,Ghichu)
VALUES ('3','3','3','3','2020-12-17','0',Null,'0.0','0.0','0.0',Null)
INSERT INTO Chitietmuontrasach(IDChitietmuontrasach,IDMuontrasach,IDSach,IDKho,Hangia,Trangthaigia,Ngaygia,Tienphathongsach,Tienphatmatsach,Tienphatgiasachcham,Ghichu)
VALUES ('4','4','4','4','2020-12-17','0',Null,'0.0','0.0','0.0',Null)
INSERT INTO Chitietmuontrasach(IDChitietmuontrasach,IDMuontrasach,IDSach,IDKho,Hangia,Trangthaigia,Ngaygia,Tienphathongsach,Tienphatmatsach,Tienphatgiasachcham,Ghichu)
VALUES ('5','5','5','1','2020-12-17','0',Null,'0.0','0.0','0.0',Null)
go
/*  NHÓM QUYỀN */
INSERT INTO Nhomquyen(IDNhomquyen, Tennhomquyen)
VALUES ('1',N'Toàn quyền');
INSERT INTO Nhomquyen(IDNhomquyen, Tennhomquyen)
VALUES ('2',N'Bộ phận');
INSERT INTO Nhomquyen(IDNhomquyen, Tennhomquyen)
VALUES ('3',N'Chỉ xem');

/* QUYỀN */
INSERT INTO Quyen(IDQuyen, IDNhomquyen, Tenquyen)
VALUES ('1', '1', N'Kiểm soát đầy đủ');
INSERT INTO Quyen(IDQuyen, IDNhomquyen, Tenquyen)
VALUES ('2', '2', N'Thiết kế');
INSERT INTO Quyen(IDQuyen, IDNhomquyen, Tenquyen)
VALUES ('3', '2', N'Sửa');
INSERT INTO Quyen(IDQuyen, IDNhomquyen, Tenquyen)
VALUES ('4', '2', N'Tạo trang con mới');
INSERT INTO Quyen(IDQuyen, IDNhomquyen, Tenquyen)
VALUES ('5', '3', N'Chỉ được xem ');



/* Chức Vụ */
INSERT INTO Chucvu(IDChucvu, Tenchucvu, Ghichucongviec  )
VALUES ('0', N'Quản lý','ngồi chơi xơi nước chè');
INSERT INTO Chucvu(IDChucvu, Tenchucvu, Ghichucongviec  )
VALUES ('1', N'Bảo vệ',N'ngồi là chính');
INSERT INTO Chucvu(IDChucvu, Tenchucvu, Ghichucongviec  )
VALUES ('2', N'Nhân viên',N'chém gió');
INSERT INTO Chucvu(IDChucvu, Tenchucvu, Ghichucongviec  )
VALUES ('3', N'Thủ kho',N'kiếm sách');
INSERT INTO Chucvu(IDChucvu, Tenchucvu, Ghichucongviec  )
VALUES ('4', N'Kế toán',N'kiếm tiền');
INSERT INTO Chucvu(IDChucvu, Tenchucvu, Ghichucongviec  )
VALUES ('5', N'Đứng chào',N'Đứng và chào thôi');

/* Nhân viên vs Chức vụ */
INSERT INTO NhanvienvsChucvu(IDNhanvien,IDChucvu ,Ngaybatdau,Ngayketthuc,Ghichu  )
VALUES ('0', '0','9/6/2019','3/3/2030','empty');
INSERT INTO NhanvienvsChucvu(IDNhanvien,IDChucvu ,Ngaybatdau,Ngayketthuc,Ghichu  )
VALUES ('1', '1','6/9/2019','3/3/2030','chả có gì');
INSERT INTO NhanvienvsChucvu(IDNhanvien,IDChucvu ,Ngaybatdau,Ngayketthuc,Ghichu  )
VALUES ('2', '1','7/1/2019','3/3/2030','bình thường');
INSERT INTO NhanvienvsChucvu(IDNhanvien,IDChucvu ,Ngaybatdau,Ngayketthuc,Ghichu  )
VALUES ('3', '2','7/2/2019','3/3/2030','empty');
INSERT INTO NhanvienvsChucvu(IDNhanvien,IDChucvu ,Ngaybatdau,Ngayketthuc,Ghichu  )
VALUES ('4', '2','9/3/2019','3/3/2030','empty');

INSERT INTO NhanvienvsChucvu(IDNhanvien,IDChucvu ,Ngaybatdau,Ngayketthuc,Ghichu  )
VALUES ('5', '2','7/5/2019','3/3/2030','vui');
INSERT INTO NhanvienvsChucvu(IDNhanvien,IDChucvu ,Ngaybatdau,Ngayketthuc,Ghichu  )
VALUES ('6', '2','8/8/2019','3/3/2030','ngu');
INSERT INTO NhanvienvsChucvu(IDNhanvien,IDChucvu ,Ngaybatdau,Ngayketthuc,Ghichu  )
VALUES ('7', '2','3/7/2019','3/3/2030','hài thế');
INSERT INTO NhanvienvsChucvu(IDNhanvien,IDChucvu ,Ngaybatdau,Ngayketthuc,Ghichu  )
VALUES ('8', '2','7/2/2019','3/3/2030','tà lằng');
INSERT INTO NhanvienvsChucvu(IDNhanvien,IDChucvu ,Ngaybatdau,Ngayketthuc,Ghichu  )
VALUES ('9', '3','8/9/2019','3/3/2030','empty');

INSERT INTO NhanvienvsChucvu(IDNhanvien,IDChucvu ,Ngaybatdau,Ngayketthuc,Ghichu  )
VALUES ('10', '3','5/9/2019','3/3/2030','empty');
INSERT INTO NhanvienvsChucvu(IDNhanvien,IDChucvu ,Ngaybatdau,Ngayketthuc,Ghichu  )
VALUES ('11', '5','5/6/2019','3/3/2030','empty');
INSERT INTO NhanvienvsChucvu(IDNhanvien,IDChucvu ,Ngaybatdau,Ngayketthuc,Ghichu  )
VALUES ('12', '3','1/7/2019','3/3/2030','empty');
INSERT INTO NhanvienvsChucvu(IDNhanvien,IDChucvu ,Ngaybatdau,Ngayketthuc,Ghichu  )
VALUES ('13', '5','4/7/2019','3/3/2030','empty');

INSERT INTO NhanvienvsChucvu(IDNhanvien,IDChucvu ,Ngaybatdau,Ngayketthuc,Ghichu  )
VALUES ('14', '2','9/8/2019','3/3/2030','empty');
INSERT INTO NhanvienvsChucvu(IDNhanvien,IDChucvu ,Ngaybatdau,Ngayketthuc,Ghichu  )
VALUES ('15', '1','8/1/2019','3/3/2030','empty');
INSERT INTO NhanvienvsChucvu(IDNhanvien,IDChucvu ,Ngaybatdau,Ngayketthuc,Ghichu  )
VALUES ('16', '0','7/6/2019','3/3/2030','empty');
INSERT INTO NhanvienvsChucvu(IDNhanvien,IDChucvu ,Ngaybatdau,Ngayketthuc,Ghichu  )
VALUES ('17', '3','9/9/2019','3/3/2030','empty');
INSERT INTO NhanvienvsChucvu(IDNhanvien,IDChucvu ,Ngaybatdau,Ngayketthuc,Ghichu  )
VALUES ('18', '4','4/8/2019','3/3/2030','empty');

INSERT INTO NhanvienvsChucvu(IDNhanvien,IDChucvu ,Ngaybatdau,Ngayketthuc,Ghichu  )
VALUES ('19', '4','6/7/2019','3/3/2030','empty');
INSERT INTO NhanvienvsChucvu(IDNhanvien,IDChucvu ,Ngaybatdau,Ngayketthuc,Ghichu  )
VALUES ('20', '4','3/6/2019','3/3/2030','empty');

/* Nhân viên vs Nhóm quyền */
INSERT INTO NhanvienvsNhomquyen(IDNhanvien,IDNhomquyen ,Ngayvaonhom,Ghichu  )
VALUES ('0','1','6/6/2020', ' empty ');
INSERT INTO NhanvienvsNhomquyen(IDNhanvien,IDNhomquyen ,Ngayvaonhom,Ghichu  )
VALUES ('16','1','6/6/2020', ' empty ');
INSERT INTO NhanvienvsNhomquyen(IDNhanvien,IDNhomquyen ,Ngayvaonhom,Ghichu  )
VALUES ('5','2','6/6/2020', ' empty ');
INSERT INTO NhanvienvsNhomquyen(IDNhanvien,IDNhomquyen ,Ngayvaonhom,Ghichu  )
VALUES ('6','2','6/6/2020', ' empty ');
INSERT INTO NhanvienvsNhomquyen(IDNhanvien,IDNhomquyen ,Ngayvaonhom,Ghichu  )
VALUES ('3','2','6/6/2020', ' empty ');
INSERT INTO NhanvienvsNhomquyen(IDNhanvien,IDNhomquyen ,Ngayvaonhom,Ghichu  )
VALUES ('4','2','6/6/2020', ' empty ');
INSERT INTO NhanvienvsNhomquyen(IDNhanvien,IDNhomquyen ,Ngayvaonhom,Ghichu  )
VALUES ('7','2','6/6/2020', ' empty ');
INSERT INTO NhanvienvsNhomquyen(IDNhanvien,IDNhomquyen ,Ngayvaonhom,Ghichu  )
VALUES ('8','2','6/6/2020', ' empty ');
INSERT INTO NhanvienvsNhomquyen(IDNhanvien,IDNhomquyen ,Ngayvaonhom,Ghichu  )
VALUES ('9','2','6/6/2020', ' empty ');
INSERT INTO NhanvienvsNhomquyen(IDNhanvien,IDNhomquyen ,Ngayvaonhom,Ghichu  )
VALUES ('10','2','6/6/2020', ' empty ');
INSERT INTO NhanvienvsNhomquyen(IDNhanvien,IDNhomquyen ,Ngayvaonhom,Ghichu  )
VALUES ('12','2','6/6/2020', ' empty ');
INSERT INTO NhanvienvsNhomquyen(IDNhanvien,IDNhomquyen ,Ngayvaonhom,Ghichu  )
VALUES ('14','2','6/6/2020', ' empty ');
INSERT INTO NhanvienvsNhomquyen(IDNhanvien,IDNhomquyen ,Ngayvaonhom,Ghichu  )
VALUES ('17','2','6/6/2020', ' empty ');
INSERT INTO NhanvienvsNhomquyen(IDNhanvien,IDNhomquyen ,Ngayvaonhom,Ghichu  )
VALUES ('18','2','6/6/2020', ' empty ');
INSERT INTO NhanvienvsNhomquyen(IDNhanvien,IDNhomquyen ,Ngayvaonhom,Ghichu  )
VALUES ('19','2','6/6/2020', ' empty ');
INSERT INTO NhanvienvsNhomquyen(IDNhanvien,IDNhomquyen ,Ngayvaonhom,Ghichu  )
VALUES ('20','2','6/6/2020', ' empty ');
INSERT INTO NhanvienvsNhomquyen(IDNhanvien,IDNhomquyen ,Ngayvaonhom,Ghichu  )
VALUES ('1','3','6/6/2020', ' empty ');
INSERT INTO NhanvienvsNhomquyen(IDNhanvien,IDNhomquyen ,Ngayvaonhom,Ghichu  )
VALUES ('2','3','6/6/2020', ' empty ');
INSERT INTO NhanvienvsNhomquyen(IDNhanvien,IDNhomquyen ,Ngayvaonhom,Ghichu  )
VALUES ('11','3','6/6/2020', ' empty ');
INSERT INTO NhanvienvsNhomquyen(IDNhanvien,IDNhomquyen ,Ngayvaonhom,Ghichu  )
VALUES ('13','3','6/6/2020', ' empty ');
INSERT INTO [dbo].[Thanhlysach]
           ([IDThanhlysach],[IDSach],[IDKho],[Ngaythanhly],[Soluongsachthanhly],[Giatrithanhly])
     VALUES
           ('1','1','1','6/6/2020','2','10000')
INSERT INTO [dbo].[Thanhlysach]
           ([IDThanhlysach],[IDSach],[IDKho],[Ngaythanhly],[Soluongsachthanhly],[Giatrithanhly])
     VALUES
           ('2','3','3','6/6/2020','4','10000')
INSERT INTO [dbo].[Thanhlysach]
           ([IDThanhlysach],[IDSach],[IDKho],[Ngaythanhly],[Soluongsachthanhly],[Giatrithanhly])
     VALUES
           ('3','4','4','6/6/2020','4','10000')