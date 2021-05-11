using DevExpress.XtraEditors;
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
    public partial class FormAddKh : DevExpress.XtraEditors.XtraForm
    {
        public FormAddKh()
        {
            InitializeComponent();
        }
        public string tenKhachHang;
        public string diaChi;
        public string sdt;
        public string mode;
        public string id;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textTenKhachHang.Text != "" && textDiaChi.Text != "" && textSdt.Text != "" )
            {
                    KhachHang kh = new KhachHang();
                    kh.TenKhachHang = textTenKhachHang.Text;
                    kh.DiaChi = textDiaChi.Text;
                    kh.SDT = textSdt.Text;
                if (simpleButton1.Text.Equals("Sửa"))
                {
                    kh.edit(id);
                }
                else
                {
                    kh.insert();

                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin...");
            }
        }

        private void FormAddKh_Load(object sender, EventArgs e)
        {
            if(mode == "edit")
            {
                simpleButton1.Text = "Sửa";
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand cm1 = new SqlCommand("SELECT * FROM t_khachhang where id =" + id, connection);
                    SqlDataReader reader = cm1.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            groupBox1.Text = "Sửa Khách Hàng " + (string)reader["tenKhachHang"];
                            textTenKhachHang.Text = (string)reader["tenKhachHang"];
                            textDiaChi.Text = (string)reader["diaChi"];
                            textSdt.Text = (string)reader["soDienThoai"];
                        }
                    }
                    else
                    {
                        Console.WriteLine("No rows found.");
                    }
                    reader.Close();
                    connection.Close();
                }
            }
        }
    }
}