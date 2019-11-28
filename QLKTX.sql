CREATE DATABASE QuanLyKTX
go

USE QuanLyKTX
go

--ACCOUNT
--SINHVIEN
--PHONG
--NHANVIEN
--HOADON

CREATE TABLE ACCOUNT
(
	ID INT IDENTITY PRIMARY KEY,
	DISPLAYNAME NVARCHAR(100) NOT NULL,
	USERNAME NVARCHAR(100) NOT NULL,
	PASS NVARCHAR(1000) NOT NULL,
)
GO

CREATE TABLE NHANVIEN
(
	MANV INT IDENTITY PRIMARY KEY,
	TENNV NVARCHAR(100) NOT NULL,
	SDTNV NVARCHAR(100) NOT NULL,
)
GO

CREATE TABLE PHONG
(
	MAPHG INT IDENTITY PRIMARY KEY,
	LOAIPHG NVARCHAR(100) NOT NULL,
	TONGSV INT NOT NULL,
	TINHTRANG NVARCHAR(100) NOT NULL,
	TOA NVARCHAR(10) NOT NULL,
	MATRUONGPHG INT NOT NULL,

	FOREIGN KEY (MATRUONGPHG) REFERENCES DBO.NHANVIEN(MANV)
)
GO

CREATE TABLE SINHVIEN
(
	MASV INT IDENTITY PRIMARY KEY,
	TENSV NVARCHAR(100) NOT NULL,
	GIOITINH NVARCHAR(10) NOT NULL,
	NGAYSINH DATE NOT NULL,
	SDTSV NVARCHAR(100) NOT NULL,
	QUEQUAN NVARCHAR(100) NOT NULL,
	MAPHG INT NOT NULL,

	FOREIGN KEY (MAPHG) REFERENCES DBO.PHONG(MAPHG)
)
GO

CREATE TABLE HOADON
(
	MAHD INT IDENTITY PRIMARY KEY,
	CHISONUOC INT NOT NULL,
	CHISODIEN INT NOT NULL,
	NGAYXUATHD DATE NOT NULL,
	TONGTIEN NVARCHAR(100) NOT NULL,
	MAPHG INT NOT NULL,

	FOREIGN KEY (MAPHG) REFERENCES DBO.PHONG(MAPHG) 
)
GO

SELECT * FROM dbo.PHONG 


	