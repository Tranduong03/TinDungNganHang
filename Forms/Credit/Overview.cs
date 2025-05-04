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
using TinDungNganHang.Models;

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
                    MaKH = kv.MaKH,
                    DaDuyet = kv.DaDuyet
                })
                .ToList();

            foreach (var item in data)
            {
                string systemStatus = LoanEligibilityService.CheckEligibility(item.MaKH);

                int rowIndex = dataGridView1.Rows.Add(
                    item.MaKhoanVay,
                    item.HoTenKH,
                    item.SoTienVay.ToString("N0") + " VND",
                    item.KyHanThang + " tháng",
                    item.LaiSuat.ToString("0.##") + " %",
                    item.NgayVay.ToShortDateString(),
                    systemStatus,
                    "" // cột trạng thái gán sau
                );

                var row = dataGridView1.Rows[rowIndex];

                if (item.DaDuyet)
                {
                    row.Cells["Status"].Value = "Approved";
                    ((DataGridViewButtonCell)row.Cells["Status"]).Style.BackColor = Color.LightGray;
                    ((DataGridViewButtonCell)row.Cells["Status"]).FlatStyle = FlatStyle.Flat;
                    ((DataGridViewButtonCell)row.Cells["Status"]).ReadOnly = true;
                }
                else
                {
                    row.Cells["Status"].Value = "Pending";
                    ((DataGridViewButtonCell)row.Cells["Status"]).Style.BackColor = Color.LawnGreen;
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Status")
            {
                var maKhoanVay = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["MaKV"].Value);

                if (dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "Pending")
                {
                    if (MessageBox.Show("Bạn có chắc chắn duyệt đơn vay này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (var context = new DataContext())
                        {
                            var khoanVay = context.KhoanVays.FirstOrDefault(kv => kv.MaKhoanVay == maKhoanVay);
                            if (khoanVay != null && !khoanVay.DaDuyet)
                            {
                                khoanVay.DaDuyet = true;

                                khoanVay.MaUser = Session.CurrentUser?.MaUser ?? 0;

                                // Tạo sổ nợ
                                var soNo = new SoNo
                                {
                                    MaKhoanVay = khoanVay.MaKhoanVay,
                                    TongTienVay = khoanVay.SoTienVay,
                                    TongTienDaTra = 0
                                };
                                context.SoNos.Add(soNo);

                                context.SaveChanges();

                                MessageBox.Show("Duyệt thành công và đã ghi vào sổ nợ!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LoadData(); 
                            }
                        }
                    }
                }
            }
        }

        private void btnNewLoan_Click(object sender, EventArgs e)
        {
            _home.LoadForm(new Profile(_home));
        }
    }
}
