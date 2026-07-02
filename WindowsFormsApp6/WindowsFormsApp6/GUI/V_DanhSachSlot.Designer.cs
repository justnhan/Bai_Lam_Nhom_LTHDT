namespace Bai_Lam_Nhom_LTHDT
{
    partial class V_DanhSachSlot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_DanhSachSlot));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLoc = new System.Windows.Forms.Label();
            this.cboLocBacSi = new System.Windows.Forms.ComboBox();
            this.dgvSlot = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBacSi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlot)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(40, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DANH SÁCH SLOT KHÁM";
            // 
            // lblLoc
            // 
            this.lblLoc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoc.ForeColor = System.Drawing.Color.White;
            this.lblLoc.Location = new System.Drawing.Point(40, 105);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(120, 30);
            this.lblLoc.TabIndex = 1;
            this.lblLoc.Text = "Lọc bác sĩ";
            // 
            // cboLocBacSi
            // 
            this.cboLocBacSi.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocBacSi.FormattingEnabled = true;
            this.cboLocBacSi.Location = new System.Drawing.Point(160, 102);
            this.cboLocBacSi.Name = "cboLocBacSi";
            this.cboLocBacSi.Size = new System.Drawing.Size(260, 33);
            this.cboLocBacSi.TabIndex = 2;
            this.cboLocBacSi.SelectedIndexChanged += new System.EventHandler(this.cboLocBacSi_SelectedIndexChanged);
            // 
            // dgvSlot
            // 
            this.dgvSlot.AllowUserToAddRows = false;
            this.dgvSlot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSlot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSlot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colBatDau,
            this.colKetThuc,
            this.colBacSi,
            this.colPhong,
            this.colTrangThai,
            this.colBenhNhan});
            this.dgvSlot.Location = new System.Drawing.Point(40, 170);
            this.dgvSlot.Name = "dgvSlot";
            this.dgvSlot.RowHeadersVisible = false;
            this.dgvSlot.RowHeadersWidth = 51;
            this.dgvSlot.RowTemplate.Height = 24;
            this.dgvSlot.Size = new System.Drawing.Size(850, 330);
            this.dgvSlot.TabIndex = 3;
            // 
            // colSTT
            // 
            this.colSTT.FillWeight = 80F;
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            // 
            // colBatDau
            // 
            this.colBatDau.FillWeight = 80F;
            this.colBatDau.HeaderText = "Giờ bắt đầu";
            this.colBatDau.MinimumWidth = 6;
            this.colBatDau.Name = "colBatDau";
            // 
            // colKetThuc
            // 
            this.colKetThuc.FillWeight = 80F;
            this.colKetThuc.HeaderText = "Giờ kết thúc";
            this.colKetThuc.MinimumWidth = 6;
            this.colKetThuc.Name = "colKetThuc";
            // 
            // colBacSi
            // 
            this.colBacSi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBacSi.FillWeight = 150F;
            this.colBacSi.HeaderText = "Bác sĩ";
            this.colBacSi.MinimumWidth = 6;
            this.colBacSi.Name = "colBacSi";
            // 
            // colPhong
            // 
            this.colPhong.FillWeight = 80F;
            this.colPhong.HeaderText = "Phòng";
            this.colPhong.MinimumWidth = 6;
            this.colPhong.Name = "colPhong";
            // 
            // colTrangThai
            // 
            this.colTrangThai.FillWeight = 80F;
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            // 
            // colBenhNhan
            // 
            this.colBenhNhan.FillWeight = 80F;
            this.colBenhNhan.HeaderText = "Bệnh nhân";
            this.colBenhNhan.MinimumWidth = 6;
            this.colBenhNhan.Name = "colBenhNhan";
            // 
            // FrmDanhSachSlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.dgvSlot);
            this.Controls.Add(this.cboLocBacSi);
            this.Controls.Add(this.lblLoc);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDanhSachSlot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDanhSachSlot";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.ComboBox cboLocBacSi;
        private System.Windows.Forms.DataGridView dgvSlot;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBacSi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBenhNhan;
    }
}