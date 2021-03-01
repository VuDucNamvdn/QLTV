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
exec LaySach

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
GO
CREATE PROCEDURE ThemDMT @MaMuonTra int,@MaSach int,@SL int, @NgayTra datetime
AS 
INSERT INTO dbo.D_MuonTra(MaMuonTra,MaSach,SoLuongSach,NgayTra,TinhTrang)
VALUES      (@MaMuonTra,@MaSach,@SL,@NgayTra,'0');
GO





CREATE PROCEDURE LayDMT @MaMuonTra int
AS 
SELECT D_MuonTra.MaSach,DauSach.TenSach,D_MuonTra.SoLuongSach,
    CASE WHEN D_MuonTra.TinhTrang = 1 THEN N'Đã trả' ELSE N'Chưa trả' END, D_MuonTra.NgayTra 
FROM
    D_MuonTra
INNER JOIN DauSach ON D_MuonTra.MaSach = DauSach.MaSach  
where D_MuonTra.MaMuonTra = @MaMuonTra
GO
exec LayDMT '1'
