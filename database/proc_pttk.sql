use HTTC
go
-- Xem thong tin vacxin
create procedure proc_docthongtin_vacxin  @mavacxin int
as
begin
	select * from VACXIN vx where vx.MAVACXIN = @mavacxin
end
--drop proc proc_docthongtin_vacxin
go
-- Xem thong tin phieu dang ky tiem chung (ho so tiem chung)
create procedure proc_xemthongtin_phieudk @maphieu int
as
begin
	select * from HOSODANGKYTIEMCHUNG hs where hs.MAHS = @maphieu
end
--drop proc proc_docthongtin_phieudk
go
-- Xem chi tiet phieu tiem chung (chi tiet ho so tiem chung)
create proc proc_xemthongtinchitiet_hstc @maphieu int, @mavacxin int
as
begin
	select * from CHITIETHOSODKTC where MAHS = @maphieu and MAVACXIN = @mavacxin
end
--drop proc proc_docthongtinchitiet_hstc
go
-- Them thong tin chi tiet ho so tiem chung
create proc proc_themchitiet_hstc @mahs int, @mavacxin int, @matrungtam int, @ngaymongmuon date, @ngaytiem date, @tinhtrang nvarchar(50), @dongia float, @tiensubenh nvarchar(50), @phanungsautiem nvarchar(50)
as
begin
	INSERT dbo.CHITIETHOSODKTC(MAHS, MAVACXIN, MATRUNGTAMTIEM, NGAYMONGMUONTIEM, NGAYTIEM, TINHTRANG, DONGIA, TIENSUBENH, PHANUNGSAUTIEM) VALUES (@mahs, @mavacxin, @matrungtam, @ngaymongmuon, @ngaytiem, @tinhtrang,  @dongia, @tiensubenh, @phanungsautiem)
end
--drop proc proc_themchitiet_hstc
go
-- Doc thong tin khach hang
create proc proc_xemthongtin_khachhang @makh int
as
begin
	select * from KHACHHANG where MAKH = @makh
end
-- drop proc proc_xemthongtin_khachhang
go
-- Cap nhat thong tin khach hang
create proc proc_capnhatthongtin_khachhang @makh int, @hoten nvarchar(50), @ngaysinh date, @SDT char(15), @diachi nvarchar(50), @matkhau char(50)
as
begin
	update KHACHHANG set HOTENKH = @hoten, NGAYSINH = @ngaysinh, SDT = @SDT, DIACHI = @diachi, MATKHAU = @matkhau where MAKH = @makh
end
-- drop proc proc_capnhatthongtin_khachhang
go
-- Cap nhat lich nhan vien
create proc proc_capnhatlichNV @manv int, @in_catruc int, @in_ngaytruc date, @up_catruc int, @up_ngaytruc date, @matrungtam int, @loailich nvarchar(50)
as
begin
	update LICHNV set CATRUC = @up_catruc, NGAYTRUC = @up_ngaytruc, MATRUNGTAMTRUC = @matrungtam, LOAILICH = @loailich where MANV = @manv and CATRUC = @in_catruc and NGAYTRUC = @in_ngaytruc
end
-- drop proc proc_capnhatlichNV
go
-- Them lich nhan vien
create proc proc_themlichNV @manv int, @catruc int, @ngaytruc date, @matrungtam int, @loailich nvarchar(50)
as
begin
	INSERT dbo.LICHNV(MANV, CATRUC, NGAYTRUC, MATRUNGTAMTRUC, LOAILICH) VALUES (@manv, @catruc, @ngaytruc, @matrungtam, @loailich)
end
-- drop proc proc_themlichNV
go
-- Cap nhat thong tin nhan vien
create proc proc_capnhat_nhanvien @manv int, @hoten nvarchar(50), @ngaysinh date, @vitri nvarchar(50), @bangcap nvarchar(50), @sdt char(15), @diachi nvarchar(50), @email char(50), @luong float, @matrungtam int, @taikhoan char(50), @matkhau char(50)
as
begin
	update NHANVIEN set HOTENNV = @hoten, NGAYSINH = @ngaysinh, VITRI = @vitri, BANGCAP = @bangcap, DIENTHOAI = @sdt, DIACHI = @diachi, EMAIL = @email, LUONG = @luong, MATRUNGTAM = @matrungtam, TAIKHOAN = @taikhoan, MATKHAU = @matkhau where MANV = @manv
end
-- drop proc proc_capnhat_nhanvien
go
select * from KHACHHANG;
where  HOTENKH like N'%%' ;
go 
create proc them_khach_hang @maKH int, @HotenKh nvarchar(50), @ngaysinh date, @sdt char(15), @diachi nvarchar(50), @taikhoan char(50), @matkhau char(50)
as
begin
	INSERT dbo.KHACHHANG(MAKH, HOTENKH, NGAYSINH, SDT, DIACHI, TAIKHOAN, MATKHAU) VALUES (@maKH, @HotenKh, @ngaysinh, @sdt, @diachi, @taikhoan,  @matkhau)
end

exec them_khach_hang 55,;
insert 

