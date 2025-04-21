namespace TinDungNganHang.Forms.Credit
{
    partial class Profile
    {

        private System.ComponentModel.IContainer components = null;
        // Các control của phần Thông tin cá nhân
        private Label lblTitle;
        private TextBox txtCCCD, txtHoTen, txtDiaChi, txtSoDienThoai, txtLaiSuat;
        private Label underlineCCCD, underlineHoTen, underlineDiaChi, underlineSoDienThoai;
        private DateTimePicker dtpNgaySinh;
        private Button btnSave;

        // Các control của phần Khoản vay
        private Label lblKhoanVay;
        private ComboBox cbThoiHanVay;
        private DateTimePicker dtpNgayVay;


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
            lblTitle = new Label();
            txtCCCD = new TextBox();
            underlineCCCD = new Label();
            txtHoTen = new TextBox();
            underlineHoTen = new Label();
            txtDiaChi = new TextBox();
            underlineDiaChi = new Label();
            txtSoDienThoai = new TextBox();
            underlineSoDienThoai = new Label();
            dtpNgaySinh = new DateTimePicker();
            btnSave = new Button();
            btnClearAll = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            tbxSdtBoMe = new TextBox();
            label3 = new Label();
            tbxTenBoMe = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            tbxSotienvay = new TextBox();
            label5 = new Label();
            lblKhoanVay = new Label();
            dtpNgayVay = new DateTimePicker();
            cbThoiHanVay = new ComboBox();
            txtLaiSuat = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Linen;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.Location = new Point(575, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(450, 65);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Credit Information";
            // 
            // txtCCCD
            // 
            txtCCCD.BorderStyle = BorderStyle.None;
            txtCCCD.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCCCD.Location = new Point(114, 225);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.PlaceholderText = "Căn cước công dân";
            txtCCCD.Size = new Size(475, 33);
            txtCCCD.TabIndex = 2;
            // 
            // underlineCCCD
            // 
            underlineCCCD.BackColor = Color.Black;
            underlineCCCD.Location = new Point(96, 265);
            underlineCCCD.Name = "underlineCCCD";
            underlineCCCD.Size = new Size(500, 2);
            underlineCCCD.TabIndex = 3;
            // 
            // txtHoTen
            // 
            txtHoTen.BorderStyle = BorderStyle.None;
            txtHoTen.Font = new Font("Bookman Old Style", 14F);
            txtHoTen.Location = new Point(114, 325);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.PlaceholderText = "Họ và tên khách hàng";
            txtHoTen.Size = new Size(475, 33);
            txtHoTen.TabIndex = 5;
            // 
            // underlineHoTen
            // 
            underlineHoTen.BackColor = Color.Black;
            underlineHoTen.Location = new Point(96, 365);
            underlineHoTen.Name = "underlineHoTen";
            underlineHoTen.Size = new Size(500, 2);
            underlineHoTen.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderStyle = BorderStyle.None;
            txtDiaChi.Font = new Font("Bookman Old Style", 14F);
            txtDiaChi.Location = new Point(114, 425);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.PlaceholderText = "Địa chỉ thường trú";
            txtDiaChi.Size = new Size(475, 33);
            txtDiaChi.TabIndex = 8;
            // 
            // underlineDiaChi
            // 
            underlineDiaChi.BackColor = Color.Black;
            underlineDiaChi.Location = new Point(96, 465);
            underlineDiaChi.Name = "underlineDiaChi";
            underlineDiaChi.Size = new Size(500, 2);
            underlineDiaChi.TabIndex = 9;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.BorderStyle = BorderStyle.None;
            txtSoDienThoai.Font = new Font("Bookman Old Style", 14F);
            txtSoDienThoai.Location = new Point(114, 525);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.PlaceholderText = "Số điện thoại khách hàng";
            txtSoDienThoai.Size = new Size(475, 33);
            txtSoDienThoai.TabIndex = 11;
            // 
            // underlineSoDienThoai
            // 
            underlineSoDienThoai.BackColor = Color.Black;
            underlineSoDienThoai.Location = new Point(96, 565);
            underlineSoDienThoai.Name = "underlineSoDienThoai";
            underlineSoDienThoai.Size = new Size(500, 2);
            underlineSoDienThoai.TabIndex = 12;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(252, 625);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(337, 40);
            dtpNgaySinh.TabIndex = 14;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.GreenYellow;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(96, 953);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(244, 49);
            btnSave.TabIndex = 15;
            btnSave.Text = "Lưu Thông Tin";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.BackColor = Color.Pink;
            btnClearAll.FlatStyle = FlatStyle.Flat;
            btnClearAll.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearAll.ForeColor = Color.Black;
            btnClearAll.Location = new Point(426, 953);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(170, 49);
            btnClearAll.TabIndex = 16;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = false;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 628);
            label1.Name = "label1";
            label1.Size = new Size(135, 38);
            label1.TabIndex = 17;
            label1.Text = "Ngày sinh";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbxSdtBoMe);
            panel1.Controls.Add(btnClearAll);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbxTenBoMe);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtCCCD);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtpNgaySinh);
            panel1.Controls.Add(underlineSoDienThoai);
            panel1.Controls.Add(txtSoDienThoai);
            panel1.Controls.Add(underlineDiaChi);
            panel1.Controls.Add(underlineCCCD);
            panel1.Controls.Add(txtDiaChi);
            panel1.Controls.Add(txtHoTen);
            panel1.Controls.Add(underlineHoTen);
            panel1.Location = new Point(0, 127);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 1100);
            panel1.TabIndex = 18;
            // 
            // label4
            // 
            label4.BackColor = Color.Black;
            label4.Location = new Point(96, 865);
            label4.Name = "label4";
            label4.Size = new Size(500, 2);
            label4.TabIndex = 22;
            // 
            // tbxSdtBoMe
            // 
            tbxSdtBoMe.BorderStyle = BorderStyle.None;
            tbxSdtBoMe.Font = new Font("Bookman Old Style", 14F);
            tbxSdtBoMe.Location = new Point(114, 825);
            tbxSdtBoMe.Name = "tbxSdtBoMe";
            tbxSdtBoMe.PlaceholderText = "Số điện thoại bố mẹ khách hàng";
            tbxSdtBoMe.Size = new Size(475, 33);
            tbxSdtBoMe.TabIndex = 21;
            // 
            // label3
            // 
            label3.BackColor = Color.Black;
            label3.Location = new Point(96, 765);
            label3.Name = "label3";
            label3.Size = new Size(500, 2);
            label3.TabIndex = 20;
            // 
            // tbxTenBoMe
            // 
            tbxTenBoMe.BorderStyle = BorderStyle.None;
            tbxTenBoMe.Font = new Font("Bookman Old Style", 14F);
            tbxTenBoMe.Location = new Point(114, 725);
            tbxTenBoMe.Name = "tbxTenBoMe";
            tbxTenBoMe.PlaceholderText = "Tên bố hoặc mẹ";
            tbxTenBoMe.Size = new Size(475, 33);
            tbxTenBoMe.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightGoldenrodYellow;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(149, 83);
            label2.Name = "label2";
            label2.Size = new Size(414, 45);
            label2.TabIndex = 18;
            label2.Text = "Information Customer";
            // 
            // panel2
            // 
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(tbxSotienvay);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lblKhoanVay);
            panel2.Controls.Add(dtpNgayVay);
            panel2.Controls.Add(cbThoiHanVay);
            panel2.Controls.Add(txtLaiSuat);
            panel2.Location = new Point(700, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 900);
            panel2.TabIndex = 19;
            // 
            // label10
            // 
            label10.BackColor = Color.Black;
            label10.Location = new Point(125, 595);
            label10.Name = "label10";
            label10.Size = new Size(650, 2);
            label10.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Light", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(150, 545);
            label9.Name = "label9";
            label9.Size = new Size(128, 38);
            label9.TabIndex = 27;
            label9.Text = "Ngày vay";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(130, 325);
            label8.Name = "label8";
            label8.Size = new Size(111, 33);
            label8.TabIndex = 26;
            label8.Text = "Kỳ hạn";
            // 
            // label7
            // 
            label7.BackColor = Color.Black;
            label7.Location = new Point(125, 482);
            label7.Name = "label7";
            label7.Size = new Size(650, 2);
            label7.TabIndex = 25;
            // 
            // label6
            // 
            label6.BackColor = Color.Black;
            label6.Location = new Point(130, 375);
            label6.Name = "label6";
            label6.Size = new Size(650, 2);
            label6.TabIndex = 24;
            // 
            // tbxSotienvay
            // 
            tbxSotienvay.BorderStyle = BorderStyle.None;
            tbxSotienvay.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxSotienvay.Location = new Point(150, 225);
            tbxSotienvay.Name = "tbxSotienvay";
            tbxSotienvay.PlaceholderText = "Số tiền vay: VND";
            tbxSotienvay.Size = new Size(600, 33);
            tbxSotienvay.TabIndex = 23;
            // 
            // label5
            // 
            label5.BackColor = Color.Black;
            label5.Location = new Point(125, 265);
            label5.Name = "label5";
            label5.Size = new Size(650, 2);
            label5.TabIndex = 10;
            // 
            // lblKhoanVay
            // 
            lblKhoanVay.AutoSize = true;
            lblKhoanVay.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKhoanVay.Location = new Point(242, 85);
            lblKhoanVay.Name = "lblKhoanVay";
            lblKhoanVay.Size = new Size(400, 43);
            lblKhoanVay.TabIndex = 0;
            lblKhoanVay.Text = "Thông Tin Khoản Vay";
            // 
            // dtpNgayVay
            // 
            dtpNgayVay.Font = new Font("Bookman Old Style", 14F);
            dtpNgayVay.Format = DateTimePickerFormat.Short;
            dtpNgayVay.Location = new Point(302, 545);
            dtpNgayVay.Name = "dtpNgayVay";
            dtpNgayVay.Size = new Size(448, 40);
            dtpNgayVay.TabIndex = 5;
            // 
            // cbThoiHanVay
            // 
            cbThoiHanVay.BackColor = Color.White;
            cbThoiHanVay.DropDownStyle = ComboBoxStyle.DropDownList;
            cbThoiHanVay.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbThoiHanVay.Items.AddRange(new object[] { "6", "12", "24", "36" });
            cbThoiHanVay.Location = new Point(242, 325);
            cbThoiHanVay.Name = "cbThoiHanVay";
            cbThoiHanVay.Size = new Size(508, 41);
            cbThoiHanVay.TabIndex = 8;
            cbThoiHanVay.SelectedIndexChanged += cbThoiHanVay_SelectedIndexChanged;
            // 
            // txtLaiSuat
            // 
            txtLaiSuat.Font = new Font("Bookman Old Style", 14F);
            txtLaiSuat.Location = new Point(150, 435);
            txtLaiSuat.Name = "txtLaiSuat";
            txtLaiSuat.PlaceholderText = "Lãi suất (%)";
            txtLaiSuat.ReadOnly = true;
            txtLaiSuat.Size = new Size(600, 40);
            txtLaiSuat.TabIndex = 9;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1600, 1250);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Profile";
            Text = "Profile Credit";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnClearAll;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label label4;
        private TextBox tbxSdtBoMe;
        private Label label3;
        private TextBox tbxTenBoMe;
        private Label label5;
        private TextBox tbxSotienvay;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label10;
        private Label label9;
    }
}