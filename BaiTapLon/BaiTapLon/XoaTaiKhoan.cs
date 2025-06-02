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
    public partial class XoaTaiKhoan : Form
    {
        string constr = "Data Source=MSI\\GIANGZZZZ;Initial Catalog=BTL_HSK;Integrated Security=True";
        public XoaTaiKhoan()
        {
            InitializeComponent();
        }

        private void XoaTaiKhoan_Load(object sender, EventArgs e)
        {
            
        }

        int check(string s1)
        {
            string sql = "select sTaiKhoan AS [Tài Khoản] from tblTaiKhoan where sTaiKhoan = " + "'" + s1 + "'";
            SqlConnection cnn = new SqlConnection(constr);
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

        private bool Xoa(string s)
        {
            string query = "delete from tblTaiKhoan where tblTaiKhoan.sTaiKhoan = " + "'" + s + "'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (check(txtTaiKhoan.Text) == 1)
                {
                    if (Xoa(txtTaiKhoan.Text))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo");
                        txtTaiKhoan.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản không có trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void dtDSTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
