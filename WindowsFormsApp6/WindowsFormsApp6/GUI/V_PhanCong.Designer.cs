namespace Bai_Lam_Nhom_LTHDT
{
    partial class V_PhanCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_PhanCong));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.dgvPhanCong = new System.Windows.Forms.DataGridView();
            this.colBacSi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhongKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(85, 75);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(217, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PHÂN CÔNG BÁC SĨ VÀO PHÒNG";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(106, 132);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(40, 16);
            this.lblNgay.TabIndex = 1;
            this.lblNgay.Text = "Ngày";
            // 
            // dtNgay
            // 
            this.dtNgay.Location = new System.Drawing.Point(177, 132);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(200, 22);
            this.dtNgay.TabIndex = 2;
            // 
            // dgvPhanCong
            // 
            this.dgvPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBacSi,
            this.colPhongKham,
            this.colBatDau,
            this.colKetThuc,
            this.colGhiChu});
            this.dgvPhanCong.Location = new System.Drawing.Point(76, 249);
            this.dgvPhanCong.Name = "dgvPhanCong";
            this.dgvPhanCong.RowHeadersWidth = 51;
            this.dgvPhanCong.RowTemplate.Height = 24;
            this.dgvPhanCong.Size = new System.Drawing.Size(679, 150);
            this.dgvPhanCong.TabIndex = 3;
            // 
            // colBacSi
            // 
            this.colBacSi.HeaderText = "Bác sĩ";
            this.colBacSi.MinimumWidth = 6;
            this.colBacSi.Name = "colBacSi";
            this.colBacSi.Width = 125;
            // 
            // colPhongKham
            // 
            this.colPhongKham.HeaderText = "Phòng khám";
            this.colPhongKham.MinimumWidth = 6;
            this.colPhongKham.Name = "colPhongKham";
            this.colPhongKham.Width = 125;
            // 
            // colBatDau
            // 
            this.colBatDau.HeaderText = "Giờ bắt đầu";
            this.colBatDau.MinimumWidth = 6;
            this.colBatDau.Name = "colBatDau";
            this.colBatDau.Width = 125;
            // 
            // colKetThuc
            // 
            this.colKetThuc.HeaderText = "Giờ kết thúc";
            this.colKetThuc.MinimumWidth = 6;
            this.colKetThuc.Name = "colKetThuc";
            this.colKetThuc.Width = 125;
            // 
            // colGhiChu
            // 
            this.colGhiChu.HeaderText = "Ghi chú";
            this.colGhiChu.MinimumWidth = 6;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Width = 125;
            // 
            // FrmPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPhanCong);
            this.Controls.Add(this.dtNgay);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPhanCong";
            this.Text = "FrmPhanCong";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.DataGridView dgvPhanCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBacSi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhongKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
    }
}