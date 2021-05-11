
namespace F_QLLKMT
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_taikhoan = new System.Windows.Forms.TextBox();
            this.tb_matkhau = new System.Windows.Forms.TextBox();
            this.bt_dangnhap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_DangNhap = new System.Windows.Forms.GroupBox();
            this.tileNavCategory1 = new DevExpress.XtraBars.Navigation.TileNavCategory();
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.label4 = new System.Windows.Forms.Label();
            this.gb_DangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu: ";
            // 
            // tb_taikhoan
            // 
            this.tb_taikhoan.Location = new System.Drawing.Point(111, 55);
            this.tb_taikhoan.Name = "tb_taikhoan";
            this.tb_taikhoan.Size = new System.Drawing.Size(185, 21);
            this.tb_taikhoan.TabIndex = 2;
            // 
            // tb_matkhau
            // 
            this.tb_matkhau.BackColor = System.Drawing.SystemColors.Window;
            this.tb_matkhau.Location = new System.Drawing.Point(111, 104);
            this.tb_matkhau.Name = "tb_matkhau";
            this.tb_matkhau.Size = new System.Drawing.Size(185, 21);
            this.tb_matkhau.TabIndex = 3;
            this.tb_matkhau.UseSystemPasswordChar = true;
            // 
            // bt_dangnhap
            // 
            this.bt_dangnhap.Image = ((System.Drawing.Image)(resources.GetObject("bt_dangnhap.Image")));
            this.bt_dangnhap.Location = new System.Drawing.Point(111, 148);
            this.bt_dangnhap.Name = "bt_dangnhap";
            this.bt_dangnhap.Size = new System.Drawing.Size(75, 29);
            this.bt_dangnhap.TabIndex = 4;
            this.bt_dangnhap.Text = "Đăng Nhập";
            this.bt_dangnhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_dangnhap.UseVisualStyleBackColor = true;
            this.bt_dangnhap.Click += new System.EventHandler(this.bt_dangnhap_Click);
            this.bt_dangnhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bt_dangnhap_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tài Khoản:";
            // 
            // gb_DangNhap
            // 
            this.gb_DangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gb_DangNhap.Controls.Add(this.label3);
            this.gb_DangNhap.Controls.Add(this.bt_dangnhap);
            this.gb_DangNhap.Controls.Add(this.tb_matkhau);
            this.gb_DangNhap.Controls.Add(this.tb_taikhoan);
            this.gb_DangNhap.Controls.Add(this.label2);
            this.gb_DangNhap.Location = new System.Drawing.Point(355, 123);
            this.gb_DangNhap.Name = "gb_DangNhap";
            this.gb_DangNhap.Size = new System.Drawing.Size(374, 216);
            this.gb_DangNhap.TabIndex = 0;
            this.gb_DangNhap.TabStop = false;
            this.gb_DangNhap.Text = "Đăng Nhập";
            this.gb_DangNhap.Enter += new System.EventHandler(this.gb_DangNhap_Enter);
            // 
            // tileNavCategory1
            // 
            this.tileNavCategory1.Name = "tileNavCategory1";
            // 
            // 
            // 
            this.tileNavCategory1.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            // 
            // imageSlider1
            // 
            this.imageSlider1.AnimationTime = 1;
            this.imageSlider1.CurrentImageIndex = 0;
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images"))));
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images1"))));
            this.imageSlider1.Location = new System.Drawing.Point(81, 123);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(222, 219);
            this.imageSlider1.TabIndex = 2;
            this.imageSlider1.Text = "imageSlider1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("SVN-Gilroy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label4.Location = new System.Drawing.Point(145, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(497, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quản Lý Của Hàng Linh Kiện Máy Tính";
            // 
            // Login
            // 
            this.Appearance.BackColor = System.Drawing.Color.Ivory;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 397);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gb_DangNhap);
            this.Controls.Add(this.imageSlider1);
            this.Name = "Login";
            this.Text = "Đăng Nhập";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.gb_DangNhap.ResumeLayout(false);
            this.gb_DangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_taikhoan;
        private System.Windows.Forms.TextBox tb_matkhau;
        private System.Windows.Forms.Button bt_dangnhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gb_DangNhap;
        private DevExpress.XtraBars.Navigation.TileNavCategory tileNavCategory1;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
        private System.Windows.Forms.Label label4;
    }
}