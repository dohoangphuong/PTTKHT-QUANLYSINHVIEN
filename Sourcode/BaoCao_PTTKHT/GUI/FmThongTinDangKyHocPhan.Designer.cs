namespace BaoCao_PTTKHT.GUI
{
    partial class FmThongTinDangKyHocPhan
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
            this.components = new System.ComponentModel.Container();
            this.tabLop = new DevComponents.DotNetBar.TabItem(this.components);
            this.slidePanel3 = new DevComponents.DotNetBar.Controls.SlidePanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXem = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.cbNamHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTenSinhVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaSinhVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabSV = new DevComponents.DotNetBar.TabItem(this.components);
            this.slidePanel1 = new DevComponents.DotNetBar.Controls.SlidePanel();
            this.slidePanel2 = new DevComponents.DotNetBar.Controls.SlidePanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slidePanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.slidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabLop
            // 
            this.tabLop.Name = "tabLop";
            this.tabLop.Text = "ĐIỂM LỚP HỌC";
            // 
            // slidePanel3
            // 
            this.slidePanel3.BackColor = System.Drawing.Color.Transparent;
            this.slidePanel3.Controls.Add(this.panel2);
            this.slidePanel3.Controls.Add(this.groupBox2);
            this.slidePanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.slidePanel3.Location = new System.Drawing.Point(0, 82);
            this.slidePanel3.Name = "slidePanel3";
            this.slidePanel3.Size = new System.Drawing.Size(1212, 233);
            this.slidePanel3.TabIndex = 8;
            this.slidePanel3.Text = "slidePanel3";
            this.slidePanel3.UsesBlockingAnimation = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXem);
            this.panel2.Controls.Add(this.buttonX3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1212, 74);
            this.panel2.TabIndex = 17;
            // 
            // btnXem
            // 
            this.btnXem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Location = new System.Drawing.Point(365, 18);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(179, 37);
            this.btnXem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXem.TabIndex = 5;
            this.btnXem.Text = "XEM";
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX3.Location = new System.Drawing.Point(774, 18);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(179, 37);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 2;
            this.buttonX3.Text = "THOÁT";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbHocKy);
            this.groupBox2.Controls.Add(this.cbNamHoc);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbTenSinhVien);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbMaSinhVien);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1212, 159);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN CẦN XEM";
            // 
            // cbHocKy
            // 
            this.cbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(771, 90);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(283, 30);
            this.cbHocKy.TabIndex = 42;
            this.cbHocKy.SelectedIndexChanged += new System.EventHandler(this.cbHocKy_SelectedIndexChanged);
            // 
            // cbNamHoc
            // 
            this.cbNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNamHoc.FormattingEnabled = true;
            this.cbNamHoc.Location = new System.Drawing.Point(771, 42);
            this.cbNamHoc.Name = "cbNamHoc";
            this.cbNamHoc.Size = new System.Drawing.Size(283, 30);
            this.cbNamHoc.TabIndex = 41;
            this.cbNamHoc.SelectedIndexChanged += new System.EventHandler(this.cbNamHoc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label1.Location = new System.Drawing.Point(665, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Học Kỳ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label4.Location = new System.Drawing.Point(158, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 21);
            this.label4.TabIndex = 39;
            this.label4.Text = "Tên sinh viên:";
            // 
            // tbTenSinhVien
            // 
            this.tbTenSinhVien.Enabled = false;
            this.tbTenSinhVien.Location = new System.Drawing.Point(290, 87);
            this.tbTenSinhVien.Multiline = true;
            this.tbTenSinhVien.Name = "tbTenSinhVien";
            this.tbTenSinhVien.ReadOnly = true;
            this.tbTenSinhVien.Size = new System.Drawing.Size(283, 33);
            this.tbTenSinhVien.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label2.Location = new System.Drawing.Point(158, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mã sinh viên:";
            // 
            // tbMaSinhVien
            // 
            this.tbMaSinhVien.Enabled = false;
            this.tbMaSinhVien.Location = new System.Drawing.Point(290, 39);
            this.tbMaSinhVien.Multiline = true;
            this.tbMaSinhVien.Name = "tbMaSinhVien";
            this.tbMaSinhVien.ReadOnly = true;
            this.tbMaSinhVien.Size = new System.Drawing.Size(283, 33);
            this.tbMaSinhVien.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label3.Location = new System.Drawing.Point(665, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Năm học:";
            // 
            // tabSV
            // 
            this.tabSV.Name = "tabSV";
            this.tabSV.Text = "ĐIỂM SINH VIÊN";
            // 
            // slidePanel1
            // 
            this.slidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.slidePanel1.Location = new System.Drawing.Point(0, 0);
            this.slidePanel1.Name = "slidePanel1";
            this.slidePanel1.Size = new System.Drawing.Size(1212, 82);
            this.slidePanel1.TabIndex = 7;
            this.slidePanel1.Text = "slidePanel1";
            this.slidePanel1.UsesBlockingAnimation = false;
            // 
            // slidePanel2
            // 
            this.slidePanel2.BackColor = System.Drawing.Color.Transparent;
            this.slidePanel2.Controls.Add(this.dataGridView2);
            this.slidePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slidePanel2.Location = new System.Drawing.Point(0, 315);
            this.slidePanel2.Name = "slidePanel2";
            this.slidePanel2.Size = new System.Drawing.Size(1212, 264);
            this.slidePanel2.TabIndex = 10;
            this.slidePanel2.Text = "slidePanel2";
            this.slidePanel2.UsesBlockingAnimation = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.MaLop,
            this.TenLop,
            this.TenMon,
            this.TenGiaoVien,
            this.SoTC,
            this.Thu,
            this.Tiet});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1212, 264);
            this.dataGridView2.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // MaLop
            // 
            this.MaLop.HeaderText = "MÃ LỚP";
            this.MaLop.Name = "MaLop";
            this.MaLop.Width = 150;
            // 
            // TenLop
            // 
            this.TenLop.HeaderText = "TÊN LỚP";
            this.TenLop.Name = "TenLop";
            // 
            // TenMon
            // 
            this.TenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenMon.HeaderText = "TÊN MÔN";
            this.TenMon.Name = "TenMon";
            // 
            // TenGiaoVien
            // 
            this.TenGiaoVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenGiaoVien.HeaderText = "TÊN GIÁO VIÊN";
            this.TenGiaoVien.Name = "TenGiaoVien";
            // 
            // SoTC
            // 
            this.SoTC.HeaderText = "SỐ TÍN CHỈ";
            this.SoTC.Name = "SoTC";
            // 
            // Thu
            // 
            this.Thu.HeaderText = "THỨ";
            this.Thu.Name = "Thu";
            // 
            // Tiet
            // 
            this.Tiet.HeaderText = "TIẾT";
            this.Tiet.Name = "Tiet";
            // 
            // FmThongTinDangKyHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 579);
            this.Controls.Add(this.slidePanel2);
            this.Controls.Add(this.slidePanel3);
            this.Controls.Add(this.slidePanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FmThongTinDangKyHocPhan";
            this.Text = "THÔNG TIN ĐĂNG KÝ HỌC PHẦN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FmThongTinDangKyHocPhan_Load);
            this.slidePanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.slidePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.TabItem tabLop;
        private DevComponents.DotNetBar.Controls.SlidePanel slidePanel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.TabItem tabSV;
        private DevComponents.DotNetBar.Controls.SlidePanel slidePanel1;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.ButtonX btnXem;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.Controls.SlidePanel slidePanel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.ComboBox cbNamHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTenSinhVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaSinhVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiet;
    }
}