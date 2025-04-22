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

namespace TinDungNganHang.Forms.Auth
{
    internal partial class Login : BaseForm
    {
        private readonly DataContext _context;

        public Login() : base()
        {
            InitializeComponent();
            _context = new DataContext();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            var user = _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                Session.CurrentUser = user;

                MessageBox.Show("Login successful!");

                var homeForm = new Forms.Home.Home();
                homeForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            usernameTextBox.Focus();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }
    }
}
