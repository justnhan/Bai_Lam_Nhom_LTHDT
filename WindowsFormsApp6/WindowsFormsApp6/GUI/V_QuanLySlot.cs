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
    public partial class V_QuanLySlot : Form
    {
        public V_QuanLySlot()
        {
            InitializeComponent();
            UiHelper.StyleForm(this);
            UiHelper.StyleTitle(lblTitle);

            UiHelper.StyleLabel(lblBacSi);
            UiHelper.StyleLabel(lblNgay);
            UiHelper.StyleLabel(lblBatDau);
            UiHelper.StyleLabel(lblKetThuc);
            UiHelper.StyleLabel(lblThoiLuong);
            UiHelper.StyleLabel(lblPhong);

            UiHelper.StyleButton(btnTaoSlot, UiHelper.Luu);

            cboBacSi.Items.Add("BS. Nguyễn Văn A");
            cboBacSi.Items.Add("BS. Trần Thị B");
            cboBacSi.Items.Add("BS. Lê Văn C");

            cboPhong.Items.Add("Phòng 101");
            cboPhong.Items.Add("Phòng 102");
            cboPhong.Items.Add("Phòng 103");

            cboBacSi.SelectedIndex = 0;
            cboPhong.SelectedIndex = 0;

            dtGioBatDau.Format = DateTimePickerFormat.Time;
            dtGioBatDau.ShowUpDown = true;

            dtGioKetThuc.Format = DateTimePickerFormat.Time;
            dtGioKetThuc.ShowUpDown = true;

            numThoiLuong.Value = 20;
        }

        private void btnTaoSlot_Click(object sender, EventArgs e)
        {
            DuLieuSlot.TaoDuLieuMau();

            DateTime batDau = dtGioBatDau.Value;
            DateTime ketThuc = dtGioKetThuc.Value;
            int thoiLuong = (int)numThoiLuong.Value;

            if (cboBacSi.Text == "")
            {
                MessageBox.Show("Vui lòng chọn bác sĩ!");
                return;
            }

            if (cboPhong.Text == "")
            {
                MessageBox.Show("Vui lòng chọn phòng khám!");
                return;
            }

            if (thoiLuong <= 0)
            {
                MessageBox.Show("Thời lượng phải lớn hơn 0!");
                return;
            }

            if (batDau >= ketThuc)
            {
                MessageBox.Show("Giờ bắt đầu phải nhỏ hơn giờ kết thúc!");
                return;
            }

            string ngay = dtNgayLamViec.Value.ToShortDateString();
            int soSlotDaTao = 0;

            while (batDau < ketThuc)
            {
                DateTime gioKetThucSlot = batDau.AddMinutes(thoiLuong);

                if (gioKetThucSlot > ketThuc)
                    break;

                string gioBD = batDau.ToString("HH:mm");
                string gioKT = gioKetThucSlot.ToString("HH:mm");

                bool tonTai = DuLieuSlot.DanhSachSlot.Any(x =>
                    x.BacSi == cboBacSi.Text &&
                    x.Phong == cboPhong.Text &&
                    x.Ngay == ngay &&
                    x.GioBatDau == gioBD
                );

                if (tonTai)
                {
                    MessageBox.Show(
                        "Slot " + gioBD + " đã tồn tại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    batDau = gioKetThucSlot;
                    continue;
                }

                DuLieuSlot.DanhSachSlot.Add(new SlotInfo
                {
                    STT = (DuLieuSlot.DanhSachSlot.Count + 1).ToString(),
                    Ngay = ngay,
                    GioBatDau = gioBD,
                    GioKetThuc = gioKT,
                    BacSi = cboBacSi.Text,
                    Phong = cboPhong.Text,
                    TrangThai = "Trống",
                    BenhNhan = "-"
                });

                soSlotDaTao++;
                batDau = gioKetThucSlot;
            }

            MessageBox.Show("Tạo thành công " + soSlotDaTao + " slot!");
        }

        private void FrmQuanLySlot_Load(object sender, EventArgs e)
        {

        }

        private void lblBacSi_Click(object sender, EventArgs e)
        {

        }

        private void lblNgay_Click(object sender, EventArgs e)
        {

        }

        private void lblBatDau_Click(object sender, EventArgs e)
        {

        }

        private void lblKetThuc_Click(object sender, EventArgs e)
        {

        }

        private void lblThoiLuong_Click(object sender, EventArgs e)
        {

        }

        private void lblPhong_Click(object sender, EventArgs e)
        {

        }
    }
}
