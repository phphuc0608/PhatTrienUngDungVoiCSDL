CREATE DATABASE De4
GO
USE De4
GO
CREATE TABLE TUYEN_DUNGG(
Matuyen char(10) primary key,
Tentuyen nvarchar(20),
Sokm int constraint Sokm check (Sokm >0),
Giave float constraint Giave check(Giave>0),
)
CREATE TABLE XE(
Maxe char(10) primary key,
Tenxe nvarchar(20),
Laixe nvarchar(20),
Phuxe nvarchar(20),
Socho int constraint Socho check (Socho>0),
Tinhtrang bit,
)
CREATE TABLE NHAT_TRINH(
MaNT char(10) primary key,
Ngay datetime,
Maxe char(10) foreign key (Maxe) references XE(Maxe),
)
CREATE TABLE CHI_TIET(
ID INT IDENTITY(1,1) primary key,
MaNT char(10) foreign key (MaNT) references NHAT_TRINH(MaNT),
Matuyen char(10) foreign key (Matuyen) references TUYEN_DUNGG(Matuyen),
Soveban int constraint Soveban check(Soveban>0),
)

INSERT INTO TUYEN_DUNGG(Matuyen,Tentuyen,Sokm,Giave) VALUES ('MT1','Tuyen1','20','250000')
INSERT INTO TUYEN_DUNGG(Matuyen,Tentuyen,Sokm,Giave) VALUES ('MT2','Tuyen2','10','150000')
INSERT INTO TUYEN_DUNGG(Matuyen,Tentuyen,Sokm,Giave) VALUES ('MT3','Tuyen3','15','200000')
select * from TUYEN_DUNGG

INSERT INTO XE(Maxe,Tenxe,Laixe,Phuxe,Socho,Tinhtrang) VALUES ('MX1','Xe1','Laixe1','Phuxe1','10','1')
INSERT INTO XE(Maxe,Tenxe,Laixe,Phuxe,Socho,Tinhtrang) VALUES ('MX2','Xe2','Laixe2','Phuxe2','4','2')
INSERT INTO XE(Maxe,Tenxe,Laixe,Phuxe,Socho,Tinhtrang) VALUES ('MX3','Xe3','Laixe3','Phuxe3','7','3')
select * from XE

INSERT INTO NHAT_TRINH(MaNT,Ngay,Maxe) VALUES ('MNT1','2/6/2020','MX1')
INSERT INTO NHAT_TRINH(MaNT,Ngay,Maxe) VALUES ('MNT2','3/6/2020','MX2')
INSERT INTO NHAT_TRINH(MaNT,Ngay,Maxe) VALUES ('MNT3','4/6/2020','MX3')
select * from NHAT_TRINH

INSERT INTO CHI_TIET(MaNT,Matuyen,Soveban) VALUES ('MNT1','MT1','4')
INSERT INTO CHI_TIET(MaNT,Matuyen,Soveban) VALUES ('MNT2','MT2','7')
INSERT INTO CHI_TIET(MaNT,Matuyen,Soveban) VALUES ('MNT3','MT3','10')
select * from CHI_TIET


--Cau3--
CREATE VIEW CAU3_VIEW AS
select b.Maxe,b.Tenxe,b.Laixe,b.Socho from TUYEN_DUNGG as a,XE as b,NHAT_TRINH as c,CHI_TIET as d
WHERE a.Matuyen = d.Matuyen AND b.Maxe = c.Maxe AND c.MaNT = d.MaNT AND b.Tinhtrang = 0
select * from CAU3_VIEW

--Cau2
 select c.MaNT, a.Matuyen,d.Soveban,a.Giave*d.Soveban[Thanh tien] from TUYEN_DUNGG as a,XE as b,NHAT_TRINH as c,CHI_TIET as d
 WHERE a.Matuyen = d.Matuyen AND b.Maxe = c.Maxe AND c.MaNT = d.MaNT 
