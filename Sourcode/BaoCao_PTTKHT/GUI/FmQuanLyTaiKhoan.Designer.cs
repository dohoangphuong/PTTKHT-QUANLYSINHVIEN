namespace BaoCao_PTTKHT.GUI
{
    partial class FmQuanLyTaiKhoan
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
            this.slidePanel1 = new DevComponents.DotNetBar.Controls.SlidePanel();
            this.tabLop = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabSV = new DevComponents.DotNetBar.TabItem(this.components);
            this.slidePanel2 = new DevComponents.DotNetBar.Controls.SlidePanel();
            this.dataPhanQuyen = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSua = new DevComponents.DotNetBar.ButtonX();
            this.btLuu = new DevComponents.DotNetBar.ButtonX();
            this.btXoa = new DevComponents.DotNetBar.ButtonX();
            this.btThem = new DevComponents.DotNetBar.ButtonX();
            this.btThoat = new DevComponents.DotNetBar.ButtonX();
            this.slidePanel3 = new DevComponents.DotNetBar.Controls.SlidePanel();
            this.groupTK = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkMK = new System.Windows.Forms.CheckBox();
            this.textMK2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textTK = new System.Windows.Forms.TextBox();
            this.textMK1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLienKet = new System.Windows.Forms.Button();
            this.slidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPhanQuyen)).BeginInit();
            this.panel1.SuspendLayout();
            this.slidePanel3.SuspendLayout();
            this.groupTK.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // slidePanel1
            // 
            this.slidePanel1.BackColor = System.Drawing.Color.White;
            this.slidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.slidePanel1.ForeColor = System.Drawing.Color.Black;
            this.slidePanel1.Location = new System.Drawing.Point(0, 0);
            this.slidePanel1.Name = "slidePanel1";
            this.slidePanel1.Size = new System.Drawing.Size(1219, 113);
            this.slidePanel1.TabIndex = 7;
            this.slidePanel1.Text = "slidePanel1";
            this.slidePanel1.UsesBlockingAnimation = false;
            // 
            // tabLop
            // 
            this.tabLop.Name = "tabLop";
            this.tabLop.Text = "ĐIỂM LỚP HỌC";
            // 
            // tabSV
            // 
            this.tabSV.Name = "tabSV";
            this.tabSV.Text = "ĐIỂM SINH VIÊN";
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
            this.slidePanel2.Size = new System.Drawing.Size(1219, 420);
            this.slidePanel2.TabIndex = 10;
            this.slidePanel2.Text = "slidePanel2";
            this.slidePanel2.UsesBlockingAnimation = false;
            // 
            // dataPhanQuyen
            // 
            this.dataPhanQuyen.AllowUserToAddRows = false;
            this.dataPhanQuyen.AllowUserToDeleteRows = false;
            this.dataPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPhanQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPhanQuyen.Location = new System.Drawing.Point(0, 327);
            this.dataPhanQuyen.Name = "dataPhanQuyen";
            this.dataPhanQuyen.ReadOnly = true;
            this.dataPhanQuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPhanQuyen.Size = new System.Drawing.Size(1219, 93);
            this.dataPhanQuyen.TabIndex = 11;
            this.dataPhanQuyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btSua);
            this.panel1.Controls.Add(this.btLuu);
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.btThem);
            this.panel1.Controls.Add(this.btThoat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 65);
            this.panel1.TabIndex = 10;
            // 
            // btSua
            // 
            this.btSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(303, 15);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(143, 37);
            this.btSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btSua.TabIndex = 7;
            this.btSua.Text = "SỬA";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btLuu
            // 
            this.btLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btLuu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Location = new System.Drawing.Point(823, 15);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(143, 37);
            this.btLuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btLuu.TabIndex = 6;
            this.btLuu.Text = "LƯU";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btXoa
            // 
            this.btXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(569, 15);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(143, 37);
            this.btXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btXoa.TabIndex = 5;
            this.btXoa.Text = "XÓA";
            this.btXoa.Click += new System.EventHandler(this.BtXoa_Click);
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
            this.btThem.Text = "THÊM";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btThoat
            // 
            this.btThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(1060, 15);
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
            this.slidePanel3.Controls.Add(this.groupTK);
            this.slidePanel3.Controls.Add(this.groupBox1);
            this.slidePanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.slidePanel3.ForeColor = System.Drawing.Color.Black;
            this.slidePanel3.Location = new System.Drawing.Point(0, 0);
            this.slidePanel3.Name = "slidePanel3";
            this.slidePanel3.Size = new System.Drawing.Size(1219, 262);
            this.slidePanel3.TabIndex = 9;
            this.slidePanel3.Text = "slidePanel3";
            this.slidePanel3.UsesBlockingAnimation = false;
            // 
            // groupTK
            // 
            this.groupTK.Controls.Add(this.btnLienKet);
            this.groupTK.Controls.Add(this.label4);
            this.groupTK.Controls.Add(this.combo);
            this.groupTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupTK.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTK.ForeColor = System.Drawing.Color.Black;
            this.groupTK.Location = new System.Drawing.Point(709, 0);
            this.groupTK.Name = "groupTK";
            this.groupTK.Size = new System.Drawing.Size(510, 262);
            this.groupTK.TabIndex = 8;
            this.groupTK.TabStop = false;
            this.groupTK.Text = "LOẠI TÀI KHOẢN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(79, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại tài khoản:";
            // 
            // combo
            // 
            this.combo.DisplayMember = "1";
            this.combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo.FormattingEnabled = true;
            this.combo.ItemHeight = 22;
            this.combo.Items.AddRange(new object[] {
            "Quản trị",
            "Sinh viên",
            "Giáo viên",
            "Cán bộ"});
            this.combo.Location = new System.Drawing.Point(227, 75);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(204, 30);
            this.combo.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textTen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkMK);
            this.groupBox1.Controls.Add(this.textMK2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textTK);
            this.groupBox1.Controls.Add(this.textMK1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 262);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // textTen
            // 
            this.textTen.BackColor = System.Drawing.Color.White;
            this.textTen.ForeColor = System.Drawing.Color.Black;
            this.textTen.Location = new System.Drawing.Point(273, 200);
            this.textTen.Multiline = true;
            this.textTen.Name = "textTen";
            this.textTen.Size = new System.Drawing.Size(229, 36);
            this.textTen.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(90, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tên người dùng:";
            // 
            // checkMK
            // 
            this.checkMK.AutoSize = true;
            this.checkMK.ForeColor = System.Drawing.Color.Black;
            this.checkMK.Location = new System.Drawing.Point(273, 159);
            this.checkMK.Name = "checkMK";
            this.checkMK.Size = new System.Drawing.Size(164, 26);
            this.checkMK.TabIndex = 3;
            this.checkMK.Text = "   Hiện mật khẩu";
            this.checkMK.UseVisualStyleBackColor = true;
            this.checkMK.CheckedChanged += new System.EventHandler(this.checkMK_CheckedChanged);
            // 
            // textMK2
            // 
            this.textMK2.BackColor = System.Drawing.Color.White;
            this.textMK2.ForeColor = System.Drawing.Color.Black;
            this.textMK2.Location = new System.Drawing.Point(273, 117);
            this.textMK2.Multiline = true;
            this.textMK2.Name = "textMK2";
            this.textMK2.PasswordChar = '*';
            this.textMK2.Size = new System.Drawing.Size(229, 36);
            this.textMK2.TabIndex = 2;
            this.textMK2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(90, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "Xác nhận mật khẩu:";
            // 
            // textTK
            // 
            this.textTK.BackColor = System.Drawing.Color.White;
            this.textTK.ForeColor = System.Drawing.Color.Black;
            this.textTK.Location = new System.Drawing.Point(273, 27);
            this.textTK.Multiline = true;
            this.textTK.Name = "textTK";
            this.textTK.Size = new System.Drawing.Size(229, 36);
            this.textTK.TabIndex = 0;
            this.textTK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textMK1
            // 
            this.textMK1.BackColor = System.Drawing.Color.White;
            this.textMK1.ForeColor = System.Drawing.Color.Black;
            this.textMK1.Location = new System.Drawing.Point(273, 75);
            this.textMK1.Multiline = true;
            this.textMK1.Name = "textMK1";
            this.textMK1.PasswordChar = '*';
            this.textMK1.Size = new System.Drawing.Size(229, 36);
            this.textMK1.TabIndex = 1;
            this.textMK1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(90, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(90, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // btnLienKet
            // 
            this.btnLienKet.Location = new System.Drawing.Point(161, 149);
            this.btnLienKet.Name = "btnLienKet";
            this.btnLienKet.Size = new System.Drawing.Size(189, 45);
            this.btnLienKet.TabIndex = 6;
            this.btnLienKet.Text = "Liên kết tài khoản";
            this.btnLienKet.UseVisualStyleBackColor = true;
            this.btnLienKet.Click += new System.EventHandler(this.btnLienKet_Click);
            // 
            // FmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 533);
            this.Controls.Add(this.slidePanel2);
            this.Controls.Add(this.slidePanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FmQuanLyTaiKhoan";
            this.Text = "MetroForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.slidePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPhanQuyen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.slidePanel3.ResumeLayout(false);
            this.groupTK.ResumeLayout(false);
            this.groupTK.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.SlidePanel slidePanel1;
        private DevComponents.DotNetBar.TabItem tabLop;
        private DevComponents.DotNetBar.TabItem tabSV;
        private DevComponents.DotNetBar.Controls.SlidePanel slidePanel2;
        private DevComponents.DotNetBar.Controls.SlidePanel slidePanel3;
        private System.Windows.Forms.GroupBox groupTK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textMK2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textTK;
        private System.Windows.Forms.TextBox textMK1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX btLuu;
        private DevComponents.DotNetBar.ButtonX btXoa;
        private DevComponents.DotNetBar.ButtonX btThem;
        private DevComponents.DotNetBar.ButtonX btThoat;
        private System.Windows.Forms.CheckBox checkMK;
        private DevComponents.DotNetBar.ButtonX btSua;
        private System.Windows.Forms.TextBox textTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataPhanQuyen;
        private System.Windows.Forms.Button btnLienKet;
    }
}