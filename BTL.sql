

	CREATE DATABASE BTL_HSK COLLATE Vietnamese_CI_AS
	GO

	use BTL_HSK
	GO	
	
	CREATE TABLE tblNhaCungCap
	(
		sMaNCC NVARCHAR(50) NOT NULL,
		sTenNCC NVARCHAR(50) NULL,
		sDiaChi NVARCHAR(50) NULL,
		sDienThoai NVARCHAR(10) NULL,
		CONSTRAINT PK_tblNhaCungCap PRIMARY KEY (sMaNCC)
	)
	GO
	
	CREATE TABLE tblMatHang (
		sMaMH NVARCHAR(50) NOT NULL,
		sTenMatHang NVARCHAR(50)
		CONSTRAINT PK_tblMH PRIMARY KEY (sMaMH)
	)
	GO

	CREATE TABLE tblSanPham
	(
		sMaSP NVARCHAR(50) NOT NULL,
		sMaMH NVARCHAR(50) NOT NULL,
		sTenSP NVARCHAR(15) NULL,
		sChatLieu NVARCHAR(50)
		CONSTRAINT PK_tblSanPham PRIMARY KEY (sMaSP),
		CONSTRAINT FK_MaHang_SanPham FOREIGN KEY (sMaMH)
		REFERENCES tblMatHang(sMaMH)
	)
	GO

	CREATE TABLE tblChiTietSanPham (
		sMaCTSP NVARCHAR(50) NOT NULL,
		sMaSP NVARCHAR(50) NOT NULL,
		sMau NVARCHAR(20),
		sSize NVARCHAR(10),
		iSoluongSP INT NULL
		CONSTRAINT PK_ChiTietSanPham PRIMARY KEY (sMaCTSP)
		CONSTRAINT FK_SanPham_ChiTietSanPham FOREIGN KEY (sMaSP)
		REFERENCES tblSanPham(sMaSP)
	)
	GO

	CREATE TABLE tblNhanVien (
		sMaNV NVARCHAR(50) NOT NULL,
		sTenNV NVARCHAR(30),
		bGioiTinh BIT,
		sDiachi NVARCHAR(30),
		sDienthoai VARCHAR(10),
		dNgayvaolam DATETIME,
		fLuongcoban FLOAT DEFAULT 0
		CONSTRAINT PK_tblNhanVien PRIMARY KEY (sMaNV)
	)
	GO
	
	CREATE TABLE tblKhachHang
	(
		sMaKH NVARCHAR(50) NOT NULL,
		sTenKH NVARCHAR(30) NOT NULL,
		bGioiTinh BIT,
		sDiachi NVARCHAR(50) NOT NULL,
		sDienthoai NVARCHAR(12) NOT NULL
		CONSTRAINT PK_MaKH PRIMARY KEY (sMaKH)
	)
	GO
	 
	CREATE TABLE tblDonDatHang
	(
		sMaHDDH NVARCHAR(50) NOT NULL,
		sMaNV NVARCHAR(50) NOT NULL,
		sMaKH NVARCHAR(50) NOT NULL,
		dNgaymuahang DATETIME DEFAULT GETDATE(),
		fTongTien FLoat DEFAULT 0,
		CONSTRAINT PK_SoHD_DonDatHang PRIMARY KEY (sMaHDDH),
		CONSTRAINT FK_MaNV_DonDatHang FOREIGN KEY (sMaNV) REFERENCES tblNhanVien(sMaNV),
		CONSTRAINT FK_MaKH_DonDatHang FOREIGN KEY (sMaKH) REFERENCES tblKhachHang(sMaKH)
	)
	GO
	
	CREATE TABLE tblChiTietDatHang
	(
		sMaHDDH NVARCHAR(50) NOT NULL,
		sMaCTSP NVARCHAR(50) NOT NULL,
		iSoLuong INT DEFAULT 0,
		fGiamGia FLOAT NULL,
		fGiaBan FLOAT NULL
		CONSTRAINT PK_ChiTietDatHang PRIMARY KEY (sMaHDDH, sMaCTSP),
		CONSTRAINT FK_soHD_tblChiTietDatHang FOREIGN KEY (sMaHDDH)
		REFERENCES tblDonDatHang(sMaHDDH),
		CONSTRAINT FK_sMahang_tblChiTietDatHang FOREIGN KEY (sMaCTSP)
		REFERENCES tblChiTietSanPham(sMaCTSP)
	)
	GO

	CREATE TABLE tblDonNhapHang
	(
		sMaHDNH NVARCHAR(50) NOT NULL,
		sMaNCC NVARCHAR(50) NOT NULL,
		sMaNV NVARCHAR(50) NOT NULL,
		dNgaynhaphang DATETIME,
		fTongTien FLOAT DEFAULT 0
		CONSTRAINT PK_SoHD_DonNhapHang PRIMARY KEY (sMaHDNH),
		CONSTRAINT FK_MaNV_DonNhapHang FOREIGN KEY (sMaNV) REFERENCES tblNhanVien(sMaNV),
		CONSTRAINT FK_mathang_nhacungcap FOREIGN KEY (sMaNCC)
		REFERENCES tblNhacungCap(sMaNCC)
	)
	GO

	CREATE TABLE tblChiTietNhapHang
	(
		sMaHDNH NVARCHAR(50) NOT NULL,
		sMaCTSP NVARCHAR(50) NOT NULL,
		iSoLuong INT DEFAULT 0,
		fGiaNhap FLOAT NULL
		CONSTRAINT PK_ChiTietNhapHang PRIMARY KEY (sMaHDNH, sMaCTSP),
		CONSTRAINT FK_soHD_ChiTietNhapHang FOREIGN KEY (sMaHDNH)
		REFERENCES tblDonNhapHang(sMaHDNH),
		CONSTRAINT FK_sMahang_ChiTietNhapHang FOREIGN KEY (sMaCTSP)
		REFERENCES tblChiTietSanPham(sMaCTSP)
	)
	GO
	
	
	-- Trigger cập nhật đơn đặt hàng
	-- Mua thêm thì tự động tăng tiền hàng lên
	create view TG_DDH AS
	select tblDonDatHang.sMaHDDH AS [Số HD], 
	sum(tblChiTietDatHang.iSoLuong*tblChiTietDatHang.fGiaBan - tblChiTietDatHang.fGiamGia)  AS [Tổng tiền hàng] 
	from tblDonDatHang
	inner join tblChiTietDatHang on tblChiTietDatHang.sMaHDDH = tblDonDatHang.sMaHDDH
	where tblChiTietDatHang.sMaHDDH = tblDonDatHang.sMaHDDH
	group by tblDonDatHang.sMaHDDH
	go

	update tblDonDatHang
	set fTongTien = TG_DDH.[Tổng tiền hàng]
	from TG_DDH
	where tblDonDatHang.sMaHDDH = TG_DDH.[Số HD]
	go

	-- Tạo Trigger để cập nhật dữ liệu vào bảng Đơn Đặt Hàng
	create trigger TG_TDCN_TongSoTienMua
	ON tblChiTietDatHang
	AFTER INSERT
	AS
	begin
		update tblDonDatHang
		set fTongTien += inserted.iSoLuong*inserted.fGiaBan - inserted.fGiamGia
		from inserted
		inner join tblDonDatHang on tblDonDatHang.sMaHDDH = inserted.sMaHDDH
	end
	go

	-- Trigger cập nhật đơn nhập hàng
	create view TG_DNH AS
	select tblDonNhapHang.sMaHDNH AS [Số HD], sum(tblChiTietNhapHang.iSoLuong*tblChiTietNhapHang.fGiaNhap)  AS [Tổng tiền hàng] 
	from tblDonNhapHang
	inner join tblChiTietNhapHang on tblChiTietNhapHang.sMaHDNH = tblDonNhapHang.sMaHDNH
	where tblChiTietNhapHang.sMaHDNH = tblDonNhapHang.sMaHDNH
	group by tblDonNhapHang.sMaHDNH
	go
	
	update tblDonNhapHang
	set fTongTien = TG_DNH.[Tổng tiền hàng]
	from TG_DNH
	where tblDonNhapHang.sMaHDNH = TG_DNH.[Số HD]
	go

	-- Tạo Trigger để cập nhật dữ liệu vào bảng Đơn Nhâp Hàng
	create trigger TG_TongSoTienNhap
	ON tblChiTietNhapHang
	AFTER INSERT
	AS
	begin
		update tblDonNhapHang
		set fTongTien += inserted.iSoLuong*inserted.fGiaNhap
		from inserted
		inner join tblDonNhapHang on tblDonNhapHang.sMaHDNH = inserted.sMaHDNH
	end
	go
	
	-- Trigger cập nhật số lượng sản phẩm
	-- View số lượng sản phẩm đã bán
	create view TG_SLSPB AS
	select tblChiTietSanPham.sMaCTSP AS [Số HD], sum(tblChiTietDatHang.iSoLuong)  AS [Tổng Số Đã Bán] 
	from tblChiTietSanPham
	inner join tblChiTietDatHang on tblChiTietDatHang.sMaCTSP = tblChiTietSanPham.sMaCTSP 
	where tblChiTietDatHang.sMaCTSP = tblChiTietSanPham.sMaCTSP
	group by tblChiTietSanPham.sMaCTSP 
	go

	-- Cập nhật số lượng sản phẩm sau khi bán
	update tblChiTietSanPham
	set iSoluongSP -= TG_SLSPB.[Tổng Số Đã Bán]
	from TG_SLSPB
	where tblChiTietSanPham.sMaCTSP = TG_SLSPB.[Số HD]
	go

	-- Trigger cập nhật
	create trigger TG_SoLuongSPBan
	ON tblChiTietDatHang
	AFTER INSERT
	AS
	begin
		update tblChiTietSanPham
		set iSoluongSP -= inserted.iSoLuong
		from inserted
		inner join tblChiTietSanPham on inserted.sMaCTSP = tblChiTietSanPham.sMaCTSP
	end
	go

	-- View số lượng sản phẩm khi nhập thêm
	create view TG_SLSPN AS
	select tblChiTietSanPham.sMaCTSP AS [Số HD], sum(tblChiTietNhapHang.iSoLuong)  AS [Tổng Số Đã Nhập] 
	from tblChiTietSanPham
	inner join tblChiTietNhapHang on tblChiTietNhapHang.sMaCTSP = tblChiTietSanPham.sMaCTSP 
	where tblChiTietNhapHang.sMaCTSP = tblChiTietSanPham.sMaCTSP
	group by tblChiTietSanPham.sMaCTSP 
	go

	-- Cập nhật số lượng sản phẩm sau khi bán
	update tblChiTietSanPham
	set iSoluongSP += TG_SLSPN.[Tổng Số Đã Nhập]
	from TG_SLSPN
	where tblChiTietSanPham.sMaCTSP = TG_SLSPN.[Số HD]
	go

	-- Trigger cập nhật
	create trigger TG_SoLuongSPNhap
	ON tblChiTietNhapHang
	AFTER INSERT
	AS
	begin
		update tblChiTietSanPham
		set iSoluongSP += inserted.iSoLuong
		from inserted
		inner join tblChiTietSanPham on inserted.sMaCTSP = tblChiTietSanPham.sMaCTSP
	end
	go

	
	-- Nhà cung cấp
	INSERT tblNhaCungCap(sMaNCC, sTenNCC, sDienThoai, sDiaChi)
	VALUES (N'NCC001', N'Công Ty CP001', '0111111111', N'Đà Nẵng')
	INSERT tblNhaCungCap(sMaNCC, sTenNCC, sDienThoai, sDiaChi)
	VALUES (N'NCC002', N'Công Ty CP002', '0111111112', N'Qảng Ninh')
	INSERT tblNhaCungCap(sMaNCC, sTenNCC, sDienThoai, sDiaChi)
	VALUES (N'NCC003', N'Công Ty CP003', '0111111113', N'Đà Nẵng')
	INSERT tblNhaCungCap(sMaNCC, sTenNCC, sDienThoai, sDiaChi)
	VALUES (N'NCC004', N'Công Ty CP004', '0111111114', N'Cao Bằng')
	INSERT tblNhaCungCap(sMaNCC, sTenNCC, sDienThoai, sDiaChi)
	VALUES (N'NCC005', N'Công Ty CP005', '0111111115', N'Phú Thọ')
	INSERT tblNhaCungCap(sMaNCC, sTenNCC, sDienThoai, sDiaChi)
	VALUES (N'NCC006', N'Công Ty CP006', '0111111116', N'Bắc Giang')
	INSERT tblNhaCungCap(sMaNCC, sTenNCC, sDienThoai, sDiaChi)
	VALUES (N'NCC007', N'Công Ty CP007', '0111111117', N'Sài Gòn')
	INSERT tblNhaCungCap(sMaNCC, sTenNCC, sDienThoai, sDiaChi)
	VALUES (N'NCC008', N'Công Ty CP008', '0111111118', N'Phú Thọ')
	GO

	-- Khai báo Mặt Hàng
	INSERT tblMatHang(sMaMH, sTenMatHang)
	VALUES(N'MH001', N'Áo')
	INSERT tblMatHang(sMaMH, sTenMatHang)
	VALUES(N'MH002', N'Áo')
	INSERT tblMatHang(sMaMH, sTenMatHang)
	VALUES(N'MH003', N'Quần')
	INSERT tblMatHang(sMaMH, sTenMatHang)
	VALUES(N'MH004', N'Quần')
	INSERT tblMatHang(sMaMH, sTenMatHang)
	VALUES(N'MH005', N'Áo')
	INSERT tblMatHang(sMaMH, sTenMatHang)
	VALUES(N'MH006', N'Áo')
	INSERT tblMatHang(sMaMH, sTenMatHang)
	VALUES(N'MH007', N'Áo')
	INSERT tblMatHang(sMaMH, sTenMatHang)
	VALUES(N'MH008', N'Áo')
	INSERT tblMatHang(sMaMH, sTenMatHang)
	VALUES(N'MH009', N'Quần')
	INSERT tblMatHang(sMaMH, sTenMatHang)
	VALUES(N'MH010', N'Quần')
	GO


	-- Bảng sản Phẩm
	INSERT tblSanPham(sMaSP, sMaMH, sTenSP, sChatLieu)
	VALUES(N'MSP001', N'MH001', N'Áo Phông', N'Vải lụa')
	INSERT tblSanPham(sMaSP, sMaMH, sTenSP, sChatLieu)
	VALUES(N'MSP002', N'MH001', N'Áo Phông', N'Vải lụa')
	INSERT tblSanPham(sMaSP, sMaMH, sTenSP, sChatLieu)
	VALUES(N'MSP003', N'MH002', N'Quần Âu', N'Vải lụa')
	INSERT tblSanPham(sMaSP, sMaMH, sTenSP, sChatLieu)
	VALUES(N'MSP004', N'MH002', N'Quần Âu', N'Vải lụa')
	GO

	-- Bảng Chi Tiết Sản Phẩm
	INSERT tblChiTietSanPham(sMaCTSP, sMaSP, sMau, sSize, iSoluongSP)
	VALUES(N'MCTSP001', N'MSP001', N'Đen', 'XL', 100)
	INSERT tblChiTietSanPham(sMaCTSP, sMaSP, sMau, sSize, iSoluongSP)
	VALUES(N'MCTSP002', N'MSP001', N'Trắng', 'XXL', 100)
	INSERT tblChiTietSanPham(sMaCTSP, sMaSP, sMau, sSize, iSoluongSP)
	VALUES(N'MCTSP003', N'MSP002', N'Trắng', 'L', 100)
	INSERT tblChiTietSanPham(sMaCTSP, sMaSP, sMau, sSize, iSoluongSP)
	VALUES(N'MCTSP004', N'MSP002', N'Xanh Dương', 'XL', 100)
	INSERT tblChiTietSanPham(sMaCTSP, sMaSP, sMau, sSize, iSoluongSP)
	VALUES(N'MCTSP005', N'MSP003', N'Tím', 'XXL', 100)
	INSERT tblChiTietSanPham(sMaCTSP, sMaSP, sMau, sSize, iSoluongSP)
	VALUES(N'MCTSP006', N'MSP003', N'Đen', 'XL', 100)
	GO

	-- Bảng Nhân Viên
	INSERT tblNhanVien(sMaNV, sTenNV, bGioiTinh, dNgayvaolam, sDienthoai, sDiachi, fLuongcoban)
	VALUES(N'MNV001', N'Nguyễn Văn A', 1, '20230820', '0211111111', N'Định Công', 20000)
	INSERT tblNhanVien(sMaNV, sTenNV, bGioiTinh, dNgayvaolam, sDienthoai, sDiachi, fLuongcoban)
	VALUES(N'MNV002', N'Nguyễn Văn B', 1, '20230507', '0211111112', N'Kim Đồng', 20000)
	INSERT tblNhanVien(sMaNV, sTenNV, bGioiTinh, dNgayvaolam, sDienthoai, sDiachi, fLuongcoban)
	VALUES(N'MNV003', N'Nguyễn Thị A', 0, '20230521', '0211111113', N'Định Công', 22000)
	GO

	-- Khách hàng
	INSERT tblKhachHang(sMaKH, sTenKH, bGioiTinh, sDienthoai, sDiachi)
	VALUES(N'MKH001', N'Nguyễn Văn A', 1, '0311111111', N'Định Công')
	INSERT tblKhachHang(sMaKH, sTenKH, bGioiTinh, sDienthoai, sDiachi)
	VALUES(N'MKH002', N'Nguyễn Văn B', 1, '0322222222', N'Hoàng Mai')
	INSERT tblKhachHang(sMaKH, sTenKH, bGioiTinh, sDienthoai, sDiachi)
	VALUES(N'MKH003', N'Nguyễn Thị C', 0, '0333333333', N'Định Công')
	INSERT tblKhachHang(sMaKH, sTenKH, bGioiTinh, sDienthoai, sDiachi)
	VALUES(N'MKH004', N'Nguyễn Thị D', 0, '0344444444', N'Cầu Giấy')
	GO

	-- Đơn nhập hàng
	INSERT tblDonNhapHang(sMaHDNH, sMaNCC, sMaNV, dNgaynhaphang) 
	VALUES(N'MHDN001', N'NCC001', N'MNV001', '20230120')
	INSERT tblDonNhapHang(sMaHDNH, sMaNCC, sMaNV, dNgaynhaphang)
	VALUES(N'MHDN002', N'NCC002', N'MNV001', '20230220')
	INSERT tblDonNhapHang(sMaHDNH, sMaNCC, sMaNV, dNgaynhaphang)
	VALUES(N'MHDN003', N'NCC003', N'MNV002', '20230325')
	INSERT tblDonNhapHang(sMaHDNH, sMaNCC, sMaNV, dNgaynhaphang) 
	VALUES(N'MHDN004', N'NCC004', N'MNV002', '20230220')
	GO

	-- Chi tiết nhập hàng
	INSERT tblChiTietNhapHang(sMaHDNH, sMaCTSP, iSoLuong, fGiaNhap) 
	VALUES(N'MHDN001', N'MCTSP001', 100, 50000)
	INSERT tblChiTietNhapHang(sMaHDNH, sMaCTSP, iSoLuong, fGiaNhap) 
	VALUES(N'MHDN001', N'MCTSP002', 100,40000)
	INSERT tblChiTietNhapHang(sMaHDNH, sMaCTSP, iSoLuong, fGiaNhap) 
	VALUES(N'MHDN002', N'MCTSP002', 100, 60000)
	INSERT tblChiTietNhapHang(sMaHDNH, sMaCTSP, iSoLuong, fGiaNhap) 
	VALUES(N'MHDN003', N'MCTSP003', 110, 70000)
	INSERT tblChiTietNhapHang(sMaHDNH, sMaCTSP, iSoLuong, fGiaNhap) 
	VALUES(N'MHDN004', N'MCTSP001', 10, 40000)
	INSERT tblChiTietNhapHang(sMaHDNH, sMaCTSP, iSoLuong, fGiaNhap) 
	VALUES(N'MHDN004', N'MCTSP002', 10, 80000)
	GO

	-- Bảng Đơn Đặt Hàng
	INSERT tblDonDatHang(sMaHDDH, sMaNV, sMaKH, dNgaymuahang) 
	VALUES(N'MHDB001', N'MNV001', N'MKH001','20231002')
	INSERT tblDonDatHang(sMaHDDH, sMaNV, sMaKH, dNgaymuahang) 
	VALUES(N'MHDB002', N'MNV001', N'MKH002','20230922')
	INSERT tblDonDatHang(sMaHDDH, sMaNV, sMaKH, dNgaymuahang)  
	VALUES(N'MHDB003', N'MNV002', N'MKH001','20231020')
	INSERT tblDonDatHang(sMaHDDH, sMaNV, sMaKH, dNgaymuahang) 
	VALUES(N'MHDB004', N'MNV002', N'MKH002','20230920')
	GO

	-- Bảng Chi Tiết Đặt Hàng
	INSERT tblChiTietDatHang(sMaHDDH, sMaCTSP, iSoLuong, fGiamGia, fGiaBan) 
	VALUES(N'MHDB001', N'MCTSP001', 2, 10000, 100000)
	INSERT tblChiTietDatHang(sMaHDDH, sMaCTSP, iSoLuong, fGiamGia, fGiaBan) 
	VALUES(N'MHDB001', N'MCTSP002', 2, 10000, 110000)
	INSERT tblChiTietDatHang(sMaHDDH, sMaCTSP, iSoLuong, fGiamGia, fGiaBan) 
	VALUES(N'MHDB002', N'MCTSP003', 3, 10000, 110000)
	INSERT tblChiTietDatHang(sMaHDDH, sMaCTSP, iSoLuong, fGiamGia, fGiaBan) 
	VALUES(N'MHDB002', N'MCTSP002', 5, 10000, 120000)
	INSERT tblChiTietDatHang(sMaHDDH, sMaCTSP, iSoLuong, fGiamGia, fGiaBan) 
	VALUES(N'MHDB003', N'MCTSP001', 1, 10000, 130000)
	INSERT tblChiTietDatHang(sMaHDDH, sMaCTSP, iSoLuong, fGiamGia, fGiaBan)  
	VALUES(N'MHDB003', N'MCTSP003', 1, 10000, 110000)
	INSERT tblChiTietDatHang(sMaHDDH, sMaCTSP, iSoLuong, fGiamGia, fGiaBan) 
	VALUES(N'MHDB004', N'MCTSP001', 3, 20000, 90000)
	INSERT tblChiTietDatHang(sMaHDDH, sMaCTSP, iSoLuong, fGiamGia, fGiaBan)   
	VALUES(N'MHDB004', N'MCTSP002', 1, 10000, 100000)
	INSERT tblChiTietDatHang(sMaHDDH, sMaCTSP, iSoLuong, fGiamGia, fGiaBan)  
	VALUES(N'MHDB004', N'MCTSP003', 5, 10000, 90000)
	GO


	create table tblTaiKhoan (
		sTaiKhoan NVARCHAR(30),
		sMatKhau nvarchar(30)
	)
	go

	insert tblTaiKhoan(sTaiKhoan, sMatKhau)
	values('sa1', '1');
	--select sTaiKhoan from tblTaiKhoan where sTaiKhoan = 'sa' and sMatKhau = '1';
	-- select sTaiKhoan from tblTaiKhoan
	

	
	--select *from tblNhaCungCap
	--select *from tblKhachHang
	--select *from tblNhanVien
	--select *from tblMatHang
	--select *from tblChiTietSanPham
	--select *from tblDonNhapHang
	--select *from tblChiTietNhapHang
	--select *from tblDonDatHang
	--select *from tblChiTietDatHang
	
	--select sTenNV as [Tên nhân viên], CASE bGioiTinh When 0 Then N'Nữ' When 1 Then 'Nam' else 'Chưa rõ' end as [Giới tính],
	--sDiachi as [Địa chỉ], sDienthoai as [Điện thoại], dNgayvaolam as [Ngày vào làm], fLuongcoban as [Lương cơ bản]
	--from tblNhanVien
	select sMaKH as [Mã khách hàng], sTenKH as [Tên khách hàng], CASE bGioiTinh When 0 Then N'Nữ' When 1 Then 'Nam' else 'Chưa rõ' end as [Giới tính],
	sDiachi as [Địa chỉ], sDienthoai as [Điện thoại]
	from tblKhachHang
	select sMaNV from tblNhanVien where tblNhanVien.sTenNV = N'Nguyễn Văn A';

	update tblNhanVien set sTenNV = N'c', bGioiTinh = 1, sDiachi = 'b' from tblNhanVien
	where tblNhanVien.sMaNV = 'a'
	go

	update tblNhanVien
	set sDienthoai = '1111111', dNgayvaolam = '20231002', fLuongcoban = 2
	from tblNhanVien
	where tblNhanVien.sMaNV = 'a'
	go

	select *from tblDonDatHang where tblDonDatHang.sMaHDDH = 'MHDB002'
	go
	select *from tblKhachHang where tblKhachHang.sMaKH = 'a';
	go
	select sMaHDNH as [Mã hóa đơn], sMaNV as [Mã nhân viên], sMaNCC as [Mã nhà cung cấp], dNgaynhaphang as [Ngày nhập hàng], fTongTien as [Tổng tiền hàng]
	from tblDonNhapHang
	go 


	select tblChiTietSanPham.sMaSP, tblSanPham.sTenSP, tblSanPham.sChatLieu, tblChiTietSanPham.sMau, tblChiTietSanPham.sSize, tblChiTietSanPham.iSoluongSP
	from tblChiTietSanPham
	inner join tblSanPham on tblSanPham.sMaSP = tblChiTietSanPham.sMaSP
	where tblChiTietSanPham.sMaSP = 'MSP001'
	go

	select tblSanPham.sTenSP, tblSanPham.sChatLieu, tblChiTietSanPham.sMau, tblChiTietSanPham.sSize, tblChiTietNhapHang.iSoLuong,
	tblChiTietNhapHang.fGiaNhap, tblDonNhapHang.sMaHDNH, tblNhaCungCap.sTenNCC, tblNhaCungCap.sDiaChi, tblNhaCungCap.sDienThoai, 
	tblDonNhapHang.dNgaynhaphang, tblDonNhapHang.fTongTien, tblNhanVien.sTenNV
	from tblDonNhapHang
	inner join tblChiTietNhapHang on tblChiTietNhapHang.sMaHDNH = tblDonNhapHang.sMaHDNH
	inner join tblChiTietSanPham on tblChiTietSanPham.sMaCTSP = tblChiTietNhapHang.sMaCTSP
	inner join tblSanPham on tblSanPham.sMaSP = tblChiTietSanPham.sMaSP
	inner join tblNhanVien on tblNhanVien.sMaNV = tblDonNhapHang.sMaNV
	inner join tblNhaCungCap on tblNhaCungCap.sMaNCC = tblDonNhapHang.sMaNCC
	where tblDonNhapHang.sMaHDNH = 'MHDN002';
	go

	select sMaHDDH as [Mã hóa đơn], sMaCTSP as [Mã chi tiết sản phẩm], iSoLuong as [Số lượng nhập], fGiamGia as [Giảm giá], fGiaBan as [Giá bán]
	from tblChiTietDatHang
	go


	