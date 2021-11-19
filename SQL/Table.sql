CREATE DATABASE TEST_BTL
USE TEST_BTL
drop database TEST_BTL


--Tạo bảng LOGIN
create table LOGIN(
	user_id nvarchar(50) primary key,
	password nvarchar(50)
)

--Tạo bảng KHOA
create table KHOA(
	id_khoa char(10) primary key not null,
	ten_khoa nvarchar(50),
	dia_chi nvarchar(50),
	so_dien_thoai varchar(10) ,
	nam_thanh_lap int check (nam_thanh_lap <= 2021  and nam_thanh_lap >=1960)
)

--Tạo bảng MONHOC
create table MONHOC(
	id_mon char(10) primary key not null,
	ten_mon nvarchar(50),
	id_khoa char(10) references KHOA(id_khoa),
	so_tin_chi int check(so_tin_chi in ('2','3','10','8')),
	he_so_cc float, he_so_gk float, he_so_ck float
)

--Tạo bảng giangvien
create table GIANGVIEN
(	id_GV char(10) primary key,
	ten_GV nvarchar(50),
	gioi_tinh bit,
	dob_gv date,
	So_dien_thoai char(10),
	quequan char(20),
	id_khoa char(10) references KHOA(id_khoa)
)
drop table GIANGVIEN

ALTER TABLE giangvien ALTER COLUMN gioi_tinh char(5) NOT NULL;
UPDATE giangvien SET gioi_tinh= 'Nam' WHERE gioi_tinh='1'
UPDATE giangvien SET gioi_tinh= 'Nu' WHERE gioi_tinh='0'

--Tạo bảng giangvien.monhoc
create table GIANGVIEN_MONHOC(
	id_mon char(10) references MONHOC(id_mon),
	id_gv char(10) references GIANGVIEN(id_gv)
	primary key(id_mon,id_gv)
)

--Tạo bảng LOPHOCPHAN
create table LOPHOCPHAN(
	id_lhp char(10) primary key,
	ten_lhp nvarchar(50),
	id_mon char(10),
	id_gv char(10),
	constraint FK_GV_MON foreign key(id_mon,id_gv) references GIANGVIEN_MONHOC(id_mon,id_gv),
	si_so int check(si_so <=60)
)
--Tạo bảng LOPHOC
create table LOPCQ(
	id_lop char(10) primary key,
	ten_lop nvarchar(50),
	id_khoa char(10) references KHOA(id_khoa),
	si_so int check(si_so <=60)
)
--Tạo bảng SINHVIEN
create table SINHVIEN(
	id_sv char(10) primary key,
	ten_sv nvarchar(50),
	dob_sv date,
	gioi_tinh bit,
	que_quan nvarchar(50),
	id_lop char(10) references LOPCQ(id_lop)
)
ALTER TABLE sinhvien ALTER COLUMN gioi_tinh char(5) NOT NULL;


UPDATE sinhvien SET gioi_tinh= 'Nam' WHERE gioi_tinh='1'

UPDATE sinhvien SET gioi_tinh= 'Nu' WHERE gioi_tinh='0'

create table SINHVIEN_LOPHP(
	id_lhp char(10) references LOPHOCPHAN(id_lhp),
	id_sv char(10) references SINHVIEN(id_sv),
	primary key(id_lhp,id_sv)
)

drop table DIEMHOCPHAN
select *from DIEMHOCPHAN
--tạo lại bang DIEMHOCPHAN
create table DIEMHOCPHAN(
	id_lhp char(10),
	id_sv char(10) ,
	foreign key (id_lhp,id_sv) references SINHVIEN_LOPHP(id_lhp,id_sv),
	primary key(id_lhp,id_sv),
	diem_cc float check(diem_cc > 0 and diem_cc <= 10),
	diem_gk float check(diem_gk > 0 and diem_gk <= 10),
	diem_ck float check(diem_ck > 0 and diem_ck <= 10),
	diem_tk float default null,
	diem_he_4 char(2) default('F')
)


--Tạo bảng Chứng chỉ
create table CHUNGCHI(
	id_cc char(10) primary key,
	ten_cc nvarchar(50)
)

--Tạo bảng sinhvien_chungchi
create table SINHVIEN_CHUNGCHI(
	id_sv char(10) references SINHVIEN(id_sv),
	id_cc char(10) references CHUNGCHI(id_cc),
	primary key(id_sv,id_cc)
)


--Proc update_diem
create proc update_diem
as
begin
 update DIEMHOCPHAN set diem_tk = diem_cc * MONHOC.he_so_cc + diem_gk * MONHOC.he_so_gk + diem_ck * MONHOC.he_so_ck
 from DIEMHOCPHAN,LOPHOCPHAN,MONHOC
 where DIEMHOCPHAN.id_lhp = LOPHOCPHAN.id_lhp and LOPHOCPHAN.id_mon = MONHOC.id_mon
