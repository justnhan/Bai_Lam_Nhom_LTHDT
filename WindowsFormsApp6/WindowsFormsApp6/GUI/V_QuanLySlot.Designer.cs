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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblPhong = new System.Windows.Forms.Label();
            this.lblThoiLuong = new System.Windows.Forms.Label();
            this.lblKetThuc = new System.Windows.Forms.Label();
            this.lblBatDau = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblBacSi = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnTaoSlot = new System.Windows.Forms.Button();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.numThoiLuong = new System.Windows.Forms.NumericUpDown();
            this.dtGioKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtGioBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtNgayLamViec = new System.Windows.Forms.DateTimePicker();
            this.cboBacSi = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThoiLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.button1);
            this.pnlMain.Controls.Add(this.lblPhong);
            this.pnlMain.Controls.Add(this.lblThoiLuong);
            this.pnlMain.Controls.Add(this.lblKetThuc);
            this.pnlMain.Controls.Add(this.lblBatDau);
            this.pnlMain.Controls.Add(this.lblNgay);
            this.pnlMain.Controls.Add(this.lblBacSi);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Controls.Add(this.btnTaoSlot);
            this.pnlMain.Controls.Add(this.cboPhong);
            this.pnlMain.Controls.Add(this.numThoiLuong);
            this.pnlMain.Controls.Add(this.dtGioKetThuc);
            this.pnlMain.Controls.Add(this.dtGioBatDau);
            this.pnlMain.Controls.Add(this.dtNgayLamViec);
            this.pnlMain.Controls.Add(this.cboBacSi);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 550);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // lblPhong
            // 
            this.lblPhong.Location = new System.Drawing.Point(163, 276);
            this.lblPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(120, 30);
            this.lblPhong.TabIndex = 27;
            this.lblPhong.Text = "Phòng khám:";
            this.lblPhong.Click += new System.EventHandler(this.lblPhong_Click_1);
            // 
            // lblThoiLuong
            // 
            this.lblThoiLuong.Location = new System.Drawing.Point(163, 223);
            this.lblThoiLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThoiLuong.Name = "lblThoiLuong";
            this.lblThoiLuong.Size = new System.Drawing.Size(150, 30);
            this.lblThoiLuong.TabIndex = 26;
            this.lblThoiLuong.Text = "Thời lượng(phút):";
            this.lblThoiLuong.Click += new System.EventHandler(this.lblThoiLuong_Click_1);
            // 
            // lblKetThuc
            // 
            this.lblKetThuc.Location = new System.Drawing.Point(163, 169);
            this.lblKetThuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetThuc.Name = "lblKetThuc";
            this.lblKetThuc.Size = new System.Drawing.Size(120, 30);
            this.lblKetThuc.TabIndex = 25;
            this.lblKetThuc.Text = "Giờ kết thúc:";
            this.lblKetThuc.Click += new System.EventHandler(this.lblKetThuc_Click_1);
            // 
            // lblBatDau
            // 
            this.lblBatDau.Location = new System.Drawing.Point(163, 120);
            this.lblBatDau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBatDau.Name = "lblBatDau";
            this.lblBatDau.Size = new System.Drawing.Size(120, 30);
            this.lblBatDau.TabIndex = 24;
            this.lblBatDau.Text = "Giờ bắt đầu:";
            this.lblBatDau.Click += new System.EventHandler(this.lblBatDau_Click_1);
            // 
            // lblNgay
            // 
            this.lblNgay.Location = new System.Drawing.Point(163, 71);
            this.lblNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(120, 30);
            this.lblNgay.TabIndex = 23;
            this.lblNgay.Text = "Ngày làm việc:";
            this.lblNgay.Click += new System.EventHandler(this.lblNgay_Click_1);
            // 
            // lblBacSi
            // 
            this.lblBacSi.Location = new System.Drawing.Point(163, 28);
            this.lblBacSi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBacSi.Name = "lblBacSi";
            this.lblBacSi.Size = new System.Drawing.Size(120, 30);
            this.lblBacSi.TabIndex = 22;
            this.lblBacSi.Text = "Bác sĩ:";
            this.lblBacSi.Click += new System.EventHandler(this.lblBacSi_Click_1);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(142, -94);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 30);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "1.Tạo slot khám";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnTaoSlot
            // 
            this.btnTaoSlot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnTaoSlot.FlatAppearance.BorderSize = 0;
            this.btnTaoSlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoSlot.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoSlot.ForeColor = System.Drawing.Color.White;
            this.btnTaoSlot.Location = new System.Drawing.Point(344, 358);
            this.btnTaoSlot.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoSlot.Name = "btnTaoSlot";
            this.btnTaoSlot.Size = new System.Drawing.Size(120, 53);
            this.btnTaoSlot.TabIndex = 20;
            this.btnTaoSlot.Text = "Tạo slot";
            this.btnTaoSlot.UseVisualStyleBackColor = false;
            this.btnTaoSlot.Click += new System.EventHandler(this.btnTaoSlot_Click_1);
            // 
            // cboPhong
            // 
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(344, 276);
            this.cboPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(120, 31);
            this.cboPhong.TabIndex = 19;
            this.cboPhong.SelectedIndexChanged += new System.EventHandler(this.cboPhong_SelectedIndexChanged);
            // 
            // numThoiLuong
            // 
            this.numThoiLuong.Location = new System.Drawing.Point(344, 221);
            this.numThoiLuong.Margin = new System.Windows.Forms.Padding(4);
            this.numThoiLuong.Name = "numThoiLuong";
            this.numThoiLuong.Size = new System.Drawing.Size(120, 30);
            this.numThoiLuong.TabIndex = 18;
            this.numThoiLuong.ValueChanged += new System.EventHandler(this.numThoiLuong_ValueChanged);
            // 
            // dtGioKetThuc
            // 
            this.dtGioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtGioKetThuc.Location = new System.Drawing.Point(344, 169);
            this.dtGioKetThuc.Margin = new System.Windows.Forms.Padding(4);
            this.dtGioKetThuc.Name = "dtGioKetThuc";
            this.dtGioKetThuc.ShowUpDown = true;
            this.dtGioKetThuc.Size = new System.Drawing.Size(120, 30);
            this.dtGioKetThuc.TabIndex = 17;
            this.dtGioKetThuc.ValueChanged += new System.EventHandler(this.dtGioKetThuc_ValueChanged);
            // 
            // dtGioBatDau
            // 
            this.dtGioBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtGioBatDau.Location = new System.Drawing.Point(344, 120);
            this.dtGioBatDau.Margin = new System.Windows.Forms.Padding(4);
            this.dtGioBatDau.Name = "dtGioBatDau";
            this.dtGioBatDau.ShowUpDown = true;
            this.dtGioBatDau.Size = new System.Drawing.Size(120, 30);
            this.dtGioBatDau.TabIndex = 16;
            this.dtGioBatDau.ValueChanged += new System.EventHandler(this.dtGioBatDau_ValueChanged);
            // 
            // dtNgayLamViec
            // 
            this.dtNgayLamViec.Location = new System.Drawing.Point(344, 71);
            this.dtNgayLamViec.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayLamViec.Name = "dtNgayLamViec";
            this.dtNgayLamViec.Size = new System.Drawing.Size(272, 30);
            this.dtNgayLamViec.TabIndex = 15;
            this.dtNgayLamViec.ValueChanged += new System.EventHandler(this.dtNgayLamViec_ValueChanged);
            // 
            // cboBacSi
            // 
            this.cboBacSi.FormattingEnabled = true;
            this.cboBacSi.Location = new System.Drawing.Point(344, 25);
            this.cboBacSi.Margin = new System.Windows.Forms.Padding(4);
            this.cboBacSi.Name = "cboBacSi";
            this.cboBacSi.Size = new System.Drawing.Size(120, 31);
            this.cboBacSi.TabIndex = 14;
            this.cboBacSi.SelectedIndexChanged += new System.EventHandler(this.cboBacSi_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // V_QuanLySlot
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1000, 700);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "V_QuanLySlot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QUẢN LÝ KHUNG GIỜ & PHÒNG KHÁM";
            this.Load += new System.EventHandler(this.FrmQuanLySlot_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numThoiLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label lblThoiLuong;
        private System.Windows.Forms.Label lblKetThuc;
        private System.Windows.Forms.Label lblBatDau;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblBacSi;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnTaoSlot;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.NumericUpDown numThoiLuong;
        private System.Windows.Forms.DateTimePicker dtGioKetThuc;
        private System.Windows.Forms.DateTimePicker dtGioBatDau;
        private System.Windows.Forms.DateTimePicker dtNgayLamViec;
        private System.Windows.Forms.ComboBox cboBacSi;
        private System.Windows.Forms.Button button1;
    }
}

