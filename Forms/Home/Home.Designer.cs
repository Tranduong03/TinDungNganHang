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
            btnExit = new Button();
            btn_HomePanel = new Button();
            btnKhachHang = new Button();
            btnThuNo = new Button();
            btnDuyetVay = new Button();
            panelMain = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.LightSteelBlue;
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
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 14F);
            btnExit.Location = new Point(0, 739);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(400, 60);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.Click += btnExit_Click;
            // 
            // btn_HomePanel
            // 
            btn_HomePanel.Font = new Font("Segoe UI", 14F);
            btn_HomePanel.Location = new Point(-3, 209);
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
            btnKhachHang.Location = new Point(0, 629);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(400, 60);
            btnKhachHang.TabIndex = 0;
            btnKhachHang.Text = "Profile Customer";
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnThuNo
            // 
            btnThuNo.Font = new Font("Segoe UI", 14F);
            btnThuNo.Location = new Point(0, 459);
            btnThuNo.Name = "btnThuNo";
            btnThuNo.Size = new Size(400, 60);
            btnThuNo.TabIndex = 1;
            btnThuNo.Text = "Thu nợ";
            btnThuNo.Click += btnThuNo_Click;
            // 
            // btnDuyetVay
            // 
            btnDuyetVay.Font = new Font("Segoe UI", 14F);
            btnDuyetVay.Location = new Point(0, 348);
            btnDuyetVay.Name = "btnDuyetVay";
            btnDuyetVay.Size = new Size(400, 60);
            btnDuyetVay.TabIndex = 2;
            btnDuyetVay.Text = "Duyệt vay";
            btnDuyetVay.Click += btnDuyetVay_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
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
            ResumeLayout(false);
        }

        private Button btn_HomePanel;
        private Button btnExit;
    }
}