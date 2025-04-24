namespace TinDungNganHang.Forms.Collection
{
    partial class Payment
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblLoanId;
        private TextBox txtLoanId;
        private Label lblCustomerName;
        private TextBox txtCustomerName;
        private Label lblAmountOwed;
        private TextBox txtAmountOwed;
        private Label lblPaymentAmount;
        private TextBox txtPaymentAmount;
        private Button btnPay;
        private Button btnBack;

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
            lblLoanId = new Label();
            txtLoanId = new TextBox();
            lblCustomerName = new Label();
            txtCustomerName = new TextBox();
            lblAmountOwed = new Label();
            txtAmountOwed = new TextBox();
            lblPaymentAmount = new Label();
            txtPaymentAmount = new TextBox();
            btnPay = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.MediumBlue;
            lblTitle.Location = new Point(160, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(361, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "💳 Debt Payment";
            // 
            // lblLoanId
            // 
            lblLoanId.AutoSize = true;
            lblLoanId.Font = new Font("Segoe UI", 12F);
            lblLoanId.Location = new Point(50, 100);
            lblLoanId.Name = "lblLoanId";
            lblLoanId.Size = new Size(100, 32);
            lblLoanId.TabIndex = 1;
            lblLoanId.Text = "Loan ID:";
            // 
            // txtLoanId
            // 
            txtLoanId.BorderStyle = BorderStyle.None;
            txtLoanId.Font = new Font("Segoe UI", 12F);
            txtLoanId.Location = new Point(210, 95);
            txtLoanId.Name = "txtLoanId";
            txtLoanId.ReadOnly = true;
            txtLoanId.Size = new Size(320, 32);
            txtLoanId.TabIndex = 2;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 12F);
            lblCustomerName.Location = new Point(50, 160);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(122, 32);
            lblCustomerName.TabIndex = 3;
            lblCustomerName.Text = "Customer:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new Font("Segoe UI", 12F);
            txtCustomerName.Location = new Point(210, 155);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new Size(320, 39);
            txtCustomerName.TabIndex = 4;
            // 
            // lblAmountOwed
            // 
            lblAmountOwed.AutoSize = true;
            lblAmountOwed.Font = new Font("Segoe UI", 12F);
            lblAmountOwed.Location = new Point(50, 220);
            lblAmountOwed.Name = "lblAmountOwed";
            lblAmountOwed.Size = new Size(174, 32);
            lblAmountOwed.TabIndex = 5;
            lblAmountOwed.Text = "Amount Owed:";
            // 
            // txtAmountOwed
            // 
            txtAmountOwed.Font = new Font("Segoe UI", 12F);
            txtAmountOwed.Location = new Point(210, 215);
            txtAmountOwed.Name = "txtAmountOwed";
            txtAmountOwed.ReadOnly = true;
            txtAmountOwed.Size = new Size(320, 39);
            txtAmountOwed.TabIndex = 6;
            // 
            // lblPaymentAmount
            // 
            lblPaymentAmount.AutoSize = true;
            lblPaymentAmount.Font = new Font("Segoe UI", 12F);
            lblPaymentAmount.Location = new Point(50, 280);
            lblPaymentAmount.Name = "lblPaymentAmount";
            lblPaymentAmount.Size = new Size(204, 32);
            lblPaymentAmount.TabIndex = 7;
            lblPaymentAmount.Text = "Payment Amount:";
            // 
            // txtPaymentAmount
            // 
            txtPaymentAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtPaymentAmount.ForeColor = Color.DarkGreen;
            txtPaymentAmount.Location = new Point(210, 275);
            txtPaymentAmount.Name = "txtPaymentAmount";
            txtPaymentAmount.Size = new Size(320, 39);
            txtPaymentAmount.TabIndex = 8;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.LawnGreen;
            btnPay.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPay.ForeColor = Color.Black;
            btnPay.Location = new Point(330, 350);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(100, 45);
            btnPay.TabIndex = 9;
            btnPay.Text = "✔ Pay";
            btnPay.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightGray;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBack.Location = new Point(210, 350);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 45);
            btnBack.TabIndex = 10;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 500);
            Controls.Add(lblTitle);
            Controls.Add(lblLoanId);
            Controls.Add(txtLoanId);
            Controls.Add(lblCustomerName);
            Controls.Add(txtCustomerName);
            Controls.Add(lblAmountOwed);
            Controls.Add(txtAmountOwed);
            Controls.Add(lblPaymentAmount);
            Controls.Add(txtPaymentAmount);
            Controls.Add(btnPay);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Payment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Payment";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
