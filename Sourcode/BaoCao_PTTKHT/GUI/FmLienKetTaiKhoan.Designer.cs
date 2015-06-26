namespace BaoCao_PTTKHT.GUI
{
    partial class FmLienKetTaiKhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataPhanQuyen = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btXoa = new DevComponents.DotNetBar.ButtonX();
            this.btThem = new DevComponents.DotNetBar.ButtonX();
            this.btThoat = new DevComponents.DotNetBar.ButtonX();
            this.slidePanel3 = new DevComponents.DotNetBar.Controls.SlidePanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTenGiangVien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTenSinhVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTaiKhoan = new System.Windows.Forms.ComboBox();
            this.cbMaGiangVien = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMSSV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.slidePanel2 = new DevComponents.DotNetBar.Controls.SlidePanel();
            this.tabSV = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabLop = new DevComponents.DotNetBar.TabItem(this.components);
            this.slidePanel1 = new DevComponents.DotNetBar.Controls.SlidePanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataPhanQuyen)).BeginInit();
            this.panel1.SuspendLayout();
            this.slidePanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.slidePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(49, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // dataPhanQuyen
            // 
            this.dataPhanQuyen.AllowUserToAddRows = false;
            this.dataPhanQuyen.AllowUserToDeleteRows = false;
            this.dataPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPhanQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPhanQuyen.Location = new System.Drawing.Point(0, 226);
            this.dataPhanQuyen.Name = "dataPhanQuyen";
            this.dataPhanQuyen.ReadOnly = true;
            this.dataPhanQuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPhanQuyen.Size = new System.Drawing.Size(835, 93);
            this.dataPhanQuyen.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.btThem);
            this.panel1.Controls.Add(this.btThoat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 65);
            this.panel1.TabIndex = 10;
            // 
            // btXoa
            // 
            this.btXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(315, 15);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(143, 37);
            this.btXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btXoa.TabIndex = 5;
            this.btXoa.Text = "XÓA";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(67, 15);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(143, 37);
            this.btThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btThem.TabIndex = 3;
            this.btThem.Text = "LIÊN KẾT";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btThoat
            // 
            this.btThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(570, 15);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(143, 37);
            this.btThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btThoat.TabIndex = 2;
            this.btThoat.Text = "THOÁT";
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // slidePanel3
            // 
            this.slidePanel3.BackColor = System.Drawing.Color.Transparent;
            this.slidePanel3.Controls.Add(this.groupBox1);
            this.slidePanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.slidePanel3.ForeColor = System.Drawing.Color.Black;
            this.slidePanel3.Location = new System.Drawing.Point(0, 0);
            this.slidePanel3.Name = "slidePanel3";
            this.slidePanel3.Size = new System.Drawing.Size(835, 161);
            this.slidePanel3.TabIndex = 9;
            this.slidePanel3.Text = "slidePanel3";
            this.slidePanel3.UsesBlockingAnimation = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTenGiangVien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbTenSinhVien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbTaiKhoan);
            this.groupBox1.Controls.Add(this.cbMaGiangVien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbMSSV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 161);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // tbTenGiangVien
            // 
            this.tbTenGiangVien.Location = new System.Drawing.Point(570, 112);
            this.tbTenGiangVien.Name = "tbTenGiangVien";
            this.tbTenGiangVien.ReadOnly = true;
            this.tbTenGiangVien.Size = new System.Drawing.Size(229, 29);
            this.tbTenGiangVien.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(442, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tên giảng viên:";
            // 
            // tbTenSinhVien
            // 
            this.tbTenSinhVien.Location = new System.Drawing.Point(570, 71);
            this.tbTenSinhVien.Name = "tbTenSinhVien";
            this.tbTenSinhVien.ReadOnly = true;
            this.tbTenSinhVien.Size = new System.Drawing.Size(229, 29);
            this.tbTenSinhVien.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(442, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên sinh viên:";
            // 
            // cbTaiKhoan
            // 
            this.cbTaiKhoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTaiKhoan.FormattingEnabled = true;
            this.cbTaiKhoan.Location = new System.Drawing.Point(176, 28);
            this.cbTaiKhoan.Name = "cbTaiKhoan";
            this.cbTaiKhoan.Size = new System.Drawing.Size(229, 30);
            this.cbTaiKhoan.TabIndex = 5;
            this.cbTaiKhoan.SelectedIndexChanged += new System.EventHandler(this.cbTaiKhoan_SelectedIndexChanged);
            // 
            // cbMaGiangVien
            // 
            this.cbMaGiangVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaGiangVien.FormattingEnabled = true;
            this.cbMaGiangVien.Location = new System.Drawing.Point(176, 112);
            this.cbMaGiangVien.Name = "cbMaGiangVien";
            this.cbMaGiangVien.Size = new System.Drawing.Size(229, 30);
            this.cbMaGiangVien.TabIndex = 4;
            this.cbMaGiangVien.SelectedIndexChanged += new System.EventHandler(this.cbMaGiangVien_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(49, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã giảng viên:";
            // 
            // cbMSSV
            // 
            this.cbMSSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMSSV.FormattingEnabled = true;
            this.cbMSSV.Location = new System.Drawing.Point(176, 71);
            this.cbMSSV.Name = "cbMSSV";
            this.cbMSSV.Size = new System.Drawing.Size(229, 30);
            this.cbMSSV.TabIndex = 2;
            this.cbMSSV.SelectedIndexChanged += new System.EventHandler(this.cbMSSV_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(49, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sinh viên:";
            // 
            // slidePanel2
            // 
            this.slidePanel2.BackColor = System.Drawing.Color.Transparent;
            this.slidePanel2.Controls.Add(this.dataPhanQuyen);
            this.slidePanel2.Controls.Add(this.panel1);
            this.slidePanel2.Controls.Add(this.slidePanel3);
            this.slidePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slidePanel2.ForeColor = System.Drawing.Color.Black;
            this.slidePanel2.Location = new System.Drawing.Point(0, 113);
            this.slidePanel2.Name = "slidePanel2";
            this.slidePanel2.Size = new System.Drawing.Size(835, 319);
            this.slidePanel2.TabIndex = 12;
            this.slidePanel2.Text = "slidePanel2";
            this.slidePanel2.UsesBlockingAnimation = false;
            // 
            // tabSV
            // 
            this.tabSV.Name = "tabSV";
            this.tabSV.Text = "ĐIỂM SINH VIÊN";
            // 
            // tabLop
            // 
            this.tabLop.Name = "tabLop";
            this.tabLop.Text = "ĐIỂM LỚP HỌC";
            // 
            // slidePanel1
            // 
            this.slidePanel1.BackColor = System.Drawing.Color.White;
            this.slidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.slidePanel1.ForeColor = System.Drawing.Color.Black;
            this.slidePanel1.Location = new System.Drawing.Point(0, 0);
            this.slidePanel1.Name = "slidePanel1";
            this.slidePanel1.Size = new System.Drawing.Size(835, 113);
            this.slidePanel1.TabIndex = 11;
            this.slidePanel1.Text = "slidePanel1";
            this.slidePanel1.UsesBlockingAnimation = false;
            // 
            // FmLienKetTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 432);
            this.Controls.Add(this.slidePanel2);
            this.Controls.Add(this.slidePanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FmLienKetTaiKhoan";
            this.Text = "LIÊN KẾT TÀI KHOẢN";
            this.Load += new System.EventHandler(this.FmLienKetTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPhanQuyen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.slidePanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.slidePanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataPhanQuyen;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX btXoa;
        private DevComponents.DotNetBar.ButtonX btThem;
        private DevComponents.DotNetBar.ButtonX btThoat;
        private DevComponents.DotNetBar.Controls.SlidePanel slidePanel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTenGiangVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTenSinhVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTaiKhoan;
        private System.Windows.Forms.ComboBox cbMaGiangVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMSSV;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.SlidePanel slidePanel2;
        private DevComponents.DotNetBar.TabItem tabSV;
        private DevComponents.DotNetBar.TabItem tabLop;
        private DevComponents.DotNetBar.Controls.SlidePanel slidePanel1;
    }
}