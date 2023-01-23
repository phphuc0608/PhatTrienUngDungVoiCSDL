CREATE DATABASE De5
GO
USE De5
GO
CREATE TABLE LOP(
Malop char(10) primary key,
Tenlop nvarchar(20),
Siso int constraint Siso check(Siso>0),
)
CREATE TABLE SINH_VIEN(
MaSV char(10) primary key,
Hoten nvarchar(100),
Ngaysinh datetime,
Gioitinh bit,
Quequan nvarchar(100),
Malop char(10) foreign key (Malop) references LOP (Malop),
)
CREATE TABLE MON_HOC(
Mamon char(10) primary key,
Tenmon nvarchar(50),
SoTC int constraint SoTC check(SoTC >0),
Hocky int constraint Hocky check(Hocky >0),
)
CREATE TABLE BANG_DIEM(
MaSV char(10) foreign key (MaSV) references SINH_VIEN (MaSV),
Malop char(10) foreign key (Malop) references LOP (Malop),
Mamon char(10) foreign key (Mamon) references MON_HOC (Mamon),
Diemgiuaky int constraint Diemgiuaky check(Diemgiuaky>0),
Diemcuoiky int constraint Diemcuoiky check(Diemcuoiky>0),
Diemtongket int constraint Diemtongket check(Diemtongket>0),
)

INSERT INTO LOP(Malop,Tenlop,Siso) VALUES ('ML1','Lop1','50')
INSERT INTO LOP(Malop,Tenlop,Siso) VALUES ('ML2','Lop2','55')
INSERT INTO LOP(Malop,Tenlop,Siso) VALUES ('ML3','Lop3','58')
SELECT * FROM LOP

INSERT INTO SINH_VIEN(MaSV, Hoten,Ngaysinh,Gioitinh,Quequan,Malop) VALUES ('MaSV1','Sinhvien1','1/5/1999','0','HP','ML1')
INSERT INTO SINH_VIEN(MaSV, Hoten,Ngaysinh,Gioitinh,Quequan,Malop) VALUES ('MaSV2','Sinhvien2','2/5/1999','1','HP','ML2')
INSERT INTO SINH_VIEN(MaSV, Hoten,Ngaysinh,Gioitinh,Quequan,Malop) VALUES ('MaSV3','Sinhvien3','3/5/1999','0','HP','ML3')
select * from SINH_VIEN
UPDATE SINH_VIEN SET  Hoten='',Ngaysinh='',Gioitinh='',Quequan='',Malop='' 
WHERE MaSV=''

INSERT INTO MON_HOC(Mamon,Tenmon,SoTC,Hocky) VALUES ('MM1','Mon1','4','1')
INSERT INTO MON_HOC(Mamon,Tenmon,SoTC,Hocky) VALUES ('MM2','Mon2','3','2')
INSERT INTO MON_HOC(Mamon,Tenmon,SoTC,Hocky) VALUES ('MM3','Mon3','4','1')
SELECT * FROM MON_HOC

INSERT INTO BANG_DIEM(MaSV,Malop,Mamon,Diemgiuaky,Diemcuoiky,Diemtongket) VALUES ('MaSV1','ML1','MM1','7','7','7')
INSERT INTO BANG_DIEM(MaSV,Malop,Mamon,Diemgiuaky,Diemcuoiky,Diemtongket) VALUES ('MaSV2','ML2','MM2','8','8','8')
INSERT INTO BANG_DIEM(MaSV,Malop,Mamon,Diemgiuaky,Diemcuoiky,Diemtongket) VALUES ('MaSV3','ML2','MM2','9','9','9')
SELECT * FROM BANG_DIEM

CREATE VIEW ten AS
SELECT MaSV,Hoten, Ngaysinh,Gioitinh,Quequan,Malop FROM SINH_VIEN
SELECT *FROM ten WHERE Hoten LIKE '%%'
--FUNCTION , PROC
--TRIGGER
SELECT * FROM LOP
SELECT * FROM SINH_VIEN
INSERT INTO SINH_VIEN(MaSV, Hoten,Ngaysinh,Gioitinh,Quequan,Malop) VALUES ('1','1','3-9-1999',0,'3','')
-- DELETE FROM SINH_VIENN WHERE MaSV = N'a'
-- Cau2-- TRIGGER 
CREATE TRIGGER C1 ON SINH_VIEN FOR INSERT
AS
BEGIN
	UPDATE LOP SET Siso= Siso+1 
END
 GO
 CREATE TRIGGER C2 ON SINH_VIEN FOR DELETE
AS
BEGIN
	UPDATE LOP SET Siso= Siso-1 
END
 GO
 CREATE TRIGGER C3 ON SINH_VIEN FOR UPDATE
AS
BEGIN
	UPDATE LOP SET Siso= Siso
END
 GO
 --Cau3--Thong ke SV diem >3.2
SELECT COUNT(A.MaSV)[TONG SINH VIEN] FROM SINH_VIEN AS A, BANG_DIEM AS B
WHERE A.MaSV=B.MaSV AND Diemtongket>3.2
