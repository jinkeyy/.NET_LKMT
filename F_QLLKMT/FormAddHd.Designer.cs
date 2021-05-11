
namespace F_QLLKMT
{
    partial class FormAddHd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddHd));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textTongTien = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dateEditNgayTao = new DevExpress.XtraEditors.DateEdit();
            this.textIdKh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add_sp_hd = new DevExpress.XtraEditors.SimpleButton();
            this.list_sp = new System.Windows.Forms.ListView();
            this.sanpham = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.giaBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thanhGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sl = new System.Windows.Forms.NumericUpDown();
            this.txt_sp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboNhanVien = new System.Windows.Forms.ComboBox();
            this.comboKhachHang = new System.Windows.Forms.ComboBox();
            this.textSdt = new System.Windows.Forms.TextBox();
            this.textDiaChi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayTao.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayTao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sl)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textTongTien);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateEditNgayTao);
            this.groupBox1.Controls.Add(this.textIdKh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Controls.Add(this.btn_add_sp_hd);
            this.groupBox1.Controls.Add(this.list_sp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_sl);
            this.groupBox1.Controls.Add(this.txt_sp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboNhanVien);
            this.groupBox1.Controls.Add(this.comboKhachHang);
            this.groupBox1.Controls.Add(this.textSdt);
            this.groupBox1.Controls.Add(this.textDiaChi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 622);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm Hóa Đơn";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tổng tiền:";
            // 
            // textTongTien
            // 
            this.textTongTien.Enabled = false;
            this.textTongTien.Location = new System.Drawing.Point(401, 401);
            this.textTongTien.Name = "textTongTien";
            this.textTongTien.Size = new System.Drawing.Size(95, 21);
            this.textTongTien.TabIndex = 21;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(460, 472);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(37, 38);
            this.simpleButton1.TabIndex = 20;
            this.simpleButton1.Visible = false;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ngày Tạo:";
            // 
            // dateEditNgayTao
            // 
            this.dateEditNgayTao.EditValue = null;
            this.dateEditNgayTao.Location = new System.Drawing.Point(282, 427);
            this.dateEditNgayTao.Name = "dateEditNgayTao";
            this.dateEditNgayTao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgayTao.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgayTao.Size = new System.Drawing.Size(100, 20);
            this.dateEditNgayTao.TabIndex = 18;
            // 
            // textIdKh
            // 
            this.textIdKh.Enabled = false;
            this.textIdKh.Location = new System.Drawing.Point(503, 50);
            this.textIdKh.Name = "textIdKh";
            this.textIdKh.Size = new System.Drawing.Size(23, 21);
            this.textIdKh.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(150, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "*Click vào tên sản phẩm để xóa.";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(282, 482);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(80, 28);
            this.simpleButton2.TabIndex = 15;
            this.simpleButton2.Text = "Xác Nhận";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btn_add_sp_hd
            // 
            this.btn_add_sp_hd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_sp_hd.ImageOptions.Image")));
            this.btn_add_sp_hd.Location = new System.Drawing.Point(546, 207);
            this.btn_add_sp_hd.Name = "btn_add_sp_hd";
            this.btn_add_sp_hd.Size = new System.Drawing.Size(21, 21);
            this.btn_add_sp_hd.TabIndex = 14;
            this.btn_add_sp_hd.Click += new System.EventHandler(this.btn_add_sp_hd_Click);
            // 
            // list_sp
            // 
            this.list_sp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sanpham,
            this.soluong,
            this.giaBan,
            this.thanhGia});
            this.list_sp.HideSelection = false;
            this.list_sp.Location = new System.Drawing.Point(153, 247);
            this.list_sp.Name = "list_sp";
            this.list_sp.Size = new System.Drawing.Size(344, 147);
            this.list_sp.TabIndex = 13;
            this.list_sp.UseCompatibleStateImageBehavior = false;
            this.list_sp.SelectedIndexChanged += new System.EventHandler(this.list_sp_SelectedIndexChanged);
            this.list_sp.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_sp_MouseDoubleClick);
            // 
            // sanpham
            // 
            this.sanpham.Text = "Sản Phẩm";
            this.sanpham.Width = 100;
            // 
            // soluong
            // 
            this.soluong.Text = "Số Lượng";
            this.soluong.Width = 100;
            // 
            // giaBan
            // 
            this.giaBan.Text = "Giá Bán";
            // 
            // thanhGia
            // 
            this.thanhGia.Text = "Thành Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Thêm Sản Phẩm:";
            // 
            // txt_sl
            // 
            this.txt_sl.Location = new System.Drawing.Point(503, 207);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(37, 21);
            this.txt_sl.TabIndex = 11;
            // 
            // txt_sp
            // 
            this.txt_sp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_sp.FormattingEnabled = true;
            this.txt_sp.Location = new System.Drawing.Point(282, 207);
            this.txt_sp.Name = "txt_sp";
            this.txt_sp.Size = new System.Drawing.Size(215, 21);
            this.txt_sp.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Địa Chỉ: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nhân Viên Tạo: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số Điện Thoại:";
            // 
            // comboNhanVien
            // 
            this.comboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNhanVien.FormattingEnabled = true;
            this.comboNhanVien.Location = new System.Drawing.Point(282, 166);
            this.comboNhanVien.Name = "comboNhanVien";
            this.comboNhanVien.Size = new System.Drawing.Size(215, 21);
            this.comboNhanVien.TabIndex = 5;
            // 
            // comboKhachHang
            // 
            this.comboKhachHang.FormattingEnabled = true;
            this.comboKhachHang.Location = new System.Drawing.Point(282, 50);
            this.comboKhachHang.Name = "comboKhachHang";
            this.comboKhachHang.Size = new System.Drawing.Size(215, 21);
            this.comboKhachHang.TabIndex = 4;
            this.comboKhachHang.SelectedValueChanged += new System.EventHandler(this.comboKhachHang_SelectedValueChanged);
            this.comboKhachHang.TextChanged += new System.EventHandler(this.comboKhachHang_TextChanged);
            // 
            // textSdt
            // 
            this.textSdt.Location = new System.Drawing.Point(282, 126);
            this.textSdt.Name = "textSdt";
            this.textSdt.Size = new System.Drawing.Size(215, 21);
            this.textSdt.TabIndex = 3;
            // 
            // textDiaChi
            // 
            this.textDiaChi.Location = new System.Drawing.Point(282, 87);
            this.textDiaChi.Name = "textDiaChi";
            this.textDiaChi.Size = new System.Drawing.Size(215, 21);
            this.textDiaChi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Khách Hàng:";
            // 
            // FormAddHd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 646);
            this.Controls.Add(this.groupBox1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FormAddHd.IconOptions.LargeImage")));
            this.Name = "FormAddHd";
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.FormAddHd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayTao.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgayTao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboNhanVien;
        private System.Windows.Forms.ComboBox comboKhachHang;
        private System.Windows.Forms.TextBox textSdt;
        private System.Windows.Forms.TextBox textDiaChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txt_sl;
        private System.Windows.Forms.ComboBox txt_sp;
        private System.Windows.Forms.ListView list_sp;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btn_add_sp_hd;
        private System.Windows.Forms.ColumnHeader sanpham;
        private System.Windows.Forms.ColumnHeader soluong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textIdKh;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.DateEdit dateEditNgayTao;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ColumnHeader giaBan;
        private System.Windows.Forms.ColumnHeader thanhGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textTongTien;
    }
}