using System;
using System.Drawing;
using System.Windows.Forms;
namespace Bai_Lam_Nhom_LTHDT.GUI
{
    partial class ChiTietLichHen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietLichHen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.dtpNgayLamViec = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboChuyenKhoa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoTenBS = new System.Windows.Forms.TextBox();
            this.txtMaBS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachBenhNhan = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThemGhiChu = new System.Windows.Forms.Button();
            this.btnTuChoi = new System.Windows.Forms.Button();
            this.btnDuyet = new System.Windows.Forms.Button();
            this.btnInDanhSach = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBenhNhan)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btTimKiem);
            this.panel1.Controls.Add(this.dtpNgayLamViec);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboChuyenKhoa);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtHoTenBS);
            this.panel1.Controls.Add(this.txtMaBS);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 129);
            this.panel1.TabIndex = 0;
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btTimKiem.ForeColor = System.Drawing.Color.White;
            this.btTimKiem.Location = new System.Drawing.Point(936, 29);
            this.btTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(142, 41);
            this.btTimKiem.TabIndex = 19;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = false;
            // 
            // dtpNgayLamViec
            // 
            this.dtpNgayLamViec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLamViec.Location = new System.Drawing.Point(565, 42);
            this.dtpNgayLamViec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayLamViec.Name = "dtpNgayLamViec";
            this.dtpNgayLamViec.Size = new System.Drawing.Size(246, 34);
            this.dtpNgayLamViec.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(411, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ngày làm việc:";
            // 
            // cboChuyenKhoa
            // 
            this.cboChuyenKhoa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboChuyenKhoa.FormattingEnabled = true;
            this.cboChuyenKhoa.Location = new System.Drawing.Point(159, 87);
            this.cboChuyenKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboChuyenKhoa.Name = "cboChuyenKhoa";
            this.cboChuyenKhoa.Size = new System.Drawing.Size(213, 36);
            this.cboChuyenKhoa.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(17, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Chuyên khoa: ";
            // 
            // txtHoTenBS
            // 
            this.txtHoTenBS.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtHoTenBS.Location = new System.Drawing.Point(159, 48);
            this.txtHoTenBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTenBS.Name = "txtHoTenBS";
            this.txtHoTenBS.Size = new System.Drawing.Size(213, 34);
            this.txtHoTenBS.TabIndex = 13;
            // 
            // txtMaBS
            // 
            this.txtMaBS.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaBS.Location = new System.Drawing.Point(159, 11);
            this.txtMaBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaBS.Name = "txtMaBS";
            this.txtMaBS.Size = new System.Drawing.Size(213, 34);
            this.txtMaBS.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(17, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "Họ và tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(17, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã bác sĩ:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.groupBox1.Controls.Add(this.dgvDanhSachBenhNhan);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 192);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1163, 218);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách bệnh nhân";
            // 
            // dgvDanhSachBenhNhan
            // 
            this.dgvDanhSachBenhNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachBenhNhan.Location = new System.Drawing.Point(11, 23);
            this.dgvDanhSachBenhNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhSachBenhNhan.MultiSelect = false;
            this.dgvDanhSachBenhNhan.Name = "dgvDanhSachBenhNhan";
            this.dgvDanhSachBenhNhan.RowHeadersWidth = 51;
            this.dgvDanhSachBenhNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachBenhNhan.Size = new System.Drawing.Size(1144, 190);
            this.dgvDanhSachBenhNhan.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.panel2.Controls.Add(this.txtGhiChu);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(13, 415);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1162, 138);
            this.panel2.TabIndex = 2;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(10, 33);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(1127, 81);
            this.txtGhiChu.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ghi chú ban đầu / yêu cầu chuẩn bị:";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(193)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(645, 559);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(143, 35);
            this.btnLamMoi.TabIndex = 12;
            this.btnLamMoi.Text = "🔄 Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnThemGhiChu
            // 
            this.btnThemGhiChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnThemGhiChu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnThemGhiChu.ForeColor = System.Drawing.Color.White;
            this.btnThemGhiChu.Location = new System.Drawing.Point(419, 559);
            this.btnThemGhiChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemGhiChu.Name = "btnThemGhiChu";
            this.btnThemGhiChu.Size = new System.Drawing.Size(178, 35);
            this.btnThemGhiChu.TabIndex = 11;
            this.btnThemGhiChu.Text = "📝 Thêm ghi chú";
            this.btnThemGhiChu.UseVisualStyleBackColor = false;
            // 
            // btnTuChoi
            // 
            this.btnTuChoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnTuChoi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnTuChoi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTuChoi.Location = new System.Drawing.Point(241, 558);
            this.btnTuChoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTuChoi.Name = "btnTuChoi";
            this.btnTuChoi.Size = new System.Drawing.Size(130, 36);
            this.btnTuChoi.TabIndex = 10;
            this.btnTuChoi.Text = "❌ Từ chối";
            this.btnTuChoi.UseVisualStyleBackColor = false;
            // 
            // btnDuyet
            // 
            this.btnDuyet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.btnDuyet.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDuyet.ForeColor = System.Drawing.Color.White;
            this.btnDuyet.Location = new System.Drawing.Point(54, 554);
            this.btnDuyet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(120, 39);
            this.btnDuyet.TabIndex = 9;
            this.btnDuyet.Text = "✅ Duyệt";
            this.btnDuyet.UseVisualStyleBackColor = false;
            // 
            // btnInDanhSach
            // 
            this.btnInDanhSach.BackColor = System.Drawing.Color.LimeGreen;
            this.btnInDanhSach.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnInDanhSach.Location = new System.Drawing.Point(975, 559);
            this.btnInDanhSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInDanhSach.Name = "btnInDanhSach";
            this.btnInDanhSach.Size = new System.Drawing.Size(175, 35);
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
            // ChiTietLichHen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1190, 629);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnInDanhSach);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThemGhiChu);
            this.Controls.Add(this.btnTuChoi);
            this.Controls.Add(this.btnDuyet);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChiTietLichHen";
            this.Text = "Chi tiết lịch hẹn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBenhNhan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox txtHoTenBS;
        private TextBox txtMaBS;
        private Label label2;
        private Label label1;
        private ComboBox cboChuyenKhoa;
        private Label label6;
        private DateTimePicker dtpNgayLamViec;
        private Label label3;
        private Button btTimKiem;
        private GroupBox groupBox1;
        private DataGridView dgvDanhSachBenhNhan;
        private Panel panel2;
        private TextBox txtGhiChu;
        private Label label4;
        private Button btnLamMoi;
        private Button btnThemGhiChu;
        private Button btnTuChoi;
        private Button btnDuyet;
        private Button btnInDanhSach;
        private Panel panel3;
        private Label label5;
        private Label label7;
    }
}