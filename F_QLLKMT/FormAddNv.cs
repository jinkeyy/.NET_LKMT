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
    public partial class FormAddNv : DevExpress.XtraEditors.XtraForm
    {
        public FormAddNv()
        {
            InitializeComponent();
        }

        private void FormAddNv_Load(object sender, EventArgs e)
        {
            if (mode == "add")
            {
                simpleButton2.Text = "Thêm";
            }
            else
            {
                simpleButton2.Text = "Sửa";
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand cm1 = new SqlCommand("SELECT * FROM t_nhanvien where id ="+id, connection);
                    SqlDataReader reader = cm1.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            groupBox1.Text = "Sửa Nhân Viên " + (string)reader["tenNhanVien"];
                            TextTenNhanVien.Text=(string)reader["tenNhanVien"];
                            textDiaChi.Text = (string)reader["diaChi"];
                            textDienThoat.Text= (string)reader["soDienThoai"];
                            textMatKhau.Text = (string)reader["pW"];
                            textRMatKhau.Text = (string)reader["pW"];
                            comboxQuyen.Text = (string)reader["quyen"];
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
        public string mode;
        public string id;
        public string tenNhanVien;
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if(TextTenNhanVien.Text != "" && textDiaChi.Text != "" && textDienThoat.Text != "" && textMatKhau.Text != "" && comboxQuyen.Text != ""){
                if (textMatKhau.Text.Equals(textRMatKhau.Text))
                {
                    NhanVien nv = new NhanVien();
                    nv.TenNhanVien = TextTenNhanVien.Text;
                    nv.DiaChi = textDiaChi.Text;
                    nv.SDT = textDienThoat.Text;
                    nv.PW = textMatKhau.Text;
                    nv.Quyen = comboxQuyen.Text;
                    if (simpleButton2.Text.Equals("Thêm"))
                    {
                        nv.insert();
                        this.Close();
                    }
                    else if(simpleButton2.Text.Equals("Sửa"))
                    {
                        nv.edit(id);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu không trùng");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin...");
            }

        }
    }
}