end
exec update_diem
select *from DIEMHOCPHAN
drop proc update_diem
--Proc doi_diem
create proc doi_diem
as
begin
	update DIEMHOCPHAN set diem_he_4 =
	case
		when diem_tk >= 9	then 'A+'
		when diem_tk >=8.5	then 'A'
		when diem_tk >=8	then 'B+'
		when diem_tk >=7	then 'B'
		when diem_tk >=6.5	then 'C+'
		when diem_tk >=6	then 'C'
		when diem_tk >=5.5	then 'D+'
		when diem_tk >=4.5	then 'D'
		else 'F' 
	end
end

drop proc doi_diem
exec doi_diem
delete  @diem_tk
--====================================================================================
--==========================TRIGGER===================================================
--====================================================================================
--trigger thêm số lượng sinhh viên lớp học phần 
update LOPHOCPHAN set si_so = 0
select *from LOPHOCPHAN

create trigger them_sl_sv_lhp on SINHVIEN_LOPHP for insert as
begin
	update LOPHOCPHAN set LOPHOCPHAN.si_so = si_so + 
	(select count(inserted.id_lhp) from inserted where LOPHOCPHAN.id_lhp = inserted.id_lhp)
end

drop trigger them_sl_sv_lhp

--trigger giảm số lượng sinhh viên lớp học phần 
create trigger bot_sl_sv_lhp on SINHVIEN_LOPHP for delete as
begin
	update LOPHOCPHAN set LOPHOCPHAN.si_so = si_so - 
	(select count(deleted.id_lhp) from deleted where LOPHOCPHAN.id_lhp = deleted.id_lhp)
end
drop trigger bot_sl_sv_lhp

--trigger tính điểm
create trigger tinh_diem_tk on DIEMHOCPHAN for insert as
begin
	update DIEMHOCPHAN set diem_tk = inserted.diem_cc * MONHOC.he_so_cc +inserted.diem_gk * MONHOC.he_so_gk + inserted.diem_ck * MONHOC.he_so_ck
	from DIEMHOCPHAN,inserted,LOPHOCPHAN,MONHOC
	where DIEMHOCPHAN.id_lhp = inserted.id_lhp and DIEMHOCPHAN.id_sv = inserted.id_sv
	and DIEMHOCPHAN.id_lhp = LOPHOCPHAN.id_lhp and LOPHOCPHAN.id_mon = MONHOC.id_mon

	update DIEMHOCPHAN set diem_he_4 = 
	case
		when DIEMHOCPHAN.diem_tk >= 9	then 'A+'
		when DIEMHOCPHAN.diem_tk >=8.5	then 'A'
		when DIEMHOCPHAN.diem_tk >=8	then 'B+'
		when DIEMHOCPHAN.diem_tk >=7	then 'B'
		when DIEMHOCPHAN.diem_tk >=6.5	then 'C+'
		when DIEMHOCPHAN.diem_tk >=6	then 'C'
		when DIEMHOCPHAN.diem_tk >=5.5	then 'D+'
		when DIEMHOCPHAN.diem_tk >=4.5	then 'D'
		else 'F' 
	end
end
drop trigger tinh_diem_tk

--trigger cập nhật điểm
create trigger tinh_diem_tk_update on DIEMHOCPHAN for update as
begin
	update DIEMHOCPHAN set diem_tk = inserted.diem_cc * MONHOC.he_so_cc +inserted.diem_gk * MONHOC.he_so_gk + inserted.diem_ck * MONHOC.he_so_ck
	from DIEMHOCPHAN,inserted,LOPHOCPHAN,MONHOC
	where DIEMHOCPHAN.id_lhp = inserted.id_lhp and DIEMHOCPHAN.id_sv = inserted.id_sv
	and DIEMHOCPHAN.id_lhp = LOPHOCPHAN.id_lhp and LOPHOCPHAN.id_mon = MONHOC.id_mon

	update DIEMHOCPHAN set diem_he_4 = 
	case
		when DIEMHOCPHAN.diem_tk >= 9	then 'A+'
		when DIEMHOCPHAN.diem_tk >=8.5	then 'A'
		when DIEMHOCPHAN.diem_tk >=8	then 'B+'
		when DIEMHOCPHAN.diem_tk >=7	then 'B'
		when DIEMHOCPHAN.diem_tk >=6.5	then 'C+'
		when DIEMHOCPHAN.diem_tk >=6	then 'C'
		when DIEMHOCPHAN.diem_tk >=5.5	then 'D+'
		when DIEMHOCPHAN.diem_tk >=4.5	then 'D'
		else 'F' 
	end
end
drop trigger tinh_diem_tk_update
