using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaiTapLon
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                if (txtTaiKhoan.Text == "")
                {
                    MessageBox.Show("Tài khoản không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            { 
                if (check(txtTaiKhoan.Text, txtMatKhau.Text) == 0)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else
                {
                    MessageBox.Show("Chào mừng bạn đến với hệ thống");
                    this.Hide();
                    TrangChu x = new TrangChu();
                    x.ShowDialog();
                    this.Close();
                }
            }
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
            } else
            {
                return 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
        }

        private void checkBox1_Click(object sender, EventArgs e)
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
    }
}
