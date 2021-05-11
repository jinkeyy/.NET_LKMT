
namespace F_QLLKMT
{
    partial class FormAddSp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddSp));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericGiaNhap = new System.Windows.Forms.NumericUpDown();
            this.numericGiaBan = new System.Windows.Forms.NumericUpDown();
            this.numericSl = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dateNgayTao = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboNhanVien = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textNsx = new System.Windows.Forms.TextBox();
            this.textDanhMuc = new System.Windows.Forms.TextBox();
            this.textDonVi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboTenSp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGiaNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSl)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericGiaNhap);
            this.groupBox1.Controls.Add(this.numericGiaBan);
            this.groupBox1.Controls.Add(this.numericSl);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.dateNgayTao);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboNhanVien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textNsx);
            this.groupBox1.Controls.Add(this.textDanhMuc);
            this.groupBox1.Controls.Add(this.textDonVi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboTenSp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 625);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu Nhập";
            // 
            // numericGiaNhap
            // 
            this.numericGiaNhap.Location = new System.Drawing.Point(280, 290);
            this.numericGiaNhap.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericGiaNhap.Name = "numericGiaNhap";
            this.numericGiaNhap.Size = new System.Drawing.Size(120, 21);
            this.numericGiaNhap.TabIndex = 23;
            // 
            // numericGiaBan
            // 
            this.numericGiaBan.Location = new System.Drawing.Point(280, 326);
            this.numericGiaBan.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericGiaBan.Name = "numericGiaBan";
            this.numericGiaBan.Size = new System.Drawing.Size(120, 21);
            this.numericGiaBan.TabIndex = 22;
            // 
            // numericSl
            // 
            this.numericSl.Location = new System.Drawing.Point(280, 251);
            this.numericSl.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericSl.Name = "numericSl";
            this.numericSl.Size = new System.Drawing.Size(120, 21);
            this.numericSl.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(205, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Giá bán: ";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(484, 417);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(23, 23);
            this.simpleButton2.TabIndex = 18;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(280, 417);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 17;
            this.simpleButton1.Text = "Xác Nhận";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dateNgayTao
            // 
            this.dateNgayTao.Location = new System.Drawing.Point(280, 362);
            this.dateNgayTao.Name = "dateNgayTao";
            this.dateNgayTao.Size = new System.Drawing.Size(227, 21);
            this.dateNgayTao.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Giá Nhập: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ngày Tạo: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Số Lượng:";
            // 
            // comboNhanVien
            // 
            this.comboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNhanVien.FormattingEnabled = true;
            this.comboNhanVien.Location = new System.Drawing.Point(280, 210);
            this.comboNhanVien.Name = "comboNhanVien";
            this.comboNhanVien.Size = new System.Drawing.Size(227, 21);
            this.comboNhanVien.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nhân Viên Tạo: ";
            // 
            // textNsx
            // 
            this.textNsx.Location = new System.Drawing.Point(280, 132);
            this.textNsx.Name = "textNsx";
            this.textNsx.Size = new System.Drawing.Size(227, 21);
            this.textNsx.TabIndex = 7;
            // 
            // textDanhMuc
            // 
            this.textDanhMuc.Location = new System.Drawing.Point(280, 170);
            this.textDanhMuc.Name = "textDanhMuc";
            this.textDanhMuc.Size = new System.Drawing.Size(227, 21);
            this.textDanhMuc.TabIndex = 6;
            // 
            // textDonVi
            // 
            this.textDonVi.Location = new System.Drawing.Point(280, 91);
            this.textDonVi.Name = "textDonVi";
            this.textDonVi.Size = new System.Drawing.Size(227, 21);
            this.textDonVi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhà Sản Xuất:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Danh Mục: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đơn vị: ";
            // 
            // comboTenSp
            // 
            this.comboTenSp.FormattingEnabled = true;
            this.comboTenSp.Location = new System.Drawing.Point(280, 54);
            this.comboTenSp.Name = "comboTenSp";
            this.comboTenSp.Size = new System.Drawing.Size(227, 21);
            this.comboTenSp.TabIndex = 1;
            this.comboTenSp.SelectedValueChanged += new System.EventHandler(this.comboTenSp_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sản Phẩm: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormAddSp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 649);
            this.Controls.Add(this.groupBox1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FormAddSp.IconOptions.LargeImage")));
            this.Name = "FormAddSp";
            this.Text = "Sản Phẩm";
            this.Load += new System.EventHandler(this.FormAddSp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGiaNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboTenSp;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DateTimePicker dateNgayTao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNsx;
        private System.Windows.Forms.TextBox textDanhMuc;
        private System.Windows.Forms.TextBox textDonVi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericSl;
        private System.Windows.Forms.NumericUpDown numericGiaNhap;
        private System.Windows.Forms.NumericUpDown numericGiaBan;
    }
}