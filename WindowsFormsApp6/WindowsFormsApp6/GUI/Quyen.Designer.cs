namespace Bai_Lam_Nhom_LTHDT.GUI
{
    partial class Quyen
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuyen = new System.Windows.Forms.TextBox();
            this.btnKtr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "bạn có quyền không?";
            // 
            // txtQuyen
            // 
            this.txtQuyen.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuyen.Location = new System.Drawing.Point(96, 68);
            this.txtQuyen.Name = "txtQuyen";
            this.txtQuyen.Size = new System.Drawing.Size(394, 34);
            this.txtQuyen.TabIndex = 1;
            // 
            // btnKtr
            // 
            this.btnKtr.Location = new System.Drawing.Point(388, 113);
            this.btnKtr.Name = "btnKtr";
            this.btnKtr.Size = new System.Drawing.Size(102, 44);
            this.btnKtr.TabIndex = 2;
            this.btnKtr.Text = "Kiểm tra";
            this.btnKtr.UseVisualStyleBackColor = true;
            this.btnKtr.Click += new System.EventHandler(this.btnKtr_Click);
            // 
            // Quyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 169);
            this.Controls.Add(this.btnKtr);
            this.Controls.Add(this.txtQuyen);
            this.Controls.Add(this.label1);
            this.Name = "Quyen";
            this.Text = "Quyen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuyen;
        private System.Windows.Forms.Button btnKtr;
    }
}