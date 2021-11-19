--BẢNG LOGIN
INSERT INTO LOGIN VALUES('admin','password')

--BẢNG KHOA
INSERT INTO KHOA VALUES 
	('KHMT','Khoa hoc may tinh','P1002','0123456788',2008),
	('DT','Dau tu','P1003','0123456787',2008),
	('CNTT','Cong nghe thong tin','P1000','0123456789',2008),
	('QTKD','Quan tri kinh doanh','P1001','0123456787',1980)
delete KHOA

--BẢNG MONHOC
INSERT INTO MONHOC VALUES 
	('CNTT1',	'Nhap mon cong nghe thong tin',	'CNTT',	3,'0.1','0.2','0.7'),
	('CNTT2',	'Lap trinh C++',				'CNTT',	3,'0.1','0.2','0.7'),
	('KHMT1',	'Tri tue nhan tao',				'KHMT',	3,'0.1','0.3','0.6'),
	('KHMT2',	'Lap trinh khoa hoc du lieu',	'KHMT',	3,'0.1','0.3','0.6'),
	('QTKD1',	'Marketing can ban',			'QTKD',	3,'0.1','0.4','0.5'),
	('DT1',		'Nhap mon dau tu',				'DT',	3,'0.1','0.2','0.7'),
	('DT2',		'Quan tri nhan luc',			'DT',	3,'0.1','0.3','0.6')
--BẢNG GIẢNG VIÊN
	insert into GIANGVIEN values
	('GV1','Dang Minh Quan',	1,'1977-1-1','0912345678','Ha Noi',		'CNTT'),
	('GV2','Cao Thi Thu Huong',	0,'1985-1-1','0912345676','Nam Dinh',	'CNTT'),
	('GV3','Luu Minh Tuan',		1,'1980-1-1','0912345672','Nam Dinh',	'KHMT'),
	('GV4','Pham Minh Hoan',	1,'1979-1-1','0912345674','Nam Dinh',	'CNTT'),
	('GV5','Nguyen Thi Chinh',	0,'1985-1-1','0912345666','Vinh Phuc',	'QTKD'),
	('GV6','To Thi Thien Huong',0,'1982-1-1','0912345665','Bac Ninh',	'QTKD'),
	('GV7','Nguyen Minh Ngoc',	0,'1977-1-1','0912345662','Nghe An',	'DT'),
	('GV8','Nguyen Thi Chinh',	0,'1985-1-1','0912345661','Thanh Hoa',	'DT')

	ALTER TABLE giangvien ALTER COLUMN gioi_tinh char(5) NOT NULL;
	UPDATE giangvien SET gioi_tinh= 'Nam' WHERE gioi_tinh='1'
	UPDATE giangvien SET gioi_tinh= 'Nu' WHERE gioi_tinh='0'
--BẢNG LOPCQ
INSERT INTO LOPCQ VALUES
	('CNTT61A','Cong nghe thong tin 61A','CNTT',50),
	('KHMT61','Khoa hoc may tinh 61','KHMT',50),
	('DT58','Dau tu 58','DT',50),
	('QTKD59B','Quan tri kinh doanh 59B','QTKD',50)
--Bảng giangvien.monhoc
insert into GIANGVIEN_MONHOC values
	('CNTT1',	'GV1'),
	('CNTT2',	'GV2'),
	('KHMT1',	'GV3'),
	('KHMT2',	'GV4'),
	('QTKD1',	'GV5'),
	('DT1',		'GV7'),
	('DT2',		'GV8')
--Bảng lophocphan
insert into LOPHOCPHAN values
	('CNTT1_1',	'Nhap mon cong nghe thong tin(220)_01',	'CNTT1','GV1',0),
	('CNTT2_1',	'Lap trinh C++(220)_01',				'CNTT2','GV2',0),
	('KHMT1_1',	'Tri tue nhan tao',						'KHMT1','GV3',0),
	('KHMT2_1',	'Lap trinh khoa hoc du lieu(219)_01',	'KHMT2','GV4',0),
	('QTKD1_1',	'Marketing can ban(219)_01',			'QTKD1','GV5',0),
	('DT1_1',	'Nhap mon dau tu(221)_01',				'DT1','GV7',0),
	('DT2_1',	'Quan tri nhan luc(221)_01',			'DT2','GV8',0)
