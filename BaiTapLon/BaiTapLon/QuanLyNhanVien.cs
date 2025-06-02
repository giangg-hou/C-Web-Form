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


    public partial class QuanLyNhanVien : Form
    {
        string constr = "Data Source=MSI\\GIANGZZZZ;Initial Catalog=BTL_HSK;Integrated Security=True";
        
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            HienDS();
            dataDSNV.Columns[0].Width = 120;
            dataDSNV.Columns[1].Width = 130;
            dataDSNV.Columns[2].Width = 100;
            dataDSNV.Columns[3].Width = 100;
            dataDSNV.Columns[4].Width = 120;
            dataDSNV.Columns[5].Width = 120;
            dataDSNV.Columns[6].Width = 120;
            dataDSNV.Columns[7].Width = 100;
        }

        private void HienDS()
        {
            string query = "select sMaNV as [Mã nhân viên] ,sTenNV as [Tên nhân viên], CASE bGioiTinh When 0 Then N'Nữ' When 1 Then 'Nam' else 'Chưa rõ' end as [Giới tính]," +
            "sDiachi as [Địa chỉ], sDienthoai as [Điện thoại], dNgayvaolam as [Ngày vào làm], fLuongcoban as [Lương cơ bản], fPhuCap as [Phụ cấp]" +
            "from tblNhanVien";

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
                        dataDSNV.DataSource = tb;
                    }
                }
            }
        }

        private void dataDSNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            object s0 = dataDSNV.Rows[e.RowIndex].Cells[0].Value.ToString();
            object s1 = dataDSNV.Rows[e.RowIndex].Cells[1].Value.ToString();
            object s2 = dataDSNV.Rows[e.RowIndex].Cells[2].Value.ToString();
            object s3 = dataDSNV.Rows[e.RowIndex].Cells[3].Value.ToString();
            object s4 = dataDSNV.Rows[e.RowIndex].Cells[4].Value.ToString();
            object s5 = dataDSNV.Rows[e.RowIndex].Cells[5].Value.ToString();
            object s6 = dataDSNV.Rows[e.RowIndex].Cells[6].Value.ToString();
            object s7 = dataDSNV.Rows[e.RowIndex].Cells[7].Value.ToString();
            
            textMaNhanVien.Text = s0.ToString();
            textTenNhanVien.Text = s1.ToString();
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
            dateNgayVaoLam.Text = s5.ToString();
            textLuong.Text = s6.ToString();
            textPhuCap.Text = s7.ToString();
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

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            if (checkMaNV(textMaNhanVien.Text))
            {
                MessageBox.Show("Tồn tại mã nhân viên trong hệ thống", "Thông báo");
            }
            else
            {
                if (rdNam.Checked == true)
                {
                    int luong = int.Parse(textLuong.Text);
                    bool ok = ThemNhanVien(textMaNhanVien.Text, textTenNhanVien.Text, 1, textDiaChi.Text, textDienThoai.Text, dateNgayVaoLam.Value, luong);
                    if (ok)
                    {
                        MessageBox.Show("Thêm Thành Công");
                        HienDS();
                    }
                }
                else
                {
                    int luong = int.Parse(textLuong.Text);
                    bool ok = ThemNhanVien(textMaNhanVien.Text, textTenNhanVien.Text, 0, textDiaChi.Text, textDienThoai.Text, dateNgayVaoLam.Value, luong);
                    if (ok)
                    {
                        MessageBox.Show("Thêm Thành Công");
                        HienDS();
                    }
                }
            }
        }

        private bool ThemNhanVien(string MaNV, string TenNV, int GioiTinh, string DiaChi, string DienThoai, DateTime ngayvaolam, int Luong)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string query = "INSERT tblNhanVien(sMaNV, sTenNV, bGioiTinh, dNgayvaolam, sDienthoai, sDiachi, fLuongcoban, fPhuCap) " +

                     "VALUES(N'" + MaNV + "', N'" + TenNV + "', " + GioiTinh + ", '" + ngayvaolam + "', '" + DienThoai + "', N'" + DiaChi + "', " + Luong + ", " + int.Parse(textPhuCap.Text) + ")";
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

        private bool XoaNhanVien(string MaNV)
        {
            string query = "delete from tblNhanVien " +
                " Where tblNhanVien.sMaNV = '" + MaNV + "'";
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

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (textMaNhanVien.Text == "")
            {
                MessageBox.Show("Hãy điền mã nhân viên để xóa", "Thông báo");
            }
            else
            {
                if (XoaNhanVien(textMaNhanVien.Text))
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


        private bool UpdateNhanVien1(string MaNV, string ten, int gioitinh, string diachi)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string query = "update tblNhanVien set sTenNV = N'" + ten +"', bGioiTinh = " + gioitinh +", sDiachi = '"+ diachi +"' from tblNhanVien" +
                " where tblNhanVien.sMaNV = '" + MaNV + "'";
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

        private bool UpdateNhanVien2(string MaNV, string dienthoai, DateTime d, int luong)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                string query = "update tblNhanVien set sDienthoai = N'" + dienthoai + "', dNgayvaolam = '" + d + "', fLuongcoban = " + luong + " , fPhuCap = " + int.Parse(textPhuCap.Text) + " from tblNhanVien" +
                " where tblNhanVien.sMaNV = '" + MaNV + "'";
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (textMaNhanVien.Text == "")
            {
                MessageBox.Show("Hãy điền mã nhân viên để cập nhật", "Thông báo");
            }
            else
            {
                int gioitinh = 0;
                if (rdNam.Checked == true) gioitinh = 1;
                if (UpdateNhanVien1(textMaNhanVien.Text, textTenNhanVien.Text, gioitinh, textDiaChi.Text) && UpdateNhanVien2(textMaNhanVien.Text, textDienThoai.Text, dateNgayVaoLam.Value, int.Parse(textLuong.Text)))
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
