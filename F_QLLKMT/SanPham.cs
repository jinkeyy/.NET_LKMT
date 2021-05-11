using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace F_QLLKMT
{
    class SanPham
    {
        private string tenSanPham;
        private string donVi;
        private string nhaSanXuat;
        private string danhMuc;
        private int soLuong;
        private int giaBan;
        private int giaNhap;
        private string ngayNhap;
        private string idNhanVien;
        public string TenSanPham   // property
        {
            get { return tenSanPham; }
            set { tenSanPham = value; }
        }
        public string DonVi   // property
        {
            get { return donVi; }
            set { donVi = value; }
        }
        public string DanhMuc   // property
        {
            get { return danhMuc; }
            set { danhMuc = value; }
        }
        public string NhaSanXuat   // property
        {
            get { return nhaSanXuat; }
            set { nhaSanXuat = value; }
        }
        public int SoLuong   // property
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public int GiaBan   // property
        {
            get { return giaBan; }
            set { giaBan = value; }
        }
        public int GiaNhap   // property
        {
            get { return giaNhap; }
            set { giaNhap = value; }
        }
        public string NgayNhap   // property
        {
            get { return ngayNhap; }
            set { ngayNhap = value; }
        }
        public string IdNhanVien
        {
            get { return idNhanVien; }
            set { idNhanVien = value; }
        }
        public DataSet show()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT t_hangnhap.id,tenNhanVien as nhanVienTao,tenSP,donVi,nhaSanXuat,danhMuc,soLuong,giaBan,giaNhap,ngayNhap FROM t_hangnhap INNER JOIN t_sanpham ON t_hangnhap.id_sp = t_sanpham.id INNER JOIN t_nhanvien ON t_nhanvien.id = t_hangnhap.id_nv", connection);
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
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT t_hangnhap.id,tenNhanVien as nhanVienTao,tenSP,donVi,nhaSanXuat,danhMuc,soLuong,giaBan,giaNhap,ngayNhap FROM t_hangnhap INNER JOIN t_sanpham ON t_hangnhap.id_sp = t_sanpham.id INNER JOIN t_nhanvien ON t_nhanvien.id = t_hangnhap.id_nv where tenSp like N'%"+key+"%'", connection);
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
                SqlCommand cm = new SqlCommand("INSERT INTO t_sanpham(tenSP, donVi, nhaSanXuat, danhMuc) VALUES (N'" + TenSanPham + "', N'" + DonVi + "', N'" + NhaSanXuat + "', N'" + DanhMuc + "'); ", connection);
                cm.ExecuteReader();



                connection.Close();
            }
            int idSp = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand cm1 = new SqlCommand("SELECT TOP 1 * FROM t_sanpham ORDER BY id DESC ", connection);
                SqlDataReader reader = cm1.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        idSp = (int)reader["id"];
                        Console.WriteLine("id = " + idSp);
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
                SqlCommand cm = new SqlCommand("INSERT INTO t_hangnhap(id_sp, id_nv, soLuong, ngayNhap, giaNhap, giaBan) VALUES ('" + idSp + "', '" + IdNhanVien + "', '" + SoLuong + "', '" + NgayNhap + "','" + GiaNhap + "','" + giaBan + "'); ", connection);
                cm.ExecuteReader();
                connection.Close();
            }
        }
        public void edit(string id_hangnhap,string id_sanpham)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand cm = new SqlCommand("UPDATE t_hangnhap Set id_nv = " + idNhanVien + ",soLuong = " + soLuong + ",ngayNhap = '" + ngayNhap  + "',giaBan = " + giaBan + ",giaNhap = " + giaNhap + " WHERE id =" + id_hangnhap, connection);
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
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand cm = new SqlCommand("UPDATE t_sanpham Set tenSP = N'" + tenSanPham + "',donVi = N'" + donVi + "',nhaSanXuat = N'" + nhaSanXuat + "',danhMuc = N'" + danhMuc + "' WHERE id =" + id_sanpham, connection);
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
