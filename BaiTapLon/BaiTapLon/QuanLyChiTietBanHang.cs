using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon
{
    public partial class QuanLyChiTietBanHang : Form
    {
        string constr = "Data Source=MSI\\GIANGZZZZ;Initial Catalog=BTL_HSK;Integrated Security=True";
        public QuanLyChiTietBanHang()
        {
            InitializeComponent();
        }
        private void HienDS()
        {
            string query = "select sMaHDDH as [Mã hóa đơn], sMaCTSP as [Mã chi tiết sản phẩm], iSoLuong as [Số lượng nhập], fGiamGia as [Giảm giá], fGiaBan as [Giá nhập]" +
                            " from tblChiTietDatHang";

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    con.Close();
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        ad.Fill(tb);    
                        dataDSChiTietBanHang.DataSource = tb;
                    }
                }
            }

        }
        private bool checkMaCTSP()
        {
            string sql = "select *from tblChiTietSanPham where tblChiTietSanPham.sMaCTSP = N'" + textMaChiTietSanPham.Text + "'";
            SqlConnection cnn = new SqlConnection(constr);
            SqlDataAdapter mydata = new SqlDataAdapter(sql, cnn);
            DataTable tbl = new DataTable();
            mydata.Fill(tbl);
            if (tbl.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool checkMaHD()
        {
            string sql = "select *from tblChiTietDatHang where tblChiTietDatHang.sMaHDDH = N'" + textMaHoaDon.Text + "'";
            SqlConnection cnn = new SqlConnection(constr);
            SqlDataAdapter mydata = new SqlDataAdapter(sql, cnn);
            DataTable tbl = new DataTable();
            mydata.Fill(tbl);
            if (tbl.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool ThemHoaDon()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string query = "INSERT tblChiTietDatHang(sMaHDDH, sMaCTSP, iSoLuong, fGiamGia, fGiaBan) " +
                                " VALUES(N'" + textMaHoaDon.Text + "', N'" + textMaChiTietSanPham.Text + "', " + int.Parse(textSoLuongNhap.Text) + ", " + int.Parse(textGiamGia.Text) + ", " + int.Parse(textGiaBan.Text) + ")";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (textMaHoaDon.Text == "" || textMaChiTietSanPham.Text == "" || textGiamGia.Text == "" || textSoLuongNhap.Text == "" || textGiaBan.Text == "")
            {
                MessageBox.Show("Không được để các trường thông tin trống", "Thông báo");
            }
            else
            {
                if (!checkMaHD())
                {
                    MessageBox.Show("Mã hóa đơn không có trong hệ thống!!!", "Thông báo");
                }
                else if (!checkMaCTSP())
                {
                    MessageBox.Show("Mã nhân viên không có trong hệ thống!!!", "Thông báo");
                }
                else
                {
                    if (ThemHoaDon())
                    {
                        MessageBox.Show("Thêm thành công!!!", "Thông báo");
                        HienDS();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!!!", "Thông báo");
                    }
                }
            }
        }

        private bool XoaHoaDon()
        {
            string query = "delete from tblChiTietDatHang " +
                " Where tblChiTietDatHang.sMaHDDH = '" + textMaHoaDon.Text + "' and tblChiTietDatHang.sMaCTSP = '" + textMaChiTietSanPham.Text + "'";

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            if (textMaHoaDon.Text == "")
            {
                MessageBox.Show("Hãy điền mã hóa đơn để xóa", "Thông báo");
            }
            else
            {
                if (XoaHoaDon())
                {
                    MessageBox.Show("Xóa thành công");
                    HienDS();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private bool UpdateHoaDon()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string query = "update tblChiTietDatHang set sMaCTSP = N'" + textMaChiTietSanPham.Text + "', iSoLuong = " + int.Parse(textSoLuongNhap.Text) + ", fGiaBan = " + int.Parse(textGiaBan.Text) + ", fGiamGia = " + int.Parse(textGiamGia.Text) + " from tblChiTietNhapHang" +
                " where tblChiTietDatHang.sMaHDDH = '" + textMaHoaDon.Text + "' and tblChiTietDatHang.sMaCTSP = '" + textMaChiTietSanPham.Text + "'";
                using (SqlCommand cmd = new SqlCommand(query, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        private void btnUpdateHoaDon_Click(object sender, EventArgs e)
        {
            if (textMaHoaDon.Text == "" || textMaChiTietSanPham.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống!!!", "Thông báo");
            }
            else if (!checkMaHD())
            {
                MessageBox.Show("Mã hóa đơn không có trong hệ thống!!!", "Thông báo");
            }
            else if (!checkMaCTSP())
            {
                MessageBox.Show("Mã chi tiết sản phẩm không có trong hệ thống!!!", "Thông báo");
            }
            else
            {
                if (UpdateHoaDon())
                {
                    MessageBox.Show("Cập nhật thành công");
                    HienDS();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại trong danh sách");
                }
            }
        }

        private void dataDSChiTietBanHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            object s0 = dataDSChiTietBanHang.Rows[e.RowIndex].Cells[0].Value.ToString();
            object s1 = dataDSChiTietBanHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            object s2 = dataDSChiTietBanHang.Rows[e.RowIndex].Cells[2].Value.ToString();
            object s3 = dataDSChiTietBanHang.Rows[e.RowIndex].Cells[3].Value.ToString();
            object s4 = dataDSChiTietBanHang.Rows[e.RowIndex].Cells[4].Value.ToString();

            textMaHoaDon.Text = s0.ToString();
            textMaChiTietSanPham.Text = s1.ToString();
            textSoLuongNhap.Text = s2.ToString();
            textGiamGia.Text = s3.ToString();
            textGiaBan.Text = s4.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                this.Hide();
                TrangChu x = new TrangChu();
                x.ShowDialog();
                this.Close();
            }
        }

        private void QuanLyChiTietBanHang_Load(object sender, EventArgs e)
        {
            HienDS();
            dataDSChiTietBanHang.Columns[0].Width = 120;
            dataDSChiTietBanHang.Columns[1].Width = 130;
            dataDSChiTietBanHang.Columns[2].Width = 110;
            dataDSChiTietBanHang.Columns[3].Width = 120;
            dataDSChiTietBanHang.Columns[4].Width = 125;
        }
    }
}
