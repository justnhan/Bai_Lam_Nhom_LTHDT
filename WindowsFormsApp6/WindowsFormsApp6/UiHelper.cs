using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Lam_Nhom_LTHDT
{
    public static class UiHelper
    {
        public static Color NenForm = Color.FromArgb(255, 255, 255);
        public static Color MenuTrai = Color.FromArgb(21, 101, 192);
        public static Color Header = Color.FromArgb(30, 136, 229);
        public static Color PanelNhat = Color.FromArgb(227, 242, 253);
        public static Color ChuThuong = Color.FromArgb(33, 33, 33);

        public static Color Them = Color.FromArgb(67, 160, 71);
        public static Color Sua = Color.FromArgb(30, 136, 229);
        public static Color Luu = Color.FromArgb(21, 101, 192);
        public static Color Xoa = Color.FromArgb(229, 57, 53);
        public static Color TimKiem = Color.FromArgb(251, 140, 0);
        public static Color Refresh = Color.FromArgb(0, 172, 193);
        public static Color Huy = Color.FromArgb(117, 117, 117);

        public static void StyleForm(Form f)
        {
            f.BackColor = NenForm;
            f.ForeColor = ChuThuong;
            f.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            f.StartPosition = FormStartPosition.CenterScreen;
        }

        public static void StyleTitle(Label lbl)
        {
            lbl.ForeColor = Header;
            lbl.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lbl.BackColor = Color.Transparent;
        }

        public static void StyleLabel(Label lbl)
        {
            lbl.ForeColor = ChuThuong;
            lbl.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lbl.BackColor = Color.Transparent;
        }

        public static void StyleButton(Button btn, Color mau)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = mau;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.TextAlign = ContentAlignment.MiddleCenter;
        }

        public static void StyleGrid(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.FixedSingle;
            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Header;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = ChuThuong;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(187, 222, 251);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 251, 255);

            dgv.GridColor = Color.FromArgb(220, 220, 220);
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
