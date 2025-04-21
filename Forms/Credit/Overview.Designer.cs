namespace TinDungNganHang.Forms.Credit
{
    partial class Overview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MaKV = new DataGridViewTextBoxColumn();
            TenKH = new DataGridViewTextBoxColumn();
            Sotien = new DataGridViewTextBoxColumn();
            Kyhan = new DataGridViewTextBoxColumn();
            Laisuat = new DataGridViewTextBoxColumn();
            Ngayvay = new DataGridViewTextBoxColumn();
            System = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnNewLoan = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaKV, TenKH, Sotien, Kyhan, Laisuat, Ngayvay, System, Status });
            dataGridView1.Location = new Point(12, 223);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1552, 885);
            dataGridView1.TabIndex = 0;
            // 
            // MaKV
            // 
            MaKV.HeaderText = "Mã khoản vay";
            MaKV.MinimumWidth = 8;
            MaKV.Name = "MaKV";
            MaKV.Width = 165;
            // 
            // TenKH
            // 
            TenKH.HeaderText = "Tên khách hàng";
            TenKH.MinimumWidth = 8;
            TenKH.Name = "TenKH";
            TenKH.Width = 200;
            // 
            // Sotien
            // 
            Sotien.HeaderText = "Số tiền ";
            Sotien.MinimumWidth = 8;
            Sotien.Name = "Sotien";
            Sotien.Width = 200;
            // 
            // Kyhan
            // 
            Kyhan.HeaderText = "Kỳ hạn";
            Kyhan.MinimumWidth = 8;
            Kyhan.Name = "Kyhan";
            Kyhan.Width = 120;
            // 
            // Laisuat
            // 
            Laisuat.HeaderText = "Lãi suất";
            Laisuat.MinimumWidth = 8;
            Laisuat.Name = "Laisuat";
            Laisuat.Width = 130;
            // 
            // Ngayvay
            // 
            Ngayvay.HeaderText = "Ngày vay";
            Ngayvay.MinimumWidth = 8;
            Ngayvay.Name = "Ngayvay";
            Ngayvay.Width = 150;
            // 
            // System
            // 
            System.HeaderText = "Hệ thống";
            System.MinimumWidth = 8;
            System.Name = "System";
            System.Width = 150;
            // 
            // Status
            // 
            Status.HeaderText = "Trạng thái";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(641, 55);
            label1.Name = "label1";
            label1.Size = new Size(253, 43);
            label1.TabIndex = 1;
            label1.Text = "Loans Status";
            // 
            // btnNewLoan
            // 
            btnNewLoan.BackColor = Color.LawnGreen;
            btnNewLoan.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewLoan.Location = new Point(1366, 14);
            btnNewLoan.Name = "btnNewLoan";
            btnNewLoan.Size = new Size(198, 47);
            btnNewLoan.TabIndex = 2;
            btnNewLoan.Text = "New Loan";
            btnNewLoan.UseVisualStyleBackColor = false;
            btnNewLoan.Click += btnNewLoan_Click;
            // 
            // Overview
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 1194);
            Controls.Add(btnNewLoan);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Overview";
            Text = "Overview";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private DataGridViewTextBoxColumn Status;
    }
}