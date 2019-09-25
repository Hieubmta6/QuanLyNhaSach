﻿

CREATE TABLE TACGIA
(
	MATG NCHAR(20) NOT NULL,
	TENTG NVARCHAR(50),
)
ALTER TABLE TACGIA
ADD CONSTRAINT PK_TACGIA PRIMARY KEY(MATG)

CREATE TABLE NHAXUATBAN
(
	MANXB NCHAR(20) NOT NULL,
	TENNXB NVARCHAR(50),
	DCNXB NVARCHAR(50),
	DTNXB NVARCHAR(50),

)
ALTER TABLE NHAXUATBAN
ADD CONSTRAINT PK_NHAXUATBAN PRIMARY KEY(MANXB)

CREATE TABLE LOAISACH
(
	MALOAISH NCHAR(20) NOT NULL,
	TENLOAISH NVARCHAR(50),
)

ALTER TABLE LOAISACH
ADD CONSTRAINT PK_LOAISACH PRIMARY KEY(MALOAISH)

CREATE TABLE SACH
(
	MASH NCHAR(20) NOT NULL,
	TENSH NVARCHAR(50),
	MATG NCHAR(20),
	MANXB NCHAR(20),
	NAMXB NCHAR(20),
	MALOAISH NCHAR(20),
	GIATIEN FLOAT,
)
ALTER TABLE SACH
ADD CONSTRAINT PK_SACH PRIMARY KEY(MASH)
ALTER TABLE SACH
ADD CONSTRAINT FK_SACH_TACGIA FOREIGN KEY(MATG) REFERENCES TACGIA(MATG)
ALTER TABLE SACH
ADD CONSTRAINT FK_SACH_LOAISACH FOREIGN KEY(MALOAISH) REFERENCES LOAISACH(MALOAISH)
ALTER TABLE SACH
ADD CONSTRAINT FK_SACH_NHAXUATBAN FOREIGN KEY(MANXB) REFERENCES NHAXUATBAN(MANXB)




CREATE TABLE KHACHHANG
(
	MAKH NCHAR(20) NOT NULL,
	
	HOTEN NVARCHAR(50),
	NGAYSINH DATE,
	GIOITINH NCHAR(20),
	DIACHI NVARCHAR(50),
	DTKH NCHAR(20),

)
ALTER TABLE KHACHHANG
ADD CONSTRAINT PK_KHACHHANG PRIMARY KEY(MAKH)

CREATE TABLE NHANVIEN
(
	MANV NCHAR(20) NOT NULL,
	HOTENNV NVARCHAR(50),
	NGAYSINH DATE,
	NGAYVL DATE,
	PHAI NCHAR(20),
	DIACHINV NVARCHAR(50),
	LUONG FLOAT,
	CHUCVU NCHAR(20),
	MANQL NCHAR(20),
)
ALTER TABLE NHANVIEN
ADD CONSTRAINT PK_NHANVIEN PRIMARY KEY(MANV)

CREATE TABLE TAIKHOAN
(
	MATK NCHAR(20) NOT NULL,
	QUYEN CHAR(20) NOT NULL,
	TENTK NVARCHAR(50) NOT NULL,
	PASSWORK NCHAR(20) NOT NULL,
	NGAYLAP DATE,
	
)
ALTER TABLE TAIKHOAN
ADD CONSTRAINT PK_TAIKHOAN PRIMARY KEY(MATK)
ALTER TABLE TAIKHOAN
ADD CONSTRAINT FK_TAIKHOAN_NHANVIEN FOREIGN KEY(MATK) REFERENCES NHANVIEN(MANV)

CREATE TABLE HOADON
(
	MAHD NCHAR(20) NOT NULL,
	NGAYLAP DATE,
	MAKH NCHAR(20),
	TONGTIEN FLOAT,
	MANV NCHAR(20),
	CONSTRAINT PK_HOADON PRIMARY KEY(MAHD)
)
ALTER TABLE HOADON
ADD CONSTRAINT FK_HOADON_KHACHHANG FOREIGN KEY(MAKH) REFERENCES KHACHHANG(MAKH)
ALTER TABLE HOADON
ADD CONSTRAINT FK_HOADON_NHANVIEN FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV)

