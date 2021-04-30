Use QLTV
Go

CREATE PROCEDURE ThemTK @id nvarchar(100), @pass nvarchar(100), @role int
AS
INSERT INTO dbo.DangNhap(MaNguoiDung,MatKhau,Quyen)
VALUES      (@id,@pass,@role);  
GO

--Quản lý đầu sách
CREATE PROCEDURE LaySach
AS
    SELECT DauSach.MaSach,DauSach.TenSach ,TheLoai.TenTheLoai , DauSach.Sl  
    FROM TheLoai  
    INNER JOIN DauSach  
    ON TheLoai.MaTheLoai = DauSach.MaTheLoai  
    ORDER BY MaSach; 
Go

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
CREATE PROCEDURE ThemMT @MaDocGia int, @NgayHetHan datetime
AS
INSERT INTO dbo.MuonTra(MaDocGia,NgayHetHan)
VALUES      (@MaDocGia,@NgayHetHan);  
SELECT SCOPE_IDENTITY();
GO

CREATE PROCEDURE ThemDMT @MaMuonTra int,@MaSach int,@SL int, @NgayTra datetime
AS
UPDATE dbo.DauSach
SET Sl = Sl-@SL
WHERE MaSach = @MaSach;
INSERT INTO dbo.D_MuonTra(MaMuonTra,MaSach,SoLuongSach,NgayTra,TinhTrang)
VALUES      (@MaMuonTra,@MaSach,@SL,@NgayTra,'0');
GO

CREATE PROCEDURE LayDMT @MaMuonTra int
AS 
SELECT D_MuonTra.MaSach,DauSach.TenSach,
    CASE WHEN D_MuonTra.TinhTrang = 1 THEN N'Đã trả' ELSE N'Chưa trả' END, D_MuonTra.NgayTra 
FROM
    D_MuonTra
INNER JOIN DauSach ON D_MuonTra.MaSach = DauSach.MaSach  
where D_MuonTra.MaMuonTra = @MaMuonTra
GO

CREATE PROCEDURE XoaMT @MaMuonTra int
AS
DELETE D_MuonTra Where D_MuonTra.MaMuonTra = @MaMuonTra
DELETE MuonTra Where MuonTra.MaMuonTra = @MaMuonTra
Go

CREATE PROCEDURE XacNhanTra @MaMuonTra int,@MaSach int, @NgayTra datetime
AS
UPDATE dbo.D_MuonTra
SET TinhTrang = '1',NgayTra = @NgayTra
WHERE MaSach = @MaSach AND MaMuonTra = @MaMuonTra AND TinhTrang = 0;
GO

CREATE PROCEDURE SuaMT @MaMuonTra int, @MaDocGia int, @NgayHetHan datetime
AS
UPDATE dbo.MuonTra
SET    MaDocGia = @MaDocGia, NgayHetHan = @NgayHetHan
Where MaMuonTra =@MaMuonTra;
GO


CREATE PROCEDURE SuaD_MT @MaMuonTra int,@MaSach int, @MaSachBanDau int
AS 
UPDATE D_MuonTra
Set MaSach = @MaSach
where D_MuonTra.MaMuonTra = @MaMuonTra And MaSach = @MaSachBanDau 
GO

CREATE PROCEDURE XoaD_MT @MaMuonTra int, @MaSach int
As
delete D_MuonTra where D_MuonTra.MaSach = @MaSach and D_MuonTra.MaMuonTra = @MaMuonTra
Declare @cnt int
select @cnt = COUNT(D_MuonTra.MaSach) from D_MuonTra where D_MuonTra.MaMuonTra = @MaMuonTra
IF @cnt <1
    delete MuonTra where MuonTra.MaMuonTra = @MaMuonTra;
GO
drop proc SuaD_MT
