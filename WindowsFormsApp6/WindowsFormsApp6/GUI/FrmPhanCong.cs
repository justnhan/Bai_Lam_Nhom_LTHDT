using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Lam_Nhom_LTHDT
{
    public partial class FrmPhanCong : Form
    {
        public FrmPhanCong()
        {
            InitializeComponent();
            UiHelper.StyleForm(this);
            UiHelper.StyleTitle(lblTitle);
            UiHelper.StyleLabel(lblNgay);
            UiHelper.StyleGrid(dgvPhanCong);

            dgvPhanCong.Rows.Add("BS. Nguyễn Văn A", "Phòng 101", "08:00", "11:00", "Khám tổng quát");
            dgvPhanCong.Rows.Add("BS. Trần Thị B", "Phòng 102", "13:00", "17:00", "Khám chuyên khoa");
            dgvPhanCong.Rows.Add("BS. Lê Văn C", "Phòng 103", "08:00", "12:00", "Khám nhi");
            dgvPhanCong.Rows.Add("BS. Phạm Thị D", "Phòng 104", "13:30", "17:30", "Khám tai mũi họng");
        }
    }
}