CREATE TABLE CHITIETHD
(
	MAHD NCHAR(20) NOT NULL,
	MASH NCHAR(20) NOT NULL,
	SOLUONG NCHAR(20),
	DONGIA FLOAT,
)
ALTER TABLE CHITIETHD
ADD CONSTRAINT PK_CHITIETHD PRIMARY KEY(MAHD,MASH)
ALTER TABLE CHITIETHD
ADD CONSTRAINT FK_CHITIETHD_HOADON FOREIGN KEY(MAHD) REFERENCES HOADON(MAHD)
ALTER TABLE CHITIETHD
ADD CONSTRAINT FK_CHITIETHD_SACH FOREIGN KEY(MASH) REFERENCES SACH(MASH)

CREATE TABLE KHO
(
	MASH NCHAR(20) NOT NULL,
	SOLUONG NCHAR(20) NOT NULL,
)
ALTER TABLE KHO
ADD CONSTRAINT PK_KHO PRIMARY KEY(MASH)
ALTER TABLE KHO
ADD CONSTRAINT FK_KHO_SACH FOREIGN KEY(MASH) REFERENCES SACH(MASH)

INSERT INTO TACGIA
VALUES ('TG001','Jacques Attali')
INSERT INTO TACGIA
VALUES ('TG002',N'Rosie Nguyễn')
INSERT INTO TACGIA
VALUES ('TG003',N'Tolly Burkan')
INSERT INTO TACGIA
VALUES ('TG004',N'Ayn Rand')
INSERT INTO TACGIA
VALUES ('TG005',N'Nguyễn Thu Trang, Nguyễn Hoàng Thu Hà')
INSERT INTO TACGIA
VALUES ('TG006',N'MBA. Nguyễn Văn Dung ')
INSERT INTO TACGIA
VALUES ('TG007',N'Ths. Hồ Thanh Lan')
INSERT INTO TACGIA
VALUES ('TG008',N'Vanness Uyên ')
INSERT INTO TACGIA
VALUES ('TG009',N'TS. Đặng Hoài Bắc, TS. Nguyễn Ngọc Minh')
INSERT INTO TACGIA
VALUES ('TG010',N'Th.S Nguyễn Trung Hiếu, TS. Đặng Hoài Bắc')

INSERT INTO NHAXUATBAN
VALUES ('NXB001',N'Nhà Xuất Bản Thông Tin Và Truyền Thông',N'50 Ngô Quyền,Q.5, TP.HCM','01267589620');
INSERT INTO NHAXUATBAN
VALUES ('NXB002',N'Nhà Xuất Bản Hội Nhà Văn',N'12 Lê Lai,Q.1, TP.HCM','0972356972');
INSERT INTO NHAXUATBAN
VALUES ('NXB003',N'Nhà Xuất Bản Thanh Niên',N'120, Thành Thái,Q.10, TP.HCM','0126874359');
INSERT INTO NHAXUATBAN
VALUES ('NXB004',N'Nhà Xuất Bản Tri Thức',N'474-476 Nguyễn Thị Minh Khai, Q.3, Tp.HCM','0935678549');
INSERT INTO NHAXUATBAN
VALUES ('NXB005',N'Nhà Xuất Bản Trẻ',N'123, Trương Định,Q.3, TP.HCM','0166458928');
INSERT INTO NHAXUATBAN
VALUES ('NXB006',N'Nhà Xuất Bản Lao Động',N'111 Bình Thới, Q.11, TP.HCM','0985123593');
INSERT INTO NHAXUATBAN
VALUES ('NXB007',N'Nhà Xuất Bản Tài Chính',N'111 Bình Thới, Q.11, TP.HCM','07524349278');
INSERT INTO NHAXUATBAN
VALUES ('NXB008',N'Nhà Xuất Bản Lao Động Xã Hội',N'21 Tô Ký, Quận 12, TP.HCM','01287654256');


INSERT INTO LOAISACH
VALUES ('S01',N'Sách Văn Học');
INSERT INTO LOAISACH
VALUES ('S02',N'Sách Kĩ Năng');
INSERT INTO LOAISACH
VALUES ('S03',N'Sách Kinh Tế');
INSERT INTO LOAISACH
VALUES ('S04',N'Sách Tham Khảo ');
INSERT INTO LOAISACH
VALUES ('S05',N'Giáo Trình');
INSERT INTO LOAISACH
VALUES ('S1111',N'Giáo Cụ');


