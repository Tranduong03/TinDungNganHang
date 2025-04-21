using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                //int months = int.Parse(cbThoiHanVay.SelectedItem.ToString());
                decimal laiSuat = LoanInterestService.GetInterestRate(months);
                txtLaiSuat.Text = laiSuat.ToString("0.##") + " % / month";
            }
        }
    }
}
