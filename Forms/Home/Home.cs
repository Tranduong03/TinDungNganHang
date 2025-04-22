using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinDungNganHang.Forms.Auth;
using TinDungNganHang.Repositories;
using TinDungNganHang.Services;

namespace TinDungNganHang.Forms.Home
{
    internal partial class Home : BaseForm
    {
        private readonly DataContext _context;
        public Home() : base()
        {
            InitializeComponent();
            _context = new DataContext();

            if (Session.CurrentUser != null)
            {
                lblName.Text = $"Hello, {Session.CurrentUser.Username}";
            }
            else
            {
                lblName.Text = $"Hello, Guest";
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoadForm(new HomePanel());
        }

        private void LoadForm(Control control)
        {
            panelMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelMain.Controls.Add(control);
        }

        public void LoadForm(Form form)
        {
            panelMain.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Add(form);
            panelMain.Tag = form;
            form.Show();
        }


        private void btnDuyetVay_Click(object sender, EventArgs e)
        {
            LoadForm(new Label { Text = "Duyệt vay", AutoSize = true, Font = new Font("Segoe UI", 18) });
        }

        private void btnThuNo_Click(object sender, EventArgs e)
        {
            LoadForm(new Label { Text = "Thu nợ", AutoSize = true, Font = new Font("Segoe UI", 18) });
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            LoadForm(new Credit.Overview(this));
        }

        private void btn_HomePanel_Click(object sender, EventArgs e)
        {
            LoadForm(new HomePanel());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

    }
}