INSERT INTO SACH
VALUES ('0001',N'Lịch Sử Của Tính Hiện Đại','TG001','NXB001','2012','S01','100.000');
INSERT INTO SACH
VALUES ('0002',N'Tuổi Trẻ Đáng Giá Bao Nhieu ','TG002','NXB002','2016','S02','55.000');
INSERT INTO SACH
VALUES ('0003',N'Nghĩ Đơn Giản, Sống Đơn Thuần ','TG003','NXB003','2018','S02','60.000');
INSERT INTO SACH
VALUES ('0004',N'Suối Nguồn','TG004','NXB004','2014','S02','108.000');
INSERT INTO SACH
VALUES ('0005',N'Lặng Nghe Cuộc Sống - Lời Nhắn Nhủ Của Mẹ','TG005','NXB005','2018','S02','90.000');
INSERT INTO SACH
VALUES ('0006',N'Quản Trị Chiến Lược','TG006','NXB006','2011','S04','95.000');
INSERT INTO SACH
VALUES ('0007',N'Marketing Công Nghiệp','TG007','NXB007','2000','S04','62.500');
INSERT INTO SACH
VALUES ('0008',N'Lịch Sử Của Tính Hiện Đại','TG008','NXB008','2017','S05','100.500');
INSERT INTO SACH
VALUES ('0009',N'Thiết Kế Logic Số','TG009','NXB001','2015','S05','97.000');
INSERT INTO SACH
VALUES ('0010',N'Thiết Kế Điện Tử Tiên Tiến','TG010','NXB001','2017','S05','69.000');



SET DATEFORMAT DMY
INSERT INTO KHACHHANG
VALUES ('KH001',N'Nguyễn Bảo Ngân','16/03/2012',N'Nữ',N'63/15 Phạm Ngọc Thảo, Tân Phú, TPHCM','01629650425');
INSERT INTO KHACHHANG
VALUES ('KH002',N'Nguyễn Hà Nam','20/03/1998',N'Nam',N'25/15 Tân Lập , Dĩ An,Bình Dương','01603352586');
INSERT INTO KHACHHANG
VALUES ('KH003',N'Bùi Ngọc Khánh Nhi','16/02/1997',N'Nữ',N'1 Tô Vĩnh Kí, Q12, TPHCM','01629650425');
INSERT INTO KHACHHANG
VALUES ('KH004',N'Bùi Thị Mai Trinh','20/10/1995',N'Nữ',N'20 CMT8, Q3, TPHCM','01676007840');
INSERT INTO KHACHHANG
VALUES ('KH005',N'Dương Minh Nghĩa','05/01/1998',N'Nam',N'11 Bình Thới, Q.11, TP.HCM','01629650425');
INSERT INTO KHACHHANG
VALUES ('KH006',N'Nguyễn Quang Vinh','20/05/1998',N'Nam',N'12 Trường Chinh, Tân Bình, TP.HCM','01629652700');
INSERT INTO KHACHHANG
VALUES ('KH007',N'Nguyễn Minh Hiếu','02/01/1998',N'Nam',N'12 Âu Cơ, Tân Bình, TP.HCM','0162960000');


Select* from NHANVIEN

SET DATEFORMAT DMY
INSERT INTO NHANVIEN
VALUES ('NV0001',N'Nguyễn Thị Thùy My','20/03/1998','25/12/2018',N'Nữ',N'13 Hoàng Diệu, thủ Đức, TPHCM','7000000',N'Nhân viên','NQL002');
INSERT INTO NHANVIEN
VALUES ('NV0002',N'Phan Thị Thùy Ly','20/10/1990','2/10/2012',N'Nữ',N'Tân Phú, TPHCM','8000000',N'Nhân viên','NQL003');
INSERT INTO NHANVIEN
VALUES ('NV0003',N'Cao Minh Quốc','05/01/1998','05/01/2017',N'Nam',N' Bình Sơn, Quảng Ngãi','10000000',N'Nhân viên','NQL004');
INSERT INTO NHANVIEN
VALUES ('NV0004',N'Nguyễn Quan Vinh','20/03/1992','05/01/2017',N'Nam',N'Biên Hòa, Đồng Nai','15000000',N'Trưởng Phòng','NQL005');
INSERT INTO NHANVIEN
VALUES ('NV0005',N'Trần THị Thanh Thu','07/02/1998','05/05/2017',N'Nữ',N'Đồng Xoài, Bình Phước','20000000',N'Giám Đốc','NQL006');
INSERT INTO NHANVIEN
VALUES ('NV0006',N'Phùng Thế Hoan','23/03/1991','05/11/2017',N'Nam',N'Bình Tân, TPHCM','9000000',N'Nhân viên','NQL007');
INSERT INTO NHANVIEN
VALUES ('NV0007',N'Nguyễn Thị Thảo Hiền','1/03/1980','28/01/2017',N'Nữ',N'Q2, TPHCM','10000000',N'Nhân viên','NQL008')
INSERT INTO NHANVIEN
VALUES ('NV0008',N'Cao Hải Quan','2/02/1999','05/09/2017',N'Nam',N'Q1, TPHCM','5000000',N'Nhân viên','NQL009')

