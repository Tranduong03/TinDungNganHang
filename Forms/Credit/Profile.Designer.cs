namespace TinDungNganHang.Forms.Credit
{
    partial class Profile
    {

        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private TextBox txtCCCD, txtHoTen, txtDiaChi, txtSoDienThoai;
        private Label underlineCCCD, underlineHoTen, underlineDiaChi, underlineSoDienThoai;
        private DateTimePicker dtpNgaySinh;
        private Button btnSave;

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
            panel1.SuspendLayout();
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
            btnSave.Location = new Point(808, 1102);
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
            btnClearAll.Location = new Point(1092, 1102);
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
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbxTenBoMe);
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
            label2.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(178, 83);
            label2.Name = "label2";
            label2.Size = new Size(319, 35);
            label2.TabIndex = 18;
            label2.Text = "Information Customer";
            // 
            // panel2
            // 
            panel2.Location = new Point(700, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 900);
            panel2.TabIndex = 19;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1600, 1250);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnClearAll);
            Controls.Add(lblTitle);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Profile";
            Text = "Profile Credit";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}