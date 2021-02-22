Use QLTV
Go

--Quản lý đầu sách
CREATE PROCEDURE ThemTheLoai @TenTheLoai nvarchar(100)
AS
INSERT INTO dbo.TheLoai(TenTheLoai)
VALUES      (@TenTheLoai);  
GO
CREATE PROCEDURE ThemSach @TenSach nvarchar(100), @MaTheLoai int, @sl int
AS
INSERT INTO dbo.DauSach(TenSach,MaTheLoai,Sl)
VALUES      (@TenSach,  
             @MaTheLoai,  
             @sl);  
GO

--Quản lý độc giả
CREATE PROCEDURE ThemDocGia @TenDocGia nvarchar(100), @NgayHetHan datetime
AS
INSERT INTO dbo.Docgia(TenDocGia,NgayHetHan)
VALUES      (@TenDocGia,@NgayHetHan);  
GO
--Quản lý mược trả