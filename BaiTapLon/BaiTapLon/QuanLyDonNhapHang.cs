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
    public partial class QuanLyDonNhapHang : Form
    {
        string constr = "Data Source=MSI\\GIANGZZZZ;Initial Catalog=BTL_HSK;Integrated Security=True";

        public QuanLyDonNhapHang()
        {
            InitializeComponent();
        }

        private void textMaHoaDon_TextChanged(object sender, EventArgs e)
        {

        }
        private void HienDS()
        {
            string query = "select sMaHDNH as [Mã hóa đơn], sMaNV as [Mã nhân viên], sMaNCC as [Mã nhà cung cấp], dNgaynhaphang as [Ngày nhập hàng], fTongTien as [Tổng tiền hàng]" +
                            " from tblDonNhapHang";

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

        private bool checkMaHD(string s)
        {
            string sql = "select *from tblDonNhapHang where tblDonNhapHang.sMaHDNH = N'" + s + "'";
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

        private bool ThemHoaDon()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string query = "INSERT tblDonNhapHang(sMaHDNH, sMaNCC, sMaNV, dNgaynhaphang) " +
                                " VALUES(N'" + textMaHoaDon.Text + "', N'" + textMaNhaCungCap.Text + "', '" + textMaNhanVien.Text + "', N'" + dateNgayNhapHang.Value + "')";
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

        private bool checkMaNCC(string s)
        {
            string sql = "select *from tblNhaCungCap where tblNhaCungCap.sMaNCC = N'" + s + "'";
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (textMaHoaDon.Text == "" || textMaNhaCungCap.Text == "" || textMaNhanVien.Text == "")
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
                else if (!checkMaNCC(textMaNhaCungCap.Text))
                {
                    MessageBox.Show("Mã nhà cung cấp không có trong hệ thống!!!", "Thông báo");
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

        private void QuanLyDonNhapHang_Load(object sender, EventArgs e)
        {
            HienDS();
            dataDSHoaDon.Columns[0].Width = 120;
            dataDSHoaDon.Columns[1].Width = 130;
            dataDSHoaDon.Columns[2].Width = 130;
            dataDSHoaDon.Columns[3].Width = 130;
            dataDSHoaDon.Columns[4].Width = 120;
       
        }

        private bool XoaHoaDon()
        {
            string query = "delete from tblDonNhapHang " +
                " Where tblDonNhapHang.sMaHDNH = '" + textMaHoaDon.Text + "'";
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
                string query = "update tblDonNhapHang set sMaNV = N'" + textMaNhanVien.Text + "', sMaNCC = '" + textMaNhaCungCap.Text + "', dNgaynhaphang = '" + dateNgayNhapHang.Value + "' from tblDonNhapHang" +
                " where tblDonNhapHang.sMaHDNH = '" + textMaHoaDon.Text + "'";
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
            else if (!checkMaNCC(textMaNhaCungCap.Text))
            {
                MessageBox.Show("Mã nhà cung cấp không có trong hệ thống!!!", "Thông báo");
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
                    MessageBox.Show("Cập nhật thất bại");
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
            textMaNhaCungCap.Text = s2.ToString();
            dateNgayNhapHang.Text = s3.ToString();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            string sql = "select tblSanPham.sTenSP, tblSanPham.sChatLieu, tblChiTietSanPham.sMau, tblChiTietSanPham.sSize, tblChiTietNhapHang.iSoLuong," +
                        " tblChiTietNhapHang.fGiaNhap, tblDonNhapHang.sMaHDNH, tblNhaCungCap.sTenNCC, tblNhaCungCap.sDiaChi, tblNhaCungCap.sDienThoai, " +
                        " tblDonNhapHang.dNgaynhaphang, tblDonNhapHang.fTongTien, tblNhanVien.sTenNV" +
                        " from tblDonNhapHang" +
                        " inner join tblChiTietNhapHang on tblChiTietNhapHang.sMaHDNH = tblDonNhapHang.sMaHDNH" +
                        " inner join tblChiTietSanPham on tblChiTietSanPham.sMaCTSP = tblChiTietNhapHang.sMaCTSP" +
                        " inner join tblSanPham on tblSanPham.sMaSP = tblChiTietSanPham.sMaSP" +
                        " inner join tblNhanVien on tblNhanVien.sMaNV = tblDonNhapHang.sMaNV" +
                        " inner join tblNhaCungCap on tblNhaCungCap.sMaNCC = tblDonNhapHang.sMaNCC" +
                        " where tblDonNhapHang.sMaHDNH = '" + textMaHoaDon.Text + "'";

            SqlConnection cnn = new SqlConnection(constr);
            SqlDataAdapter mydata = new SqlDataAdapter(sql, cnn);
            DataTable tbl = new DataTable();
            mydata.Fill(tbl);
            dsinHoaDonNhap hoadon = new dsinHoaDonNhap();
            hoadon.SetDataSource(tbl);
            InHoaDonBan f = new InHoaDonBan();
            f.crystalReportViewer1.ReportSource = hoadon;
            f.Show();
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

        private void loadDuLieu()
        {
            string query = "select sMaHDNH as [Mã hóa đơn], sMaNV as [Mã nhân viên], sMaNCC as [Mã nhà cung cấp], dNgaynhaphang as [Ngày nhập hàng], fTongTien as [Tổng tiền hàng]" +
                            " from tblDonNhapHang";

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
                    }
                }
            }
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
