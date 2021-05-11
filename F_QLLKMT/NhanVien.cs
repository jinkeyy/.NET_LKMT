using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace F_QLLKMT
{
    class NhanVien
    {
        private string tennhanvien;
        private string diachi;
        private string sdt;
        private string pw;
        private string quyen;
        public string TenNhanVien   // property
        {
            get { return tennhanvien; }
            set { tennhanvien = value; }
        }
        public string DiaChi   // property
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string SDT   // property
        {
            get { return sdt; }
            set { sdt = value; }
        }
        public string PW   // property
        {
            get { return pw; }
            set { pw = value; }
        }
        public string Quyen   // property
        {
            get { return quyen; }
            set { quyen = value; }
        }

        public DataSet show()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from t_nhanvien", connection);
                DataSet data = new DataSet();
                adapter.Fill(data);
                connection.Close();
                return data;
            }
        }
        public void insert()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand cm = new SqlCommand("INSERT INTO t_nhanvien(tenNhanVien, diaChi, soDienThoai, pW, quyen) VALUES (N'" + TenNhanVien + "', N'" + DiaChi + "', N'" + SDT+ "', N'" +PW+ "', N'" +Quyen+ "'); ", connection);
                cm.ExecuteReader();
                connection.Close();
            }
        }
        public void delete(String id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand cm = new SqlCommand("DELETE FROM t_nhanvien WHERE id ="+id, connection);
                try
                {
                    cm.ExecuteReader();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi");
                }
                connection.Close();
            }
        }
        public void edit(String id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand cm = new SqlCommand("UPDATE t_nhanvien Set tenNhanVien = N'"+TenNhanVien+ "',diaChi = N'" + DiaChi + "',soDienThoai = '" + SDT + "',pW = '" + PW + "',quyen = N'" + Quyen + "' WHERE id =" + id, connection);
                try
                {
                    cm.ExecuteReader();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi");
                }
                connection.Close();
            }
        }
    }

 }
