CREATE DATABASE De3
GO 
USE De3
GO 
CREATE TABLE NHA_CUNGCAP(
MaCongty char(10) primary key,
TenCongty nvarchar(100),
Diachi nvarchar(100),
Dienthoai char(20),
)
CREATE TABLE MAT_HANG(
Mahang char(10)primary key,
Tenhang nvarchar(100),
Donvi float constraint Donvi check (Donvi > 0),
SL int constraint SL check (SL >0),
MaCongty char(10) foreign key (MaCongty) references NHA_CUNGCAP(MaCongty),
)
CREATE TABLE NHAN_VIEN(
MaNV char(10)primary key,
TenNV nvarchar(100),
Ngaysinh datetime,
SDT char(20),
)
CREATE TABLE PHIEU_NHAP(
ID int identity(1,1) primary key,
Mahang char(10) foreign key (Mahang) references MAT_HANG(Mahang),
MaNV char(10) foreign key (MaNV) references NHAN_VIEN(MaNV),
Soluongnhap int constraint Soluongnhap check(Soluongnhap > 0),
Ngaynhap datetime,
)

INSERT INTO NHA_CUNGCAP(MaCongty,TenCongty,Diachi,Dienthoai) VALUES ('MCT1','CTY1','HP','0151552')
INSERT INTO NHA_CUNGCAP(MaCongty,TenCongty,Diachi,Dienthoai) VALUES ('MCT2','CTY2','HP','01251552')
INSERT INTO NHA_CUNGCAP(MaCongty,TenCongty,Diachi,Dienthoai) VALUES ('MCT3','CTY3','HP','01521552')
SELECT * FROM NHA_CUNGCAP

INSERT INTO MAT_HANG(Mahang,Tenhang,Donvi,SL,MaCongty) VALUES ('MH1','Hang1','1','5','MCT1')
INSERT INTO MAT_HANG(Mahang,Tenhang,Donvi,SL,MaCongty) VALUES ('MH2','Hang2','2','1','MCT2')
INSERT INTO MAT_HANG(Mahang,Tenhang,Donvi,SL,MaCongty) VALUES ('MH3','Hang3','3','4','MCT3')
SELECT * FROM MAT_HANG

INSERT INTO NHAN_VIEN(MaNV,TenNV,Ngaysinh,SDT) VALUES ('NV1','Han','3/3/1997','15313515')
INSERT INTO NHAN_VIEN(MaNV,TenNV,Ngaysinh,SDT) VALUES ('NV2','Hanh','2/3/1997','125313515')
INSERT INTO NHAN_VIEN(MaNV,TenNV,Ngaysinh,SDT) VALUES ('NV3','Hang','6/3/1997','015313515')
SELECT * FROM NHAN_VIEN

INSERT INTO PHIEU_NHAP(Mahang,MaNV,Soluongnhap,Ngaynhap) VALUES ('MH1','NV1','50','2/1/2021')
INSERT INTO PHIEU_NHAP(Mahang,MaNV,Soluongnhap,Ngaynhap) VALUES ('MH2','NV2','20','3/1/2021')
INSERT INTO PHIEU_NHAP(Mahang,MaNV,Soluongnhap,Ngaynhap) VALUES ('MH3','NV3','40','3/1/2021')
SELECT * FROM PHIEU_NHAP

SELECT Mahang,Tenhang,Donvi,SL,MaCongty FROM MAT_HANG 
INSERT INTO MAT_HANG (Mahang,Tenhang,Donvi,SL) VALUES ('','',1,2)
UPDATE MAT_HANG SET Tenhang='',Donvi=2,SL=3
WHERE Mahang=''
--DELETE FROM MAT_HANG WHERE Mahang=''
CREATE VIEW HANG AS
SELECT Mahang,Tenhang,Donvi,SL,MaCongty FROM MAT_HANG 

SELECT * FROM HANG WHERE Tenhang LIKE '%c%'
SELECT * FROM HANG WHERE SL = 1

--TRIGGER -- Cau2
DECLARE @so1 int SET @so1 = 1--
DECLARE @so2 int SET @so1 = 3 + @so1 +4
PRINT(@so1)

SELECT * FROM PHIEU_NHAP
CREATE TRIGGER UTG_PN_DELETE on PHIEU_NHAP FOR DELETE
AS
BEGIN
	DECLARE @slnhap INT SET @slnhap = (SELECT deleted.Soluongnhap FROM deleted)
	DECLARE @mamh CHAR(10) SET @mamh = (SELECT deleted.Mahang FROM deleted)
	UPDATE MAT_HANG SET SL = SL - @slnhap WHERE MAT_HANG.Mahang = @mamh
END
GO

CREATE TRIGGER UTG_PN_UPDATE on PHIEU_NHAP FOR UPDATE
AS
BEGIN
	DECLARE @slnhapthem INT SET @slnhapthem = (SELECT inserted.Soluongnhap FROM inserted)
	DECLARE @slnhapxoa INT SET @slnhapxoa = (SELECT deleted.Soluongnhap FROM deleted)
	DECLARE @mamh CHAR(10) SET @mamh = (SELECT inserted.Mahang FROM inserted)
	UPDATE MAT_HANG SET SL = SL - @slnhapthem + @slnhapxoa  WHERE MAT_HANG.Mahang = @mamh
END
GO
-- Cau3-- Ten hang , Ten Nha Cung cap , Ngay nhap , So luong
CREATE FUNCTION UF_Cau3()RETURNS TABLE AS
	RETURN SELECT a.Tenhang , c.TenCongty , b.Ngaynhap , Soluongnhap FROM MAT_HANG AS a , PHIEU_NHAP AS b , NHA_CUNGCAP AS c , NHAN_VIEN AS d 
	WHERE a.Mahang = b.Mahang AND b.MaNV = d.MaNV AND a.MaCongty = c.MaCongty AND Soluongnhap > 50
GO

