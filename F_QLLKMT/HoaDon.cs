using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace F_QLLKMT
{
    class HoaDon
    {
        public void taoHoaDonChiTiet(string id_hangnhap,string sl,string id_hoadon)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand cm = new SqlCommand("INSERT INTO t_hoadonchitiet(id_hangnhap, soluong, id_hoadon) VALUES(" + id_hangnhap + "," + sl + ", " + id_hoadon + ") ", connection);
                cm.ExecuteReader();
                connection.Close();
            }
            int slKho = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand cm1 = new SqlCommand("Select * from t_hangnhap where id = "+id_hangnhap, connection);
                SqlDataReader reader = cm1.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        slKho = (int)reader["soLuong"];
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
                SqlCommand cm = new SqlCommand("UPDATE t_hangnhap Set soLuong = N'" + Convert.ToString((slKho -Convert.ToInt32(sl))) + "' WHERE id =" + id_hangnhap, connection);
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
        public void taoHoaDon(string idNv,string idKh,string ngayTao)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand cm = new SqlCommand("INSERT INTO t_hoadon(id_nv, id_khachhang, ngaytao) VALUES(" + idNv + "," + idKh + ", N'" + ngayTao+ "') ", connection);
                cm.ExecuteReader();
                connection.Close();
            }
        }
        public DataSet show()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select t_hoadon.id,tenNhanVien,tenKhachHang,ngaytao from t_hoadon  INNER JOIN t_nhanvien on t_hoadon.id_nv = t_nhanvien.id INNER JOIN t_khachhang on t_hoadon.id_khachhang = t_khachhang.id", connection);
                DataSet data = new DataSet();
                adapter.Fill(data);
                connection.Close();
                return data;
            }
        }
        public DataSet search(string key)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select t_hoadon.id,tenNhanVien,tenKhachHang,ngaytao from t_hoadon  INNER JOIN t_nhanvien on t_hoadon.id_nv = t_nhanvien.id INNER JOIN t_khachhang on t_hoadon.id_khachhang = t_khachhang.id where tenKhachHang like N'%"+key+"%'", connection);
                DataSet data = new DataSet();
                adapter.Fill(data);
                connection.Close();
                return data;
            }
        }
    }
}