SET DATEFORMAT DMY
INSERT INTO HOADON
VALUES ('HD001','12/01/2013','KH001','100.000','NV0001');
INSERT INTO HOADON
VALUES ('HD002','01/11/2015','KH002','205.000','NV0002');
INSERT INTO HOADON
VALUES ('HD003','12/12/2017','KH003','151.000','NV0003');
INSERT INTO HOADON
VALUES ('HD004','05/1/2018','KH004','160.000','NV0004');
SET DATEFORMAT DMY
INSERT INTO HOADON
VALUES ('HD005','2/12/2017','KH005','520.000','NV0005');
INSERT INTO HOADON
VALUES ('HD006','20/1/2013','KH006','368.000','NV0006');
INSERT INTO HOADON
VALUES ('HD007','30/01/2017','KH007','960.000','NV0007');

INSERT INTO CHITIETHD
VALUES('HD001','0001','2','100000');
INSERT INTO CHITIETHD
VALUES('HD002','0002','1','50000');
INSERT INTO CHITIETHD
VALUES('HD003','0003','5','520000');
INSERT INTO CHITIETHD
VALUES('HD004','0004','3','120000');
INSERT INTO CHITIETHD
VALUES('HD005','0005','4','99000');
INSERT INTO CHITIETHD
VALUES('HD006','0006','1','110000');
INSERT INTO CHITIETHD
VALUES('HD007','0007','2','320000');

SET DATEFORMAT DMY
INSERT INTO TAIKHOAN
VALUES ('NV0001','admin','adim','v123','12/10/2001');
INSERT INTO TAIKHOAN
VALUES ('NV0003','user','user','v122','12/10/2001');

INSERT INTO KHO
VALUES ('0001','22');
INSERT INTO KHO
VALUES ('0002','300');
INSERT INTO KHO
VALUES ('0003','60');
INSERT INTO KHO
VALUES ('0004','108');
INSERT INTO KHO
VALUES ('0005','90');
INSERT INTO KHO
VALUES ('0006','95');
INSERT INTO KHO
VALUES ('0007','62');
INSERT INTO KHO
VALUES ('0008','100');
INSERT INTO KHO
VALUES ('0009','97');
INSERT INTO KHO
VALUES ('0010','69');
INSERT INTO KHO
VALUES ('001k','69');


Delete TAIKHOAN from NHANVIEN,TAIKHOAN  where TAIKHOAN.MATK='NV0004' and TAIKHOAN.MATK=NHANVIEN.MANV;
Delete CHITIETHD from HOADON where HOADON.MAHD=CHITIETHD.MAHD AND HOADON.MANV='NV0004'
Delete HOADON from HOADON,NHANVIEN where HOADON.MANV=NHANVIEN.MANV AND HOADON.MANV='NV0004'
Delete NHANVIEN where NHANVIEN.MANV='NV0004';

update NHANVIEN set HOTENNV='NHAN' where NHANVIEN.MANV='NV0004';

INSERT INTO NHANVIEN VALUES ('1111',N'hinh','20/3/1998','20/3/1998',N'nam',N'20','258',N'nv','ql05')
select QUYEN From TAIKHOAN
Select MASH,TENSH,SACH.MATG,SACH.MANXB,NAMXB,SACH.MALOAISH,GIATIEN,TENTG,TENNXB,TENLOAISH from SACH,TACGIA,NHAXUATBAN,LOAISACH where SACH.MALOAISH=LOAISACH.MALOAISH AND SACH.MATG=TACGIA.MATG AND SACH.MANXB=NHAXUATBAN.MANXB
select * from SACH