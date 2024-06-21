create database commodity_exchange_application;
Go

use commodity_exchange_application
GO


--Tạo bảng đăng nhập
create table DANGNHAP
(
	TenTaiKhoan varchar(30) primary key,
	MatKhau varchar(15) not null
);
Go

--Tạo bảng đăng ký
create table DANGKY
(
	TenTaiKhoan varchar(30) primary key,
	HoTen nvarchar(50) not null,
	Email varchar(50) not null,
	MatKhau varchar(20) not null,
	SDT char (10) not null,
	DiaChi nvarchar(max) not null,
);
Go

--Tạo bảng Sản phẩm
create table SANPHAM
(
	TenSanPham Nvarchar(200) ,
	TenTaiKhoan varchar(30) ,
	MaSP int IDENTITY(1,1) not null,
	LoaiMatHang Nvarchar(max) not null,
	GiaTienMoi money not null,
	GiaTienCu money not null,
	DiaChiBan Nvarchar(max) not null,
	HinhAnh Nvarchar(max) not null,
	PRIMARY KEY (TenSanPham,TenTaiKhoan)
);
Go

--Tạo bảng chi tiết Sản phẩm
create table CT_SANPHAM
(
	TenSanPham Nvarchar(200) ,
	TenTaiKhoan varchar(30) ,
	MaSP int IDENTITY(1,1),
	NgayMua date,
	TinhTrangMatHang Nvarchar(max) ,
	MoTaHuHai Nvarchar(max),
	MoTaChiTiet Nvarchar(max),
	ThongSoKyThuat Nvarchar(max),
	HinhAnh1 Nvarchar(max),
	HinhAnh2 Nvarchar(max),
	HinhAnh3 Nvarchar(max),
	HinhAnh4 Nvarchar(max),
	PRIMARY KEY (TenSanPham,TenTaiKhoan),
);
Go


--Tạo bảng Giấy tờ tùy thân
create table GIAYTOTUYTHAN
(
	SoCCCD varchar(20) primary key,
	HoTen nvarchar(30) ,
	NgaySinh varchar(30),
	GioiTinh nvarchar(10),
	QuocTich nvarchar(30),
	QueQuan nvarchar(max),
	NoiThuongTru nvarchar(max),
	NoiCap nvarchar(max)
);
GO

CREATE TABLE UuTien
(
    TenTaiKhoan VARCHAR(30),
    TenSanPham NVARCHAR(200),
	UuTien bit,
    PRIMARY KEY (TenTaiKhoan, TenSanPham),
    FOREIGN KEY (TenTaiKhoan) REFERENCES DANGNHAP(TenTaiKhoan) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (TenSanPham) REFERENCES products(TenSanPham) ON DELETE CASCADE ON UPDATE CASCADE
);

--Tạo trigger khi insert vào bảng DANGKY thì insert vào Bảng DANGNHAP
create trigger themvaobang_dangnhap
on DANGKY
after insert
as
begin
    insert into DANGNHAP(tentaikhoan, matkhau)
    select tentaikhoan, matkhau
    from inserted;
end;
Go

--Thử thêm vào bảng đăng ký xem bảng đăng nhập có không

INSERT INTO DANGKY (TenTaiKhoan, HoTen, Email, MatKhau, SDT, DiaChi) 
VALUES ('username1', N'Họ và tên 1', 'example1@example.com', 'password1', '0123456789', N'Địa chỉ 1'),
       ('username2', N'Họ và tên 2', 'example2@example.com', 'password2', '0123456789', N'Địa chỉ 2'),
       ('username3', N'Họ và tên 3', 'example3@example.com', 'password3', '0123456789', N'Địa chỉ 3');
GO


--Tạo thêm trigger để khi update bảng DANGKY thì UPDATE bảng DANGNHAP ở TenTaiKhoan và MATKHAU
create TRIGGER UpdateDangNhap
ON DANGKY
AFTER UPDATE
AS
BEGIN
    UPDATE DANGNHAP
    SET DANGNHAP.TenTaiKhoan = i.TenTaiKhoan,
        DANGNHAP.MatKhau = i.MatKhau
    FROM DANGNHAP
    INNER JOIN inserted i ON DANGNHAP.TenTaiKhoan = i.TenTaiKhoan;
END;
Go



--Tạo viewSP_ChitietSP (Lấy thông tin chung là giá cũ, giá mới, địa chỉ bán, hình ảnh nền từ bảng SANPHAM.., 
--và các thông tin còn lại của bảng chitietsanPham, Lấy thêm thông tin từ bảng DANGKY là HoTenNguoiDung)
create VIEW viewSP_ChitietSP AS
SELECT 
    sp.TenSanPham,
    sp.GiaTienCu,
    sp.GiaTienMoi,
    sp.DiaChiBan,
    cts.TenTaiKhoan,
    cts.MaSP,
    cts.NgayMua,
    cts.TinhTrangMatHang,
    cts.MoTaHuHai,
    cts.MoTaChiTiet,
    cts.ThongSoKyThuat,
	sp.HinhAnh,
    cts.HinhAnh1,
    cts.HinhAnh2,
    cts.HinhAnh3,
    cts.HinhAnh4,
    dk.HoTen
