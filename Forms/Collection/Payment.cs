using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinDungNganHang.Repositories;
using TinDungNganHang.Services;
using System.Data.Entity;
using TinDungNganHang.Models;
using TinDungNganHang.Helpers;

namespace TinDungNganHang.Forms.Collection
{
    public partial class Payment : Form
    {
        private int _maSoNo;
        private Form _parentForm;
        public Payment(int maSoNo, Form parent)
        {
            InitializeComponent();
            _maSoNo = maSoNo;
            _parentForm = parent;
            LoadPaymentInfo();
        }

        private void LoadPaymentInfo()
        {
            using (var context = new DataContext())
            {
                var soNo = context.SoNos
                                  .Include("KhoanVay.KhachHang")
                                  .FirstOrDefault(s => s.MaSoNo == _maSoNo);

                if (soNo != null && soNo.KhoanVay != null)
                {
                    txtLoanId.Text = soNo.MaKhoanVay.ToString();

                    var khachHang = soNo.KhoanVay.KhachHang;
                    txtCustomerName.Text = khachHang != null ? khachHang.HoTen : "Unknown";

                    txtCCCD.Text = khachHang != null ? khachHang.CCCD : "Unknown";

                    decimal tongTien = LoanCalculationService.CalculateTotalLoan(soNo.KhoanVay);
                    txtAmountOwed.Text = tongTien.ToString("N0") + " VND";
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin sổ nợ hoặc khoản vay!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool _isTyping = false;

        private void txtPaymentAmount_TextChanged(object sender, EventArgs e)
        {
            if (_isTyping) return;

            _isTyping = true;

            TextBox textBox = (TextBox)sender;
            string input = textBox.Text.Replace(".", "").Replace(",", "").Trim();

            if (decimal.TryParse(input, out decimal value))
            {
                textBox.Text = string.Format("{0:N0}", value);
                textBox.SelectionStart = textBox.Text.Length; // đưa con trỏ về cuối
            }

            _isTyping = false;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPaymentAmount.Text.Trim(), out decimal paymentAmount) || paymentAmount <= 0)
            {
                MessageBox.Show("Please enter a valid payment amount greater than 0!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new DataContext())
            {
                var soNo = context.SoNos.Include(s => s.KhoanVay).FirstOrDefault(s => s.MaSoNo == _maSoNo);

                if (soNo == null || soNo.KhoanVay == null)
                {
                    MessageBox.Show("Debt record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal totalLoan = LoanCalculationService.CalculateTotalLoan(soNo.KhoanVay);

                decimal amountRemaining = totalLoan - soNo.TongTienDaTra;

                if (paymentAmount > amountRemaining)
                {
                    MessageBox.Show($"Payment amount exceeds the remaining debt.\nRemaining: {amountRemaining:N0} VND", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                soNo.TongTienDaTra += paymentAmount;

                if (soNo.TongTienDaTra >= totalLoan)
                {
                    MessageBox.Show("Debt fully paid!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Payment successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                context.LichSuTraNos.Add(new LichSuTraNo
                {
                    MaKhoanVay = soNo.MaKhoanVay,
                    NgayTra = DateTime.Now,
                    SoTienTra = paymentAmount,
                    TrongHan = PaymentDeadlineHelper.IsWithinDeadline(
                                soNo.KhoanVay.NgayVay,
                                soNo.KhoanVay.KyHanThang,
                                DateTime.Now
                    ),
                    MaUser = Session.CurrentUser?.MaUser ?? 0,
                    //GhiChu = "Thanh toán qua giao diện"
                    GhiChu = PaymentDeadlineHelper.IsWithinDeadline(soNo.KhoanVay.NgayVay, soNo.KhoanVay.KyHanThang, DateTime.Now)
                    ? "Thanh toán trong hạn" : "Thanh toán quá hạn, phạt thêm 500.000VND"
                });


                context.SaveChanges();
            }

            this.Close();
        }

    }
}
