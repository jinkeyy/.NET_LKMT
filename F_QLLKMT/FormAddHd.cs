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
using COMExcel = Microsoft.Office.Interop.Excel;

namespace F_QLLKMT
{
    public partial class FormAddHd : DevExpress.XtraEditors.XtraForm
    {
        public FormAddHd()
        {
            InitializeComponent();
        }
        public string id_hd;
        public string mode;
        public string tongtien;
        public string idHd;
        public string tenNhanVien;
        public string tenKhachHang;
        public string diaChi;
        public string sdt;
        public string ngayTao;
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_sp_hd_Click(object sender, EventArgs e)
        {
            String txtSp = txt_sp.Text;
            int txtSl =  Int32.Parse(txt_sl.Text);
            string[] arrListStr = txtSp.Split(' ');
            int id = Convert.ToInt32(arrListStr[arrListStr.Length - 1]);
            int sl = Convert.ToInt32(arrListStr[arrListStr.Length - 3]);
            int giaBan = Convert.ToInt32(arrListStr[arrListStr.Length - 6]);
            if (txtSp != "" && txtSl > 0 && txtSl <= sl)
            {
                string[] row = { txtSp, Convert.ToString(txtSl), Convert.ToString(giaBan), Convert.ToString(giaBan*txtSl) };
                var listViewItem = new ListViewItem(row);
                list_sp.Items.Add(listViewItem);
                list_sp.View = View.Details;
                resetTxt();
            }

        }
        private void resetTxt()
        {
            txt_sp.Text="";
            txt_sl.Text = "0";
        }

        private void list_sp_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///*MessageBox.Show("click");*/
            /*addmakhoa.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();*/
        }


        private void list_sp_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (list_sp.SelectedItems.Count >= 1)
            {
                ListViewItem item = list_sp.SelectedItems[0];
                if (item.Bounds.Contains(e.Location))
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa "+ item.Text+" ?", "Đang xóa...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        list_sp.Items[item.Index].Remove();
                    }
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if(comboKhachHang.Text != "" && comboNhanVien.Text != "" && dateEditNgayTao.Text != "" && list_sp.Items.Count > 0)
            {
                string[] arrListStr = comboKhachHang.Text.Split(' ');
                string idKh = arrListStr[arrListStr.Length - 1];
                string[] arrListStr1 = comboNhanVien.Text.Split(' ');
                string idNv = arrListStr1[arrListStr.Length - 1];
                if (textIdKh.Text == "")
                {
                    MessageBox.Show("Khách hàng mới");
                    KhachHang kh = new KhachHang();
                    kh.TenKhachHang = comboKhachHang.Text;
                    kh.DiaChi = textDiaChi.Text;
                    kh.SDT = textSdt.Text;
                    kh.insert();
                    using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                    {
                        connection.Open();
                        SqlCommand cm1 = new SqlCommand("SELECT TOP 1 * FROM t_khachhang ORDER BY id DESC ", connection);
                        SqlDataReader reader = cm1.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                idKh = Convert.ToString(reader["id"]);
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
                else
                {
                    //Khách hàng cũ
                    idKh = arrListStr[arrListStr.Length - 1];
                }
                HoaDon hd = new HoaDon();
                hd.taoHoaDon(idNv, idKh, dateEditNgayTao.Text);
                string idHd = "";
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand cm1 = new SqlCommand("SELECT TOP 1 * FROM t_hoadon ORDER BY id DESC ", connection);
                    SqlDataReader reader = cm1.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            idHd = Convert.ToString(reader["id"]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No rows found.");
                    }
                    reader.Close();
                    connection.Close();
                }
                for (int i = 0; i < list_sp.Items.Count; i++)
                {
                    string[] arrListStr2 = list_sp.Items[i].Text.Split(' ');
                    string idSp = arrListStr1[arrListStr.Length - 1];
      
                    hd.taoHoaDonChiTiet(idSp, list_sp.Items[i].SubItems[1].Text,idHd);
                }
                MessageBox.Show("Tạo Hóa Đơn thành công");
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin...");
            }

        }

