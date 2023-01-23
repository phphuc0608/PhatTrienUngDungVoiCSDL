CREATE DATABASE De6
GO
USE De6
GO 
CREATE TABLE PHONG_BAN(
MaPB char(10) primary key,
TenPB nvarchar (100),
Chucnang nvarchar(100),
)
CREATE TABLE NHAN_VIEN(
MaNV char(10) primary key,
TenNV nvarchar (100),
NGaysinh datetime,
Phai nchar(10),
Quequan nvarchar(100),
SDT char(20),
MaPB char(10) foreign key (MaPB)references PHONG_BAN(MaPB),
)
CREATE TABLE CONG_TRINH(
MaCT char(10) primary key,
TenCT nvarchar (100),
Diadiem nvarchar(100),
)
CREATE TABLE PHAN_CONG(
ID INT identity(1,1) primary key,
MaCT char (10)foreign key (MaCT)references CONG_TRINH(MaCT),
MaNV char(10)foreign key (MaNV)references NHAN_VIEN(MaNV),
Ngayphancong datetime,
Ngayhoanthanh datetime,
)

select * from NHAN_VIEN
insert into PHONG_BAN(MaPB,TenPB,Chucnang) values ('PB1','Phong1','CN1')
insert into PHONG_BAN(MaPB,TenPB,Chucnang) values ('PB2','Phong2','CN2')
insert into PHONG_BAN(MaPB,TenPB,Chucnang) values ('PB3','Phong3','CN3')
select *from PHONG_BAN

INSERT INTO NHAN_VIEN (MaNV ,TenNV, NGaysinh, Phai, Quequan,SDT, MaPB) VALUES ('MaNV1','NV1','2/3/1994','A','HP','131555','PB1')
INSERT INTO NHAN_VIEN (MaNV ,TenNV, NGaysinh, Phai, Quequan,SDT, MaPB) VALUES ('MaNV2','NV2','6/3/1994','B','HN','13174555','PB2')
INSERT INTO NHAN_VIEN (MaNV ,TenNV, NGaysinh, Phai, Quequan,SDT,MaPB) VALUES ('MaNV3','NV3','8/3/1994','C','HD','13155475','PB3')
select *from NHAN_VIEN

UPDATE NHAN_VIEN SET TenNV='', NGaysinh='', Phai='', Quequan='',SDT=''
WHERE MaNV =''

create view nv AS
select MaNV ,TenNV, NGaysinh, Phai, Quequan,SDT,MaPB from NHAN_VIEN
select * from nv where TenNV LIKE '%%'
select * from nv where Quequan =''
--Cau 2
select b.MaPB , b.TenPB ,count(a.MaNV)[so nhan vien] from NHAN_VIEN as a,PHONG_BAN as b WHERE a.MaPB = b.MaPB
GROUP BY b.TenPB , b.MaPB
--cau3
SELECT * FROM PHONG_BAN
SELECT * FROM CONG_TRINH

CREATE VIEW VIEW_Cau3 AS
select DATEDIFF(DAY,Ngayphancong,Ngayhoanthanh)[TGHT],a.MaCT,a.TenCT,c.TenNV from CONG_TRINH as a,PHAN_CONG as b,NHAN_VIEN as c
WHERE a.MaCT = b.MaCT AND b.MaNV = c.MaNV    

SELECT MAX(TGHT) FROM VIEW_Cau3