select * from LOPHOCPHAN
--Bang chungchi
insert into CHUNGCHI values
('CC1','Chung chi tin hoc'),
('CC2','Chung chi tieng anh'),
('CC3','Chung chi quoc phong')



--Bảng sinh viên
delete from SINHVIEN

	ALTER TABLE sinhvien ALTER COLUMN gioi_tinh char(5) NOT NULL;
	UPDATE sinhvien SET gioi_tinh= 'Nam' WHERE gioi_tinh='1'
	UPDATE sinhvien SET gioi_tinh= 'Nu' WHERE gioi_tinh='0'
insert into SINHVIEN values --CNTT61A
('11190354','Nguyen The Anh','2001-12-24','Nu','Ha Noi','CNTT61A'),
('11190355','Vu Thi Tu Anh','2001-10-01','Nu','Hai Duong','CNTT61A'),
('11190356','Nguyen Dinh Chung','2001-09-09','Nam','Nghe An','CNTT61A'),
('11190357','Bui Van Cuong','2001-12-02','Nam','Bac Giang','CNTT61A'),
('11190358','Tran Manh Cuong','1999-12-13','Nam','Vinh Phuc','CNTT61A'),
('11190359','Pham Duy','2001-11-07','Nam','Ha Noi','CNTT61A'),
('11190360','Nguyen Khanh Diem','2001-07-07','Nu','Ha Noi','CNTT61A'),
('11190361','Tran Mai Duy','2001-06-06','Nam','Thai Binh','CNTT61A'),
('11190362','Ta Thi Thuy Duong','2001-05-18','Nu','Ha Noi','CNTT61A'),
('11190363','Tran Thao Dan','2001-06-19','Nam','Hue','CNTT61A'),
('11190364','Dang Ba Dai','2001-01-22','Nam','Lao Cai','CNTT61A'),
('11190365','Ha Duy Do','2001-02-02','Nam','Nghe An','CNTT61A'),
('11190366','Hoang Thi Giang','2001-08-28','Nu','Ha Noi','CNTT61A'),
('11190367','Tran Thi Giang','2001-05-11','Nu','Ha Noi','CNTT61A'),
('11190368','Pham Thi Thanh Hang','2001-05-08','Nu','Ha Noi','CNTT61A'),
('11190369','Phạm Như Hoa','2001-12-24','Nu','Ninh Binh','CNTT61A'),
('11190370','Vu Minh Hoan','2001-05-05','Nam','Bac Ninh','CNTT61A'),
('11190371','Phạm Minh Huyen','2001-08-26','Nu','Hai Duong','CNTT61A'),
('11190372','Phan Thu Hường','2001-11-11','Nu','Ha Noi','CNTT61A'),
('11190373','Pham Thuy Linh','2001-01-12','Nu','Thanh Hoa','CNTT61A'),
('11190374','Nguyễn Ngoc Long','2001-02-20','Nam','Ha Noi','CNTT61A'),
('11190375','Nguyen Thi Mai','2001-12-04','Nu','Lang Son','CNTT61A')

