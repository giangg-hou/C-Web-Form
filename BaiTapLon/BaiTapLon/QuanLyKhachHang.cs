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
    public partial class QuanLyKhachHang : Form
    {
        string constr = "Data Source=MSI\\GIANGZZZZ;Initial Catalog=BTL_HSK;Integrated Security=True";

        public QuanLyKhachHang()
        {
            InitializeComponent();
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

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            HienDS();
            dataDSKH.Columns[0].Width = 120;
            dataDSKH.Columns[1].Width = 130;
            dataDSKH.Columns[2].Width = 100;
            dataDSKH.Columns[3].Width = 120;
            dataDSKH.Columns[4].Width = 120;
        }

        private void HienDS()
        {
            string query = "select sMaKH as [Mã khách hàng], sTenKH as [Tên khách hàng], CASE bGioiTinh When 0 Then N'Nữ' When 1 Then 'Nam' else 'Chưa rõ' end as [Giới tính], " +
                            " sDiachi as [Địa chỉ], sDienthoai as [Điện thoại] from tblKhachHang";

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
                        dataDSKH.DataSource = tb;
                    }
                }
            }
        }
        private bool ThemKhachHang(int gioitinh)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string query = "INSERT tblKhachHang(sMaKH, sTenKH, bGioiTinh, sDienthoai, sDiachi) " +
                     "VALUES(N'" + textMaKhachHang.Text + "', N'" + textTenKhachHang.Text + "', " + gioitinh + ", '" + textDienThoai.Text + "', N'" + textDiaChi.Text + "')";
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
        private bool checkMaKH()
        {
            string sql = "select *from tblKhachHang where tblKhachHang.sMaKH = N'" + textMaKhachHang.Text + "'";
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
            if (textMaKhachHang.Text == "")
            {
                MessageBox.Show("Không được để trống", "Thông báo");
            }
            else if (checkMaKH())
            {
                MessageBox.Show("Tồn tại mã khách hàng trong hệ thống", "Thông báo");
            }
            else
            {
                if (rdNam.Checked == true)
                {
                    bool ok = ThemKhachHang(1);
                    if (ok)
                    {
                        MessageBox.Show("Thêm Thành Công");
                        HienDS();
                    }
                }
                else
                {
                    bool ok = ThemKhachHang(0);
                    if (ok)
                    {
                        MessageBox.Show("Thêm Thành Công");
                        HienDS();
                    }
                }
            }
        }

        private bool XoaKhachHang(string MaKH)
        {
            string query = "delete from tblKhachHang " +
                " Where tblKhachHang.sMaKH = '" + MaKH + "'";
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (textMaKhachHang.Text == "")
            {
                MessageBox.Show("Hãy điền mã khách hàng để xóa", "Thông báo");
            }
            else
            {
                if (XoaKhachHang(textMaKhachHang.Text))
                {
                    MessageBox.Show("Xóa thành công");
                    HienDS();
                }
                else
                {
                    MessageBox.Show("Mã khách hàng không có trong danh sách");
                }
            }
        }

        private bool UpdateKhachHang(int gioitinh)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string query = "update tblKhachHang set sTenKH = N'" + textTenKhachHang.Text + "', bGioiTinh = " + gioitinh + ", sDiachi = N'" + textDiaChi.Text + "', sDienthoai = '" + textDienThoai.Text + "' from tblKhachHang" +
                " where tblKhachHang.sMaKH = '" + textMaKhachHang.Text + "'";
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

        private void dataDSKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            object s0 = dataDSKH.Rows[e.RowIndex].Cells[0].Value.ToString();
            object s1 = dataDSKH.Rows[e.RowIndex].Cells[1].Value.ToString();
            object s2 = dataDSKH.Rows[e.RowIndex].Cells[2].Value.ToString();
            object s3 = dataDSKH.Rows[e.RowIndex].Cells[3].Value.ToString();
            object s4 = dataDSKH.Rows[e.RowIndex].Cells[4].Value.ToString();

            textMaKhachHang.Text = s0.ToString();
            textTenKhachHang.Text = s1.ToString();
            if (s2.ToString() == "Nam")
            {
                rdNam.Checked = true;
                rdNu.Checked = false;
            }
            else
            {
                rdNam.Checked = false;
                rdNu.Checked = true;
            }
            textDiaChi.Text = s3.ToString();
            textDienThoai.Text = s4.ToString();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (textMaKhachHang.Text == "")
            {
                MessageBox.Show("Hãy điền mã khách hàng để cập nhật", "Thông báo");
            }
            else
            {
                int gioitinh = 0;
                if (rdNam.Checked == true) gioitinh = 1;
                if (UpdateKhachHang(gioitinh))
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
    }
}
