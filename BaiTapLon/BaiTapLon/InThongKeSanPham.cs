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
    public partial class InThongKeSanPham : Form
    {
        string constr = "Data Source=MSI\\GIANGZZZZ;Initial Catalog=BTL_HSK;Integrated Security=True";

        public InThongKeSanPham()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select tblChiTietSanPham.sMaSP, tblSanPham.sTenSP, tblSanPham.sChatLieu, tblChiTietSanPham.sMau, tblChiTietSanPham.sSize, tblChiTietSanPham.iSoluongSP" +
                        " from tblChiTietSanPham" +
                        " inner join tblSanPham on tblSanPham.sMaSP = tblChiTietSanPham.sMaSP" +
                        " where tblChiTietSanPham.sMaSP = '" + textBox1.Text +"'";

            SqlConnection cnn = new SqlConnection(constr);
            SqlDataAdapter mydata = new SqlDataAdapter(sql, cnn);
            DataTable tbl = new DataTable();
            mydata.Fill(tbl);
            SanPham sp = new SanPham();
            sp.SetDataSource(tbl);
            crystalReportViewer1.ReportSource = sp;
        }
    }
}
