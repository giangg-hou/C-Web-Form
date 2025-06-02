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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "" || txtMatKhauNhapLai.Text == "")
            {
                MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (check(txtTaiKhoan.Text) == 1)
                {
                    MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (txtMatKhau.Text != txtMatKhauNhapLai.Text)
                    {
                        MessageBox.Show("Mật khẩu nhập lại khác mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (insert(txtTaiKhoan.Text, txtMatKhau.Text) == 1)
                        {

                            MessageBox.Show("Đăng Ký thành công", "Thông báo");
                            txtTaiKhoan.Text = "";
                            txtMatKhau.Text = "";
                            txtMatKhauNhapLai.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Đăng ký thất bại", "Thông báo");
                        }
                    }
                }
            }
        }

        int check(string s1)
        {
            string str = "Data Source=MSI\\GIANGZZZZ;Initial Catalog=BTL_HSK;Integrated Security=True";
            string sql = "select sTaiKhoan from tblTaiKhoan where sTaiKhoan = " + "'" + s1 + "'";
            SqlConnection cnn = new SqlConnection(str);
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

        int insert(string s1, string s2)
        {
            string str = "Data Source=MSI\\GIANGZZZZ;Initial Catalog=BTL_HSK;Integrated Security=True";
            string sql = "insert tblTaiKhoan(sTaiKhoan, sMatKhau) " +
                           "values('"+ s1 +"', '"+ s2 +"')";
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

        private void DangKy_Load(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
            txtMatKhauNhapLai.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                txtMatKhauNhapLai.PasswordChar = '\0';
            }
            else
            {
                txtMatKhauNhapLai.PasswordChar = '*';
            }
        }
    }
}
