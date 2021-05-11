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
    public partial class FormAddSp : DevExpress.XtraEditors.XtraForm
    {
        public FormAddSp()
        {
            InitializeComponent();
        }
        public string id_hangnhap;
        public string id_sp;
        public string id_nv;
        public string mode;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormAddSp_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand cm = new SqlCommand("Select * from t_nhanvien", connection);
                SqlDataReader reader = cm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        String tempTen = (string)reader["tenNhanVien"] ;
                        String tempId = Convert.ToString((int)reader["id"]);
                        String temp = tempTen+ " id: " + tempId ;
                        comboNhanVien.Items.Add(temp);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
                connection.Close();
            }
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand cm = new SqlCommand("Select * from t_sanpham", connection);
                SqlDataReader reader = cm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        String temp = (string)reader["tenSP"];
                        comboTenSp.Items.Add(temp);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
                connection.Close();
            }
            if(mode == "edit")
            {
                groupBox1.Text = "Sửa";
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand cm = new SqlCommand("select * from t_hangnhap inner join t_sanpham on t_hangnhap.id_sp = t_sanpham.id inner join t_nhanvien on t_nhanvien.id = t_hangnhap.id_nv where t_hangnhap.id = "+id_hangnhap, connection);
                    SqlDataReader reader = cm.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            simpleButton1.Text = "Sửa";
                            id_sp = Convert.ToString(reader["id_sp"]);
                            comboTenSp.Text = (string)reader["tenSP"];
                            textDonVi.Text = (string)reader["donVi"];
                            textDanhMuc.Text = (string)reader["danhMuc"];
                            textNsx.Text = (string)reader["nhaSanXuat"];
                            string tempNv = (string)reader["tenNhanVien"] + " id: " + Convert.ToString(reader["id_nv"]);
                            comboNhanVien.SelectedItem = tempNv;
                            numericGiaBan.Value = Convert.ToDecimal(reader["giaBan"]);
                            numericSl.Value = Convert.ToDecimal(reader["soLuong"]);
                            numericSl.Enabled = false;
                            numericGiaNhap.Value = Convert.ToDecimal(reader["giaNhap"]);
                            dateNgayTao.Value = Convert.ToDateTime(reader["ngayNhap"]);
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
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string[] arrListStr = comboNhanVien.Text.Split(' ');
            String idNv =  arrListStr[arrListStr.Length-1];
            if (comboTenSp.Text != "" && Convert.ToInt32(numericGiaNhap.Value) != 0 && idNv != "" && Convert.ToInt32(numericSl.Value)>0)
            {
                SanPham sp = new SanPham();
                sp.TenSanPham = comboTenSp.Text;
                sp.DonVi = textDonVi.Text;
                sp.NhaSanXuat = textNsx.Text;
                sp.DanhMuc = textDanhMuc.Text;
                sp.IdNhanVien = idNv;
                sp.SoLuong = Convert.ToInt32(numericSl.Value);
                sp.GiaBan = Convert.ToInt32(numericGiaBan.Value);
                sp.GiaNhap = Convert.ToInt32(numericGiaNhap.Value);
                sp.NgayNhap = dateNgayTao.Text;
                if(simpleButton1.Text == "Sửa")
                {
                    sp.edit(id_hangnhap, id_sp);
                }
                else
                {
                    sp.insert();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin...");
            }

        }

        private void comboTenSp_SelectedValueChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand cm = new SqlCommand("Select * from t_sanpham where tenSP = N'"+comboTenSp.Text +"'", connection);
                SqlDataReader reader = cm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                       
                        textDonVi.Text = (string)reader["donVi"];
                        textDanhMuc.Text = (string)reader["nhaSanXuat"];
                        textNsx.Text = (string)reader["danhMuc"];
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