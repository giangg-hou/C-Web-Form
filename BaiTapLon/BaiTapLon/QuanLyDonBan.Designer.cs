
namespace BaiTapLon
{
    partial class QuanLyDonBan
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
            this.dataDSHoaDon = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThemNhanHoaDon = new System.Windows.Forms.Button();
            this.dateNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.textMaKhachHang = new System.Windows.Forms.TextBox();
            this.textMaNhanVien = new System.Windows.Forms.TextBox();
            this.textMaHoaDon = new System.Windows.Forms.TextBox();
            this.lbNgayVaoLam = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.lbMaNhanVien = new System.Windows.Forms.Label();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataDSHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(655, 279);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 35);
            this.btnThoat.TabIndex = 71;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnUpdateHoaDon
            // 
            this.btnUpdateHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdateHoaDon.Location = new System.Drawing.Point(371, 279);
            this.btnUpdateHoaDon.Name = "btnUpdateHoaDon";
            this.btnUpdateHoaDon.Size = new System.Drawing.Size(116, 35);
            this.btnUpdateHoaDon.TabIndex = 70;
            this.btnUpdateHoaDon.Text = "Cập nhật";
            this.btnUpdateHoaDon.UseVisualStyleBackColor = true;
            this.btnUpdateHoaDon.Click += new System.EventHandler(this.btnUpdateHoaDon_Click);
            // 
            // btnXoaHoaDon
            // 
            this.btnXoaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaHoaDon.Location = new System.Drawing.Point(238, 279);
            this.btnXoaHoaDon.Name = "btnXoaHoaDon";
            this.btnXoaHoaDon.Size = new System.Drawing.Size(116, 35);
            this.btnXoaHoaDon.TabIndex = 69;
            this.btnXoaHoaDon.Text = "Xóa";
            this.btnXoaHoaDon.UseVisualStyleBackColor = true;
            this.btnXoaHoaDon.Click += new System.EventHandler(this.btnXoaHoaDon_Click);
            // 
            // dataDSHoaDon
            // 
            this.dataDSHoaDon.AllowUserToAddRows = false;
            this.dataDSHoaDon.AllowUserToDeleteRows = false;
            this.dataDSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDSHoaDon.Location = new System.Drawing.Point(100, 376);
            this.dataDSHoaDon.Name = "dataDSHoaDon";
            this.dataDSHoaDon.ReadOnly = true;
            this.dataDSHoaDon.Size = new System.Drawing.Size(671, 297);
            this.dataDSHoaDon.TabIndex = 68;
            this.dataDSHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDSHoaDon_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(96, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Danh sách hóa đơn : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(308, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 24);
            this.label4.TabIndex = 66;
            this.label4.Text = "ĐƠN BÁN HÀNG";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnThemNhanHoaDon
            // 
            this.btnThemNhanHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemNhanHoaDon.Location = new System.Drawing.Point(97, 279);
            this.btnThemNhanHoaDon.Name = "btnThemNhanHoaDon";
            this.btnThemNhanHoaDon.Size = new System.Drawing.Size(116, 35);
            this.btnThemNhanHoaDon.TabIndex = 65;
            this.btnThemNhanHoaDon.Text = "Thêm";
            this.btnThemNhanHoaDon.UseVisualStyleBackColor = true;
            this.btnThemNhanHoaDon.Click += new System.EventHandler(this.btnThemNhanHoaDon_Click);
            // 
            // dateNgayVaoLam
            // 
            this.dateNgayVaoLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateNgayVaoLam.Location = new System.Drawing.Point(592, 185);
            this.dateNgayVaoLam.Name = "dateNgayVaoLam";
            this.dateNgayVaoLam.Size = new System.Drawing.Size(166, 26);
            this.dateNgayVaoLam.TabIndex = 62;
            this.dateNgayVaoLam.ValueChanged += new System.EventHandler(this.dateNgayVaoLam_ValueChanged);
            // 
            // textMaKhachHang
            // 
            this.textMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textMaKhachHang.Location = new System.Drawing.Point(592, 116);
            this.textMaKhachHang.Name = "textMaKhachHang";
            this.textMaKhachHang.Size = new System.Drawing.Size(166, 26);
            this.textMaKhachHang.TabIndex = 60;
            this.textMaKhachHang.TextChanged += new System.EventHandler(this.textMaKhachHang_TextChanged);
            // 
            // textMaNhanVien
            // 
            this.textMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textMaNhanVien.Location = new System.Drawing.Point(222, 185);
            this.textMaNhanVien.Name = "textMaNhanVien";
            this.textMaNhanVien.Size = new System.Drawing.Size(166, 26);
            this.textMaNhanVien.TabIndex = 56;
            this.textMaNhanVien.TextChanged += new System.EventHandler(this.textMaNhanVien_TextChanged);
            // 
            // textMaHoaDon
            // 
            this.textMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textMaHoaDon.Location = new System.Drawing.Point(222, 119);
            this.textMaHoaDon.Name = "textMaHoaDon";
            this.textMaHoaDon.Size = new System.Drawing.Size(166, 26);
            this.textMaHoaDon.TabIndex = 55;
            this.textMaHoaDon.TextChanged += new System.EventHandler(this.textMaHoaDon_TextChanged);
            // 
            // lbNgayVaoLam
            // 
            this.lbNgayVaoLam.AutoSize = true;
            this.lbNgayVaoLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNgayVaoLam.Location = new System.Drawing.Point(443, 190);
            this.lbNgayVaoLam.Name = "lbNgayVaoLam";
            this.lbNgayVaoLam.Size = new System.Drawing.Size(128, 20);
            this.lbNgayVaoLam.TabIndex = 54;
            this.lbNgayVaoLam.Text = "Ngày mua hàng: ";
            this.lbNgayVaoLam.Click += new System.EventHandler(this.lbNgayVaoLam_Click);
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDiaChi.Location = new System.Drawing.Point(443, 119);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(130, 20);
            this.lbDiaChi.TabIndex = 52;
            this.lbDiaChi.Text = "Mã khách hàng : ";
            this.lbDiaChi.Click += new System.EventHandler(this.lbDiaChi_Click);
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.AutoSize = true;
            this.lbTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenNhanVien.Location = new System.Drawing.Point(96, 191);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(115, 20);
            this.lbTenNhanVien.TabIndex = 51;
            this.lbTenNhanVien.Text = "Mã nhân viên : ";
            this.lbTenNhanVien.Click += new System.EventHandler(this.lbTenNhanVien_Click);
            // 
            // lbMaNhanVien
            // 
            this.lbMaNhanVien.AutoSize = true;
            this.lbMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaNhanVien.Location = new System.Drawing.Point(96, 125);
            this.lbMaNhanVien.Name = "lbMaNhanVien";
            this.lbMaNhanVien.Size = new System.Drawing.Size(101, 20);
            this.lbMaNhanVien.TabIndex = 50;
            this.lbMaNhanVien.Text = "Mã hóa đơn: ";
            this.lbMaNhanVien.Click += new System.EventHandler(this.lbMaNhanVien_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnInHoaDon.Location = new System.Drawing.Point(514, 279);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(116, 35);
            this.btnInHoaDon.TabIndex = 72;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // QuanLyDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 685);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnUpdateHoaDon);
            this.Controls.Add(this.btnXoaHoaDon);
            this.Controls.Add(this.dataDSHoaDon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThemNhanHoaDon);
            this.Controls.Add(this.dateNgayVaoLam);
            this.Controls.Add(this.textMaKhachHang);
            this.Controls.Add(this.textMaNhanVien);
            this.Controls.Add(this.textMaHoaDon);
            this.Controls.Add(this.lbNgayVaoLam);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbTenNhanVien);
            this.Controls.Add(this.lbMaNhanVien);
            this.Name = "QuanLyDonBan";
            this.Text = "QuanLyDonBan";
            this.Load += new System.EventHandler(this.QuanLyDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDSHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnUpdateHoaDon;
        private System.Windows.Forms.Button btnXoaHoaDon;
        private System.Windows.Forms.DataGridView dataDSHoaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThemNhanHoaDon;
        private System.Windows.Forms.DateTimePicker dateNgayVaoLam;
        private System.Windows.Forms.TextBox textMaKhachHang;
        private System.Windows.Forms.TextBox textMaNhanVien;
        private System.Windows.Forms.TextBox textMaHoaDon;
        private System.Windows.Forms.Label lbNgayVaoLam;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbTenNhanVien;
        private System.Windows.Forms.Label lbMaNhanVien;
        private System.Windows.Forms.Button btnInHoaDon;
    }
}