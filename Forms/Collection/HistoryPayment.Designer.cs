namespace TinDungNganHang.Forms.Collection
{
    partial class HistoryPayment
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvHistory;
        private Label lblTitle;

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
            dgvHistory = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(644, 52);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(249, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Lịch sử trả nợ";
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.ColumnHeadersHeight = 34;
            dgvHistory.Location = new Point(12, 136);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersWidth = 62;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new Size(1576, 1102);
            dgvHistory.TabIndex = 1;
            // 
            // HistoryPayment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1600, 1250);
            Controls.Add(lblTitle);
            Controls.Add(dgvHistory);
            Name = "HistoryPayment";
            Text = "Lịch sử trả nợ";
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}