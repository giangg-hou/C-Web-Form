
namespace BaiTapLon
{
    partial class QuanLyChiTietNhapHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnUpdateHoaDon = new System.Windows.Forms.Button();
            this.btnXoaHoaDon = new System.Windows.Forms.Button();
            this.dataDSChiTietNhapHang = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.textSoLuongNhap = new System.Windows.Forms.TextBox();
            this.textMaChiTietSanPham = new System.Windows.Forms.TextBox();
            this.textMaHoaDon = new System.Windows.Forms.TextBox();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.lbMaNhanVien = new System.Windows.Forms.Label();
            this.textGiaNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textGiaTriTimKiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataDanhSachTimKiem = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataDSChiTietNhapHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDanhSachTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(662, 240);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 35);
            this.btnThoat.TabIndex = 103;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnUpdateHoaDon
            // 
            this.btnUpdateHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdateHoaDon.Location = new System.Drawing.Point(476, 240);
            this.btnUpdateHoaDon.Name = "btnUpdateHoaDon";
            this.btnUpdateHoaDon.Size = new System.Drawing.Size(116, 35);
            this.btnUpdateHoaDon.TabIndex = 102;
            this.btnUpdateHoaDon.Text = "Cập nhật";
            this.btnUpdateHoaDon.UseVisualStyleBackColor = true;
            this.btnUpdateHoaDon.Click += new System.EventHandler(this.btnUpdateHoaDon_Click);
            // 
            // btnXoaHoaDon
            // 
            this.btnXoaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaHoaDon.Location = new System.Drawing.Point(305, 240);
            this.btnXoaHoaDon.Name = "btnXoaHoaDon";
            this.btnXoaHoaDon.Size = new System.Drawing.Size(116, 35);
            this.btnXoaHoaDon.TabIndex = 101;
            this.btnXoaHoaDon.Text = "Xóa";
            this.btnXoaHoaDon.UseVisualStyleBackColor = true;
            this.btnXoaHoaDon.Click += new System.EventHandler(this.btnXoaHoaDon_Click);
            // 
            // dataDSChiTietNhapHang
            // 
            this.dataDSChiTietNhapHang.AllowUserToAddRows = false;
            this.dataDSChiTietNhapHang.AllowUserToDeleteRows = false;
            this.dataDSChiTietNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDSChiTietNhapHang.Location = new System.Drawing.Point(77, 340);
            this.dataDSChiTietNhapHang.Name = "dataDSChiTietNhapHang";
            this.dataDSChiTietNhapHang.ReadOnly = true;
            this.dataDSChiTietNhapHang.Size = new System.Drawing.Size(553, 297);
            this.dataDSChiTietNhapHang.TabIndex = 100;
            this.dataDSChiTietNhapHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDSChiTietNhapHang_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(73, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 20);
            this.label2.TabIndex = 99;
            this.label2.Text = "Danh sách chi tiết nhập hàng : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(331, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 24);
            this.label4.TabIndex = 98;
            this.label4.Text = "CHI TIẾT NHẬP HÀNG";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(128, 240);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(116, 35);
            this.btnThem.TabIndex = 97;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // textSoLuongNhap
            // 
            this.textSoLuongNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textSoLuongNhap.Location = new System.Drawing.Point(612, 92);
            this.textSoLuongNhap.Name = "textSoLuongNhap";
            this.textSoLuongNhap.Size = new System.Drawing.Size(166, 26);
            this.textSoLuongNhap.TabIndex = 95;
            // 
            // textMaChiTietSanPham
            // 
            this.textMaChiTietSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textMaChiTietSanPham.Location = new System.Drawing.Point(291, 164);
            this.textMaChiTietSanPham.Name = "textMaChiTietSanPham";
            this.textMaChiTietSanPham.Size = new System.Drawing.Size(166, 26);
            this.textMaChiTietSanPham.TabIndex = 94;
            // 
            // textMaHoaDon
            // 
            this.textMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textMaHoaDon.Location = new System.Drawing.Point(291, 98);
            this.textMaHoaDon.Name = "textMaHoaDon";
            this.textMaHoaDon.Size = new System.Drawing.Size(166, 26);
            this.textMaHoaDon.TabIndex = 93;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDiaChi.Location = new System.Drawing.Point(487, 95);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(124, 20);
            this.lbDiaChi.TabIndex = 91;
            this.lbDiaChi.Text = "Số lượng nhập : ";
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.AutoSize = true;
            this.lbTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenNhanVien.Location = new System.Drawing.Point(115, 170);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(167, 20);
            this.lbTenNhanVien.TabIndex = 90;
            this.lbTenNhanVien.Text = "Mã chi tiết sản phẩm : ";
            // 
            // lbMaNhanVien
            // 
            this.lbMaNhanVien.AutoSize = true;
            this.lbMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaNhanVien.Location = new System.Drawing.Point(115, 104);
            this.lbMaNhanVien.Name = "lbMaNhanVien";
            this.lbMaNhanVien.Size = new System.Drawing.Size(101, 20);
            this.lbMaNhanVien.TabIndex = 89;
            this.lbMaNhanVien.Text = "Mã hóa đơn: ";
            // 
            // textGiaNhap
            // 
            this.textGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textGiaNhap.Location = new System.Drawing.Point(612, 167);
            this.textGiaNhap.Name = "textGiaNhap";
            this.textGiaNhap.Size = new System.Drawing.Size(166, 26);
            this.textGiaNhap.TabIndex = 106;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(487, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 105;
            this.label1.Text = "Giá nhập : ";
            // 
            // textGiaTriTimKiem
            // 
            this.textGiaTriTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textGiaTriTimKiem.Location = new System.Drawing.Point(1031, 89);
            this.textGiaTriTimKiem.Name = "textGiaTriTimKiem";
            this.textGiaTriTimKiem.Size = new System.Drawing.Size(126, 26);
            this.textGiaTriTimKiem.TabIndex = 108;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(850, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 107;
            this.label3.Text = "Tìm kiếm theo số lượng:";
            // 
            // dataDanhSachTimKiem
            // 
            this.dataDanhSachTimKiem.AllowUserToAddRows = false;
            this.dataDanhSachTimKiem.AllowUserToDeleteRows = false;
            this.dataDanhSachTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDanhSachTimKiem.Location = new System.Drawing.Point(662, 340);
            this.dataDanhSachTimKiem.Name = "dataDanhSachTimKiem";
            this.dataDanhSachTimKiem.ReadOnly = true;
            this.dataDanhSachTimKiem.Size = new System.Drawing.Size(553, 297);
            this.dataDanhSachTimKiem.TabIndex = 109;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(658, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 20);
            this.label5.TabIndex = 110;
            this.label5.Text = "Danh sách tìm kiếm : ";
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.Location = new System.Drawing.Point(1031, 148);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(126, 45);
            this.buttonTimKiem.TabIndex = 111;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // QuanLyChiTietNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 649);
            this.Controls.Add(this.buttonTimKiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataDanhSachTimKiem);
            this.Controls.Add(this.textGiaTriTimKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textGiaNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnUpdateHoaDon);
            this.Controls.Add(this.btnXoaHoaDon);
            this.Controls.Add(this.dataDSChiTietNhapHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.textSoLuongNhap);
            this.Controls.Add(this.textMaChiTietSanPham);
            this.Controls.Add(this.textMaHoaDon);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbTenNhanVien);
            this.Controls.Add(this.lbMaNhanVien);
            this.Name = "QuanLyChiTietNhapHang";
            this.Text = "QuanLyChiTietNhapHang";
            this.Load += new System.EventHandler(this.QuanLyChiTietNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDSChiTietNhapHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDanhSachTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnUpdateHoaDon;
        private System.Windows.Forms.Button btnXoaHoaDon;
        private System.Windows.Forms.DataGridView dataDSChiTietNhapHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox textSoLuongNhap;
        private System.Windows.Forms.TextBox textMaChiTietSanPham;
        private System.Windows.Forms.TextBox textMaHoaDon;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbTenNhanVien;
        private System.Windows.Forms.Label lbMaNhanVien;
        private System.Windows.Forms.TextBox textGiaNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textGiaTriTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataDanhSachTimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonTimKiem;
    }
}