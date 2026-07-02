namespace WindowsFormsApp6
{
    partial class Main_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_DangNhap));
            this.lblDangNhapHeThong = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHeThongQuanLyPhongKham = new System.Windows.Forms.Label();
            this.chkHienMatKhau = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDangNhapHeThong
            // 
            this.lblDangNhapHeThong.AutoSize = true;
            this.lblDangNhapHeThong.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDangNhapHeThong.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDangNhapHeThong.Location = new System.Drawing.Point(181, 37);
            this.lblDangNhapHeThong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDangNhapHeThong.Name = "lblDangNhapHeThong";
            this.lblDangNhapHeThong.Size = new System.Drawing.Size(437, 31);
            this.lblDangNhapHeThong.TabIndex = 0;
            this.lblDangNhapHeThong.Text = "Chào mừng bạn đến với Medical Center";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(23, 239);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(375, 30);
            this.txtTaiKhoan.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhau.Location = new System.Drawing.Point(23, 330);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(375, 30);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Location = new System.Drawing.Point(247, 372);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(151, 61);
            this.btnDangKy.TabIndex = 4;
            this.btnDangKy.Text = "Đăng ký ";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.IndianRed;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(467, 372);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(151, 61);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Location = new System.Drawing.Point(19, 206);
            this.lblTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(108, 28);
            this.lblTaiKhoan.TabIndex = 7;
            this.lblTaiKhoan.Text = " Tài khoản :";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(27, 297);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(108, 28);
            this.lblMatKhau.TabIndex = 8;
            this.lblMatKhau.Text = "Mật  khẩu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(320, 476);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "© 2026 Phòng khám Medical Center";
            // 
            // lblHeThongQuanLyPhongKham
            // 
            this.lblHeThongQuanLyPhongKham.AutoSize = true;
            this.lblHeThongQuanLyPhongKham.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHeThongQuanLyPhongKham.ForeColor = System.Drawing.Color.Gray;
            this.lblHeThongQuanLyPhongKham.Location = new System.Drawing.Point(183, 135);
            this.lblHeThongQuanLyPhongKham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeThongQuanLyPhongKham.Name = "lblHeThongQuanLyPhongKham";
            this.lblHeThongQuanLyPhongKham.Size = new System.Drawing.Size(209, 40);
            this.lblHeThongQuanLyPhongKham.TabIndex = 10;
            this.lblHeThongQuanLyPhongKham.Text = "Hệ thống quản lý Lịch hẹn \r\ncho hệ thống các phòng khám\r\n";
            // 
            // chkHienMatKhau
            // 
            this.chkHienMatKhau.AutoSize = true;
            this.chkHienMatKhau.Location = new System.Drawing.Point(430, 330);
            this.chkHienMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkHienMatKhau.Name = "chkHienMatKhau";
            this.chkHienMatKhau.Size = new System.Drawing.Size(188, 32);
            this.chkHienMatKhau.TabIndex = 11;
            this.chkHienMatKhau.Text = "Hiển thị mật khẩu";
            this.chkHienMatKhau.UseVisualStyleBackColor = true;
            this.chkHienMatKhau.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(32, 372);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(151, 61);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng nhập ";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 229);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(257, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "- Đem đến giải pháp tốt nhất-";
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(663, 517);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkHienMatKhau);
            this.Controls.Add(this.lblHeThongQuanLyPhongKham);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblTaiKhoan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.lblDangNhapHeThong);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDangNhapHeThong;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHeThongQuanLyPhongKham;
        private System.Windows.Forms.CheckBox chkHienMatKhau;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}