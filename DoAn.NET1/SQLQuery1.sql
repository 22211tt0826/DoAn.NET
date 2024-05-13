CREATE DATABASE QLSV 
USE QLSV

SET DATEFORMAT dmy;
CREATE TABLE khoa(
maKhoa nvarchar (20) not null,
tenKhoa nvarchar (30),
PRIMARY KEY (maKhoa)
)
CREATE TABLE GiaoVien (
maGV nvarchar (20) not null,
hoTenGV nvarchar (30),
gioitinh  nvarchar (40),
ngaySinh date ,
noiSinh nvarchar (20),
sDT nvarchar(10) ,
eMail nvarchar (30),
tenCV nvarchar(20),
tenLop nvarchar (20),
passTK nvarchar (20),
maKhoa nvarchar (20) not null,
primary key (maGV),
FOREIGN KEY (maKhoa) REFERENCES  Khoa(maKhoa),
)
CREATE TABLE SinhVien (
maSV nvarchar (20) not null,
hoTenSV nvarchar (30),
gioitinh  nvarchar (40),
ngaySinh date ,
noiSinh nvarchar (20),
sDT nvarchar(10) ,
eMail nvarchar (30),
tenCV nvarchar(20) ,
tenLop nvarchar (20),
maGV nvarchar (20) not null,
passTK nvarchar (20)
primary key (maSV),
FOREIGN KEY (maGV) REFERENCES  GiaoVien(maGV)
)

CREATE TABLE Lop(
tenLop nvarchar (20),
maKhoa nvarchar (20) not null,
PRIMARY KEY (maKhoa),
FOREIGN KEY (maKhoa) REFERENCES  Khoa(maKhoa),
)

CREATE TABLE hocPhan(
maHP nvarchar (20) not null,
tenHP nvarchar (30),
soTC int ,
loaiHP nvarchar (10),
gia int ,
tenHK nvarchar (10),
maKhoa nvarchar (20) not null,
PRIMARY KEY (maHP),
FOREIGN KEY (maKhoa) REFERENCES  khoa(maKhoa)
)

CREATE TABLE bangDiem (
maHP nvarchar (20) not null,
maSV nvarchar (20) not null, 
tenHK nvarchar (10),
diemGK float ,
diemCK float ,
diemTB float,
primary key (maSV,maHP),
FOREIGN KEY (maSV) REFERENCES SinhVien(maSV),
FOREIGN KEY (maHP) REFERENCES hocPhan(maHP),

)
CREATE TABLE hocBong (
maHB nvarchar (20)not null ,
loaiHB nvarchar (10),
tenHK nvarchar (10),
maSV nvarchar (20) not null, 
PRIMARY KEY (maHB),
FOREIGN KEY (maSV) REFERENCES SinhVien(maSV)
)
CREATE TABLE BangViPham(
maVP nvarchar (20) not null,
noidungVP nvarchar (200),
maSV nvarchar (20) not null,
maHP nvarchar (20) not null,
primary key (maVP,maSV),
FOREIGN KEY (maSV) REFERENCES SinhVien(maSV),
FOREIGN KEY (maHP) REFERENCES hocPhan(maHP),
)
CREATE TABLE sinhVienVP(
maVP nvarchar (20) not null,
thoiGian date ,
maSV nvarchar (20) not null,
primary key (maVP,maSV),
FOREIGN KEY (maSV) REFERENCES SinhVien(maSV),
)
CREATE TABLE diemDanh(
maSV nvarchar (20) not null,
maHP nvarchar (20) not null,
sotiet int ,
thoiGian date,
primary key (maSV,maHP,thoiGian),
FOREIGN KEY (maSV) REFERENCES SinhVien(maSV),
FOREIGN KEY (maHP) REFERENCES hocPhan(maHP),
)
CREATE TABLE taiKhoan(
tenTk nvarchar (30),
passTK nvarchar (20)
primary key (tenTk)
)

