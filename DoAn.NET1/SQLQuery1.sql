CREATE DATABASE QLSV 
USE QLSV

CREATE TABLE chucVu (
maCV nvarchar (20) not null,
tenCV nvarchar (20)
primary key (maCV)
)
CREATE TABLE SinhVien (
maSV nvarchar (20) not null,
hoTenSV nvarchar (30),
gioitinh  nvarchar (40),
ngaySinh date ,
noiSinh nvarchar (20),
sDT int ,
eMail nvarchar (30),
maCV nvarchar(20) not null,
maLop nvarchar (20) not null,
primary key (maSV) ,
FOREIGN KEY (maCV) REFERENCES  chucVu(maCV),

)
CREATE TABLE GiaoVien (
maGV nvarchar (20) not null,
hoTenGV nvarchar (30),
gioitinh  nvarchar (40),
ngaySinh date ,
noiSinh nvarchar (20),
sDT int ,
eMail nvarchar (30),
maCV nvarchar(20),
maSV nvarchar (20) not null,
maLop nvarchar (20) not null,
primary key (maGV),
FOREIGN KEY (maCV) REFERENCES  chucVu(maCV),
FOREIGN KEY (maSV) REFERENCES  SinhVien(maSV),

)
CREATE TABLE khoa(
maKhoa nvarchar (20) not null,
tenKhoa nvarchar (30),
maSV nvarchar (20) not null,
maGV nvarchar (20) not null,
PRIMARY KEY (maKhoa),
FOREIGN KEY (maSV) REFERENCES  SinhVien(maSV),
FOREIGN KEY (maGV) REFERENCES  GiaoVien(maGV)
)
CREATE TABLE Lop(
tenLop nvarchar (20),
maKhoa nvarchar (20) not null,
maSV nvarchar (20) not null,
maGV nvarchar (20) not null,
PRIMARY KEY (maKhoa,maSV,maGV)
)
CREATE TABLE hocPhan(
maHP nvarchar (20) not null,
tenHP nvarchar (30),
soTC int ,
loaiHP nvarchar (10),
gia int ,
tenHK nvarchar (10),
maKhoa nvarchar (20) not null,
maSV nvarchar (20) not null,
PRIMARY KEY (maHP),
FOREIGN KEY (maKhoa) REFERENCES  khoa(maKhoa),
FOREIGN KEY (maSV) REFERENCES SinhVien(maSV)
)

CREATE TABLE bangDiem (
maHP nvarchar (20) not null,
maSV nvarchar (20) not null, 
tenHK nvarchar (10),
diemGK float ,
diemCK float ,
diemTB float,
PRIMARY KEY (maSV,maHP)
)
CREATE TABLE hocBong (
maHB nvarchar (20)not null ,
loaiHB nvarchar (10),
tenHK nvarchar (10),
maSV nvarchar (20) not null, 
PRIMARY KEY (maHB),
FOREIGN KEY (maSV) REFERENCES SinhVien(maSV)
)
CREATE TABLE sinhVienVP(
noiDungVP nvarchar (20),
thoiGianSV date ,
maSV nvarchar (20) not null,
maHP nvarchar (20) not null,
PRIMARY KEY (maSV,maHP)
)
CREATE TABLE taiKhoan(
tenTK nvarchar (20),
passTK nvarchar (20)
)
