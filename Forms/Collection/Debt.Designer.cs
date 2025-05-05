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

            ((System.ComponentModel.ISupportInitialize)(dgvDebt)).BeginInit();
            SuspendLayout();

            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.Location = new Point(600, 30);
            lblTitle.Text = "Debt Management";

            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Bookman Old Style", 14F);
            txtSearch.Location = new Point(426, 125);
            txtSearch.PlaceholderText = "Enter Customer ID or Loan ID";
            txtSearch.Size = new Size(600, 40);

            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LawnGreen;
            btnSearch.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnSearch.Location = new Point(1061, 125);
            btnSearch.Size = new Size(150, 40);
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;

            // 
            // dgvDebt
            // 
            dgvDebt.AllowUserToAddRows = false;
            dgvDebt.AllowUserToDeleteRows = false;
            dgvDebt.ReadOnly = true;
            dgvDebt.AutoGenerateColumns = false;
            dgvDebt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDebt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDebt.Location = new Point(12, 200);
            dgvDebt.Size = new Size(1552, 980);
            dgvDebt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDebt.Name = "dgvDebt";

            // 
            // Columns
            // 
            MaSoNo.DataPropertyName = "MaSoNo";
            MaSoNo.HeaderText = "Mã sổ nợ";
            MaSoNo.Name = "MaSoNo";
            MaSoNo.MinimumWidth = 100;

            MaKhoanVay.DataPropertyName = "MaKhoanVay";
            MaKhoanVay.HeaderText = "Mã khoản vay";
            MaKhoanVay.Name = "MaKhoanVay";
            MaKhoanVay.MinimumWidth = 100;

            TenKH.DataPropertyName = "TenKH";
            TenKH.HeaderText = "Tên khách hàng";
            TenKH.Name = "TenKH";
            TenKH.MinimumWidth = 150;

            CCCD.DataPropertyName = "CCCD";
            CCCD.HeaderText = "CCCD";
            CCCD.Name = "CCCD";
            CCCD.MinimumWidth = 150;

            TongTienVay.DataPropertyName = "TongTienVay";
            TongTienVay.HeaderText = "Tổng tiền vay";
            TongTienVay.Name = "TongTienVay";
            TongTienVay.MinimumWidth = 150;

            TongTienDaTra.DataPropertyName = "TongTienDaTra";
            TongTienDaTra.HeaderText = "Tổng tiền đã trả";
            TongTienDaTra.Name = "TongTienDaTra";
            TongTienDaTra.MinimumWidth = 150;

            dgvDebt.Columns.AddRange(new DataGridViewColumn[]
            {
                MaSoNo, MaKhoanVay, TenKH, CCCD, TongTienVay, TongTienDaTra
            });

            // 
            // Debt Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 1250);
            BackColor = Color.White;
            Text = "Debt Management";
            Controls.Add(lblTitle);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(dgvDebt);
            Name = "Debt";

            dgvDebt.CellDoubleClick += dgvDebt_CellDoubleClick;

            ((System.ComponentModel.ISupportInitialize)dgvDebt).EndInit();
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
