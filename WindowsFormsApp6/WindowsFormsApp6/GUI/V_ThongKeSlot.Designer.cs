namespace Bai_Lam_Nhom_LTHDT
{
    partial class FrmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongKe));
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbTongSlot = new System.Windows.Forms.GroupBox();
            this.lblTongSlot = new System.Windows.Forms.Label();
            this.gbSlotTrong = new System.Windows.Forms.GroupBox();
            this.lblSlotTrong = new System.Windows.Forms.Label();
            this.gbDaDat = new System.Windows.Forms.GroupBox();
            this.lblDaDat = new System.Windows.Forms.Label();
            this.gbDaHuy = new System.Windows.Forms.GroupBox();
            this.lblDaHuy = new System.Windows.Forms.Label();
            this.gbTongSlot.SuspendLayout();
            this.gbSlotTrong.SuspendLayout();
            this.gbDaDat.SuspendLayout();
            this.gbDaHuy.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(122, 104);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THỐNG KÊ SLOT KHÁM";
            // 
            // gbTongSlot
            // 
            this.gbTongSlot.Controls.Add(this.lblTongSlot);
            this.gbTongSlot.Location = new System.Drawing.Point(128, 176);
            this.gbTongSlot.Name = "gbTongSlot";
            this.gbTongSlot.Size = new System.Drawing.Size(200, 100);
            this.gbTongSlot.TabIndex = 1;
            this.gbTongSlot.TabStop = false;
            this.gbTongSlot.Text = "Tổng slot";
            this.gbTongSlot.Enter += new System.EventHandler(this.gbTongSlot_Enter);
            // 
            // lblTongSlot
            // 
            this.lblTongSlot.AutoSize = true;
            this.lblTongSlot.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSlot.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTongSlot.Location = new System.Drawing.Point(74, 34);
            this.lblTongSlot.Name = "lblTongSlot";
            this.lblTongSlot.Size = new System.Drawing.Size(43, 50);
            this.lblTongSlot.TabIndex = 0;
            this.lblTongSlot.Text = "9";
            // 
            // gbSlotTrong
            // 
            this.gbSlotTrong.Controls.Add(this.lblSlotTrong);
            this.gbSlotTrong.Location = new System.Drawing.Point(128, 293);
            this.gbSlotTrong.Name = "gbSlotTrong";
            this.gbSlotTrong.Size = new System.Drawing.Size(200, 100);
            this.gbSlotTrong.TabIndex = 2;
            this.gbSlotTrong.TabStop = false;
            this.gbSlotTrong.Text = "Slot trống";
            // 
            // lblSlotTrong
            // 
            this.lblSlotTrong.AutoSize = true;
            this.lblSlotTrong.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlotTrong.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblSlotTrong.Location = new System.Drawing.Point(68, 25);
            this.lblSlotTrong.Name = "lblSlotTrong";
            this.lblSlotTrong.Size = new System.Drawing.Size(43, 50);
            this.lblSlotTrong.TabIndex = 1;
            this.lblSlotTrong.Text = "5";
            // 
            // gbDaDat
            // 
            this.gbDaDat.Controls.Add(this.lblDaDat);
            this.gbDaDat.Location = new System.Drawing.Point(392, 176);
            this.gbDaDat.Name = "gbDaDat";
            this.gbDaDat.Size = new System.Drawing.Size(200, 100);
            this.gbDaDat.TabIndex = 3;
            this.gbDaDat.TabStop = false;
            this.gbDaDat.Text = "Đã đặt";
            // 
            // lblDaDat
            // 
            this.lblDaDat.AutoSize = true;
            this.lblDaDat.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaDat.ForeColor = System.Drawing.Color.Orange;
            this.lblDaDat.Location = new System.Drawing.Point(79, 34);
            this.lblDaDat.Name = "lblDaDat";
            this.lblDaDat.Size = new System.Drawing.Size(43, 50);
            this.lblDaDat.TabIndex = 1;
            this.lblDaDat.Text = "3";
            // 
            // gbDaHuy
            // 
            this.gbDaHuy.Controls.Add(this.lblDaHuy);
            this.gbDaHuy.Location = new System.Drawing.Point(392, 293);
            this.gbDaHuy.Name = "gbDaHuy";
            this.gbDaHuy.Size = new System.Drawing.Size(200, 100);
            this.gbDaHuy.TabIndex = 4;
            this.gbDaHuy.TabStop = false;
            this.gbDaHuy.Text = "Đã hủy";
            // 
            // lblDaHuy
            // 
            this.lblDaHuy.AutoSize = true;
            this.lblDaHuy.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaHuy.ForeColor = System.Drawing.Color.Red;
            this.lblDaHuy.Location = new System.Drawing.Point(79, 25);
            this.lblDaHuy.Name = "lblDaHuy";
            this.lblDaHuy.Size = new System.Drawing.Size(43, 50);
            this.lblDaHuy.TabIndex = 1;
            this.lblDaHuy.Text = "1";
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbDaHuy);
            this.Controls.Add(this.gbDaDat);
            this.Controls.Add(this.gbSlotTrong);
            this.Controls.Add(this.gbTongSlot);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmThongKe";
            this.Text = "FrmThongKe";
            this.gbTongSlot.ResumeLayout(false);
            this.gbTongSlot.PerformLayout();
            this.gbSlotTrong.ResumeLayout(false);
            this.gbSlotTrong.PerformLayout();
            this.gbDaDat.ResumeLayout(false);
            this.gbDaDat.PerformLayout();
            this.gbDaHuy.ResumeLayout(false);
            this.gbDaHuy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbTongSlot;
        private System.Windows.Forms.GroupBox gbSlotTrong;
        private System.Windows.Forms.GroupBox gbDaDat;
        private System.Windows.Forms.GroupBox gbDaHuy;
        private System.Windows.Forms.Label lblTongSlot;
        private System.Windows.Forms.Label lblSlotTrong;
        private System.Windows.Forms.Label lblDaDat;
        private System.Windows.Forms.Label lblDaHuy;
    }
}