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

namespace TinDungNganHang.Forms.Collection
{
    public partial class Debt : Form
    {
        private readonly DataContext _context;

        public Debt()
        {
            InitializeComponent();
            _context = new DataContext();
            LoadAllDebt();
            //btnSearch.Click += btnSearch_Click;
        }

        private void LoadAllDebt()
        {
            var data = _context.SoNos
                .Include("KhoanVay")
                .Include("KhoanVay.KhachHang")
                .ToList()
                .Select(sn => new
                {
                    sn.MaSoNo,
                    sn.MaKhoanVay,
                    TenKH = sn.KhoanVay?.KhachHang?.HoTen ?? "Unknown",
                    CCCD = sn.KhoanVay?.KhachHang?.CCCD ?? "Unknown",
                    TongTienVay = sn.KhoanVay != null ? LoanCalculationService.CalculateTotalLoan(sn.KhoanVay) : 0, 
                    sn.TongTienDaTra
                })
                .ToList();

            dgvDebt.DataSource = data;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            var data = _context.SoNos
                .Include("KhoanVay")
                .Include("KhoanVay.KhachHang")
                .Where(sn => sn.MaKhoanVay.ToString().Contains(keyword) || sn.KhoanVay.KhachHang.CCCD.Contains(keyword))
                .ToList()
                .Select(sn => new
                {
                    sn.MaSoNo,
                    sn.MaKhoanVay,
                    TenKH = sn.KhoanVay?.KhachHang?.HoTen ?? "Unknown",
                    CCCD = sn.KhoanVay?.KhachHang?.CCCD ?? "Unknown",
                    TongTienVay = sn.KhoanVay != null ? LoanCalculationService.CalculateTotalLoan(sn.KhoanVay) : 0, 
                    sn.TongTienDaTra
                })
                .ToList();

            dgvDebt.DataSource = data;
        }
    }
}
