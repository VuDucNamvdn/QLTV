Use QLTV
Go

exec ThemSach @TenSach = N'Một ngày ta có 48 giờ', @TenTheLoai = N'Khoa huyễn', @sl = '5'

--Quản lý đầu sách
CREATE PROCEDURE ThemTheLoai @TenTheLoai nvarchar(100)
AS
INSERT INTO dbo.TheLoai(TenTheLoai)
VALUES      (@TenTheLoai);  
GO
CREATE PROCEDURE ThemSach @TenSach nvarchar(100), @TenTheLoai nvarchar(100), @sl int
AS
INSERT INTO dbo.DauSach(TenSach,MaTheLoai,Sl)
VALUES      (@TenSach,  
             (Select MaTheLoai from TheLoai where TenTheLoai = @TenTheLoai),  
             @sl);  
GO

--Quản lý độc giả
CREATE PROCEDURE ThemDocGia @TenDocGia nvarchar(100), @NgayHetHan datetime
AS
INSERT INTO dbo.Docgia(TenDocGia,NgayHetHan)
VALUES      (@TenDocGia,@NgayHetHan);  
GO
--Quản lý mược trả