delete  from SINHVIEN where id_lop = 'CNTT61A'
--đầu tư 58
insert into SINHVIEN values 
('11191880','Nguyen Tuan An','08/06/2001','Nam','Ha Noi','DT58'),
('11191881','Đo Quynh Anh','09/16/2001','Nu','Nghe An','DT58'),
('11191884','Ha Ngoc Duyen','10/16/2001','Nu','Ha Noi','DT58'),
('11191885','Le Dinh Hiep','04/09/2001','Nam','TP.HCM','DT58'),
('11191886','Nguyen Trung Hieu','07/17/2001','Nam','TP.HCM','DT58'),
('11191887','Lai Thi Thu Hoai','06/05/2000','Nu','Thai Binh','DT58'),
('11191888','Ta Viet Hoang','12/28/2001','Nam','Ha Nam','DT58'),
('11191889','Nguyen Thi Hue','12/12/2001','Nu','Nam Dinh','DT58'),
('11191890','Nguyen Thi Huong','03/29/2001','Nu','Nam Dinh','DT58'),
('11191891','Hoang Thi Ngoc Le','08/06/2001','Nu','Ha Tinh','DT58'),
('11191892','Pham Quang Nghi','01/24/2001','Nam','Ha Giang','DT58'),
('11191893','Nguyen Quang Nhat','02/24/2001','Nam','Ha Nam','DT58'),
('11191894','Đoan Hong Nhung','08/22/2001','Nu','Son La','DT58'),
('11191895','Nguyen Thi Thuy Nhung','11/10/2001','Nu','Hung Yen','DT58'),
('11191896','Trinh Thi Kieu Oanh','06/10/2001','Nu','Thanh Hoa','DT58'),
('11191897','Hoang Quang Phong','10/28/2000','Nam','Thanh Hoa','DT58'),
('11191898','Nguyen Thi Hong Phuc','07/23/2001','Nam','Nam Dinh','DT58'),
('11191899','Nguyen Thu Phuong','07/18/2001','Nu','Bac Ninh','DT58'),
('11191900','Nghiem Thi Quyen','01/08/2001','Nu','Phu Tho','DT58'),
('11191901','Pham Thi Quynh','04/29/2001','Nu','Bac Ninh','DT58')


--KHMT61
	insert into sinhvien values ('11193201','Le Thi Quynh Anh'	,'2001-01-01' ,'Nu','Cao Bang', 'KHMT61')
	insert into sinhvien values ('11193202','Do Minh Anh'	,'06/23/2001' ,'Nu','Lao Cai', 'KHMT61')
	insert into sinhvien values ('11193203','Nguyen Mai Anh','10/10/2001' ,'Nu','Thai Binh', 'KHMT61')
	insert into sinhvien values ('11193204','Ta Thi Mai Anh'	,'01/29/2001' ,'Nu','Ha Nam', 'KHMT61')
	insert into sinhvien values ('11193205','Nguyen Ngoc Anh'	,'01/08/2001' ,'Nu','Cao Bang', 'KHMT61')
	insert into sinhvien values ('11193206','Nguyen Duc Bao'	,'02/04/2001' ,'Nam','Ha Noi', 'KHMT61')
	insert into sinhvien values ('11193207','Le Van Dao'	,'07/01/2001' ,'Nam','Hai Phong', 'KHMT61')
	insert into sinhvien values ('11193208','Vu Dang Doanh'	,'09/07/2001' ,'Nam','Bac Can', 'KHMT61')
	insert into sinhvien values ('11193209','Nguyen Hong Giang'	,'05/05/2001' ,'Nu','Cao Bang', 'KHMT61')
	insert into sinhvien values ('11193210','Ngo Thi Giang','12/03/2001' ,'Nu','Ha Tinh', 'KHMT61')
	insert into sinhvien values ('11193211','Truong Thi Giang','10/02/2001' ,'Nu','Thai Binh', 'KHMT61')
	insert into sinhvien values ('11193212','Nguyen Van Hanh','11/16/2001' ,'Nam','Hai Duong', 'KHMT61')
	insert into sinhvien values ('11193213','Pham Thanh Hang','07/19/2001' ,'Nu','Vinh Phuc', 'KHMT61')
	insert into sinhvien values ('11193214','Le Thu Hang','06/24/2001' ,'Nu','Cao Bang', 'KHMT61')
	insert into sinhvien values ('11193215','Nguyen Van Hung','04/21/2001' ,'Nam','Cao Bang', 'KHMT61')
	insert into sinhvien values ('11193216','Pham Thi Ha','09/13/2001' ,'Nu','Vinh Phuc', 'KHMT61')
	insert into sinhvien values ('11193217','Mai Quoc Hoang','02/17/2001' ,'Nam','Nghe An', 'KHMT61')
	insert into sinhvien values ('11193218','Nguyen Vu Ngoc Mai','04/25/2001' ,'Nu','Hai Duong', 'KHMT61')
	insert into sinhvien values ('11193219','Nguyen Van Linh','09/01/2001' ,'Nam','Cao Bang', 'KHMT61')
	insert into sinhvien values ('11193220','Vu Khanh Linh','08/01/2001' ,'Nu','Vinh Phuc', 'KHMT61')
	insert into sinhvien values ('11193221','To Cam Mai','07/01/2001' ,'Nu','Nghe An', 'KHMT61')
	insert into sinhvien values ('11193222','Khuong Ngoc Minh','06/11/2001' ,'Nam','Son La', 'KHMT61')
	insert into sinhvien values ('11193223','Nguyen Van Thanh','04/18/2001' ,'Nam','Cao Bang', 'KHMT61')
	insert into sinhvien values ('11193224','Nguyen Thi Thanh Phuong','02/22/2001' ,'Nu','Vinh Phuc', 'KHMT61')
	insert into sinhvien values ('11193225','Hoang Van Phat','12/12/2001' ,'Nam','Nghe An', 'KHMT61')

