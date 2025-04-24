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
        private Label lblCCCD;
        private TextBox txtCCCD;


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
            lblCCCD = new Label();
            txtCCCD = new TextBox();
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
            lblTitle.Location = new Point(163, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(361, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "💳 Debt Payment";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLoanId
            // 
            lblLoanId.AutoSize = true;
            lblLoanId.Font = new Font("Bookman Old Style", 12F);
            lblLoanId.Location = new Point(45, 110);
            lblLoanId.Name = "lblLoanId";
            lblLoanId.Size = new Size(113, 27);
            lblLoanId.TabIndex = 1;
            lblLoanId.Text = "Loan ID:";
            // 
            // txtLoanId
            // 
            txtLoanId.BorderStyle = BorderStyle.None;
            txtLoanId.Font = new Font("Segoe UI", 12F);
            txtLoanId.Location = new Point(230, 105);
            txtLoanId.Name = "txtLoanId";
            txtLoanId.ReadOnly = true;
            txtLoanId.Size = new Size(320, 32);
            txtLoanId.TabIndex = 2;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Bookman Old Style", 12F);
            lblCustomerName.Location = new Point(45, 160);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(135, 27);
            lblCustomerName.TabIndex = 3;
            lblCustomerName.Text = "Customer:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new Font("Segoe UI", 12F);
            txtCustomerName.Location = new Point(230, 155);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new Size(320, 39);
            txtCustomerName.TabIndex = 4;
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Font = new Font("Bookman Old Style", 12F);
            lblCCCD.Location = new Point(45, 215);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(93, 27);
            lblCCCD.TabIndex = 5;
            lblCCCD.Text = "CCCD:";
            // 
            // txtCCCD
            // 
            txtCCCD.Font = new Font("Segoe UI", 12F);
            txtCCCD.Location = new Point(230, 210);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.ReadOnly = true;
            txtCCCD.Size = new Size(320, 39);
            txtCCCD.TabIndex = 6;
            // 
            // lblAmountOwed
            // 
            lblAmountOwed.AutoSize = true;
            lblAmountOwed.Font = new Font("Bookman Old Style", 12F);
            lblAmountOwed.Location = new Point(45, 270);
            lblAmountOwed.Name = "lblAmountOwed";
            lblAmountOwed.Size = new Size(187, 27);
            lblAmountOwed.TabIndex = 7;
            lblAmountOwed.Text = "Amount Owed:";
            // 
            // txtAmountOwed
            // 
            txtAmountOwed.Font = new Font("Segoe UI", 12F);
            txtAmountOwed.Location = new Point(230, 265);
            txtAmountOwed.Name = "txtAmountOwed";
            txtAmountOwed.ReadOnly = true;
            txtAmountOwed.Size = new Size(320, 39);
            txtAmountOwed.TabIndex = 8;
            // 
            // lblPaymentAmount
            // 
            lblPaymentAmount.AutoSize = true;
            lblPaymentAmount.Font = new Font("Bookman Old Style", 12F);
            lblPaymentAmount.Location = new Point(45, 325);
            lblPaymentAmount.Name = "lblPaymentAmount";
            lblPaymentAmount.Size = new Size(123, 27);
            lblPaymentAmount.TabIndex = 9;
            lblPaymentAmount.Text = "Payment:";
            // 
            // txtPaymentAmount
            // 
            txtPaymentAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtPaymentAmount.ForeColor = Color.DarkGreen;
            txtPaymentAmount.Location = new Point(230, 320);
            txtPaymentAmount.Name = "txtPaymentAmount";
            txtPaymentAmount.Size = new Size(320, 39);
            txtPaymentAmount.TabIndex = 10;
            txtPaymentAmount.TextChanged += txtPaymentAmount_TextChanged;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.LawnGreen;
            btnPay.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPay.ForeColor = Color.Black;
            btnPay.Location = new Point(325, 380);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(100, 45);
            btnPay.TabIndex = 11;
            btnPay.Text = "✔ Pay";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightGray;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBack.Location = new Point(205, 380);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 45);
            btnBack.TabIndex = 12;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(622, 460);
            Controls.Add(lblTitle);
            Controls.Add(lblLoanId);
            Controls.Add(txtLoanId);
            Controls.Add(lblCustomerName);
            Controls.Add(txtCustomerName);
            Controls.Add(lblCCCD);
            Controls.Add(txtCCCD);
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
