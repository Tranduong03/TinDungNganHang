namespace TinDungNganHang.Forms.Auth
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            imageList1 = new ImageList(components);
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btn_clear = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = SystemColors.HighlightText;
            usernameTextBox.BorderStyle = BorderStyle.None;
            usernameTextBox.Font = new Font("Bookman Old Style", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTextBox.ForeColor = Color.Black;
            usernameTextBox.ImeMode = ImeMode.NoControl;
            usernameTextBox.Location = new Point(1403, 471);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PlaceholderText = "Username";
            usernameTextBox.Size = new Size(482, 38);
            usernameTextBox.TabIndex = 1;
            usernameTextBox.KeyDown += TextBox_KeyDown;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font("Bookman Old Style", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(1403, 590);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '#';
            passwordTextBox.PlaceholderText = "Password";
            passwordTextBox.Size = new Size(482, 38);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.KeyDown += TextBox_KeyDown;
            // 
            // loginButton
            // 
            loginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginButton.BackColor = Color.GreenYellow;
            loginButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.Location = new Point(1366, 707);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(369, 58);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(0, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 1200);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1545, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1444, 315);
            label1.Name = "label1";
            label1.Size = new Size(379, 48);
            label1.TabIndex = 7;
            label1.Text = "WELCOME, MY BANK";
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.LightCoral;
            btn_clear.Location = new Point(1757, 707);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(128, 58);
            btn_clear.TabIndex = 8;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(1366, 623);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(507, 28);
            label2.TabIndex = 9;
            label2.Text = "                                                                                                   ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(1366, 504);
            label3.Name = "label3";
            label3.Size = new Size(507, 28);
            label3.TabIndex = 10;
            label3.Text = "                                                                                                   ";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2000, 1250);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_clear);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(loginButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private ImageList imageList1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_clear;
        private Label label2;
        private Label label3;
    }
}