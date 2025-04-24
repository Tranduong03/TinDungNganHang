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
using HomeForm = TinDungNganHang.Forms.Home.Home;
using System.Data.Entity;


namespace TinDungNganHang.Forms.Collection
{
    public partial class Debt : Form
    {
        private HomeForm _home;
        private readonly DataContext _context;

        internal Debt(HomeForm home)
        {
            InitializeComponent();
            _context = new DataContext();
            LoadAllDebt();
            _home = home;
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

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    string keyword = txtSearch.Text.Trim();

        //    var data = _context.SoNos
        //        .Include("KhoanVay")
        //        .Include("KhoanVay.KhachHang")
        //        .Where(sn => sn.MaKhoanVay.ToString().Contains(keyword) || sn.KhoanVay.KhachHang.CCCD.Contains(keyword))
        //        .ToList()
        //        .Select(sn => new
        //        {
        //            sn.MaSoNo,
        //            sn.MaKhoanVay,
        //            TenKH = sn.KhoanVay?.KhachHang?.HoTen ?? "Unknown",
        //            CCCD = sn.KhoanVay?.KhachHang?.CCCD ?? "Unknown",
        //            TongTienVay = sn.KhoanVay != null ? LoanCalculationService.CalculateTotalLoan(sn.KhoanVay) : 0, 
        //            sn.TongTienDaTra
        //        })
        //        .ToList();

        //    dgvDebt.DataSource = data;
        //}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            var data = _context.SoNos
                .Include("KhoanVay")
                .Include("KhoanVay.KhachHang")
                .ToList()
                .Where(sn =>
                    sn.MaKhoanVay.ToString().Contains(keyword) ||
                    (sn.KhoanVay?.KhachHang?.CCCD?.Contains(keyword) ?? false)
                )
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



        private void dgvDebt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvDebt.Rows[e.RowIndex];
                int maSoNo = Convert.ToInt32(row.Cells["MaSoNo"].Value);
                //_home.LoadForm(new Payment(maSoNo, this)); 

                var paymentForm = new Payment(maSoNo, this);
                //paymentForm.Show();
                paymentForm.ShowDialog(this); // Form hiện lên, không cho tương tác với form dưới

            }
        }

    }
}
