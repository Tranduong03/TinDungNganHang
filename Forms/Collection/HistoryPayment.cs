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

namespace TinDungNganHang.Forms.Collection
{
    public partial class HistoryPayment : Form
    {
        private readonly DataContext _context;

        public HistoryPayment()
        {
            InitializeComponent();
            _context = new DataContext();
            LoadHistory();
        }

        private void LoadHistory()
        {
            var rawData = _context.LichSuTraNos
                .Include("NguoiThuNo")
                .Include("KhoanVay.KhachHang")
                .ToList();

            var data = rawData.Select(p => new
            {
                p.MaKhoanVay,
                CCCD = p.KhoanVay?.KhachHang?.CCCD ?? "Không rõ",
                NgayTra = p.NgayTra.ToString("dd/MM/yyyy"),
                SoTienTra = p.SoTienTra.ToString("N0") + " VND",
                TrongHan = p.TrongHan ? "Trong hạn" : "Quá hạn",
                p.GhiChu,
                TenUser = p.NguoiThuNo?.HoTen ?? "Không rõ"
            }).ToList();

            dgvHistory.DataSource = data;
        }


    }
}
