CREATE DATABASE De2
GO
USE De2
GO
CREATE TABLE NXB(
 MaNXB char(10) primary key,
 TenNXB nvarchar(100),
 )
CREATE TABLE S_VIEN(
MaSV char(10) primary key,
Hoten nvarchar(100) ,
Ngaysinh datetime,
Gioitinh bit,
)
  CREATE TABLE SACH(
Masach char(10) primary key,
Tensach nvarchar(100),
Theloai nvarchar(20),
NamXB int,
Trangthai char(3),
MaNXB char(10) foreign key (MaNXB) references NXB(MaNXB),
)
CREATE TABLE PHIEU_MUONN (
Masach char(10) foreign key (Masach) references SACH(Masach),
Ngaymuon datetime,
Ngaytra datetime,
MaSV char(10) foreign key (MaSV) references S_VIEN(MaSV),
)

INSERT INTO NXB(MaNXB,TenNXB) VALUES ('NXB1','ABC')
INSERT INTO NXB(MaNXB,TenNXB) VALUES ('NXB2','BCD')
INSERT INTO NXB(MaNXB,TenNXB) VALUES ('NXB3','CDE')
SELECT * FROM NXB

INSERT INTO  S_VIEN(MaSV,Hoten,Ngaysinh,Gioitinh) VALUES ('MA1','SV1','2/3/1997','0')
INSERT INTO  S_VIEN(MaSV,Hoten,Ngaysinh,Gioitinh) VALUES ('MA2','SV2','2/5/1997','1')
INSERT INTO  S_VIEN(MaSV,Hoten,Ngaysinh,Gioitinh) VALUES ('MA3','SV3','2/6/1997','0')
SELECT * FROM NXB

INSERT INTO SACH(Masach,Tensach,Theloai,NamXB,Trangthai,MaNXB) VALUES ('MS1','Sach1','TL1','2005','A','NXB1')
INSERT INTO SACH(Masach,Tensach,Theloai,NamXB,Trangthai,MaNXB) VALUES ('MS2','Sach2','TL2','2007','B','NXB3')
INSERT INTO SACH(Masach,Tensach,Theloai,NamXB,Trangthai,MaNXB) VALUES ('MS3','Sach3','TL3','2009','C','NXB2')
SELECT * FROM SACH

INSERT INTO PHIEU_MUONN(Masach,Ngaymuon,Ngaytra,MaSV) VALUES ('MS3','6/2/2020','6/10/2020','MA1')
INSERT INTO PHIEU_MUONN(Masach,Ngaymuon,Ngaytra,MaSV) VALUES ('MS2','7/2/2020','7/10/2020','MA2')
INSERT INTO PHIEU_MUONN(Masach,Ngaymuon,Ngaytra,MaSV) VALUES ('MS1','8/2/2020','8/10/2020','MA3')
SELECT * FROM PHIEU_MUONN

UPDATE SACH SET Tensach='',Theloai='',NamXB=0,Trangthai=''
WHERE Masach=''
--delete from SACH where Masach=''
--DROP DATABASE QLMS
SELECT * FROM SACH WHERE NamXB = 123
SELECT TOP(1) Tensach FROM SACH
SELECT Masach,Tensach,Theloai,NamXB,Trangthai,MaNXB FROM SACH 
--Cau2--
CREATE VIEW Cau2_VIEW AS
SELECT b.Tensach,COUNT(a.Masach)[SoLuong] FROM PHIEU_MUONN AS a,SACH AS b
WHERE a.Masach = b.Masach GROUP BY Tensach
--
SELECT * FROM Cau2_VIEW where SoLuong =(SELECT MAX(SoLuong) FROM Cau2_VIEW)
--
SELECT MAX(SoLuong) FROM Cau2_VIEW

--Cau 3-- tao trigger
CREATE TRIGGER CAU_3_INSERT ON PHIEU_MUONN FOR INSERT 
AS
	BEGIN
	
		UPDATE SACH SET Trangthai='NO' WHERE SACH.Masach = (SELECT Masach FROM INSERTED)
	END
	GO
CREATE TRIGGER CAU_3_DELETE ON PHIEU_MUONN FOR DELETE  
AS
	BEGIN
		UPDATE SACH SET Trangthai='YES' WHERE SACH.Masach = (SELECT Masach FROM deleted)
	END
	GO

