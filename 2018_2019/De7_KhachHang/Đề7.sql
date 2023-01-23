CREATE DATABASE De7
USE De7
GO 
CREATE TABLE PHONG(
Maphong char(10) primary key,
Tenphong nvarchar (100),
Loaiphong nvarchar (100),
Giaphong float constraint Giaphong check(Giaphong>0),
Mota nvarchar(100),
)
CREATE TABLE KHACH_HANG(
MaKH int IDENTITY(1,10) primary key,
TenKH nvarchar (100),
CMND char(20),
Quoctich nvarchar(100),
Gioitinh bit,
Maphong char(10) foreign key (Maphong)references PHONG(Maphong),
)
CREATE TABLE DK_THUEPHONG(
MaTP int IDENTITY(1,1) primary key,
MaKH int foreign key (MaKH) references KHACH_HANG(MaKH),
Maphong char(10) foreign key (Maphong)references PHONG(Maphong),
Ngaynhan datetime,
Dattruoc float constraint Dattruoc check(Dattruoc>0),
)
CREATE TABLE HOA_DON(
MaHD int IDENTITY(1,1) primary key,
MaTP int foreign key (MaTP)references DK_THUEPHONG(MaTP),
Ngaytracong datetime,
Sotien float constraint Sotien check(Sotien >0),
)

insert into PHONG(Maphong,Tenphong,Loaiphong,Giaphong,Mota) values ('1','Phong1','Loai1','100000','ABC')
insert into PHONG(Maphong,Tenphong,Loaiphong,Giaphong,Mota) values ('2','Phong2','Loai2','120000','BCD')
insert into PHONG(Maphong,Tenphong,Loaiphong,Giaphong,Mota) values ('3','Phong3','Loai3','150000','CDE')

insert into KHACH_HANG(TenKH,CMND,Quoctich,Gioitinh,Maphong) values ('An','03155156','VN','1','1')
insert into KHACH_HANG(TenKH,CMND,Quoctich,Gioitinh,Maphong) values ('Anh','03155156','VN','0','2')
insert into KHACH_HANG(TenKH,CMND,Quoctich,Gioitinh,Maphong) values ('Lam','03155156','VN','1','3')

insert into DK_THUEPHONG(Maphong,Ngaynhan,Dattruoc) values ('1','2/3/2020','1')
insert into DK_THUEPHONG(Maphong,Ngaynhan,Dattruoc) values ('2','2/4/2020','2')
insert into DK_THUEPHONG(Maphong,Ngaynhan,Dattruoc) values ('3','2/5/2020','3')

insert into HOA_DON(Ngaytracong,Sotien) values ('6/7/2020','100000')
insert into HOA_DON(Ngaytracong,Sotien) values ('9/7/2020','120000')
insert into HOA_DON(Ngaytracong,Sotien) values ('5/7/2020','130000')

SELECT * FROM PHONG
SELECT * FROM KHACH_HANG
SELECT * FROM DK_THUEPHONG
SELECT * FROM HOA_DON

select MaKH,TenKH,CMND,Quoctich,Gioitinh,Maphong from KHACH_HANG
create view kh as
select MaKH,TenKH,CMND,Quoctich,Gioitinh,Maphong from KHACH_HANG
select * from kh where TenKH LIKE '%a%'

 --Cau 2
create view hd AS
SELECT (datediff(day,c.ngaynhan,a.Ngaytracong)*d.Giaphong- c.Dattruoc)[Sotien] , d.MaPhong FROM HOA_DON as a,KHACH_HANG as b, DK_THUEPHONG as c ,PHONG as d
where a.MaTP=c.MaTP and b.MaKH=c.MaKH and c.Maphong=d.Maphong
SELECT * FROM hd

-- Cau 3
GO
CREATE VIEW Tien_Phong AS
select (SUM(Sotien))[SoTien],b.Tenphong from hd as a, PHONG as b
WHERE a.MaPhong = b.Maphong
GROUP BY Tenphong

SELECT MAX(SoTien) FROM hd

