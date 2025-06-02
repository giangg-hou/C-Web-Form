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
    public partial class ThayDoiMatKhau : Form
    {
        public ThayDoiMatKhau()
        {
            InitializeComponent();
        }


        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        int check(string s1, string s2)
        {
            string str = "Data Source=MSI\\GIANGZZZZ;Initial Catalog=BTL_HSK;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(str);
            string sql = "select sTaiKhoan from tblTaiKhoan where sTaiKhoan = " + "'" + s1 + "' and sMatKhau = " + "'" + s2 + "'";
            SqlDataAdapter mydata = new SqlDataAdapter(sql, cnn);
            DataTable tbl = new DataTable();
            mydata.Fill(tbl);
            if (tbl.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        int update (string s1, string s2)
        {
            string str = "Data Source=MSI\\GIANGZZZZ;Initial Catalog=BTL_HSK;Integrated Security=True";
            string sql = "update tblTaiKhoan set sMatKhau = " + "'" + s1 + "'" + " where tblTaiKhoan.sTaiKhoan = " + "'" + s2 + "'";
            using (SqlConnection cnn = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    if (i > 0) return 1;
                    else return 0;
                }
            }
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "" || txtMatKhauCu.Text == "" || txtMatKhauMoi.Text == "")
            {
                MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (check(txtTaiKhoan.Text, txtMatKhauCu.Text) == 0)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (txtMatKhauCu.Text == txtMatKhauMoi.Text)
                    {
                        MessageBox.Show("Mật khẩu mới bị trùng với mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } else
                    {
                        if (update(txtMatKhauMoi.Text, txtTaiKhoan.Text) == 1)
                        {
                            MessageBox.Show("Cập nhật thành công", "Thông báo");
                            txtMatKhauMoi.Text = "";
                            txtTaiKhoan.Text = "";
                            txtMatKhauCu.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại", "Thông báo");
                        }
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtMatKhauCu.PasswordChar = '\0';
            }
            else
            {
                txtMatKhauCu.PasswordChar = '*';
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                txtMatKhauMoi.PasswordChar = '\0';
            }
            else
            {
                txtMatKhauMoi.PasswordChar = '*';
            }
        }

        private void ThayDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtMatKhauCu.PasswordChar = '*';
            txtMatKhauMoi.PasswordChar = '*';
        }
    }
}