FROM 
    SanPham sp
JOIN 
    CT_SANPHAM cts ON sp.TenSanPham = cts.TenSanPham
JOIN 
    DANGKY dk ON sp.TenTaiKhoan = dk.TenTaiKhoan;
GO

--tạo hàm trong sql để insert vào 2 bảng SP và ChitietSP và tự động thêm cột mã sản phẩm cho bảng san phẩm và bảng 
CREATE PROCEDURE InsertIntoSanPhamAndChiTietSanPham
    @TenSanPham NVARCHAR(100),
    @TenNguoiDung VARCHAR(20),
    @LoaiMatHang NVARCHAR(30),
    @GiaTienMoi char(30),
    @GiaTienCu char(30),
    @DiaChiBan NVARCHAR(max),
    @HinhAnh NVARCHAR(max),
    @NgayMua date,
    @TinhTrangMatHang NVARCHAR(700),
    @MoTaHuHai NVARCHAR(MAX),
    @MoTaChiTiet NVARCHAR(MAX),
    @ThongSoKyThuat NVARCHAR(MAX),
    @HinhAnh1 NVARCHAR(255),
    @HinhAnh2 NVARCHAR(255),
    @HinhAnh3 NVARCHAR(255),
    @HinhAnh4 NVARCHAR(255)
AS
BEGIN

    -- Thêm vào bảng SanPham và lấy mã sản phẩm được tạo tự động
    INSERT INTO SanPham (TenSanPham, TenTaiKhoan, LoaiMatHang, GiaTienMoi, GiaTienCu, DiaChiBan, HinhAnh)
    VALUES (@TenSanPham, @TenNguoiDung, @LoaiMatHang, @GiaTienMoi, @GiaTienCu, @DiaChiBan, @HinhAnh);

    -- Thêm vào bảng ChiTietSanPham
    INSERT INTO CT_SANPHAM(TenSanPham, TenTaiKhoan, NgayMua, TinhTrangMatHang, MoTaHuHai, MoTaChiTiet, ThongSoKyThuat, HinhAnh1, HinhAnh2, HinhAnh3, HinhAnh4)
    VALUES (@TenSanPham, @TenNguoiDung, @NgayMua, @TinhTrangMatHang, @MoTaHuHai, @MoTaChiTiet, @ThongSoKyThuat, @HinhAnh1, @HinhAnh2, @HinhAnh3, @HinhAnh4);
END;
Go

--VD thêm sản phẩm mới
EXEC InsertIntoSanPhamAndChiTietSanPham 
    @TenSanPham = N'Tên sản phẩm',
    @TenNguoiDung = 'tenNGuoiDung',
    @LoaiMatHang = N'Loại mặt hàng',
    @GiaTienMoi = '1000000',
    @GiaTienCu = '800000',
    @DiaChiBan = N'Địa chỉ bán',
    @HinhAnh = N'URL hình ảnh',
    @NgayMua = '2022-03-29',
    @TinhTrangMatHang = N'Tình trạng',
    @MoTaHuHai = N'Mô tả hư hại',
    @MoTaChiTiet = N'Mô tả chi tiết',
    @ThongSoKyThuat = N'Thông số kỹ thuật',
    @HinhAnh1 = N'URL hình ảnh 1',
    @HinhAnh2 = N'URL hình ảnh 2',
    @HinhAnh3 = N'URL hình ảnh 3',
    @HinhAnh4 = N'URL hình ảnh 4';
Go


--Hàm xóa sản phẩm từ hai bảng
CREATE PROCEDURE DeleteFromSanPhamAndChiTietSanPham
    @TenSanPham NVARCHAR(100), @TenTaiKhoan varchar(30)
AS
BEGIN
    -- Xóa từ bảng ChiTietSanPham
    DELETE FROM CT_SANPHAM WHERE TenSanPham = @TenSanPham and TenTaiKhoan = @TenTaiKhoan;

    -- Xóa từ bảng SanPham
    DELETE FROM SanPham WHERE TenSanPham = @TenSanPham and TenTaiKhoan = @TenTaiKhoan;
END;
Go

--Xóa thử
EXECUTE DeleteFromSanPhamAndChiTietSanPham @TenSanPham = N'Tên sản phẩm', @TenTaiKhoan = 'Tên ngu?i dùng';
Go


