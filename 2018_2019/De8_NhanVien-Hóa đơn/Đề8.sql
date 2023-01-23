CREATE DATABASE De8
GO
USE De8
GO
CREATE TABLE SAN_PHAM(
Masp char(10) primary key,
Tensp nvarchar(100),
Mota nvarchar(100),
Dongia float constraint Dongia check(Dongia>0),
Xuatxu nvarchar(100),
)
CREATE TABLE NHAN_VIEN(
MaNV char(10) primary key,
TenNV nvarchar(100),
Ngaysinh datetime,
Phai nvarchar(10),
Diachi nvarchar(100),
SDT char(20),
)
CREATE TABLE HD_BAN(
MaHD INT IDENTITY(1,1) primary key,
MaNV char(10) foreign key (MaNV) references NHAN_VIEN(MaNV),
Ngayban datetime,
)
CREATE TABLE CHITIET_HD(
MaHD INT foreign key (MaHD) references HD_BAN(MaHD),
Soluong int constraint Soluong check(Soluong>0),
Giaban int constraint Giaban check(Giaban>0),
Masp char(10) foreign key (Masp) references SAN_PHAM(Masp),
)

insert into SAN_PHAM(Masp,Tensp,Mota,Dongia,Xuatxu) values ('MaSP1','Sanpham1','A','100000','VN')
insert into SAN_PHAM(Masp,Tensp,Mota,Dongia,Xuatxu) values ('MaSP2','Sanpham2','B','110000','VN')
insert into SAN_PHAM(Masp,Tensp,Mota,Dongia,Xuatxu) values ('MaSP3','Sanpham3','C','120000','VN')
select * from SAN_PHAM

insert into NHAN_VIEN (MaNV,TenNV,Ngaysinh,Phai,Diachi,SDT) values ('MaNV1','NV1','1-2-1999','N','HP','665155')
insert into NHAN_VIEN (MaNV,TenNV,Ngaysinh,Phai,Diachi,SDT) values ('MaNV2','NV2','2-2-1999','Ng','HN','66555')
insert into NHAN_VIEN (MaNV,TenNV,Ngaysinh,Phai,Diachi,SDT) values ('MaNV3','NV3','3-2-1999','Nh','HD','6655155')
select * from NHAN_VIEN

insert into HD_BAN(MaNV,Ngayban) values ('MaNV1','5/6/2020')
insert into HD_BAN(MaNV,Ngayban) values ('MaNV2','6/6/2020')
insert into HD_BAN(MaNV,Ngayban) values ('MaNV3','7/6/2020')
select * from HD_BAN

insert into CHITIET_HD(Soluong,Giaban,Masp) values ('20','50000','MaSP1')
insert into CHITIET_HD(Soluong,Giaban,Masp) values ('25','40000','MaSP2')
insert into CHITIET_HD(Soluong,Giaban,Masp) values ('30','30000','MaSP3')
select * from CHITIET_HD

UPDATE NHAN_VIEN SET TenNV='',Ngaysinh='',Phai='',Diachi='',SDT=''
WHERE MaNV=''

create view nv as

select *from nv where TenNV LIKE '%a%'
 select *from nv where Ngaysinh ='1-2-1999'
 
 select * from SAN_PHAM
 select * from CHITIET_HD
 --Cau2--
 select a.Tensp,a.Xuatxu,a.Dongia*b.Soluong from SAN_PHAM as a,CHITIET_HD as b
 where a.Masp=b.Masp
 --Cau3--
 create view sp as
 select a.Tensp,c.Ngayban,d.TenNV,a.Dongia,b.Soluong,a.Dongia*b.Soluong[Thanh tien] from SAN_PHAM as a,CHITIET_HD as b ,HD_BAN as c,NHAN_VIEN as d
 where a.Masp=b.Masp and b.MaHD=c.MaHD and c.MaNV=d.MaNV
 select *from sp

  
