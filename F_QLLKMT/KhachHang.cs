using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace F_QLLKMT
{
    class KhachHang
    {
        private string tenkhachhang;
        private string diachi;
        private string sdt;
        public string TenKhachHang // property
        {
            get { return tenkhachhang; }
            set { tenkhachhang = value; }
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
        public DataSet show()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from t_khachhang", connection);
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
                SqlCommand cm = new SqlCommand("INSERT INTO t_khachhang(tenKhachHang, diaChi, soDienThoai) VALUES (N'" + TenKhachHang + "', N'" + DiaChi + "', N'" + SDT + "'); ", connection);
                cm.ExecuteReader();
                connection.Close();
            }
        }
        public void delete(String id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand cm = new SqlCommand("DELETE FROM t_khachhang WHERE id=" + id, connection);
                cm.ExecuteReader();
                connection.Close();
            }
        }
        public void edit(String id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand cm = new SqlCommand("UPDATE t_khachhang Set tenKhachHang = N'" + TenKhachHang + "',diaChi = N'" + DiaChi + "',soDienThoai = '" + SDT +"' WHERE id =" + id, connection);
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