insert into SINHVIEN values
	('11191401','Bui Thi Ngoc Anh','2001/07/01','Nu','Thai Binh','QTKD59B'),
	('11191402','Doan Phuong Duyen','2001/07/01','Nu','Ha Noi','QTKD59B'),
	('11191403','Bui Ngoc Cham','2001/07/01','Nu','Thai Binh','QTKD59B'),
	('11191404','Truong Thi Giang ','2001/07/01','Nu','Thai Binh','QTKD59B'),
	('11191405','Hoang Thu Ha','2001/07/01','Nu','Hai Phong','QTKD59B'),
	('11191406','Nguyen The Minh','2001/07/01','Nam','Nam Dinh','QTKD59B'),
	('11191407','Nguyen Trong The','2001/07/01','Nam','Nghe An','QTKD59B'),
	('11191408','Pham Tien Hung','2001/07/01','Nam','Thai Binh','QTKD59B'),
	('11191409','Nguyen Manh Quan','2001/07/01','Nam','Thai Binh','QTKD59B'),
	('11191410','Vu Thanh Trang','2001/07/01','Nu','Thanh Hoa','QTKD59B'),
	('11191411','Dang Huong Giang','2001/07/01','Nu','Hue','QTKD59B'),
	('11191412','Hoang Tien Viet','2001/07/01','Nam','Thai Binh','QTKD59B'),
	('11191413','Tran Thi Ha','2001/07/01','Nu','TP Ho Chi Minh','QTKD59B'),
	('11191414','Pham Hoang Thanh Tam','2001/07/01','Nu','Thai Binh','QTKD59B'),
	('11191415','Nguyen Thi Thanh Tam','2001/07/01','Nu','Ha Noi','QTKD59B'),
	('11191416','Doan Quoc Cuong','2001/07/01','Nam','Thai Binh','QTKD59B'),
	('11191417','Nguyen Ngoc Hung','2001/07/01','Nam','Hai Phong','QTKD59B'),
	('11191418','Nguyen Thi Hong Ngoc','2001/07/01','Nu','Thai Binh','QTKD59B'),
	('11191419','Tham Tung Lam','2001/07/01','Nam','Hai Duong','QTKD59B'),
	('11191420','Vu Huu Quan','2001/07/01','Nam','Thai Binh','QTKD59B')

--DỮ LIỆU BẢNG SINHVIEN-LOPHP
insert into SINHVIEN_LOPHP values 
('DT1_1','11191880'),
('DT1_1','11191881'),
('DT1_1','11191884'),
('DT1_1','11191885'),
('DT1_1','11191886'),
('DT1_1','11191887'),
('DT1_1','11191888'),
('DT1_1','11191889'),
('DT1_1','11191890'),
('DT1_1','11191891'),
('DT1_1','11191892'),
('DT1_1','11191893'),
('DT1_1','11191894'),
('DT1_1','11191895'),
('DT1_1','11191896'),
('DT1_1','11191897'),
('DT1_1','11191898'),
('DT1_1','11191899'),
('DT1_1','11191900'),
('DT1_1','11191901')

