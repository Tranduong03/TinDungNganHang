namespace TinDungNganHang.Forms.Home
{
    partial class HomePanel
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTotalLoans;
        private Label lblTotalLoanAmount;
        private Label lblTotalPaid;
        private Label lblOverdueLoans;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTotalLoans = new Label();
            lblTotalLoanAmount = new Label();
            lblTotalPaid = new Label();
            lblOverdueLoans = new Label();
            SuspendLayout();
            // 
            // lblTotalLoans
            // 
            lblTotalLoans.AutoSize = true;
            lblTotalLoans.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalLoans.Location = new Point(50, 50);
            lblTotalLoans.Name = "lblTotalLoans";
            lblTotalLoans.Size = new Size(300, 38);
            lblTotalLoans.Text = "Tổng số khoản vay: ...";
            // 
            // lblTotalLoanAmount
            // 
            lblTotalLoanAmount.AutoSize = true;
            lblTotalLoanAmount.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalLoanAmount.Location = new Point(50, 110);
            lblTotalLoanAmount.Name = "lblTotalLoanAmount";
            lblTotalLoanAmount.Size = new Size(360, 38);
            lblTotalLoanAmount.Text = "Tổng số tiền cho vay: ...";
            // 
            // lblTotalPaid
            // 
            lblTotalPaid.AutoSize = true;
            lblTotalPaid.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalPaid.Location = new Point(50, 170);
            lblTotalPaid.Name = "lblTotalPaid";
            lblTotalPaid.Size = new Size(290, 38);
            lblTotalPaid.Text = "Tổng tiền đã thu: ...";
            // 
            // lblOverdueLoans
            // 
            lblOverdueLoans.AutoSize = true;
            lblOverdueLoans.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblOverdueLoans.Location = new Point(50, 230);
            lblOverdueLoans.Name = "lblOverdueLoans";
            lblOverdueLoans.Size = new Size(320, 38);
            lblOverdueLoans.Text = "Số khoản vay quá hạn: ...";
            // 
            // StatisticsPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 400);
            Controls.Add(lblTotalLoans);
            Controls.Add(lblTotalLoanAmount);
            Controls.Add(lblTotalPaid);
            Controls.Add(lblOverdueLoans);
            Name = "StatisticsPanel";
            Text = "Thống kê";
            Load += HomePanel_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}