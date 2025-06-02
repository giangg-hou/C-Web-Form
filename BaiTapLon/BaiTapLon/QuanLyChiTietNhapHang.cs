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
    public partial class QuanLyChiTietNhapHang : Form
    {
        string constr = "Data Source=MSI\\GIANGZZZZ;Initial Catalog=BTL_HSK;Integrated Security=True";
        public QuanLyChiTietNhapHang()
        {
            InitializeComponent();
        }

        private void HienDS()
        {
            string query = "select sMaHDNH as [Mã hóa đơn], sMaCTSP as [Mã chi tiết sản phẩm], iSoLuong as [Số lượng nhập], fGiaNhap as [Giá nhập]" +
                            " from tblChiTietNhapHang";

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
                        dataDSChiTietNhapHang.DataSource = tb;
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
            string sql = "select *from tblDonNhapHang where tblDonNhapHang.sMaHDNH = N'" + textMaHoaDon.Text + "'";
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
                string query = "INSERT tblChiTietNhapHang(sMaHDNH, sMaCTSP, iSoLuong, fGiaNhap) " +
                                " VALUES(N'" + textMaHoaDon.Text + "', N'" + textMaChiTietSanPham.Text + "', " + int.Parse(textSoLuongNhap.Text) + ", " + int.Parse(textGiaNhap.Text) + ")";
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
        private void QuanLyChiTietNhapHang_Load(object sender, EventArgs e)
        {
            HienDS();
            dataDSChiTietNhapHang.Columns[0].Width = 120;
            dataDSChiTietNhapHang.Columns[1].Width = 130;
            dataDSChiTietNhapHang.Columns[2].Width = 130;
            dataDSChiTietNhapHang.Columns[3].Width = 130;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (textMaHoaDon.Text == "" || textMaChiTietSanPham.Text == "" || textGiaNhap.Text == "" || textSoLuongNhap.Text == "")
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
            string query = "delete from tblChiTietNhapHang " +
                " Where tblChiTietNhapHang.sMaHDNH = '" + textMaHoaDon.Text + "' and tblChiTietNhapHang.sMaCTSP = '" + textMaChiTietSanPham.Text +"'";

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
                string query = "update tblChiTietNhapHang set sMaCTSP = N'" + textMaChiTietSanPham.Text + "', iSoLuong = " + int.Parse(textSoLuongNhap.Text) + ", fGiaNhap = " + int.Parse(textGiaNhap.Text) + " from tblChiTietNhapHang" +
                " where tblChiTietNhapHang.sMaHDNH = '" + textMaHoaDon.Text + "' and tblChiTietNhapHang.sMaCTSP = '" + textMaChiTietSanPham.Text +"'";
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

        private void dataDSChiTietNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            object s0 = dataDSChiTietNhapHang.Rows[e.RowIndex].Cells[0].Value.ToString();
            object s1 = dataDSChiTietNhapHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            object s2 = dataDSChiTietNhapHang.Rows[e.RowIndex].Cells[2].Value.ToString();
            object s3 = dataDSChiTietNhapHang.Rows[e.RowIndex].Cells[3].Value.ToString();

            textMaHoaDon.Text = s0.ToString();
            textMaChiTietSanPham.Text = s1.ToString();
            textSoLuongNhap.Text = s2.ToString();
            textGiaNhap.Text = s3.ToString();
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

        private void TimKiem(int x)
        {
            string query = "select sMaHDNH as [Mã hóa đơn], sMaCTSP as [Mã chi tiết sản phẩm], iSoLuong as [Số lượng nhập], fGiaNhap as [Giá nhập]" +
                            " from tblChiTietNhapHang where  tblChiTietNhapHang.iSoLuong >= " + x;

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
                        dataDanhSachTimKiem.DataSource = tb;
                    }
                }
            }
        }

        private bool checkSoLuong(int x)
        {
            string sql = "select *from tblChiTietNhapHang where tblChiTietNhapHang.iSoLuong >= " + x;
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

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if (textGiaTriTimKiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập", "Thông báo");
            }
            else
            {
                if (checkSoLuong(int.Parse(textGiaTriTimKiem.Text)))
                {
                    TimKiem(int.Parse(textGiaTriTimKiem.Text));
                }
                else
                {
                    DataTable tb = new DataTable();
                    dataDanhSachTimKiem.DataSource = tb;
                    MessageBox.Show("Không tìm thấy", "Thông báo");
                }
            }
        }
    }
}