--Hàm sửa sản phẩm từ hai bảng
CREATE PROCEDURE UpdateSanPhamAndChiTietSanPham
    @TenSanPham NVARCHAR(100),
    @TenNguoiDung VARCHAR(30),
    @LoaiMatHang NVARCHAR(30),
    @GiaTienMoi money,
    @GiaTienCu money,
    @DiaChiBan NVARCHAR(max),
    @HinhAnh NVARCHAR(max),
    @NgayMua date,
    @TinhTrangMatHang NVARCHAR(max),
    @MoTaHuHai NVARCHAR(MAX),
    @MoTaChiTiet NVARCHAR(MAX),
    @ThongSoKyThuat NVARCHAR(MAX),
    @HinhAnh1 NVARCHAR(max),
    @HinhAnh2 NVARCHAR(max),
    @HinhAnh3 NVARCHAR(max),
    @HinhAnh4 NVARCHAR(max)
AS
BEGIN
    -- Cập nhật thông tin trong bảng SanPham
    UPDATE SanPham
    SET TenTaiKhoan = @TenNguoiDung,
        LoaiMatHang = @LoaiMatHang,
        GiaTienMoi = @GiaTienMoi,
        GiaTienCu = @GiaTienCu,
        DiaChiBan = @DiaChiBan,
        HinhAnh = @HinhAnh
    WHERE TenSanPham = @TenSanPham and TenTaiKhoan = @TenNguoiDung;

    -- Cập nhật thông tin trong bảng ChiTietSanPham
    UPDATE CT_SANPHAM
    SET TenTaiKhoan = @TenNguoiDung,
        NgayMua = @NgayMua,
        TinhTrangMatHang = @TinhTrangMatHang,
        MoTaHuHai = @MoTaHuHai,
        MoTaChiTiet = @MoTaChiTiet,
        ThongSoKyThuat = @ThongSoKyThuat,
        HinhAnh1 = @HinhAnh1,
        HinhAnh2 = @HinhAnh2,
        HinhAnh3 = @HinhAnh3,
        HinhAnh4 = @HinhAnh4
    WHERE TenSanPham = @TenSanPham and TenTaiKhoan = @TenNguoiDung;
END;
GO

--vd update
EXECUTE UpdateSanPhamAndChiTietSanPham 
    @TenSanPham = N'Tên sản phẩm',
    @TenNguoiDung = 'tenNGuoiDung',
    @LoaiMatHang = N'Loại mặt hàng mới',
    @GiaTienMoi = '210591',
    @GiaTienCu = '1029104',
    @DiaChiBan = N'Địa chỉ bán mới',
    @HinhAnh = N'Đường dẫn đến hình ảnh mới',
    @NgayMua = '01-01-2000',
    @TinhTrangMatHang = N'Tình trạng mặt hàng mới',
    @MoTaHuHai = N'Mô tả hư hại mới',
    @MoTaChiTiet = N'Mô tả chi tiết mới',
    @ThongSoKyThuat = N'Thông số kỹ thuật mới',
    @HinhAnh1 = N'Đường dẫn đến hình ảnh 1 mới',
    @HinhAnh2 = N'Đường dẫn đến hình ảnh 2 mới',
    @HinhAnh3 = N'Đường dẫn đến hình ảnh 3 mới',
    @HinhAnh4 = N'Đường dẫn đến hình ảnh 4 mới';
GO

--Hàm tìm kiếm sản phẩm
CREATE PROCEDURE SearchSanPham
    @TenSanPham NVARCHAR(100), @TenTaiKhoan VARCHAR(30)
AS
BEGIN
    SELECT 
        sp.TenSanPham,
        sp.TenTaiKhoan,
        sp.LoaiMatHang,
        sp.GiaTienMoi,
        sp.GiaTienCu,
        sp.DiaChiBan,
        sp.HinhAnh,
        cts.NgayMua,
        cts.TinhTrangMatHang,
        cts.MoTaHuHai,
        cts.MoTaChiTiet,
        cts.ThongSoKyThuat,
        cts.HinhAnh1,
        cts.HinhAnh2,
        cts.HinhAnh3,
        cts.HinhAnh4
    FROM 
        SanPham sp
    JOIN 
        CT_SANPHAM cts ON sp.TenSanPham = cts.TenSanPham 
    WHERE 
        sp.TenSanPham LIKE '%' + @TenSanPham + '%' and sp.TenTaiKhoan = @TenTaiKhoan
END;
GO

--Thử tìm
EXECUTE SearchSanPham  N'Tên sản phẩm', 'tenNGuoiDung'
Go


--banng uu tien
CREATE TABLE UuTien (
  TenTaiKhoan VARCHAR(30) ,
  TenSanPham NVARCHAR(200) ,
  UuTien BIT ,
  PRIMARY KEY (TenTaiKhoan, TenSanPham),
  CONSTRAINT FK_UuTien_DANGNHAP FOREIGN KEY (TenTaiKhoan) REFERENCES DANGNHAP(TenTaiKhoan) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT FK_UuTien_products FOREIGN KEY (TenSanPham) REFERENCES products(TenSanPham) ON DELETE CASCADE ON UPDATE CASCADE
);