insert into SINHVIEN_LOPHP values 
('DT2_1','11191880'),
('DT2_1','11191881'),
('DT2_1','11191884'),
('DT2_1','11191885'),
('DT2_1','11191886'),
('DT2_1','11191887'),
('DT2_1','11191888'),
('DT2_1','11191889'),
('DT2_1','11191890'),
('DT2_1','11191891'),
('DT2_1','11191892'),
('DT2_1','11191893'),
('DT2_1','11191894'),
('DT2_1','11191895'),
('DT2_1','11191896'),
('DT2_1','11191897'),
('DT2_1','11191898'),
('DT2_1','11191899'),
('DT2_1','11191900'),
('DT2_1','11191901')
insert into SINHVIEN_LOPHP values 
('QTKD1_1','11191401'),
('QTKD1_1','11191402'),
('QTKD1_1','11191403'),
('QTKD1_1','11191404'),
('QTKD1_1','11191405'),
('QTKD1_1','11191406'),
('QTKD1_1','11191407'),
('QTKD1_1','11191408'),
('QTKD1_1','11191409'),
('QTKD1_1','11191410'),
('QTKD1_1','11191411'),
('QTKD1_1','11191412'),
('QTKD1_1','11191413'),
('QTKD1_1','11191414'),
('QTKD1_1','11191415'),
('QTKD1_1','11191416'),
('QTKD1_1','11191417'),
('QTKD1_1','11191418'),
('QTKD1_1','11191419'),
('QTKD1_1','11191420')

insert into SINHVIEN_LOPHP values 
('KHMT2_1','11193201'),
('KHMT2_1','11193202'),
('KHMT2_1','11193203'),
('KHMT2_1','11193204'),
('KHMT2_1','11193205'),
('KHMT2_1','11193206'),
('KHMT2_1','11193207'),
('KHMT2_1','11193208'),
('KHMT2_1','11193209'),
('KHMT2_1','11193210'),
('KHMT2_1','11193211'),
('KHMT2_1','11193212'),
('KHMT2_1','11193213'),
('KHMT2_1','11193214'),
('KHMT2_1','11193215'),
('KHMT2_1','11193216'),
('KHMT2_1','11193217')
----
insert into SINHVIEN_LOPHP values 
('KHMT1_1','11193201'),
('KHMT1_1','11193202'),
('KHMT1_1','11193203'),
('KHMT1_1','11193204'),
('KHMT1_1','11193205'),
('KHMT1_1','11193206'),
('KHMT1_1','11193207'),
('KHMT1_1','11193218'),
('KHMT1_1','11193219'),
('KHMT1_1','11193220'),
('KHMT1_1','11193221'),
('KHMT1_1','11193222'),
('KHMT1_1','11193223'),
('KHMT1_1','11193224'),
('KHMT1_1','11193225')

insert into SINHVIEN_LOPHP values 
('CNTT2_1','11190354'),
('CNTT2_1','11190355'),
('CNTT2_1','11190356'),
('CNTT2_1','11190357'),
('CNTT2_1','11190358'),
('CNTT2_1','11190359'),
('CNTT2_1','11190360'),
('CNTT2_1','11190361'),
('CNTT2_1','11190362'),
('CNTT2_1','11190363'),
('CNTT2_1','11190364'),
('CNTT2_1','11190365'),
('CNTT2_1','11190366'),
('CNTT2_1','11190367'),
('CNTT2_1','11190368'),
('CNTT2_1','11190369'),
('CNTT2_1','11190370'),
('CNTT2_1','11190371'),
('CNTT2_1','11190372'),
('CNTT2_1','11190373')

insert into SINHVIEN_LOPHP values 
('CNTT1_1','11190354'),
('CNTT1_1','11190355'),
('CNTT1_1','11190356'),
('CNTT1_1','11190357'),
('CNTT1_1','11190358'),
('CNTT1_1','11190359'),
('CNTT1_1','11190360'),
('CNTT1_1','11190361'),
('CNTT1_1','11190362'),
('CNTT1_1','11190363'),
('CNTT1_1','11190364'),
('CNTT1_1','11190365'),
('CNTT1_1','11190366'),
('CNTT1_1','11190367'),
('CNTT1_1','11190368'),
('CNTT1_1','11190369'),
('CNTT1_1','11190370'),
('CNTT1_1','11190371'),
('CNTT1_1','11190372'),
('CNTT1_1','11190373'),
('CNTT1_1','11190374'),
('CNTT1_1','11190375')

