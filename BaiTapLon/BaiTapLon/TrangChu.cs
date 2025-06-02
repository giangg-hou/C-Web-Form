using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DoiMK_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThayDoiMatKhau x = new ThayDoiMatKhau();
            x.ShowDialog();
            this.Close();
        }

        private void thêmTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKy x = new DangKy();
            x.ShowDialog();
            this.Close();
        }

        private void XoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            XoaTaiKhoan x = new XoaTaiKhoan();
            x.ShowDialog();
            this.Close();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyNhanVien x = new QuanLyNhanVien();
            x.ShowDialog();
            this.Close();
        }

        private void quảnLýĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyDonBan x = new QuanLyDonBan();
            x.ShowDialog();
            this.Close();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyKhachHang x = new QuanLyKhachHang();
            x.ShowDialog();
            this.Close();
        }

        private void thốngKêSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            InThongKeSanPham x = new InThongKeSanPham();
            x.ShowDialog();
            this.Close();
        }

        private void quảnLýĐơnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyDonNhapHang x = new QuanLyDonNhapHang();
            x.ShowDialog();
            this.Close();
        }

        private void quảnLýChiTiếtBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyChiTietBanHang x = new QuanLyChiTietBanHang();
            x.ShowDialog();
            this.Close();
        }

        private void quảnLýĐơnNhậpHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyChiTietNhapHang x = new QuanLyChiTietNhapHang();
            x.ShowDialog();
            this.Close();
        }
    }
}
