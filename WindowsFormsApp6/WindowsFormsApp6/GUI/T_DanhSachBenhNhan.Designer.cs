namespace Bai_Lam_Nhom_LTHDT
{
    partial class T_DanhSachBenhNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(T_DanhSachBenhNhan));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKinhLup = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBenhNhan = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpNgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.txtNgheNghiep = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.txtMaBenhNhan = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnXoaBenhNhan = new System.Windows.Forms.Button();
            this.btnSuaThongTin = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnInDanhSach = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH BỆNH NHÂN";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.groupBox1.Controls.Add(this.btnLoc);
            this.groupBox1.Controls.Add(this.cboLoai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnKinhLup);
            this.groupBox1.Controls.Add(this.txtTuKhoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1489, 98);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TÌM KIẾM - LỌC";
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(1332, 36);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(95, 36);
            this.btnLoc.TabIndex = 6;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboLoai
            // 
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Items.AddRange(new object[] {
            "Tất cả",
            "Nam",
            "Nữ"});
            this.cboLoai.Location = new System.Drawing.Point(443, 43);
            this.cboLoai.Margin = new System.Windows.Forms.Padding(4);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(147, 36);
            this.cboLoai.TabIndex = 4;
            this.cboLoai.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loại:";
            // 
            // btnKinhLup
            // 
            this.btnKinhLup.Location = new System.Drawing.Point(229, 43);
            this.btnKinhLup.Margin = new System.Windows.Forms.Padding(4);
            this.btnKinhLup.Name = "btnKinhLup";
            this.btnKinhLup.Size = new System.Drawing.Size(41, 36);
            this.btnKinhLup.TabIndex = 2;
            this.btnKinhLup.Text = "🔍";
            this.btnKinhLup.UseVisualStyleBackColor = true;
            this.btnKinhLup.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(100, 45);
            this.txtTuKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(121, 34);
            this.txtTuKhoa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ khóa: ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.groupBox2.Controls.Add(this.dgvBenhNhan);
            this.groupBox2.Location = new System.Drawing.Point(15, 164);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1489, 238);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DANH SÁCH BỆNH NHÂN";
            // 
            // dgvBenhNhan
            // 
            this.dgvBenhNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBenhNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaBN,
            this.colHoTen,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colSDT,
            this.colDiaChi,
            this.colNgayDangKy,
            this.colGhiChu});
            this.dgvBenhNhan.Location = new System.Drawing.Point(14, 35);
            this.dgvBenhNhan.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBenhNhan.Name = "dgvBenhNhan";
            this.dgvBenhNhan.RowHeadersVisible = false;
            this.dgvBenhNhan.RowHeadersWidth = 51;
            this.dgvBenhNhan.RowTemplate.Height = 24;
            this.dgvBenhNhan.Size = new System.Drawing.Size(1467, 195);
            this.dgvBenhNhan.TabIndex = 0;
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            // 
            // colMaBN
            // 
            this.colMaBN.HeaderText = "Mã BN";
            this.colMaBN.MinimumWidth = 6;
            this.colMaBN.Name = "colMaBN";
            // 
            // colHoTen
            // 
            this.colHoTen.HeaderText = "Họ và tên";
            this.colHoTen.MinimumWidth = 6;
            this.colHoTen.Name = "colHoTen";
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.HeaderText = "Giới tính";
            this.colGioiTinh.MinimumWidth = 6;
            this.colGioiTinh.Name = "colGioiTinh";
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.MinimumWidth = 6;
            this.colNgaySinh.Name = "colNgaySinh";
            // 
            // colSDT
            // 
            this.colSDT.HeaderText = "SĐT";
            this.colSDT.MinimumWidth = 6;
            this.colSDT.Name = "colSDT";
            // 
            // colDiaChi
            // 
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.MinimumWidth = 6;
            this.colDiaChi.Name = "colDiaChi";
            // 
            // colNgayDangKy
            // 
            this.colNgayDangKy.HeaderText = "Ngày đăng ký";
            this.colNgayDangKy.MinimumWidth = 6;
            this.colNgayDangKy.Name = "colNgayDangKy";
            // 
            // colGhiChu
            // 
            this.colGhiChu.HeaderText = "Ghi chú";
            this.colGhiChu.MinimumWidth = 6;
            this.colGhiChu.Name = "colGhiChu";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.groupBox3.Controls.Add(this.dtpNgayDangKy);
            this.groupBox3.Controls.Add(this.txtGhiChu);
            this.groupBox3.Controls.Add(this.dtpNgaySinh);
            this.groupBox3.Controls.Add(this.rdoNu);
            this.groupBox3.Controls.Add(this.rdoNam);
            this.groupBox3.Controls.Add(this.txtNgheNghiep);
            this.groupBox3.Controls.Add(this.txtDiaChi);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.txtSDT);
            this.groupBox3.Controls.Add(this.txtHoVaTen);
            this.groupBox3.Controls.Add(this.txtMaBenhNhan);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(15, 402);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1481, 255);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "THÔNG TIN CHI TIẾT";
            // 
            // dtpNgayDangKy
            // 
            this.dtpNgayDangKy.Location = new System.Drawing.Point(938, 45);
            this.dtpNgayDangKy.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayDangKy.Name = "dtpNgayDangKy";
            this.dtpNgayDangKy.Size = new System.Drawing.Size(205, 34);
            this.dtpNgayDangKy.TabIndex = 19;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(877, 98);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(262, 126);
            this.txtGhiChu.TabIndex = 18;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(184, 200);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(274, 34);
            this.dtpNgaySinh.TabIndex = 17;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(264, 150);
            this.rdoNu.Margin = new System.Windows.Forms.Padding(4);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(60, 32);
            this.rdoNu.TabIndex = 16;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(172, 150);
            this.rdoNam.Margin = new System.Windows.Forms.Padding(4);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(75, 32);
            this.rdoNam.TabIndex = 15;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // txtNgheNghiep
            // 
            this.txtNgheNghiep.Location = new System.Drawing.Point(619, 197);
            this.txtNgheNghiep.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgheNghiep.Name = "txtNgheNghiep";
            this.txtNgheNghiep.Size = new System.Drawing.Size(136, 34);
            this.txtNgheNghiep.TabIndex = 14;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(564, 146);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(136, 34);
            this.txtDiaChi.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(551, 92);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(136, 34);
            this.txtEmail.TabIndex = 12;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(551, 42);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(136, 34);
            this.txtSDT.TabIndex = 11;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(182, 92);
            this.txtHoVaTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(136, 34);
            this.txtHoVaTen.TabIndex = 10;
            // 
            // txtMaBenhNhan
            // 
            this.txtMaBenhNhan.Location = new System.Drawing.Point(182, 32);
            this.txtMaBenhNhan.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaBenhNhan.Name = "txtMaBenhNhan";
            this.txtMaBenhNhan.Size = new System.Drawing.Size(136, 34);
            this.txtMaBenhNhan.TabIndex = 0;
            this.txtMaBenhNhan.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(785, 92);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 28);
            this.label14.TabIndex = 9;
            this.label14.Text = "Ghi chú:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(785, 43);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 28);
            this.label13.TabIndex = 8;
            this.label13.Text = "Ngày đăng ký:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(474, 197);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 28);
            this.label12.TabIndex = 7;
            this.label12.Text = "Nghề nghiệp:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(474, 146);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 28);
            this.label11.TabIndex = 6;
            this.label11.Text = "Địa chỉ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(474, 92);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 28);
            this.label10.TabIndex = 5;
            this.label10.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(474, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 28);
            this.label9.TabIndex = 4;
            this.label9.Text = "SĐT:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 197);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 28);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ngày sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 28);
            this.label7.TabIndex = 2;
            this.label7.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Họ và tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã bệnh nhân";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(29, 666);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(169, 55);
            this.btnThemMoi.TabIndex = 4;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            // 
            // btnXoaBenhNhan
            // 
            this.btnXoaBenhNhan.Location = new System.Drawing.Point(384, 666);
            this.btnXoaBenhNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaBenhNhan.Name = "btnXoaBenhNhan";
            this.btnXoaBenhNhan.Size = new System.Drawing.Size(169, 55);
            this.btnXoaBenhNhan.TabIndex = 5;
            this.btnXoaBenhNhan.Text = "Xóa bệnh nhân";
            this.btnXoaBenhNhan.UseVisualStyleBackColor = true;
            // 
            // btnSuaThongTin
            // 
            this.btnSuaThongTin.Location = new System.Drawing.Point(206, 666);
            this.btnSuaThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaThongTin.Name = "btnSuaThongTin";
            this.btnSuaThongTin.Size = new System.Drawing.Size(169, 55);
            this.btnSuaThongTin.TabIndex = 6;
            this.btnSuaThongTin.Text = "Sửa thông tin";
            this.btnSuaThongTin.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(1247, 666);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(169, 55);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // btnInDanhSach
            // 
            this.btnInDanhSach.Location = new System.Drawing.Point(1070, 666);
            this.btnInDanhSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnInDanhSach.Name = "btnInDanhSach";
            this.btnInDanhSach.Size = new System.Drawing.Size(169, 55);
            this.btnInDanhSach.TabIndex = 8;
            this.btnInDanhSach.Text = "In danh sách";
            this.btnInDanhSach.UseVisualStyleBackColor = true;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Location = new System.Drawing.Point(892, 666);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(169, 55);
            this.btnXuatExcel.TabIndex = 9;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(34, 746);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(210, 28);
            this.label15.TabIndex = 10;
            this.label15.Text = "Tổng số: 36 bệnh nhân";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1167, 750);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 28);
            this.label16.TabIndex = 11;
            this.label16.Text = "Trang";
            // 
            // DanhSachBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1521, 785);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnInDanhSach);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnSuaThongTin);
            this.Controls.Add(this.btnXoaBenhNhan);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DanhSachBenhNhan";
            this.Text = "Danh sách bệnh nhân";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DanhSachBenhNhan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKinhLup;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaBenhNhan;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.TextBox txtNgheNghiep;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.DateTimePicker dtpNgayDangKy;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnXoaBenhNhan;
        private System.Windows.Forms.Button btnSuaThongTin;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnInDanhSach;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}