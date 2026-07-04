namespace Bai_Lam_Nhom_LTHDT.GUI
{
    partial class Main_TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_TrangChu));
            this.cboNhanVat = new System.Windows.Forms.ComboBox();
            this.btnMainDangNhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // cboNhanVat
            // 
            this.cboNhanVat.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNhanVat.FormattingEnabled = true;
            this.cboNhanVat.Items.AddRange(new object[] {
            "Tiếp tân",
            "Điều phối viên",
            "Bác sĩ trưởng",
            "Quản lý"});
            this.cboNhanVat.Location = new System.Drawing.Point(663, 404);
            this.cboNhanVat.Name = "cboNhanVat";
            this.cboNhanVat.Size = new System.Drawing.Size(413, 53);
            this.cboNhanVat.TabIndex = 1;
            this.cboNhanVat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnMainDangNhap
            // 
            this.btnMainDangNhap.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMainDangNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainDangNhap.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMainDangNhap.Location = new System.Drawing.Point(861, 536);
            this.btnMainDangNhap.Name = "btnMainDangNhap";
            this.btnMainDangNhap.Size = new System.Drawing.Size(215, 64);
            this.btnMainDangNhap.TabIndex = 2;
            this.btnMainDangNhap.Text = "Đăng Nhập";
            this.btnMainDangNhap.UseVisualStyleBackColor = false;
            this.btnMainDangNhap.Click += new System.EventHandler(this.btnMainDangNhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 636);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sự khỏe mạnh của bạn chính là niềm vui của chúng tôi!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(654, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 54);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bạn là?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Bai_Lam_Nhom_LTHDT.Properties.Resources.ChatGPT_Image_21_49_05_3_thg_7__2026;
            this.pictureBox2.Location = new System.Drawing.Point(535, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(664, 265);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Bai_Lam_Nhom_LTHDT.Properties.Resources.ChatGPT_Image_21_02_13_3_thg_7__20261;
            this.pictureBox1.Location = new System.Drawing.Point(23, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 555);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(753, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(208, 156);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // Main_TrangChu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1185, 670);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMainDangNhap);
            this.Controls.Add(this.cboNhanVat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Main_TrangChu";
            this.Text = "Main_TrangChu";
            this.Load += new System.EventHandler(this.Main_TrangChu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboNhanVat;
        private System.Windows.Forms.Button btnMainDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}