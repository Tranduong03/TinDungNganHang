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
            {
                var totalLoans = _context.KhoanVays.Count();
                var totalLoanAmount = _context.KhoanVays.Sum(k => (decimal?)k.SoTienVay) ?? 0;
                var totalPaid = _context.LichSuTraNos.Sum(l => (decimal?)l.SoTienTra) ?? 0;
                var overdueLoans = _context.KhoanVays
                    .AsEnumerable() // chuyển sang client-side để tính toán
                    .Count(k =>
                    {
                        var dueDate = k.NgayVay.AddMonths(k.KyHanThang);
                        return DateTime.Now > dueDate &&
                        !_context.LichSuTraNos.Any(l => l.MaKhoanVay == k.MaKhoanVay && l.NgayTra >= dueDate);
                    });

                lblTotalLoans.Text = totalLoans.ToString();
                lblTotalLoanAmount.Text = totalLoanAmount.ToString("N0") + " đ";
                lblTotalPaid.Text = totalPaid.ToString("N0") + " đ";
                lblOverdueLoans.Text = overdueLoans.ToString();
            }
        }
    }
}
