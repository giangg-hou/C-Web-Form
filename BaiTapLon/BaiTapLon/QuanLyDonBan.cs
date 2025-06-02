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
    public partial class QuanLyDonBan : Form
    {
        string constr = "Data Source=MSI\\GIANGZZZZ;Initial Catalog=BTL_HSK;Integrated Security=True";

        public QuanLyDonBan()
        {
            InitializeComponent();
        }

        private void QuanLyDonBan_Load(object sender, EventArgs e)
        {
            HienDS();
            dataDSHoaDon.Columns[0].Width = 120;
            dataDSHoaDon.Columns[1].Width = 130;
            dataDSHoaDon.Columns[2].Width = 130;
            dataDSHoaDon.Columns[3].Width = 130;
            dataDSHoaDon.Columns[4].Width = 120;
        }

        private void lbMaNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void HienDS()
        {
            string query = "select sMaHDDH as [Mã hóa đơn], sMaNV as [Mã nhân viên], sMaKH as [Mã khách hàng], dNgaymuahang as [Ngày mua hàng], fTongTien as [Tổng tiền hàng] " +
                            " from tblDonDatHang";

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
                        dataDSHoaDon.DataSource = tb;
                    }
                }
            }
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

        private bool checkMaHD(string s)
        {
            string sql = "select *from tblDonDatHang where tblDonDatHang.sMaHDDH = N'" + s + "'";
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

        private bool checkMaNV(string s)
        {
            string sql = "select *from tblNhanVien where tblNhanVien.sMaNV = N'" + s + "'";
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
        private bool checkMaKH(string s)
        {
            string sql = "select *from tblKhachHang where tblKhachHang.sMaKH = N'" + s + "'";
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
                string query = "INSERT tblDonDatHang(sMaHDDH, sMaNV, sMaKH, dNgaymuahang) " +
                                " VALUES(N'"+ textMaHoaDon.Text +"', N'"+ textMaNhanVien.Text +"', N'"+ textMaKhachHang.Text +"', '"+ dateNgayVaoLam.Value +"')";

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

        private void btnThemNhanHoaDon_Click(object sender, EventArgs e)
        {
            if (textMaHoaDon.Text == "" || textMaKhachHang.Text == "" || textMaNhanVien.Text == "")
            {
                MessageBox.Show("Không được để các trường thông tin trống", "Thông báo");
            }
            else
            {
                if (checkMaHD(textMaHoaDon.Text))
                {
                    MessageBox.Show("Mã hóa đơn đã tồn tại trong hệ thống!!!", "Thông báo");
                }
                else if (!checkMaNV(textMaNhanVien.Text))
                {
                    MessageBox.Show("Mã nhân viên không có trong hệ thống!!!", "Thông báo");
                }
                else if (!checkMaKH(textMaKhachHang.Text))
                {
                    MessageBox.Show("Mã khách hàng không có trong hệ thống!!!", "Thông báo");
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

        private void dataDSHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            object s0 = dataDSHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString();
            object s1 = dataDSHoaDon.Rows[e.RowIndex].Cells[1].Value.ToString();
            object s2 = dataDSHoaDon.Rows[e.RowIndex].Cells[2].Value.ToString();
            object s3 = dataDSHoaDon.Rows[e.RowIndex].Cells[3].Value.ToString();

            textMaHoaDon.Text = s0.ToString();
            textMaNhanVien.Text = s1.ToString();
            textMaKhachHang.Text = s2.ToString();
            dateNgayVaoLam.Text = s3.ToString();
        }

        private bool XoaHoaDon()
        {
            string query = "delete from tblDonDatHang " +
                " Where tblDonDatHang.sMaHDDH = '" + textMaHoaDon.Text + "'";
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
                    MessageBox.Show("Mã nhân viên không có trong danh sách");
                }
            }
        }

        private bool UpdateHoaDon()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string query = "update tblDonDatHang set sMaNV = N'" + textMaNhanVien.Text + "', sMaKH = '"+ textMaKhachHang.Text + "', dNgaymuahang = '"+ dateNgayVaoLam.Value +"' from tblDonDatHang" +
                " where tblDonDatHang.sMaHDDH = '" + textMaHoaDon.Text + "'";
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
            if (textMaHoaDon.Text == "")
            {
                MessageBox.Show("Vui lòng điền mã hóa đơn!!!", "Thông báo");
            }
            else if (!checkMaHD(textMaHoaDon.Text))
            {
                MessageBox.Show("Mã hóa đơn không có trong hệ thống!!!", "Thông báo");
            }
            else if (!checkMaNV(textMaNhanVien.Text))
            {
                MessageBox.Show("Mã nhân viên không có trong hệ thống!!!", "Thông báo");
            }
            else if (!checkMaKH(textMaKhachHang.Text))
            {
                MessageBox.Show("Mã khách hàng không có trong hệ thống!!!", "Thông báo");
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
                    MessageBox.Show("Không tìm thấy nhân viên trong danh sách");
                }
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            string sql = "select tblDonDatHang.sMaHDDH, tblDonDatHang.sMaNV, tblDonDatHang.sMaKH, tblDonDatHang.dNgaymuahang, tblDonDatHang.fTongTien, " +
            " tblNhanVien.sTenNV, tblKhachHang.sTenKH, tblSanPham.sTenSP, tblSanPham.sChatLieu, tblChiTietSanPham.sMau, tblChiTietSanPham.sSize, " +
            " tblChiTietDatHang.iSoluong, tblChiTietDatHang.fGiamGia, tblChiTietDatHang.fGiaBan " +
            " from tblDonDatHang " +
            " inner join tblChiTietDatHang on tblChiTietDatHang.sMaHDDH = tblDonDatHang.sMaHDDH " +
            " inner join tblChiTietSanPham on tblChiTietSanPham.sMaCTSP = tblChiTietDatHang.sMaCTSP " +
            " inner join tblSanPham on tblSanPham.sMaSP = tblChiTietSanPham.sMaSP " +
            " inner join tblNhanVien on tblNhanVien.sMaNV = tblDonDatHang.sMaNV " +
            " inner join tblKhachHang on tblKhachHang.sMaKH = tblDonDatHang.sMaKH " +
            " where tblDonDatHang.sMaHDDH = N'" + textMaHoaDon.Text +"'";

            SqlConnection cnn = new SqlConnection(constr);
            SqlDataAdapter mydata = new SqlDataAdapter(sql, cnn);
            DataTable tbl = new DataTable();
            mydata.Fill(tbl);
            HoaDonBan hoadon = new HoaDonBan();
            hoadon.SetDataSource(tbl);
            InHoaDonBan f = new InHoaDonBan();
            f.crystalReportViewer1.ReportSource = hoadon;
            f.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateNgayVaoLam_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textMaKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void textMaNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void textMaHoaDon_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbNgayVaoLam_Click(object sender, EventArgs e)
        {

        }

        private void lbDiaChi_Click(object sender, EventArgs e)
        {

        }

        private void lbTenNhanVien_Click(object sender, EventArgs e)
        {

        }
    }
}
