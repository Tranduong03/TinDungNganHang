namespace TinDungNganHang.Forms.Home
{
    partial class Home
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelMenu;
        private Panel panelMain;
        private Button btnDuyetVay;
        private Button btnThuNo;
        private Button btnKhachHang;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panelMenu = new Panel();
            lblName = new Label();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            btn_HomePanel = new Button();
            btnKhachHang = new Button();
            btnThuNo = new Button();
            btnDuyetVay = new Button();
            panelMain = new Panel();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.LightSkyBlue;
            panelMenu.Controls.Add(lblName);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(btnExit);
            panelMenu.Controls.Add(btn_HomePanel);
            panelMenu.Controls.Add(btnKhachHang);
            panelMenu.Controls.Add(btnThuNo);
            panelMenu.Controls.Add(btnDuyetVay);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(400, 1250);
            panelMenu.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Bookman Old Style", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(79, 274);
            lblName.Name = "lblName";
            lblName.Size = new Size(239, 52);
            lblName.TabIndex = 6;
            lblName.Text = "Hello, you";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(105, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 14F);
            btnExit.Location = new Point(0, 1000);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(400, 60);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.Click += btnExit_Click;
            // 
            // btn_HomePanel
            // 
            btn_HomePanel.Font = new Font("Segoe UI", 14F);
            btn_HomePanel.Location = new Point(0, 520);
            btn_HomePanel.Name = "btn_HomePanel";
            btn_HomePanel.Size = new Size(400, 60);
            btn_HomePanel.TabIndex = 3;
            btn_HomePanel.Text = "Home";
            btn_HomePanel.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_HomePanel.Click += btn_HomePanel_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.Font = new Font("Segoe UI", 14F);
            btnKhachHang.Location = new Point(0, 880);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(400, 60);
            btnKhachHang.TabIndex = 0;
            btnKhachHang.Text = "Profile Customer";
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnThuNo
            // 
            btnThuNo.Font = new Font("Segoe UI", 14F);
            btnThuNo.Location = new Point(0, 640);
            btnThuNo.Name = "btnThuNo";
            btnThuNo.Size = new Size(400, 60);
            btnThuNo.TabIndex = 1;
            btnThuNo.Text = "Thu nợ";
            btnThuNo.Click += btnThuNo_Click;
            // 
            // btnDuyetVay
            // 
            btnDuyetVay.Font = new Font("Segoe UI", 14F);
            btnDuyetVay.Location = new Point(0, 760);
            btnDuyetVay.Name = "btnDuyetVay";
            btnDuyetVay.Size = new Size(400, 60);
            btnDuyetVay.TabIndex = 2;
            btnDuyetVay.Text = "Duyệt vay";
            btnDuyetVay.Click += btnDuyetVay_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = SystemColors.GradientActiveCaption;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(400, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1600, 1250);
            panelMain.TabIndex = 0;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2000, 1250);
            Controls.Add(panelMain);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private Button btn_HomePanel;
        private Button btnExit;
        private PictureBox pictureBox1;
        private Label lblName;
    }
}