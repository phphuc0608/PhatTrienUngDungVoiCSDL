create database De1
go
use De1
GO
create table BENH_NHAN(
Mabn char(10) PRIMARY KEY ,
Tenbn nvarchar(50),
Ngaysinh datetime,
Gioitinh nchar(10),
Diachi nvarchar(100),
Ngaynhapvien datetime,
)
create table KHOA(
Makhoa char(10) primary key,
Tenkhoa nvarchar(50) ,
Chucnang nvarchar(50),
)
create table BAC_SI(
Mabs char(10) primary key,
Tenbs nvarchar(20),
Makhoa char(10),
FOREIGN key (Makhoa) REFERENCES KHOA(Makhoa),
)
create table CHI_TIET_KHAM(
Id int primary key identity(1,1),
Ngaykham datetime,
Ketluan nvarchar(100),
Vienphi float check(Vienphi>0),
Mabn char(10) ,
FOREIGN key (Mabn) REFERENCES BENH_NHAN(Mabn),
Mabs char(10) ,
FOREIGN key (Mabs) REFERENCES BAC_SI(Mabs),
)
INSERT INTO BENH_NHAN(Mabn,Tenbn,Ngaysinh,Gioitinh,Diachi,Ngaynhapvien) VALUES('BN1',N'An','3/6/1995','1','2/35','2/11/2020')
INSERT INTO BENH_NHAN(Mabn,Tenbn,Ngaysinh,Gioitinh,Diachi,Ngaynhapvien) VALUES('BN2',N'Anh','2/3/1992','0','2/36','2/10/2020')
INSERT INTO BENH_NHAN(Mabn,Tenbn,Ngaysinh,Gioitinh,Diachi,Ngaynhapvien) VALUES('BN3',N'Ang','3/7/1996','1','2/361','2/12/2020')
SELECT * FROM BENH_NHAN

INSERT INTO KHOA (Makhoa,Tenkhoa,Chucnang) VALUES('K1','Khoa1','CN1')
INSERT INTO KHOA (Makhoa,Tenkhoa,Chucnang) VALUES('K2','Khoa2','CN2')
INSERT INTO KHOA (Makhoa,Tenkhoa,Chucnang) VALUES('K3','Khoa3','CN3')
SELECT * FROM KHOA

INSERT INTO BAC_SI (Mabs,Tenbs,Makhoa) VALUES ('BS1','Toan','K1')
INSERT INTO BAC_SI (Mabs,Tenbs,Makhoa) VALUES ('BS2','Tan','K2')
INSERT INTO BAC_SI (Mabs,Tenbs,Makhoa) VALUES ('BS3','Ton','K3')
SELECT * FROM BAC_SI

INSERT INTO CHI_TIET_KHAM (Ngaykham,Ketluan,Vienphi,Mabn,Mabs) VALUES ('1/18/2021','Binhthuong','200000','BN1','BS3')
INSERT INTO CHI_TIET_KHAM (Ngaykham,Ketluan,Vienphi,Mabn,Mabs) VALUES ('1/17/2021','Binhthuong','210000','BN2','BS2')
INSERT INTO CHI_TIET_KHAM (Ngaykham,Ketluan,Vienphi,Mabn,Mabs) VALUES ('1/16/2021','Binhthuong','220000','BN3','BS1')
SELECT * FROM CHI_TIET_KHAM

--Cau2--
SELECT c.Makhoa,b.Tenbs,SUM(Vienphi) FROM CHI_TIET_KHAM AS a, BAC_SI AS b, KHOA AS c
WHERE a.Mabs = b.Mabs AND b.Makhoa = c.Makhoa
GROUP BY c.Makhoa , b.Tenbs

--Cau3
--TAO VIEW MABS,TENBS,TENKHOA bAC SI CO NHIEU BENH NHAN NHAT
CREATE VIEW CAU3 AS
SELECT A.Mabs,A.Tenbs,C.Tenkhoa ,COUNT(B.Mabn)[SO BENH NHAN] FROM  BAC_SI AS A,CHI_TIET_KHAM AS B, KHOA AS C
WHERE A.Mabs=B.Mabs AND A.Makhoa=C.Makhoa
GROUP BY  A.Mabs,A.Tenbs,C.Tenkhoa

SELECT MAX([SO BENH NHAN]) FROM CAU3
SELECT * FROM CAU3 WHERE [SO BENH NHAN] = (SELECT MAX([SO BENH NHAN]) FROM CAU3)


---
--Tong bac si theo tung khoa 
CREATE  VIEW C4 AS
SELECT B.Tenkhoa, COUNT(A.Mabs)[TONG BAC SI] FROM BAC_SI AS A,KHOA AS B 
WHERE A.Makhoa=B.Makhoa
GROUP BY B.Tenkhoa

--KHOA CO NHIEU BAC SI NHAT 
SELECT * FROM C4 WHERE [TONG BAC SI] =(SELECT MAX([TONG BAC SI])FROM C4)

-- TAO VIEW CO TEN BENH NHAN, TEN BAC SI ,TEN KHOA .TONG SO BENH NHAN KHAM THEO TUNG BAC SI
CREATE VIEW C5 AS
SELECT D.Tenbn, B.Tenbs,C.Tenkhoa ,COUNT (A.Mabn)[TONG BENH NHAN]FROM CHI_TIET_KHAM AS A, BAC_SI AS B, KHOA AS C, BENH_NHAN AS D
WHERE D.Mabn=A.Mabn AND B.Makhoa=C.Makhoa AND A.Mabs=B.Mabs AND KHOA.Makhoa=''
GROUP BY D.Tenbn, B.Tenbs,C.Tenkhoa 
SELECT * FROM C5 WHERE 
 



 




SELECT Mabn , Tenbn , Ngaysinh , Gioitinh , Diachi , Ngaynhapvien FROM BENH_NHAN WHERE Tenbn LIKE N'%%' AND Ngaynhapvien = ''

INSERT INTO BENH_NHAN(Mabn , Tenbn , Ngaysinh , Gioitinh , Diachi , Ngaynhapvien)
VALUES ('','','','','','')
update BENH_NHAN set Tenbn = N'', Ngaysinh='' , Gioitinh='' , Diachi='' , Ngaynhapvien=''
where Mabn=''
delete from BENH_NHAN where Mabn=''
SELECT * FROM BENH_NHAN WHERE Tenbn LIKE N'%q%' AND
CREATE VIEW View_BenhNhan AS
SELECT Mabn , Tenbn , Ngaysinh , Gioitinh , Diachi , Ngaynhapvien FROM BENH_NHAN WHERE Tenbn LIKE N'%q%' AND Ngaynhapvien = '" + dateTimePicker2.Value + "'
SELECT * FROM View_BenhNhan WHERE Tenbn LIKE N'%q%'