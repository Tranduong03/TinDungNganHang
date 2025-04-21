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
using HomeForm = TinDungNganHang.Forms.Home.Home;
using System.Data.Entity;
using TinDungNganHang.Services;

namespace TinDungNganHang.Forms.Credit
{
    public partial class Overview : Form
    {
        private HomeForm _home;
        private readonly DataContext _context;

        internal Overview(HomeForm home)
        {
            InitializeComponent();
            _home = home;
            _context = new DataContext();
            LoadData();
        }

        //private void LoadData()
        //{
        //    dataGridView1.Rows.Clear();

        //    var loans = _context.KhoanVays.Include(kv => kv.KhachHang).ToList().Select(kv => new
        //        {
        //            kv.MaKhoanVay,
        //            HoTenKH = kv.KhachHang != null ? kv.KhachHang.HoTen : "Không rõ",
        //            kv.SoTienVay,
        //            kv.KyHanThang,
        //            kv.LaiSuat,
        //            kv.NgayVay,
        //            HeThong = "Tin Dung Ngan Hang",
        //            TrangThai = kv.DaDuyet ? "Đã duyệt" : "Chưa duyệt"
        //        })
        //        .ToList();

        //    foreach (var loan in loans)
        //    {
        //        dataGridView1.Rows.Add(
        //            loan.MaKhoanVay,
        //            loan.HoTenKH,
        //            loan.SoTienVay.ToString("N0") + " VND",
        //            loan.KyHanThang + " tháng",
        //            loan.LaiSuat.ToString("0.##") + " %",
        //            loan.NgayVay.ToString("dd/MM/yyyy"),
        //            loan.HeThong,
        //            loan.TrangThai
        //        );
        //    }
        //}

        private void LoadData()
        {
            dataGridView1.Rows.Clear();
            var data = _context.KhoanVays
                .Select(kv => new
                {
                    kv.MaKhoanVay,
                    HoTenKH = kv.KhachHang != null ? kv.KhachHang.HoTen : "Unknown",
                    kv.SoTienVay,
                    kv.KyHanThang,
                    kv.LaiSuat,
                    kv.NgayVay,
                    MaKH = kv.MaKH, // cần thêm MaKH để gọi CheckEligibility
                    Status = kv.DaDuyet ? "Approved" : "Pending"
                })
                .ToList();

            dataGridView1.Rows.Clear();
            foreach (var item in data)
            {
                // Gọi service kiểm tra điều kiện cho từng khoản vay
                string systemStatus = LoanEligibilityService.CheckEligibility(item.MaKH);

                dataGridView1.Rows.Add(
                    item.MaKhoanVay,
                    item.HoTenKH,
                    item.SoTienVay.ToString("N0") + " VND",
                    item.KyHanThang + " tháng",
                    item.LaiSuat.ToString("0.##") + " %",
                    item.NgayVay.ToShortDateString(),
                    systemStatus,
                    item.Status
                );
            }
        }


        private void btnNewLoan_Click(object sender, EventArgs e)
        {
            _home.LoadForm(new Profile());
        }
    }
}
