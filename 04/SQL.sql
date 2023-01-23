create database De4
use De4
create table KhoaHoc
(
	MaKhoaHoc nvarchar(25) primary key,
	TenKhoaHoc nvarchar(200) not null unique,
	SoBuoi int,
	HocPhi numeric(18,0)
)
create table LopHoc
(
	MaLop nvarchar(30) primary key,
	TenLop nvarchar(100),
	MaKhoaHoc nvarchar(25),
	MaGV nvarchar(20),
	TuNgay datetime,
	DenNgay datetime,
	foreign key(MaKhoaHoc) references KhoaHoc(MaKhoaHoc),
	foreign key(MaGV) references GiaoVien(MaGV)
)
create table HocVien
(
	MaHV nvarchar(25) primary key,
	TenHV nvarchar(50) not null,
	NgaySinh datetime,
	Tel varchar(50),
	MaLop nvarchar(30),
	NgayVao datetime,
	foreign key(MaLop) references LopHoc(MaLop)
)
create table GiaoVien
(
	MaGV nvarchar(20) primary key,
	TenGV nvarchar(50),
	DiaChi nvarchar(100)
)

--Cau 2
create view TimKiemLopHoc
as select MaLop,TenLop,MaKhoaHoc,LopHoc.MaGV,TuNgay,DenNgay from LopHoc inner join GiaoVien on GiaoVien.MaGV = LopHoc.MaGV where DiaChi = 'KHOA CNTT'

--Cau 3
alter table LopHoc add SoHocVien int not null default 0

create trigger ThemHocVien
on HocVien
for insert
as begin
	declare @maLop nvarchar(30);
	set @maLop = (select MaLop from inserted);
	update LopHoc set SoHocVien = SoHocVien + 1 where MaLop = @maLop;
end
------------------------------------------------------------------------------------
create trigger XoaHocVien
on HocVien
for delete
as begin
	declare @maLop nvarchar(30);
	set @maLop = (select MaLop from deleted);
	update LopHoc set SoHocVien = SoHocVien - 1 where MaLop = @maLop;
end

create trigger SuaHocVien
on HocVien
for update
as begin
	declare @maLopCu nvarchar(30);
	declare @maLopMoi nvarchar(30);
	set @maLopCu = (select MaLop from deleted);
	set @maLopMoi = (select MaLop from inserted);
	update LopHoc set SoHocVien = SoHocVien - 1 where MaLop = @maLopCu;
	update LopHoc set SoHocVien = SoHocVien + 1 where MaLop = @maLopMoi;
end


drop procedure [spThemHocVien]
create procedure spThemHocVien @maHV nvarchar(25), @tenHV nvarchar(50), @ngaySinh datetime, @Tel varchar(50), @maLop nvarchar(30), @ngayVao datetime
as begin
	declare @dem int;
	set @dem = (select count(*) from HocVien where MaHV = @maHV);
	if @dem > 0
		throw 50000,N'Trùng mã học viên',1;
	else
		set @dem = (select count(*) from LopHoc where MaLop = @maLop);
		if @dem <= 0
			throw 50001,N'Lớp học không tồn tại',1;
		else 
			insert HocVien values (@maHV,@tenHV,@ngaySinh,@Tel,@maLop,@ngayVao);
end

create procedure spSuaHocVien @maHV nvarchar(25), @tenHV nvarchar(50), @ngaySinh datetime, @Tel varchar(50), @maLop nvarchar(30), @ngayVao datetime
as begin
	declare @dem int;
	set @dem = (select count(*) from LopHoc where MaLop = @maLop);
	if @dem <= 0
		throw 50000,N'Lớp học không tồn tại',1;
	else
		update HocVien set TenHV = @tenHV, NgaySinh = @ngaySinh, Tel = @Tel, MaLop = @maLop, NgayVao = @ngayVao where MaHV = @maHV
end