--BẢNG DIEMHOCPHAN
insert into DIEMHOCPHAN values
('CNTT1_1','11190354',7,7,7,7,''),
('CNTT1_1','11190355',9,6,8,7,''),
('CNTT1_1','11190356',9,7,7.5,7,''),
('CNTT1_1','11190357',9,8,8.5,7,''),
('CNTT1_1','11190358',9,5,8.5,7,''),
('CNTT1_1','11190359',10,6,6,7,''),
('CNTT1_1','11190360',10,6,8,7,''),
('CNTT1_1','11190361',10,7,7,7,''),
('CNTT1_1','11190362',8,8,7,7,''),
('CNTT1_1','11190363',8,7,9,7,''),
('CNTT1_1','11190364',9,7,9,7,''),
('CNTT1_1','11190365',10,7.5,7.5,7,''),
('CNTT1_1','11190366',9,9,9,7,''),
('CNTT1_1','11190367',10,10,7,7,''),
('CNTT1_1','11190368',10,8,7,7,''),
('CNTT1_1','11190369',10,9,9,7,''),
('CNTT1_1','11190370',10,10,8,7,''),
('CNTT1_1','11190371',9,9,8,7,''),
('CNTT1_1','11190372',9,5,6,7,''),
('CNTT1_1','11190373',9,6,7,7,''),
('CNTT1_1','11190374',10,8,8,7,''),
('CNTT1_1','11190375',10,9,10,7,'')

insert into DIEMHOCPHAN values 
('QTKD1_1','11191401',8,7,9,'',''),
('QTKD1_1','11191402',10,9,8,'',''),
('QTKD1_1','11191403',8,6,8,'',''),
('QTKD1_1','11191404',7,9,7,'',''),
('QTKD1_1','11191405',10,8,7,'',''),
('QTKD1_1','11191406',9,7,6,'',''),
('QTKD1_1','11191407',9,7,6,'',''),
('QTKD1_1','11191408',10,9,7,'',''),
('QTKD1_1','11191409',10,8,9,'',''),
('QTKD1_1','11191410',9,8,6,'',''),
('QTKD1_1','11191411',10,9,7,'',''),
('QTKD1_1','11191412',9,7,8,'',''),
('QTKD1_1','11191413',10,9,7,'',''),
('QTKD1_1','11191414',10,8.5,7,'',''),
('QTKD1_1','11191415',9,8,7.5,'',''),
('QTKD1_1','11191416',10,6.5,7,'',''),
('QTKD1_1','11191417',9,8,6,'',''),
('QTKD1_1','11191418',10,9,7.5,'',''),
('QTKD1_1','11191419',10,8,7.5,'',''),
('QTKD1_1','11191420',9,8,8.5,'','')

	insert into DIEMHOCPHAN values
('KHMT2_1','11193201',7,9,5,'',''),
('KHMT2_1','11193202',10,6,8,'',''),
('KHMT2_1','11193203',7,9,7,'',''),
('KHMT2_1','11193204',9,6,8,'',''),
('KHMT2_1','11193205',7,6,7,'',''),
('KHMT2_1','11193206',10,6,8,'',''),
('KHMT2_1','11193207',6,7,9,'',''),
('KHMT2_1','11193208',10,6,8,'',''),
('KHMT2_1','11193209',9,6,8,'',''),
('KHMT2_1','11193210',7,10,7,'',''),
('KHMT2_1','11193211',10,9,8,'',''),
('KHMT2_1','11193212',9,6,8,'',''),
('KHMT2_1','11193213',9,7,7,'',''),
('KHMT2_1','11193214',10,6,8,'',''),
('KHMT2_1','11193215',7,7,7,'',''),
('KHMT2_1','11193216',10,6,8,'',''),
('KHMT2_1','11193217',10,7,6,'','')
----
insert into DIEMHOCPHAN values
('KHMT1_1','11193201',10,9,5,'',''),
('KHMT1_1','11193202',9,6,8,'',''),
('KHMT1_1','11193203',7,9,7,'',''),
('KHMT1_1','11193204',8,6,8,'',''),
('KHMT1_1','11193205',7,6,7,'',''),
('KHMT1_1','11193206',10,6,8,'',''),
('KHMT1_1','11193207',10,7,9,'',''),
('KHMT1_1','11193218',10,6,8,'',''),
('KHMT1_1','11193219',9,9,8,'',''),
('KHMT1_1','11193220',7,10,7,'',''),
('KHMT1_1','11193221',10,9,8,'',''),
('KHMT1_1','11193222',9,6,8,'',''),
('KHMT1_1','11193223',9,7,7,'',''),
('KHMT1_1','11193224',10,6,8,'',''),
('KHMT1_1','11193225',7,7,7,'','')