        private void FormAddHd_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand cm = new SqlCommand("select * from t_hangnhap INNER JOIN t_sanpham on t_hangnhap.id_sp = t_sanpham.id where soLuong > 0", connection);
                SqlDataReader reader = cm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        String tempTen = (string)reader["tenSP"];
                        String tempGia = Convert.ToString(reader["giaBan"]);
                        String tempIdSp = Convert.ToString(reader["id"]);
                        String tempSl = Convert.ToString(reader["soLuong"]);
                        String temp = tempTen + "( " + tempGia + " VND) Còn: " + tempSl +" Id: "+tempIdSp;
                        txt_sp.Items.Add(temp);
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
                SqlCommand cm = new SqlCommand("select * from t_nhanvien", connection);
                SqlDataReader reader = cm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        String tempTen = (string)reader["tenNhanVien"];
                        String tempId = Convert.ToString(reader["id"]);
                        String temp = tempTen + " Id: "+tempId;
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
                SqlCommand cm = new SqlCommand("select * from t_khachhang", connection);
                SqlDataReader reader = cm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        String tempTen = (string)reader["tenKhachHang"];
                        String tempId = Convert.ToString(reader["id"]);
                        String temp = tempTen + " Id: " + tempId;
                        comboKhachHang.Items.Add(temp);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
                connection.Close();
            }
            //////////////////////////////////////////////////////////////
            if(mode == "edit")
            {
                groupBox1.Text = ("Sửa");
            }
            if(mode == "info")
            {
                simpleButton1.Visible = true;
                simpleButton2.Visible = false;
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand cm = new SqlCommand("select * from t_hoadon inner join t_nhanvien on t_hoadon.id_nv = t_nhanvien.id inner join t_khachhang on t_khachhang.id = t_hoadon.id_khachhang where t_hoadon.id = " + id_hd , connection);
                    SqlDataReader reader = cm.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            comboKhachHang.Enabled = false;
                            textDiaChi.Enabled = false;
                            textSdt.Enabled = false;
                            comboNhanVien.Enabled = false;
                            dateEditNgayTao.Enabled = false;
                            label6.Hide();
                            label3.Hide();
                            txt_sp.Hide();
                            txt_sl.Hide();
                            btn_add_sp_hd.Hide();
                            comboKhachHang.Text = (string)reader["tenKhachHang"];
                            tenKhachHang = (string)reader["tenKhachHang"];
                            textDiaChi.Text = (string)reader["diaChi"];
                            diaChi = (string)reader["diaChi"];
                            textSdt.Text = (string)reader["soDienThoai"];
                            sdt = (string)reader["soDienThoai"];
                            comboNhanVien.SelectedItem = (string)reader["tenNhanVien"]+" Id: "+Convert.ToString(reader["id_nv"]);
                            dateEditNgayTao.Text = (string)reader["ngaytao"];
                            ngayTao = (string)reader["ngaytao"];
                            tenNhanVien = (string)reader["tenNhanVien"];
                            groupBox1.Text = "Hóa Đơn Của Khách Hàng "+ (string)reader["tenKhachHang"];
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
                    SqlCommand cm = new SqlCommand("select * from t_hangnhap inner join t_hoadonchitiet on t_hangnhap.id = t_hoadonchitiet.id_hangnhap inner join t_sanpham on t_hangnhap.id_sp = t_sanpham.id where id_hoadon = " + id_hd, connection);
                    SqlDataReader reader = cm.ExecuteReader();
                    if (reader.HasRows)
                    {
                        int tong = 0;
                        while (reader.Read())
                        {
                            list_sp.Enabled = false;
                            int gia = Convert.ToInt32(reader["soluong"]) * Convert.ToInt32(reader["giaBan"]);
                            tong = tong + gia;
                            string[] row = { (string)reader["tenSP"], Convert.ToString(reader["soluong"]), Convert.ToString(reader["giaBan"])+" VND ", Convert.ToString(gia) + " VND"};
                            var listViewItem = new ListViewItem(row);
                            list_sp.Items.Add(listViewItem);
                            list_sp.View = View.Details;
                        }
                        /*                        string[] row1 = { "Tổng tiền: ","","", Convert.ToString(tong)+ " VND" };
                                                var listViewItem1 = new ListViewItem(row1);
                                                list_sp.Items.Add(listViewItem1);
                                                list_sp.View = View.Details;*/
                        tongtien =Convert.ToString(tong);
                        textTongTien.Text = tongtien + " VND";
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

        private void comboKhachHang_SelectedValueChanged(object sender, EventArgs e)
        {
 
            string[] arrListStr = comboKhachHang.Text.Split(' ');
            string id = arrListStr[arrListStr.Length - 1];
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlCommand cm = new SqlCommand("select * from t_khachhang where id = "+id, connection);
                SqlDataReader reader = cm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        comboKhachHang.Text = (string)reader["tenKhachHang"];
                        textDiaChi.Text = (string)reader["diaChi"];
                        textSdt.Text = (string)reader["soDienThoai"];
                        textIdKh.Text = Convert.ToString(reader["id"]);

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

        private void comboKhachHang_TextChanged(object sender, EventArgs e)
        {
            textIdKh.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;

            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "CỬA HÀNG LINH KIỆN ĐIỆN TỬ";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Phú Diễn - Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: ";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            // Biểu diễn thông tin chung của hóa đơn bán
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = id_hd;
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tenKhachHang;
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = diaChi;
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = sdt;
            //Lấy thông tin các mặt hàng
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Thành tiền";
            for (hang = 0; hang < list_sp.Items.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for ( cot = 0; cot < 4; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = list_sp.Items[hang].SubItems[cot].Text;
                   /* if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = list_sp.Items[cot].Text + "%";*/
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tongtien+ " VND";
            /*exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range["A1:F1"].Value = "Bằng chữ: " + tblThongtinHD.Rows[0][2].ToString();*/
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(ngayTao);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tenNhanVien;
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;
        }
    }
}