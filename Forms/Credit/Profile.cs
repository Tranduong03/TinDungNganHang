using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinDungNganHang.Forms.Home;
using TinDungNganHang.Models;
using TinDungNganHang.Repositories;
using TinDungNganHang.Services;

namespace TinDungNganHang.Forms.Credit
{
    public partial class Profile : Form
    {
        private readonly DataContext _context;

        public Profile()
        {
            InitializeComponent();
            _context = new DataContext();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var khachHang = new KhachHang
            {
                CCCD = txtCCCD.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
                SoDienThoai = txtSoDienThoai.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                TenBoMe = tbxTenBoMe.Text.Trim(),
                SdtBoMe = tbxSdtBoMe.Text.Trim()
            };

            _context.KhachHangs.Add(khachHang);
            _context.SaveChanges();

            MessageBox.Show("Đã lưu thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblCCCD.Text = txtCCCD.Text.Trim();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtCCCD.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            tbxTenBoMe.Clear();
            tbxSdtBoMe.Clear();
        }

        private void cbThoiHanVay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbThoiHanVay.SelectedItem != null)
            {
                int months = int.Parse(cbThoiHanVay.SelectedItem?.ToString() ?? "0");
                decimal laiSuat = LoanInterestService.GetInterestRate(months);
                txtLaiSuat.Text = laiSuat.ToString("0.##") + " % / month";
            }
        }

        private void btnSaveLoan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxSotienvay.Text) || cbThoiHanVay.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khoản vay!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thử tìm khách hàng vừa nhập
            var cccd = txtCCCD.Text.Trim();
            var khachHang = _context.KhachHangs.FirstOrDefault(kh => kh.CCCD == cccd);

            if (khachHang == null)
            {
                MessageBox.Show("Không tìm thấy khách hàng để tạo khoản vay!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var khoanVay = new KhoanVay
            {
                MaKH = khachHang.MaKH,
                SoTienVay = decimal.Parse(tbxSotienvay.Text.Trim()),
                KyHanThang = int.Parse(cbThoiHanVay.SelectedItem?.ToString() ?? "0"),
                NgayVay = dtpNgayVay.Value,
                LaiSuat = (float)LoanInterestService.GetInterestRate(int.Parse(cbThoiHanVay.SelectedItem?.ToString() ?? "0")),
                DaDuyet = false // chưa duyệt ngay lúc thêm
            };

            _context.KhoanVays.Add(khoanVay);
            _context.SaveChanges();

            MessageBox.Show("Đã lưu khoản vay thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelLoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            var homePanel = new HomePanel(); 
            homePanel.Show();
        }
    }
}
