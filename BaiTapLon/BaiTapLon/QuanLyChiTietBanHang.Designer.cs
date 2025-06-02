
namespace BaiTapLon
{
    partial class QuanLyChiTietBanHang
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
            this.textGiamGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnUpdateHoaDon = new System.Windows.Forms.Button();
            this.btnXoaHoaDon = new System.Windows.Forms.Button();
            this.dataDSChiTietBanHang = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.textSoLuongNhap = new System.Windows.Forms.TextBox();
            this.textMaChiTietSanPham = new System.Windows.Forms.TextBox();
            this.textMaHoaDon = new System.Windows.Forms.TextBox();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.lbMaNhanVien = new System.Windows.Forms.Label();
            this.textGiaBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataDSChiTietBanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // textGiamGia
            // 
            this.textGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textGiamGia.Location = new System.Drawing.Point(607, 168);
            this.textGiamGia.Name = "textGiamGia";
            this.textGiamGia.Size = new System.Drawing.Size(166, 26);
            this.textGiamGia.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(482, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 120;
            this.label1.Text = "Giảm giá : ";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(657, 296);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 35);
            this.btnThoat.TabIndex = 119;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnUpdateHoaDon
            // 
            this.btnUpdateHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdateHoaDon.Location = new System.Drawing.Point(657, 231);
            this.btnUpdateHoaDon.Name = "btnUpdateHoaDon";
            this.btnUpdateHoaDon.Size = new System.Drawing.Size(116, 35);
            this.btnUpdateHoaDon.TabIndex = 118;
            this.btnUpdateHoaDon.Text = "Cập nhật";
            this.btnUpdateHoaDon.UseVisualStyleBackColor = true;
            this.btnUpdateHoaDon.Click += new System.EventHandler(this.btnUpdateHoaDon_Click);
            // 
            // btnXoaHoaDon
            // 
            this.btnXoaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaHoaDon.Location = new System.Drawing.Point(510, 296);
            this.btnXoaHoaDon.Name = "btnXoaHoaDon";
            this.btnXoaHoaDon.Size = new System.Drawing.Size(116, 35);
            this.btnXoaHoaDon.TabIndex = 117;
            this.btnXoaHoaDon.Text = "Xóa";
            this.btnXoaHoaDon.UseVisualStyleBackColor = true;
            this.btnXoaHoaDon.Click += new System.EventHandler(this.btnXoaHoaDon_Click);
            // 
            // dataDSChiTietBanHang
            // 
            this.dataDSChiTietBanHang.AllowUserToAddRows = false;
            this.dataDSChiTietBanHang.AllowUserToDeleteRows = false;
            this.dataDSChiTietBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDSChiTietBanHang.Location = new System.Drawing.Point(123, 366);
            this.dataDSChiTietBanHang.Name = "dataDSChiTietBanHang";
            this.dataDSChiTietBanHang.ReadOnly = true;
            this.dataDSChiTietBanHang.Size = new System.Drawing.Size(650, 297);
            this.dataDSChiTietBanHang.TabIndex = 116;
            this.dataDSChiTietBanHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDSChiTietBanHang_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(119, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 20);
            this.label2.TabIndex = 115;
            this.label2.Text = "Danh sách chi tiết bán hàng : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(335, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 24);
            this.label4.TabIndex = 114;
            this.label4.Text = "CHI TIẾT BÁN HÀNG";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(510, 231);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(116, 35);
            this.btnThem.TabIndex = 113;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // textSoLuongNhap
            // 
            this.textSoLuongNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textSoLuongNhap.Location = new System.Drawing.Point(295, 228);
            this.textSoLuongNhap.Name = "textSoLuongNhap";
            this.textSoLuongNhap.Size = new System.Drawing.Size(166, 26);
            this.textSoLuongNhap.TabIndex = 112;
            // 
            // textMaChiTietSanPham
            // 
            this.textMaChiTietSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textMaChiTietSanPham.Location = new System.Drawing.Point(295, 165);
            this.textMaChiTietSanPham.Name = "textMaChiTietSanPham";
            this.textMaChiTietSanPham.Size = new System.Drawing.Size(166, 26);
            this.textMaChiTietSanPham.TabIndex = 111;
            // 
            // textMaHoaDon
            // 
            this.textMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textMaHoaDon.Location = new System.Drawing.Point(295, 99);
            this.textMaHoaDon.Name = "textMaHoaDon";
            this.textMaHoaDon.Size = new System.Drawing.Size(166, 26);
            this.textMaHoaDon.TabIndex = 110;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDiaChi.Location = new System.Drawing.Point(119, 231);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(115, 20);
            this.lbDiaChi.TabIndex = 109;
            this.lbDiaChi.Text = "Số lượng bán : ";
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.AutoSize = true;
            this.lbTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenNhanVien.Location = new System.Drawing.Point(119, 171);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(167, 20);
            this.lbTenNhanVien.TabIndex = 108;
            this.lbTenNhanVien.Text = "Mã chi tiết sản phẩm : ";
            // 
            // lbMaNhanVien
            // 
            this.lbMaNhanVien.AutoSize = true;
            this.lbMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaNhanVien.Location = new System.Drawing.Point(119, 105);
            this.lbMaNhanVien.Name = "lbMaNhanVien";
            this.lbMaNhanVien.Size = new System.Drawing.Size(101, 20);
            this.lbMaNhanVien.TabIndex = 107;
            this.lbMaNhanVien.Text = "Mã hóa đơn: ";
            // 
            // textGiaBan
            // 
            this.textGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textGiaBan.Location = new System.Drawing.Point(607, 99);
            this.textGiaBan.Name = "textGiaBan";
            this.textGiaBan.Size = new System.Drawing.Size(166, 26);
            this.textGiaBan.TabIndex = 123;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(482, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 122;
            this.label3.Text = "Giá bán : ";
            // 
            // QuanLyChiTietBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 666);
            this.Controls.Add(this.textGiaBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textGiamGia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnUpdateHoaDon);
            this.Controls.Add(this.btnXoaHoaDon);
            this.Controls.Add(this.dataDSChiTietBanHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.textSoLuongNhap);
            this.Controls.Add(this.textMaChiTietSanPham);
            this.Controls.Add(this.textMaHoaDon);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbTenNhanVien);
            this.Controls.Add(this.lbMaNhanVien);
            this.Name = "QuanLyChiTietBanHang";
            this.Text = "QuanLyChiTietBanHang";
            this.Load += new System.EventHandler(this.QuanLyChiTietBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDSChiTietBanHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textGiamGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnUpdateHoaDon;
        private System.Windows.Forms.Button btnXoaHoaDon;
        private System.Windows.Forms.DataGridView dataDSChiTietBanHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox textSoLuongNhap;
        private System.Windows.Forms.TextBox textMaChiTietSanPham;
        private System.Windows.Forms.TextBox textMaHoaDon;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbTenNhanVien;
        private System.Windows.Forms.Label lbMaNhanVien;
        private System.Windows.Forms.TextBox textGiaBan;
        private System.Windows.Forms.Label label3;
    }
}