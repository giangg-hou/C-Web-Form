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
    public partial class HienDanhSachT3 : Form
    {
        string constr = "Data Source=MSI\\GIANGZZZZ;Initial Catalog=BTL_HSK;Integrated Security=True";
        public HienDanhSachT3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                        " where tblDonNhapHang.sMaHDNH = '" + cbo.Text + "'";

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

        private void HienDanhSachT3_Load(object sender, EventArgs e)
        {
            string query = "select sMaHDNH as [Mã hóa đơn], sMaNV as [Mã nhân viên], sMaNCC as [Mã nhà cung cấp], dNgaynhaphang as [Ngày nhập hàng], fTongTien as [Tổng tiền hàng]" +
                           " from tblDonNhapHang";

            
        }
    }
}
