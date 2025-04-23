namespace TinDungNganHang.Forms.Collection
{
    partial class Debt
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvDebt;

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
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvDebt = new DataGridView();
            MaSoNo = new DataGridViewTextBoxColumn();
            MaKhoanVay = new DataGridViewTextBoxColumn();
            TenKH = new DataGridViewTextBoxColumn();
            CCCD = new DataGridViewTextBoxColumn();
            TongTienVay = new DataGridViewTextBoxColumn();
            TongTienDaTra = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDebt).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.Location = new Point(600, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(452, 65);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Debt Management";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(426, 125);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter Customer ID or Loan ID";
            txtSearch.Size = new Size(600, 40);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LawnGreen;
            btnSearch.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnSearch.Location = new Point(1061, 125);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 40);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvDebt
            // 
            dgvDebt.AllowUserToAddRows = false;
            dgvDebt.AllowUserToDeleteRows = false;
            dgvDebt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDebt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDebt.Columns.AddRange(new DataGridViewColumn[] { MaSoNo, MaKhoanVay, TenKH, CCCD, TongTienVay, TongTienDaTra });
            dgvDebt.Location = new Point(12, 200);
            dgvDebt.Name = "dgvDebt";
            dgvDebt.ReadOnly = true;
            dgvDebt.RowHeadersWidth = 62;
            dgvDebt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDebt.Size = new Size(1576, 1038);
            dgvDebt.TabIndex = 3;
            // 
            // MaSoNo
            // 
            MaSoNo.DataPropertyName = "MaSoNo";
            MaSoNo.HeaderText = "Mã sổ nợ";
            MaSoNo.MinimumWidth = 8;
            MaSoNo.Name = "MaSoNo";
            MaSoNo.ReadOnly = true;
            // 
            // MaKhoanVay
            // 
            MaKhoanVay.DataPropertyName = "MaKhoanVay";
            MaKhoanVay.HeaderText = "Mã khoản vay";
            MaKhoanVay.MinimumWidth = 8;
            MaKhoanVay.Name = "MaKhoanVay";
            MaKhoanVay.ReadOnly = true;
            // 
            // TenKH
            // 
            TenKH.DataPropertyName = "TenKH";
            TenKH.HeaderText = "Tên khách hàng";
            TenKH.MinimumWidth = 8;
            TenKH.Name = "TenKH";
            TenKH.ReadOnly = true;
            // 
            // CCCD
            // 
            CCCD.HeaderText = "CCCD";
            CCCD.MinimumWidth = 8;
            CCCD.Name = "CCCD";
            CCCD.ReadOnly = true;
            // 
            // TongTienVay
            // 
            TongTienVay.DataPropertyName = "TongTienVay";
            TongTienVay.HeaderText = "Tổng tiền vay";
            TongTienVay.MinimumWidth = 8;
            TongTienVay.Name = "TongTienVay";
            TongTienVay.ReadOnly = true;
            // 
            // TongTienDaTra
            // 
            TongTienDaTra.DataPropertyName = "TongTienDaTra";
            TongTienDaTra.HeaderText = "Tổng tiền đã trả";
            TongTienDaTra.MinimumWidth = 8;
            TongTienDaTra.Name = "TongTienDaTra";
            TongTienDaTra.ReadOnly = true;
            // 
            // Debt
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1600, 1250);
            Controls.Add(lblTitle);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(dgvDebt);
            Name = "Debt";
            Text = "Debt Management";
            ((System.ComponentModel.ISupportInitialize)dgvDebt).EndInit();
            dgvDebt.CellDoubleClick += dgvDebt_CellDoubleClick;
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridViewTextBoxColumn MaSoNo;
        private DataGridViewTextBoxColumn MaKhoanVay;
        private DataGridViewTextBoxColumn TenKH;
        private DataGridViewTextBoxColumn CCCD;
        private DataGridViewTextBoxColumn TongTienVay;
        private DataGridViewTextBoxColumn TongTienDaTra;
    }
}
