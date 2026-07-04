using System;
using System.Drawing;
using System.Windows.Forms;
namespace Bai_Lam_Nhom_LTHDT.GUI
{
    partial class N_ChiTietLichHen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(N_ChiTietLichHen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.dtpNgayLamViec = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboChuyenKhoa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachBenhNhan = new System.Windows.Forms.DataGridView();
            this.btnTuChoi = new System.Windows.Forms.Button();
            this.btnInDanhSach = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboBacSi = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBenhNhan)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cboBacSi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btTimKiem);
            this.panel1.Controls.Add(this.dtpNgayLamViec);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboChuyenKhoa);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 152);
            this.panel1.TabIndex = 0;
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.ForeColor = System.Drawing.Color.White;
            this.btTimKiem.Location = new System.Drawing.Point(978, 84);
            this.btTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(157, 52);
            this.btTimKiem.TabIndex = 19;
            this.btTimKiem.Text = "🔎 Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = false;
            // 
            // dtpNgayLamViec
            // 
            this.dtpNgayLamViec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLamViec.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLamViec.Location = new System.Drawing.Point(677, 8);
            this.dtpNgayLamViec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayLamViec.Name = "dtpNgayLamViec";
            this.dtpNgayLamViec.Size = new System.Drawing.Size(458, 34);
            this.dtpNgayLamViec.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(519, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ngày làm việc:";
            // 
            // cboChuyenKhoa
            // 
            this.cboChuyenKhoa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboChuyenKhoa.FormattingEnabled = true;
            this.cboChuyenKhoa.Location = new System.Drawing.Point(196, 13);
            this.cboChuyenKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboChuyenKhoa.Name = "cboChuyenKhoa";
            this.cboChuyenKhoa.Size = new System.Drawing.Size(294, 36);
            this.cboChuyenKhoa.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(40, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Chuyên khoa: ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.groupBox1.Controls.Add(this.dgvDanhSachBenhNhan);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 215);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1163, 390);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách bệnh nhân";
            // 
            // dgvDanhSachBenhNhan
            // 
            this.dgvDanhSachBenhNhan.AllowUserToAddRows = false;
            this.dgvDanhSachBenhNhan.AllowUserToDeleteRows = false;
            this.dgvDanhSachBenhNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachBenhNhan.Location = new System.Drawing.Point(11, 31);
            this.dgvDanhSachBenhNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhSachBenhNhan.MultiSelect = false;
            this.dgvDanhSachBenhNhan.Name = "dgvDanhSachBenhNhan";
            this.dgvDanhSachBenhNhan.ReadOnly = true;
            this.dgvDanhSachBenhNhan.RowHeadersWidth = 51;
            this.dgvDanhSachBenhNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachBenhNhan.Size = new System.Drawing.Size(1144, 333);
            this.dgvDanhSachBenhNhan.TabIndex = 0;
            // 
            // btnTuChoi
            // 
            this.btnTuChoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnTuChoi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnTuChoi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTuChoi.Location = new System.Drawing.Point(49, 630);
            this.btnTuChoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTuChoi.Name = "btnTuChoi";
            this.btnTuChoi.Size = new System.Drawing.Size(130, 48);
            this.btnTuChoi.TabIndex = 10;
            this.btnTuChoi.Text = "❌ Từ chối";
            this.btnTuChoi.UseVisualStyleBackColor = false;
            // 
            // btnInDanhSach
            // 
            this.btnInDanhSach.BackColor = System.Drawing.Color.LimeGreen;
            this.btnInDanhSach.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnInDanhSach.Location = new System.Drawing.Point(992, 630);
            this.btnInDanhSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInDanhSach.Name = "btnInDanhSach";
            this.btnInDanhSach.Size = new System.Drawing.Size(175, 47);
            this.btnInDanhSach.TabIndex = 13;
            this.btnInDanhSach.Text = "🖨️ In danh sách";
            this.btnInDanhSach.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(12, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1159, 50);
            this.panel3.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(389, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(378, 54);
            this.label7.TabIndex = 1;
            this.label7.Text = "CHI TIẾT LỊCH HẸN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(368, -4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 54);
            this.label5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(40, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Bác sĩ: ";
            // 
            // cboBacSi
            // 
            this.cboBacSi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboBacSi.FormattingEnabled = true;
            this.cboBacSi.Location = new System.Drawing.Point(196, 76);
            this.cboBacSi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboBacSi.Name = "cboBacSi";
            this.cboBacSi.Size = new System.Drawing.Size(294, 36);
            this.cboBacSi.TabIndex = 21;
            // 
            // N_ChiTietLichHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1190, 717);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnInDanhSach);
            this.Controls.Add(this.btnTuChoi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "N_ChiTietLichHen";
            this.Text = "Chi tiết lịch hẹn";
            this.Load += new System.EventHandler(this.N_ChiTietLichHen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBenhNhan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ComboBox cboChuyenKhoa;
        private Label label6;
        private DateTimePicker dtpNgayLamViec;
        private Label label3;
        private Button btTimKiem;
        private GroupBox groupBox1;
        private DataGridView dgvDanhSachBenhNhan;
        private Button btnTuChoi;
        private Button btnInDanhSach;
        private Panel panel3;
        private Label label5;
        private Label label7;
        private ComboBox cboBacSi;
        private Label label1;
    }
}