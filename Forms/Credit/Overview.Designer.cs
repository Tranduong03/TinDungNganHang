

namespace TinDungNganHang.Forms.Credit
{
    partial class Overview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overview));
            dataGridView1 = new DataGridView();
            MaKV = new DataGridViewTextBoxColumn();
            TenKH = new DataGridViewTextBoxColumn();
            Sotien = new DataGridViewTextBoxColumn();
            Kyhan = new DataGridViewTextBoxColumn();
            Laisuat = new DataGridViewTextBoxColumn();
            Ngayvay = new DataGridViewTextBoxColumn();
            System = new DataGridViewTextBoxColumn();
            Status = new DataGridViewButtonColumn();
            label1 = new Label();
            btnNewLoan = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            cbStatus = new ComboBox();
            txtCustomerName = new TextBox();
            txtAmountMin = new TextBox();
            txtAmountMax = new TextBox();
            dtFrom = new DateTimePicker();
            dtTo = new DateTimePicker();
            btnRefresh = new Button();
            panel1 = new Panel();
            btn_filter = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaKV, TenKH, Sotien, Kyhan, Laisuat, Ngayvay, System, Status });
            dataGridView1.Location = new Point(12, 223);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1552, 959);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MaKV
            // 
            MaKV.HeaderText = "Mã khoản vay";
            MaKV.MinimumWidth = 8;
            MaKV.Name = "MaKV";
            // 
            // TenKH
            // 
            TenKH.HeaderText = "Tên khách hàng";
            TenKH.MinimumWidth = 8;
            TenKH.Name = "TenKH";
            // 
            // Sotien
            // 
            Sotien.HeaderText = "Số tiền ";
            Sotien.MinimumWidth = 8;
            Sotien.Name = "Sotien";
            // 
            // Kyhan
            // 
            Kyhan.HeaderText = "Kỳ hạn";
            Kyhan.MinimumWidth = 8;
            Kyhan.Name = "Kyhan";
            // 
            // Laisuat
            // 
            Laisuat.HeaderText = "Lãi suất";
            Laisuat.MinimumWidth = 8;
            Laisuat.Name = "Laisuat";
            // 
            // Ngayvay
            // 
            Ngayvay.HeaderText = "Ngày vay";
            Ngayvay.MinimumWidth = 8;
            Ngayvay.Name = "Ngayvay";
            // 
            // System
            // 
            System.HeaderText = "Hệ thống";
            System.MinimumWidth = 8;
            System.Name = "System";
            // 
            // Status
            // 
            Status.HeaderText = "Trạng thái";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(629, 34);
            label1.Name = "label1";
            label1.Size = new Size(302, 42);
            label1.TabIndex = 1;
            label1.Text = "Hồ Sơ Vay Tiền";
            // 
            // btnNewLoan
            // 
            btnNewLoan.BackColor = Color.LawnGreen;
            btnNewLoan.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewLoan.Location = new Point(1366, 14);
            btnNewLoan.Name = "btnNewLoan";
            btnNewLoan.Size = new Size(198, 62);
            btnNewLoan.TabIndex = 2;
            btnNewLoan.Text = "Hồ sơ mới";
            btnNewLoan.UseVisualStyleBackColor = false;
            btnNewLoan.Click += btnNewLoan_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Bookman Old Style", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(81, 132);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "   Tìm kiếm khoản vay";
            textBox1.Size = new Size(444, 42);
            textBox1.TabIndex = 5;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(81, 156);
            label2.Name = "label2";
            label2.Size = new Size(444, 27);
            label2.TabIndex = 4;
            label2.Text = "____________________________________\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(473, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // cbStatus
            // 
            cbStatus.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbStatus.Items.AddRange(new object[] { "All", "Approved", "Pending" });
            cbStatus.Location = new Point(0, 0);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(231, 41);
            cbStatus.TabIndex = 0;
            // 
            // txtCustomerName
            // 
            txtCustomerName.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerName.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerName.Location = new Point(1, 44);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "Tên khách hàng";
            txtCustomerName.Size = new Size(230, 40);
            txtCustomerName.TabIndex = 1;
            // 
            // txtAmountMin
            // 
            txtAmountMin.BorderStyle = BorderStyle.FixedSingle;
            txtAmountMin.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmountMin.Location = new Point(270, 0);
            txtAmountMin.Name = "txtAmountMin";
            txtAmountMin.PlaceholderText = "Số tiền min";
            txtAmountMin.Size = new Size(212, 40);
            txtAmountMin.TabIndex = 2;
            // 
            // txtAmountMax
            // 
            txtAmountMax.BorderStyle = BorderStyle.FixedSingle;
            txtAmountMax.Font = new Font("Bookman Old Style", 14F);
            txtAmountMax.Location = new Point(524, 0);
            txtAmountMax.Name = "txtAmountMax";
            txtAmountMax.PlaceholderText = "max";
            txtAmountMax.Size = new Size(204, 40);
            txtAmountMax.TabIndex = 3;
            // 
            // dtFrom
            // 
            dtFrom.Font = new Font("Bookman Old Style", 12F);
            dtFrom.Format = DateTimePickerFormat.Short;
            dtFrom.Location = new Point(270, 47);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(212, 36);
            dtFrom.TabIndex = 4;
            dtFrom.Value = new DateTime(2005, 5, 8, 1, 20, 0, 0);
            // 
            // dtTo
            // 
            dtTo.Font = new Font("Bookman Old Style", 12F);
            dtTo.Format = DateTimePickerFormat.Short;
            dtTo.Location = new Point(524, 47);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(204, 36);
            dtTo.TabIndex = 5;
            // 
            // btnRefresh
            // 
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(1480, 99);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(84, 84);
            btnRefresh.TabIndex = 6;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_filter);
            panel1.Controls.Add(cbStatus);
            panel1.Controls.Add(dtTo);
            panel1.Controls.Add(dtFrom);
            panel1.Controls.Add(txtAmountMax);
            panel1.Controls.Add(txtAmountMin);
            panel1.Controls.Add(txtCustomerName);
            panel1.Location = new Point(583, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(852, 84);
            panel1.TabIndex = 7;
            // 
            // btn_filter
            // 
            btn_filter.Image = (Image)resources.GetObject("btn_filter.Image");
            btn_filter.Location = new Point(768, 0);
            btn_filter.Name = "btn_filter";
            btn_filter.Size = new Size(84, 84);
            btn_filter.TabIndex = 8;
            btn_filter.Click += btn_filter_Click;
            // 
            // Overview
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 1194);
            Controls.Add(btnRefresh);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(btnNewLoan);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Name = "Overview";
            Text = "Overview";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dataGridView1;
        private Label label1;
        private Button btnNewLoan;
        private DataGridViewTextBoxColumn MaKV;
        private DataGridViewTextBoxColumn TenKH;
        private DataGridViewTextBoxColumn Sotien;
        private DataGridViewTextBoxColumn Kyhan;
        private DataGridViewTextBoxColumn Laisuat;
        private DataGridViewTextBoxColumn Ngayvay;
        private DataGridViewTextBoxColumn System;
        private DataGridViewButtonColumn Status;
        private TextBox textBox1;
        private Label label2;
        private PictureBox pictureBox1;
        private ComboBox cbStatus;
        private TextBox txtCustomerName;
        private TextBox txtAmountMin;
        private TextBox txtAmountMax;
        private DateTimePicker dtFrom;
        private DateTimePicker dtTo;
        private Button btnRefresh;
        private Panel panel1;
        private Button btn_filter;
    }
}