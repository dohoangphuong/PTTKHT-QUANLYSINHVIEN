namespace BaoCao_PTTKHT.GUI
{
    partial class FmQuanLyDangKyHocPhan
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
            this.slidePanel2 = new DevComponents.DotNetBar.Controls.SlidePanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabSV = new DevComponents.DotNetBar.TabItem(this.components);
            this.slidePanel3 = new DevComponents.DotNetBar.Controls.SlidePanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX6 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.slidePanel1 = new DevComponents.DotNetBar.Controls.SlidePanel();
            this.tabLop = new DevComponents.DotNetBar.TabItem(this.components);
            this.Chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.slidePanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // slidePanel2
            // 
            this.slidePanel2.BackColor = System.Drawing.Color.Transparent;
            this.slidePanel2.Controls.Add(this.dataGridView2);
            this.slidePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slidePanel2.Location = new System.Drawing.Point(0, 262);
            this.slidePanel2.Name = "slidePanel2";
            this.slidePanel2.Size = new System.Drawing.Size(1362, 238);
            this.slidePanel2.TabIndex = 6;
            this.slidePanel2.Text = "slidePanel2";
            this.slidePanel2.UsesBlockingAnimation = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chon,
            this.dataGridViewTextBoxColumn1,
            this.MaLop,
            this.TenMon,
            this.SoTC,
            this.Thu,
            this.Ca,
            this.PhongHoc,
            this.ToiDa,
            this.DaDK});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1362, 238);
            this.dataGridView2.TabIndex = 10;
            // 
            // tabSV
            // 
            this.tabSV.Name = "tabSV";
            this.tabSV.Text = "ĐIỂM SINH VIÊN";
            // 
            // slidePanel3
            // 
            this.slidePanel3.BackColor = System.Drawing.Color.Transparent;
            this.slidePanel3.Controls.Add(this.panel2);
            this.slidePanel3.Controls.Add(this.groupBox2);
            this.slidePanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.slidePanel3.Location = new System.Drawing.Point(0, 66);
            this.slidePanel3.Name = "slidePanel3";
            this.slidePanel3.Size = new System.Drawing.Size(1362, 196);
            this.slidePanel3.TabIndex = 5;
            this.slidePanel3.Text = "slidePanel3";
            this.slidePanel3.UsesBlockingAnimation = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonX1);
            this.panel2.Controls.Add(this.buttonX6);
            this.panel2.Controls.Add(this.buttonX3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1362, 71);
            this.panel2.TabIndex = 7;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(557, 18);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(179, 37);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 6;
            this.buttonX1.Text = "XEM THÔNG TIN";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX6
            // 
            this.buttonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX6.Location = new System.Drawing.Point(237, 18);
            this.buttonX6.Name = "buttonX6";
            this.buttonX6.Size = new System.Drawing.Size(179, 37);
            this.buttonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX6.TabIndex = 5;
            this.buttonX6.Text = "ĐĂNG KÝ";
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX3.Location = new System.Drawing.Point(866, 18);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(179, 37);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 2;
            this.buttonX3.Text = "THOÁT";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1362, 196);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ĐĂNG KÝ NHANH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label3.Location = new System.Drawing.Point(108, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mã môn:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(234, 22);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(613, 97);
            this.textBox2.TabIndex = 1;
            // 
            // slidePanel1
            // 
            this.slidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.slidePanel1.Location = new System.Drawing.Point(0, 0);
            this.slidePanel1.Name = "slidePanel1";
            this.slidePanel1.Size = new System.Drawing.Size(1362, 66);
            this.slidePanel1.TabIndex = 4;
            this.slidePanel1.Text = "slidePanel1";
            this.slidePanel1.UsesBlockingAnimation = false;
            // 
            // tabLop
            // 
            this.tabLop.Name = "tabLop";
            this.tabLop.Text = "ĐIỂM LỚP HỌC";
            // 
            // Chon
            // 
            this.Chon.HeaderText = "CHỌN";
            this.Chon.Name = "Chon";
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
            // TenMon
            // 
            this.TenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenMon.HeaderText = "TÊN MÔN";
            this.TenMon.Name = "TenMon";
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
            // Ca
            // 
            this.Ca.HeaderText = "CA HỌC";
            this.Ca.Name = "Ca";
            // 
            // PhongHoc
            // 
            this.PhongHoc.HeaderText = "PHÒNG HỌC";
            this.PhongHoc.Name = "PhongHoc";
            // 
            // ToiDa
            // 
            this.ToiDa.HeaderText = "TỐI ĐA";
            this.ToiDa.Name = "ToiDa";
            // 
            // DaDK
            // 
            this.DaDK.HeaderText = "ĐÃ ĐĂNG KÝ";
            this.DaDK.Name = "DaDK";
            // 
            // FmQuanLyDangKyHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 500);
            this.Controls.Add(this.slidePanel2);
            this.Controls.Add(this.slidePanel3);
            this.Controls.Add(this.slidePanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FmQuanLyDangKyHocPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ ĐĂNG KÝ HỌC PHẦN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.slidePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.slidePanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.SlidePanel slidePanel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DevComponents.DotNetBar.TabItem tabSV;
        private DevComponents.DotNetBar.Controls.SlidePanel slidePanel3;
        private DevComponents.DotNetBar.Controls.SlidePanel slidePanel1;
        private DevComponents.DotNetBar.TabItem tabLop;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX6;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ca;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhongHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToiDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaDK;
    }
}