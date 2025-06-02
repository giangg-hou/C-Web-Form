
namespace BaiTapLon
{
    partial class QuanLyDonNhapHang
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
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnUpdateHoaDon = new System.Windows.Forms.Button();
            this.btnXoaHoaDon = new System.Windows.Forms.Button();
            this.dataDSHoaDon = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.dateNgayNhapHang = new System.Windows.Forms.DateTimePicker();
            this.textMaNhaCungCap = new System.Windows.Forms.TextBox();
            this.textMaNhanVien = new System.Windows.Forms.TextBox();
            this.textMaHoaDon = new System.Windows.Forms.TextBox();
            this.lbNgayVaoLam = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.lbMaNhanVien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataDSHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnInHoaDon.Location = new System.Drawing.Point(520, 242);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(116, 35);
            this.btnInHoaDon.TabIndex = 88;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(661, 242);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 35);
            this.btnThoat.TabIndex = 87;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnUpdateHoaDon
            // 
            this.btnUpdateHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdateHoaDon.Location = new System.Drawing.Point(377, 242);
            this.btnUpdateHoaDon.Name = "btnUpdateHoaDon";
            this.btnUpdateHoaDon.Size = new System.Drawing.Size(116, 35);
            this.btnUpdateHoaDon.TabIndex = 86;
            this.btnUpdateHoaDon.Text = "Cập nhật";
            this.btnUpdateHoaDon.UseVisualStyleBackColor = true;
            this.btnUpdateHoaDon.Click += new System.EventHandler(this.btnUpdateHoaDon_Click);
            // 
            // btnXoaHoaDon
            // 
            this.btnXoaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaHoaDon.Location = new System.Drawing.Point(244, 242);
            this.btnXoaHoaDon.Name = "btnXoaHoaDon";
            this.btnXoaHoaDon.Size = new System.Drawing.Size(116, 35);
            this.btnXoaHoaDon.TabIndex = 85;
            this.btnXoaHoaDon.Text = "Xóa";
            this.btnXoaHoaDon.UseVisualStyleBackColor = true;
            this.btnXoaHoaDon.Click += new System.EventHandler(this.btnXoaHoaDon_Click);
            // 
            // dataDSHoaDon
            // 
            this.dataDSHoaDon.AllowUserToAddRows = false;
            this.dataDSHoaDon.AllowUserToDeleteRows = false;
            this.dataDSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDSHoaDon.Location = new System.Drawing.Point(106, 339);
            this.dataDSHoaDon.Name = "dataDSHoaDon";
            this.dataDSHoaDon.ReadOnly = true;
            this.dataDSHoaDon.Size = new System.Drawing.Size(671, 297);
            this.dataDSHoaDon.TabIndex = 84;
            this.dataDSHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDSHoaDon_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(102, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 83;
            this.label2.Text = "Danh sách hóa đơn : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(325, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 24);
            this.label4.TabIndex = 82;
            this.label4.Text = "ĐƠN NHẬP HÀNG";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(103, 242);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(116, 35);
            this.btnThem.TabIndex = 81;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dateNgayNhapHang
            // 
            this.dateNgayNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateNgayNhapHang.Location = new System.Drawing.Point(606, 164);
            this.dateNgayNhapHang.Name = "dateNgayNhapHang";
            this.dateNgayNhapHang.Size = new System.Drawing.Size(166, 26);
            this.dateNgayNhapHang.TabIndex = 80;
            // 
            // textMaNhaCungCap
            // 
            this.textMaNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textMaNhaCungCap.Location = new System.Drawing.Point(606, 95);
            this.textMaNhaCungCap.Name = "textMaNhaCungCap";
            this.textMaNhaCungCap.Size = new System.Drawing.Size(166, 26);
            this.textMaNhaCungCap.TabIndex = 79;
            // 
            // textMaNhanVien
            // 
            this.textMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textMaNhanVien.Location = new System.Drawing.Point(228, 164);
            this.textMaNhanVien.Name = "textMaNhanVien";
            this.textMaNhanVien.Size = new System.Drawing.Size(166, 26);
            this.textMaNhanVien.TabIndex = 78;
            // 
            // textMaHoaDon
            // 
            this.textMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textMaHoaDon.Location = new System.Drawing.Point(228, 98);
            this.textMaHoaDon.Name = "textMaHoaDon";
            this.textMaHoaDon.Size = new System.Drawing.Size(166, 26);
            this.textMaHoaDon.TabIndex = 77;
            this.textMaHoaDon.TextChanged += new System.EventHandler(this.textMaHoaDon_TextChanged);
            // 
            // lbNgayVaoLam
            // 
            this.lbNgayVaoLam.AutoSize = true;
            this.lbNgayVaoLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNgayVaoLam.Location = new System.Drawing.Point(457, 169);
            this.lbNgayVaoLam.Name = "lbNgayVaoLam";
            this.lbNgayVaoLam.Size = new System.Drawing.Size(133, 20);
            this.lbNgayVaoLam.TabIndex = 76;
            this.lbNgayVaoLam.Text = "Ngày nhập hàng: ";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDiaChi.Location = new System.Drawing.Point(457, 98);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(143, 20);
            this.lbDiaChi.TabIndex = 75;
            this.lbDiaChi.Text = "Mã nhà cung cấp : ";
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.AutoSize = true;
            this.lbTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenNhanVien.Location = new System.Drawing.Point(102, 170);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(115, 20);
            this.lbTenNhanVien.TabIndex = 74;
            this.lbTenNhanVien.Text = "Mã nhân viên : ";
            // 
            // lbMaNhanVien
            // 
            this.lbMaNhanVien.AutoSize = true;
            this.lbMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaNhanVien.Location = new System.Drawing.Point(102, 104);
            this.lbMaNhanVien.Name = "lbMaNhanVien";
            this.lbMaNhanVien.Size = new System.Drawing.Size(101, 20);
            this.lbMaNhanVien.TabIndex = 73;
            this.lbMaNhanVien.Text = "Mã hóa đơn: ";
            // 
            // QuanLyDonNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 639);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnUpdateHoaDon);
            this.Controls.Add(this.btnXoaHoaDon);
            this.Controls.Add(this.dataDSHoaDon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dateNgayNhapHang);
            this.Controls.Add(this.textMaNhaCungCap);
            this.Controls.Add(this.textMaNhanVien);
            this.Controls.Add(this.textMaHoaDon);
            this.Controls.Add(this.lbNgayVaoLam);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbTenNhanVien);
            this.Controls.Add(this.lbMaNhanVien);
            this.Name = "QuanLyDonNhapHang";
            this.Text = "QuanLyDonNhapHang";
            this.Load += new System.EventHandler(this.QuanLyDonNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDSHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnUpdateHoaDon;
        private System.Windows.Forms.Button btnXoaHoaDon;
        private System.Windows.Forms.DataGridView dataDSHoaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dateNgayNhapHang;
        private System.Windows.Forms.TextBox textMaNhaCungCap;
        private System.Windows.Forms.TextBox textMaNhanVien;
        private System.Windows.Forms.TextBox textMaHoaDon;
        private System.Windows.Forms.Label lbNgayVaoLam;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbTenNhanVien;
        private System.Windows.Forms.Label lbMaNhanVien;
    }
}