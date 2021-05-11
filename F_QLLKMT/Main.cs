using DevExpress.XtraBars;
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
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            InitializeComponent();
            showKh();
        }
        public string quyen;

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormAddNv form = new FormAddNv();
            form.mode = "add";
            form.ShowDialog();
            showNv();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void ribbon_SelectedPageChanged(object sender, EventArgs e)
        {
            text_chon_kh.EditValue = "";
            text_chon_nv.EditValue = "";
            text_chon_sp.EditValue = "";
            text_chon_hd.EditValue = "";
            if (Convert.ToString(ribbon.SelectedPage).Equals("Khách Hàng"))
            {
                showKh();
            }
            else if (Convert.ToString(ribbon.SelectedPage).Equals("Nhân Viên"))
            {
                showNv();
            }
            else if (Convert.ToString(ribbon.SelectedPage).Equals("Sản Phẩm"))
            {
                showSp();
            }
            else if (Convert.ToString(ribbon.SelectedPage).Equals("Hóa Đơn"))
            {
                showHd();
            }
   
        }

        private void btn_add_kh_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormAddKh formKh = new FormAddKh();
            formKh.ShowDialog();
            showKh();

        }

        private void btn_add_sp_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormAddSp formSp = new FormAddSp();
            formSp.ShowDialog();
            showSp();
        }

        private void btn_add_hd_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormAddHd formHd = new FormAddHd();
            formHd.ShowDialog();
            showHd();
        }

        private void showNv()
        {
            NhanVien nv = new NhanVien();
            DataSet data = nv.show();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = data.Tables[0];
        }
        private void showKh()
        {
    
            KhachHang kh = new KhachHang();
            DataSet data = kh.show();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = data.Tables[0];
        }
        private void showSp()
        {

            SanPham sp = new SanPham();
            DataSet data = sp.show();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = data.Tables[0];
        }
        private  void showHd()
        {
            HoaDon hd = new HoaDon();
            DataSet data = hd.show();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = data.Tables[0];
        }
        private void dataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            for (int i = 0; i < dataGridView.RowCount - 1; i++)
            {
                dataGridView.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String id = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            text_chon_nv.EditValue = id;
            text_chon_kh.EditValue = id;
            text_chon_sp.EditValue = id;
            text_chon_hd.EditValue = id;
        }

        private void btn_delete_nv_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(Convert.ToString(text_chon_nv.EditValue) != "")
            {
                DialogResult DRsult = MessageBox.Show("Có chắc chắn xóa nhân viên id = "+ Convert.ToString(text_chon_nv.EditValue) + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DRsult == DialogResult.Yes)
                {
                    NhanVien nv = new NhanVien();
                    nv.delete(Convert.ToString(text_chon_nv.EditValue));
                    showNv();
                }

            }
            else
            {
                MessageBox.Show("Chưa mã nào được chọn...");
            }
        }

        private void btn_delete_kh_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Convert.ToString(text_chon_kh.EditValue) != "")
            {
                DialogResult DRsult = MessageBox.Show("Có chắc chắn xóa khách hàng id = " + Convert.ToString(text_chon_kh.EditValue) + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DRsult == DialogResult.Yes)
                {
                    KhachHang kh = new KhachHang();
                    kh.delete(Convert.ToString(text_chon_kh.EditValue));
                    showKh();
                }

            }
            else
            {
                MessageBox.Show("Chưa mã nào được chọn...");
            }
        }

        private void btn_edit_sp_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Convert.ToString(text_chon_sp.EditValue) == "")
            {
                MessageBox.Show("Chưa chọn mã ....");
            }
            else
            {
                FormAddSp form = new FormAddSp();
                form.mode = "edit";
                form.id_hangnhap = Convert.ToString(text_chon_sp.EditValue);
                form.ShowDialog();
                showSp();
            }
        }

        private void btn_edit_nv_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Convert.ToString(text_chon_nv.EditValue) == "")
            {
                MessageBox.Show("Chưa chọn mã ....");
            }
            else
            {
                FormAddNv form = new FormAddNv();
                form.mode = "edit";
                form.id = Convert.ToString(text_chon_nv.EditValue);
                form.ShowDialog();
                showNv();
            }

        }

        private void btn_edit_kh_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(Convert.ToString(text_chon_kh.EditValue) != "")
            {
                FormAddKh formKh = new FormAddKh();
                formKh.id = Convert.ToString(text_chon_kh.EditValue);
                formKh.mode = "edit";
                formKh.ShowDialog();
                showKh();
            }
            else
            {
                MessageBox.Show("Chưa chọn mã ....");
            }
        }

        private void btn_edit_hd_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Convert.ToString(text_chon_hd.EditValue) != "")
            {
                FormAddHd formHd = new FormAddHd();
                formHd.id_hd = Convert.ToString(text_chon_hd.EditValue);
                formHd.mode = "edit";
                formHd.ShowDialog();
                showHd();
            }
            else
            {
                MessageBox.Show("Chưa chọn mã ....");
            }
        }

        private void btnXemHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Convert.ToString(text_chon_hd.EditValue) != "")
            {
                FormAddHd formHd = new FormAddHd();
                formHd.id_hd = Convert.ToString(text_chon_hd.EditValue);
                formHd.mode = "info";
                formHd.ShowDialog();
                showHd();
            }
            else
            {
                MessageBox.Show("Chưa chọn mã ....");
            }
        }

        private void btn_report_hd_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormBaoCao bc = new FormBaoCao();
            bc.ShowDialog();
        }

        private void btnLogOut_ItemClick(object sender, ItemClickEventArgs e)
        {

            DialogResult DRsult = MessageBox.Show("Có đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DRsult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {

                Login lg = new Login();
                lg.Show();


        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            if(quyen=="Nhân Viên")
            {
                page_nv.Visible = false;
            }
            else
            {
                page_nv.Visible = true;
            }
        }

        private void searchSp_EditValueChanged(object sender, EventArgs e)
        {

            SanPham sp = new SanPham();
            DataSet data = sp.search(Convert.ToString(searchSp.EditValue));
            if (data.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Dữ liệu không được tìm thấy");
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = data.Tables[0];
        }

        private void searchHd_EditValueChanged(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            DataSet data = hd.search(Convert.ToString(searchHd.EditValue));
            if (data.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Dữ liệu không được tìm thấy");
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = data.Tables[0];
        }
    }
}