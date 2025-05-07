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


namespace TinDungNganHang.Forms.Home
{
    public partial class HomePanel : Form
    {
        private readonly DataContext _context;

        public HomePanel()
        {
            InitializeComponent();
            _context = new DataContext();
        }

        private void HomePanel_Load(object sender, EventArgs e)
        {
            LoadStatistics();
        }

        /// <summary>
        /// Tải các thống kê chính: số khoản vay, tổng số tiền cho vay, tiền đã thu và số khoản vay quá hạn.
        /// </summary>
        private void LoadStatistics()
        {
            // Tổng số khoản vay
            int totalLoans = _context.KhoanVays.Count();

            // Tổng số tiền cho vay
            decimal totalLoanAmount = _context.KhoanVays.Sum(k => (decimal?)k.SoTienVay) ?? 0;

            // Tổng tiền đã thu
            decimal totalPaid = _context.LichSuTraNos.Sum(l => (decimal?)l.SoTienTra) ?? 0;

            // Khoản vay quá hạn
            int overdueLoans = _context.KhoanVays
                .AsEnumerable() // chuyển sang client-side để tính toán
                .Count(k =>
                {
                    DateTime dueDate = k.NgayVay.AddMonths(k.KyHanThang);
                    return DateTime.Now > dueDate &&
                           !_context.LichSuTraNos.Any(l => l.MaKhoanVay == k.MaKhoanVay && l.NgayTra >= dueDate);
                });

            // Cập nhật UI
            UpdateStatisticsUI(totalLoans, totalLoanAmount, totalPaid, overdueLoans);
        }

        /// <summary>
        /// Hiển thị các số liệu thống kê trên giao diện.
        /// </summary>
        private void UpdateStatisticsUI(int totalLoans, decimal totalLoanAmount, decimal totalPaid, int overdueLoans)
        {
            textBox1.Text = totalLoans.ToString();
            textBox2.Text = totalLoanAmount.ToString("N0") + " đ";
            textBox3.Text = totalPaid.ToString("N0") + " đ";
            textBox4.Text = overdueLoans.ToString();
        }
    }
}
