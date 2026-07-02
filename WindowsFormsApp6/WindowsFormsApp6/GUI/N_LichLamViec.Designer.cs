using System;
using System.Drawing;
using System.Windows.Forms;
namespace Bai_Lam_Nhom_LTHDT.GUI
{
    partial class N_LichLamViec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(N_LichLamViec));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.nudSoBenhNhanToiDa = new System.Windows.Forms.NumericUpDown();
            this.nudGioKetThuc = new System.Windows.Forms.NumericUpDown();
            this.nudGioBatDau = new System.Windows.Forms.NumericUpDown();
            this.txtHoTenBS = new System.Windows.Forms.TextBox();
            this.txtMaBS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgayLamViec = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLichLamViec = new System.Windows.Forms.DataGridView();
            this.btnXemLichCuThe = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoBenhNhanToiDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGioKetThuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGioBatDau)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichLamViec)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.nudSoBenhNhanToiDa);
            this.panel1.Controls.Add(this.nudGioKetThuc);
            this.panel1.Controls.Add(this.nudGioBatDau);
            this.panel1.Controls.Add(this.txtHoTenBS);
            this.panel1.Controls.Add(this.txtMaBS);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtpNgayLamViec);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(8, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 197);
            this.panel1.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(193)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(566, 136);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(103, 35);
            this.btnLamMoi.TabIndex = 20;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(391, 135);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 36);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(230, 135);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(104, 36);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(36, 132);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 39);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // nudSoBenhNhanToiDa
            // 
            this.nudSoBenhNhanToiDa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoBenhNhanToiDa.Location = new System.Drawing.Point(659, 94);
            this.nudSoBenhNhanToiDa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudSoBenhNhanToiDa.Name = "nudSoBenhNhanToiDa";
            this.nudSoBenhNhanToiDa.Size = new System.Drawing.Size(150, 34);
            this.nudSoBenhNhanToiDa.TabIndex = 16;
            // 
            // nudGioKetThuc
            // 
            this.nudGioKetThuc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nudGioKetThuc.Location = new System.Drawing.Point(659, 46);
            this.nudGioKetThuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudGioKetThuc.Name = "nudGioKetThuc";
            this.nudGioKetThuc.Size = new System.Drawing.Size(150, 34);
            this.nudGioKetThuc.TabIndex = 15;
            // 
            // nudGioBatDau
            // 
            this.nudGioBatDau.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nudGioBatDau.Location = new System.Drawing.Point(659, 6);
            this.nudGioBatDau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudGioBatDau.Name = "nudGioBatDau";
            this.nudGioBatDau.Size = new System.Drawing.Size(131, 34);
            this.nudGioBatDau.TabIndex = 14;
            // 
            // txtHoTenBS
            // 
            this.txtHoTenBS.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtHoTenBS.Location = new System.Drawing.Point(178, 48);
            this.txtHoTenBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTenBS.Name = "txtHoTenBS";
            this.txtHoTenBS.Size = new System.Drawing.Size(250, 34);
            this.txtHoTenBS.TabIndex = 13;
            // 
            // txtMaBS
            // 
            this.txtMaBS.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaBS.Location = new System.Drawing.Point(178, 11);
            this.txtMaBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaBS.Name = "txtMaBS";
            this.txtMaBS.Size = new System.Drawing.Size(250, 34);
            this.txtMaBS.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(36, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Họ và tên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(36, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 28);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mã bác sĩ:";
            // 
            // dtpNgayLamViec
            // 
            this.dtpNgayLamViec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLamViec.Location = new System.Drawing.Point(178, 91);
            this.dtpNgayLamViec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayLamViec.Name = "dtpNgayLamViec";
            this.dtpNgayLamViec.Size = new System.Drawing.Size(250, 34);
            this.dtpNgayLamViec.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(456, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số bệnh nhân tối đa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(456, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giờ kết thúc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(456, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giờ bắt đầu: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày làm việc:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.groupBox1.Controls.Add(this.dgvLichLamViec);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.groupBox1.Location = new System.Drawing.Point(8, 277);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(898, 281);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách lịch";
            // 
            // dgvLichLamViec
            // 
            this.dgvLichLamViec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichLamViec.Location = new System.Drawing.Point(6, 31);
            this.dgvLichLamViec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLichLamViec.MultiSelect = false;
            this.dgvLichLamViec.Name = "dgvLichLamViec";
            this.dgvLichLamViec.RowHeadersWidth = 51;
            this.dgvLichLamViec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichLamViec.Size = new System.Drawing.Size(875, 236);
            this.dgvLichLamViec.TabIndex = 0;
            // 
            // btnXemLichCuThe
            // 
            this.btnXemLichCuThe.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnXemLichCuThe.ForeColor = System.Drawing.Color.White;
            this.btnXemLichCuThe.Location = new System.Drawing.Point(737, 562);
            this.btnXemLichCuThe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemLichCuThe.Name = "btnXemLichCuThe";
            this.btnXemLichCuThe.Size = new System.Drawing.Size(152, 32);
            this.btnXemLichCuThe.TabIndex = 2;
            this.btnXemLichCuThe.Text = "Xem lịch cụ thể";
            this.btnXemLichCuThe.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 71);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "LỊCH LÀM VIỆC ";
            // 
            // N_LichLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(919, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnXemLichCuThe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "N_LichLamViec";
            this.Text = "Lịch làm việc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoBenhNhanToiDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGioKetThuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGioBatDau)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichLamViec)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpNgayLamViec;
        private TextBox txtHoTenBS;
        private TextBox txtMaBS;
        private Label label6;
        private Label label7;
        private NumericUpDown nudSoBenhNhanToiDa;
        private NumericUpDown nudGioKetThuc;
        private NumericUpDown nudGioBatDau;
        private GroupBox groupBox1;
        private DataGridView dgvLichLamViec;
        private Button btnXemLichCuThe;
        private Panel panel2;
        private Label label1;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}