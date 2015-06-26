namespace BaoCao_PTTKHT.GUI
{
    partial class FmDangNhap
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
            this.btDN = new DevComponents.DotNetBar.ButtonX();
            this.textTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btTT = new DevComponents.DotNetBar.ButtonX();
            this.btThoat = new DevComponents.DotNetBar.ButtonX();
            this.textMatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkMK = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btDN
            // 
            this.btDN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btDN.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btDN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDN.Location = new System.Drawing.Point(74, 307);
            this.btDN.Name = "btDN";
            this.btDN.Size = new System.Drawing.Size(164, 37);
            this.btDN.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btDN.TabIndex = 3;
            this.btDN.Text = "ĐĂNG NHẬP";
            this.btDN.Click += new System.EventHandler(this.btDN_Click);
            // 
            // textTen
            // 
            this.textTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTen.Location = new System.Drawing.Point(308, 134);
            this.textTen.Multiline = true;
            this.textTen.Name = "textTen";
            this.textTen.Size = new System.Drawing.Size(262, 29);
            this.textTen.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tài khoản:";
            // 
            // btTT
            // 
            this.btTT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btTT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btTT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTT.Location = new System.Drawing.Point(308, 307);
            this.btTT.Name = "btTT";
            this.btTT.Size = new System.Drawing.Size(164, 37);
            this.btTT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btTT.TabIndex = 4;
            this.btTT.Text = "XEM THÔNG TIN";
            this.btTT.Click += new System.EventHandler(this.thongtin_Click);
            // 
            // btThoat
            // 
            this.btThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(529, 307);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(164, 37);
            this.btThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "THOÁT";
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // textMatKhau
            // 
            this.textMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMatKhau.Location = new System.Drawing.Point(308, 191);
            this.textMatKhau.Multiline = true;
            this.textMatKhau.Name = "textMatKhau";
            this.textMatKhau.PasswordChar = '*';
            this.textMatKhau.Size = new System.Drawing.Size(262, 29);
            this.textMatKhau.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mật khẩu:";
            // 
            // checkMK
            // 
            this.checkMK.AutoSize = true;
            this.checkMK.Location = new System.Drawing.Point(308, 244);
            this.checkMK.Name = "checkMK";
            this.checkMK.Size = new System.Drawing.Size(127, 17);
            this.checkMK.TabIndex = 2;
            this.checkMK.Text = "   Hiển thị mật khẩu";
            this.checkMK.UseVisualStyleBackColor = true;
            this.checkMK.CheckedChanged += new System.EventHandler(this.checkMK_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(271, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 45);
            this.label2.TabIndex = 28;
            this.label2.Text = "ĐĂNG NHẬP";
            // 
            // FmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 416);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkMK);
            this.Controls.Add(this.textMatKhau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btTT);
            this.Controls.Add(this.textTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btDN);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.KeyPreview = true;
            this.Name = "FmDangNhap";
            this.Text = "ĐĂNG NHẬP";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frDangNhap_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btDN;
        private System.Windows.Forms.TextBox textTen;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.ButtonX btTT;
        private DevComponents.DotNetBar.ButtonX btThoat;
        private System.Windows.Forms.TextBox textMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkMK;
        private System.Windows.Forms.Label label2;
    }
}