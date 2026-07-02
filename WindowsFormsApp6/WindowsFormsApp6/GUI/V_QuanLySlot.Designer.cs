namespace Bai_Lam_Nhom_LTHDT
{
    partial class V_QuanLySlot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_QuanLySlot));
            this.cboBacSi = new System.Windows.Forms.ComboBox();
            this.dtNgayLamViec = new System.Windows.Forms.DateTimePicker();
            this.dtGioBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtGioKetThuc = new System.Windows.Forms.DateTimePicker();
            this.numThoiLuong = new System.Windows.Forms.NumericUpDown();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.btnTaoSlot = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBacSi = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblBatDau = new System.Windows.Forms.Label();
            this.lblKetThuc = new System.Windows.Forms.Label();
            this.lblThoiLuong = new System.Windows.Forms.Label();
            this.lblPhong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numThoiLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // cboBacSi
            // 
            this.cboBacSi.FormattingEnabled = true;
            this.cboBacSi.Location = new System.Drawing.Point(270, 158);
            this.cboBacSi.Margin = new System.Windows.Forms.Padding(4);
            this.cboBacSi.Name = "cboBacSi";
            this.cboBacSi.Size = new System.Drawing.Size(292, 31);
            this.cboBacSi.TabIndex = 0;
            // 
            // dtNgayLamViec
            // 
            this.dtNgayLamViec.Location = new System.Drawing.Point(270, 252);
            this.dtNgayLamViec.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayLamViec.Name = "dtNgayLamViec";
            this.dtNgayLamViec.Size = new System.Drawing.Size(292, 30);
            this.dtNgayLamViec.TabIndex = 1;
            // 
            // dtGioBatDau
            // 
            this.dtGioBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtGioBatDau.Location = new System.Drawing.Point(270, 345);
            this.dtGioBatDau.Margin = new System.Windows.Forms.Padding(4);
            this.dtGioBatDau.Name = "dtGioBatDau";
            this.dtGioBatDau.ShowUpDown = true;
            this.dtGioBatDau.Size = new System.Drawing.Size(292, 30);
            this.dtGioBatDau.TabIndex = 2;
            // 
            // dtGioKetThuc
            // 
            this.dtGioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtGioKetThuc.Location = new System.Drawing.Point(270, 438);
            this.dtGioKetThuc.Margin = new System.Windows.Forms.Padding(4);
            this.dtGioKetThuc.Name = "dtGioKetThuc";
            this.dtGioKetThuc.ShowUpDown = true;
            this.dtGioKetThuc.Size = new System.Drawing.Size(292, 30);
            this.dtGioKetThuc.TabIndex = 3;
            // 
            // numThoiLuong
            // 
            this.numThoiLuong.Location = new System.Drawing.Point(270, 532);
            this.numThoiLuong.Margin = new System.Windows.Forms.Padding(4);
            this.numThoiLuong.Name = "numThoiLuong";
            this.numThoiLuong.Size = new System.Drawing.Size(292, 30);
            this.numThoiLuong.TabIndex = 4;
            // 
            // cboPhong
            // 
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(270, 625);
            this.cboPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(292, 31);
            this.cboPhong.TabIndex = 5;
            // 
            // btnTaoSlot
            // 
            this.btnTaoSlot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnTaoSlot.FlatAppearance.BorderSize = 0;
            this.btnTaoSlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoSlot.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoSlot.ForeColor = System.Drawing.Color.White;
            this.btnTaoSlot.Location = new System.Drawing.Point(270, 719);
            this.btnTaoSlot.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoSlot.Name = "btnTaoSlot";
            this.btnTaoSlot.Size = new System.Drawing.Size(202, 69);
            this.btnTaoSlot.TabIndex = 6;
            this.btnTaoSlot.Text = "Tạo slot";
            this.btnTaoSlot.UseVisualStyleBackColor = false;
            this.btnTaoSlot.Click += new System.EventHandler(this.btnTaoSlot_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(68, 50);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(338, 65);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "1.Tạo slot khám";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBacSi
            // 
            this.lblBacSi.Location = new System.Drawing.Point(89, 160);
            this.lblBacSi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBacSi.Name = "lblBacSi";
            this.lblBacSi.Size = new System.Drawing.Size(146, 43);
            this.lblBacSi.TabIndex = 8;
            this.lblBacSi.Text = "Bác sĩ:";
            this.lblBacSi.Click += new System.EventHandler(this.lblBacSi_Click);
            // 
            // lblNgay
            // 
            this.lblNgay.Location = new System.Drawing.Point(90, 252);
            this.lblNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(146, 43);
            this.lblNgay.TabIndex = 9;
            this.lblNgay.Text = "Ngày làm việc:";
            this.lblNgay.Click += new System.EventHandler(this.lblNgay_Click);
            // 
            // lblBatDau
            // 
            this.lblBatDau.Location = new System.Drawing.Point(90, 345);
            this.lblBatDau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBatDau.Name = "lblBatDau";
            this.lblBatDau.Size = new System.Drawing.Size(146, 43);
            this.lblBatDau.TabIndex = 10;
            this.lblBatDau.Text = "Giờ bắt đầu:";
            this.lblBatDau.Click += new System.EventHandler(this.lblBatDau_Click);
            // 
            // lblKetThuc
            // 
            this.lblKetThuc.Location = new System.Drawing.Point(90, 438);
            this.lblKetThuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetThuc.Name = "lblKetThuc";
            this.lblKetThuc.Size = new System.Drawing.Size(146, 43);
            this.lblKetThuc.TabIndex = 11;
            this.lblKetThuc.Text = "Giờ kết thúc:";
            this.lblKetThuc.Click += new System.EventHandler(this.lblKetThuc_Click);
            // 
            // lblThoiLuong
            // 
            this.lblThoiLuong.Location = new System.Drawing.Point(90, 532);
            this.lblThoiLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThoiLuong.Name = "lblThoiLuong";
            this.lblThoiLuong.Size = new System.Drawing.Size(146, 43);
            this.lblThoiLuong.TabIndex = 12;
            this.lblThoiLuong.Text = "Thời lượng(phút):";
            this.lblThoiLuong.Click += new System.EventHandler(this.lblThoiLuong_Click);
            // 
            // lblPhong
            // 
            this.lblPhong.Location = new System.Drawing.Point(89, 625);
            this.lblPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(146, 43);
            this.lblPhong.TabIndex = 13;
            this.lblPhong.Text = "Phòng khám:";
            this.lblPhong.Click += new System.EventHandler(this.lblPhong_Click);
            // 
            // FrmQuanLySlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(882, 833);
            this.Controls.Add(this.lblPhong);
            this.Controls.Add(this.lblThoiLuong);
            this.Controls.Add(this.lblKetThuc);
            this.Controls.Add(this.lblBatDau);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.lblBacSi);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnTaoSlot);
            this.Controls.Add(this.cboPhong);
            this.Controls.Add(this.numThoiLuong);
            this.Controls.Add(this.dtGioKetThuc);
            this.Controls.Add(this.dtGioBatDau);
            this.Controls.Add(this.dtNgayLamViec);
            this.Controls.Add(this.cboBacSi);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1000, 700);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmQuanLySlot";
            this.Text = "QUẢN LÝ KHUNG GIỜ & PHÒNG KHÁM";
            this.Load += new System.EventHandler(this.FrmQuanLySlot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numThoiLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBacSi;
        private System.Windows.Forms.DateTimePicker dtNgayLamViec;
        private System.Windows.Forms.DateTimePicker dtGioBatDau;
        private System.Windows.Forms.DateTimePicker dtGioKetThuc;
        private System.Windows.Forms.NumericUpDown numThoiLuong;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.Button btnTaoSlot;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBacSi;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblBatDau;
        private System.Windows.Forms.Label lblKetThuc;
        private System.Windows.Forms.Label lblThoiLuong;
        private System.Windows.Forms.Label lblPhong;
    }
}

