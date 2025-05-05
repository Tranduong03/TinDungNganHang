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
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.LightSkyBlue;
            panelMenu.Controls.Add(pictureBox6);
            panelMenu.Controls.Add(pictureBox5);
            panelMenu.Controls.Add(pictureBox4);
            panelMenu.Controls.Add(pictureBox3);
            panelMenu.Controls.Add(pictureBox2);
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
            btnExit.BackColor = Color.White;
            btnExit.Font = new Font("Bookman Old Style", 15F);
            btnExit.Location = new Point(0, 920);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(400, 70);
            btnExit.TabIndex = 4;
            btnExit.Text = "    Đăng Xuất";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btn_HomePanel
            // 
            btn_HomePanel.BackColor = Color.White;
            btn_HomePanel.Font = new Font("Bookman Old Style", 15F);
            btn_HomePanel.Location = new Point(0, 400);
            btn_HomePanel.Name = "btn_HomePanel";
            btn_HomePanel.Size = new Size(400, 70);
            btn_HomePanel.TabIndex = 3;
            btn_HomePanel.Text = "Trang Chủ";
            btn_HomePanel.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_HomePanel.UseVisualStyleBackColor = false;
            btn_HomePanel.Click += btn_HomePanel_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.BackColor = Color.White;
            btnKhachHang.Font = new Font("Bookman Old Style", 15F);
            btnKhachHang.Location = new Point(0, 530);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(400, 70);
            btnKhachHang.TabIndex = 0;
            btnKhachHang.Text = "    Quản Lí Đơn Vay";
            btnKhachHang.UseVisualStyleBackColor = false;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnThuNo
            // 
            btnThuNo.BackColor = Color.White;
            btnThuNo.Font = new Font("Bookman Old Style", 15F);
            btnThuNo.Location = new Point(0, 660);
            btnThuNo.Name = "btnThuNo";
            btnThuNo.Size = new Size(400, 70);
            btnThuNo.TabIndex = 1;
            btnThuNo.Text = "Quản Lí Thu Nợ";
            btnThuNo.UseVisualStyleBackColor = false;
            btnThuNo.Click += btnThuNo_Click;
            // 
            // btnDuyetVay
            // 
            btnDuyetVay.BackColor = Color.White;
            btnDuyetVay.Font = new Font("Bookman Old Style", 15F);
            btnDuyetVay.Location = new Point(0, 790);
            btnDuyetVay.Name = "btnDuyetVay";
            btnDuyetVay.Size = new Size(400, 70);
            btnDuyetVay.TabIndex = 2;
            btnDuyetVay.Text = "Quản Lí Sổ Nợ";
            btnDuyetVay.UseVisualStyleBackColor = false;
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
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Control;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(10, 925);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.Control;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(10, 795);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.Control;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(10, 665);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(60, 60);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.Control;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(10, 535);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(60, 60);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = SystemColors.Control;
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(10, 405);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(60, 60);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 11;
            pictureBox6.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        private Button btn_HomePanel;
        private Button btnExit;
        private PictureBox pictureBox1;
        private Label lblName;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}