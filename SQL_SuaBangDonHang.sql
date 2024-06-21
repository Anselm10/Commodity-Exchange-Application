ALTER TABLE DONHANG
ADD TrangThai INT DEFAULT 0;
GO

alter table products
Add LoaiMatHang nvarchar(50);
Go

alter table products
Add GiaGoc money
Go

alter table products
Add TinhTrangMathang nvarchar(max)
go
alter table products
Add MoTaHuHai nvarchar(max)
go
alter table products
Add MoTaChiTiet nvarchar(max)
go
alter table products
Add DiaChi nvarchar(max)
go
alter table products
Add NgayMua date
go