insert into DIEMHOCPHAN values
('DT1_1','11191880',7,7,7,'',''),
('DT1_1','11191881',10,7,8,'',''),
('DT1_1','11191884',9,8,8.5,'',''),
('DT1_1','11191885',8,7,7,'',''),
('DT1_1','11191886',7,8.5,9,'',''),
('DT1_1','11191887',8,6,7,'',''),
('DT1_1','11191888',10,5,6.5,'',''),
('DT1_1','11191889',6,6.5,7,'',''),
('DT1_1','11191890',6,8,7.5,'',''),
('DT1_1','11191891',10,9,9.5,'',''),
('DT1_1','11191892',9,7.5,7,'',''),
('DT1_1','11191893',9,8,8,'',''),
('DT1_1','11191894',7,8,9,'',''),
('DT1_1','11191895',8,7,6,'',''),
('DT1_1','11191896',10,6,4,'',''),
('DT1_1','11191897',8,7,3,'',''),
('DT1_1','11191898',9,10,10,'',''),
('DT1_1','11191899',9,10,7,'',''),
('DT1_1','11191900',8,7,7,'',''),
('DT1_1','11191901',7,8,9,'','')

insert into DIEMHOCPHAN values
('DT2_1','11191880',7,7,7,'',''),
('DT2_1','11191881',10,7,8,'',''),
('DT2_1','11191884',9,8,8.5,'',''),
('DT2_1','11191885',8,7,7,'',''),
('DT2_1','11191886',7,8.5,9,'',''),
('DT2_1','11191887',8,6,7,'',''),
('DT2_1','11191888',10,5,6.5,'',''),
('DT2_1','11191889',6,6.5,7,'',''),
('DT2_1','11191890',6,8,7.5,'',''),
('DT2_1','11191891',10,9,9.5,'',''),
('DT2_1','11191892',9,7.5,7,'',''),
('DT2_1','11191893',9,8,8,'',''),
('DT2_1','11191894',7,8,9,'',''),
('DT2_1','11191895',8,7,6,'',''),
('DT2_1','11191896',10,6,4,'',''),
('DT2_1','11191897',8,7,3,'',''),
('DT2_1','11191898',9,10,10,'',''),
('DT2_1','11191899',9,10,7,'',''),
('DT2_1','11191900',8,7,7,'',''),
('DT2_1','11191901',7,8,9,'','')


--DỮ LIỆU BẢNG SINHVIEN_CHUNGCHI
insert into SINHVIEN_CHUNGCHI values
('11190354','CC3'),('11190355','CC3'),('11190356','CC3'),
('11190357','CC3'),('11190358','CC3'),('11190359','CC3'),
('11190360','CC3'),('11190361','CC3'),('11190362','CC3'),
('11190363','CC3'),('11190364','CC3'),('11190365','CC3'),
('11190366','CC3'),('11190367','CC3'),('11190368','CC3'),
('11190369','CC3'),('11190370','CC3'),('11190371','CC3'),
('11190372','CC3'),('11190373','CC3'),('11190374','CC3'),
('11190375','CC3'),

('11190354','CC1'),('11190355','CC1'),('11190356','CC1'),
('11190357','CC1'),('11190358','CC1'),('11190359','CC1'),
('11190360','CC1'),('11190361','CC1'),('11190362','CC1'),
('11190363','CC1'),('11190364','CC1'),('11190365','CC1'),
('11190366','CC1'),('11190367','CC1'),('11190368','CC1'),
('11190369','CC1'),('11190370','CC1'),('11190371','CC1'),
('11190372','CC1'),('11190373','CC1'),('11190374','CC1'),
('11190375','CC1')


