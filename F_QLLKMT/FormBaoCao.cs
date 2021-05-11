using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace F_QLLKMT
{
    public partial class FormBaoCao : Form
    {
        public FormBaoCao()
        {
            InitializeComponent();
        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {
          
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                BaoCaoHoaDon rpt = new BaoCaoHoaDon();
                SqlDataAdapter dap = new SqlDataAdapter("select t_hoadon.id,tenNhanVien,tenKhachHang,t_khachhang.diaChi,t_khachhang.soDienThoai,ngaytao from t_hoadon inner join t_nhanvien on t_hoadon.id_nv = t_nhanvien.id inner join t_khachhang on t_khachhang.id = t_hoadon.id_khachhang ", connection);
                DataSet data = new DataSet();
                dap.Fill(data);
                rpt.SetDataSource(data.Tables[0]);
                rpHoaDon.ReportSource = rpt;
                connection.Close();
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void rpHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                BaoCaoHoaDon rpt = new BaoCaoHoaDon();
                SqlDataAdapter dap = new SqlDataAdapter("select t_hoadon.id,tenNhanVien,tenKhachHang,t_khachhang.diaChi,t_khachhang.soDienThoai,ngaytao from t_hoadon inner join t_nhanvien on t_hoadon.id_nv = t_nhanvien.id inner join t_khachhang on t_khachhang.id = t_hoadon.id_khachhang where tenKhachHang like N'%"+textKey.Text+"%'", connection);
                DataSet data = new DataSet();
                dap.Fill(data);
                rpt.SetDataSource(data.Tables[0]);
                rpHoaDon.ReportSource = rpt;
                connection.Close();
            }
            textKey.Text = "";
        }
    }
}
