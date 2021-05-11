
namespace F_QLLKMT
{
    partial class FormBaoCao
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
            this.rpHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.BaoCaoHoaDon2 = new F_QLLKMT.BaoCaoHoaDon();
            this.BaoCaoHoaDon1 = new F_QLLKMT.BaoCaoHoaDon();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rpHoaDon
            // 
            this.rpHoaDon.ActiveViewIndex = 0;
            this.rpHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpHoaDon.Location = new System.Drawing.Point(1, 2);
            this.rpHoaDon.Name = "rpHoaDon";
            this.rpHoaDon.ReportSource = this.BaoCaoHoaDon2;
            this.rpHoaDon.Size = new System.Drawing.Size(959, 644);
            this.rpHoaDon.TabIndex = 0;
            this.rpHoaDon.Load += new System.EventHandler(this.rpHoaDon_Load);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(1068, 55);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Tìm";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textKey
            // 
            this.textKey.Location = new System.Drawing.Point(966, 57);
            this.textKey.Name = "textKey";
            this.textKey.Size = new System.Drawing.Size(96, 20);
            this.textKey.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(963, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm Kiếm Khách Hàng";
            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 646);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textKey);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.rpHoaDon);
            this.Name = "FormBaoCao";
            this.Text = "FormBaoCao";
            this.Load += new System.EventHandler(this.FormBaoCao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpHoaDon;
        private BaoCaoHoaDon BaoCaoHoaDon1;
        private BaoCaoHoaDon BaoCaoHoaDon2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textKey;
        private System.Windows.Forms.Label label1;
    }
}