insert into SINHVIEN_CHUNGCHI values 
('11191880','CC1'), ('11191884','CC3'),
('11191881','CC2'), ('11191885','CC3'),
('11191886','CC2'), ('11191887','CC2'),
('11191888','CC1'), ('11191889','CC1'),
('11191890','CC3'), ('11191891','CC2'),
('11191892','CC3'), ('11191893','CC3'),
('11191894','CC2'), ('11191895','CC2'),
('11191896','CC1'), ('11191897','CC2'),
('11191898','CC2'), ('11191899','CC1'),
('11191900','CC2'), ('11191901','CC1'),
('11191884','CC1'), ('11191890','CC1')

insert into SINHVIEN_CHUNGCHI values
('11191401','CC3'),
('11191402','CC3'),
('11191403','CC3'),
('11191404','CC1'),
('11191405','CC2'),
('11191406','CC1'),
('11191407','CC3'),
('11191408','CC3'),
('11191409','CC2'),
('11191410','CC2'),
('11191411','CC3'),
('11191412','CC3'),
('11191413','CC3'),
('11191414','CC1'),
('11191415','CC3'),
('11191416','CC2'),
('11191417','CC3'),
('11191418','CC3'),
('11191419','CC1'),
('11191420','CC3')

insert into SINHVIEN_CHUNGCHI values 
('11191880','CC1'), ('11191884','CC3'),
('11191881','CC2'), ('11191885','CC3'),
('11191886','CC2'), ('11191887','CC2'),
('11191888','CC1'), ('11191889','CC1'),
('11191890','CC3'), ('11191891','CC2'),
('11191892','CC3'), ('11191893','CC3'),
('11191894','CC2'), ('11191895','CC2'),
('11191896','CC1'), ('11191897','CC2'),
('11191898','CC2'), ('11191899','CC1'),
('11191900','CC2'), ('11191901','CC1'),
('11191884','CC1'), ('11191890','CC1')

insert into SINHVIEN_CHUNGCHI values('11193201','CC1')
	insert into SINHVIEN_CHUNGCHI values('11193202','CC3')
	insert into SINHVIEN_CHUNGCHI values('11193203','CC1')
	insert into SINHVIEN_CHUNGCHI values('11193204','CC2')
	insert into SINHVIEN_CHUNGCHI values('11193205','CC1')
	insert into SINHVIEN_CHUNGCHI values('11193206','CC2')
	insert into SINHVIEN_CHUNGCHI values('11193207','CC3')
	insert into SINHVIEN_CHUNGCHI values('11193208','CC1')
	insert into SINHVIEN_CHUNGCHI values('11193209','CC1')
	insert into SINHVIEN_CHUNGCHI values('11193210','CC2')
	insert into SINHVIEN_CHUNGCHI values('11193211','CC3')
	insert into SINHVIEN_CHUNGCHI values('11193225','CC1')
	insert into SINHVIEN_CHUNGCHI values('11193212','CC3')
	insert into SINHVIEN_CHUNGCHI values('11193213','CC1')
	insert into SINHVIEN_CHUNGCHI values('11193214','CC2')
	insert into SINHVIEN_CHUNGCHI values('11193215','CC1')
	insert into SINHVIEN_CHUNGCHI values('11193216','CC2')
	insert into SINHVIEN_CHUNGCHI values('11193217','CC3')
	insert into SINHVIEN_CHUNGCHI values('11193218','CC1')
	insert into SINHVIEN_CHUNGCHI values('11193219','CC1')
	insert into SINHVIEN_CHUNGCHI values('11193220','CC2')
	insert into SINHVIEN_CHUNGCHI values('11193221','CC3')
	insert into SINHVIEN_CHUNGCHI values('11193222','CC1')
	insert into SINHVIEN_CHUNGCHI values('11193223','CC2')
	insert into SINHVIEN_CHUNGCHI values('11193224','CC3')


SELECT *FROM sinhVIEN
SELECT *FROM LOPCQ
SELECT *FROM LOPHOCPHAN
SELECT *FROM GIANGVIEN
SELECT *FROM DIEMHOCPHAN
select *from SINHVIEN_CHUNGCHI