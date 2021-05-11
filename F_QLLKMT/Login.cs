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
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
                    }

        private void progressPanel1_Click(object sender, EventArgs e)
        {

        }

        private void tileBar1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gb_DangNhap_Enter(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
                    }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
                    }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            string tenNhanVien = "";
            if(tb_matkhau.Text == "" && tb_taikhoan.Text == "")
            {
                MessageBox.Show("Chưa nhập tài khoản hoặc mật khẩu...");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand cm1 = new SqlCommand("SELECT  * FROM t_nhanvien where soDienThoai = '"+tb_taikhoan.Text+"' AND pW = '"+tb_matkhau.Text+"'", connection);
                    SqlDataReader reader = cm1.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            tenNhanVien = (string)reader["tenNhanVien"];
                            string quyen = (string)reader["quyen"];
                            Main form = new Main();
                            form.quyen = quyen;
                            form.Show();
                    
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu sai...");
                    }
                    reader.Close();
                    connection.Close();
                }
            }
        }

        private void bt_dangnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
