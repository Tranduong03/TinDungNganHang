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
        private Label lblRemainingAmount;
        private TextBox txtRemainingAmount;



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
            lblRemainingAmount = new Label();
            txtRemainingAmount = new TextBox();
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
            lblLoanId.Size = new Size(180, 27);
            lblLoanId.TabIndex = 1;
            lblLoanId.Text = "Mã Khoản Vay";
            // 
            // txtLoanId
            // 
            txtLoanId.BorderStyle = BorderStyle.None;
            txtLoanId.Font = new Font("Segoe UI", 12F);
            txtLoanId.Location = new Point(270, 102);
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
            lblCustomerName.Size = new Size(208, 27);
            lblCustomerName.TabIndex = 3;
            lblCustomerName.Text = "Tên Khách Hàng";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new Font("Segoe UI", 12F);
            txtCustomerName.Location = new Point(270, 152);
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
            lblCCCD.Size = new Size(120, 27);
            lblCCCD.TabIndex = 5;
            lblCCCD.Text = "Số CCCD";
            // 
            // txtCCCD
            // 
            txtCCCD.Font = new Font("Segoe UI", 12F);
            txtCCCD.Location = new Point(270, 207);
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
            lblAmountOwed.Size = new Size(103, 27);
            lblAmountOwed.TabIndex = 7;
            lblAmountOwed.Text = "Tổng Nợ";
            // 
            // txtAmountOwed
            // 
            txtAmountOwed.Font = new Font("Segoe UI", 12F);
            txtAmountOwed.Location = new Point(270, 267);
            txtAmountOwed.Name = "txtAmountOwed";
            txtAmountOwed.ReadOnly = true;
            txtAmountOwed.Size = new Size(320, 39);
            txtAmountOwed.TabIndex = 8;
            // 
            // lblPaymentAmount
            // 
            lblPaymentAmount.AutoSize = true;
            lblPaymentAmount.Font = new Font("Bookman Old Style", 12F);
            lblPaymentAmount.Location = new Point(45, 398);
            lblPaymentAmount.Name = "lblPaymentAmount";
            lblPaymentAmount.Size = new Size(153, 27);
            lblPaymentAmount.TabIndex = 9;
            lblPaymentAmount.Text = "Thanh Toán";
            // 
            // txtPaymentAmount
            // 
            txtPaymentAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtPaymentAmount.ForeColor = Color.DarkGreen;
            txtPaymentAmount.Location = new Point(270, 390);
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
            btnPay.Location = new Point(346, 479);
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
            btnBack.Location = new Point(148, 479);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 45);
            btnBack.TabIndex = 12;
            btnBack.Text = "← Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // lblRemainingAmount
            // 
            lblRemainingAmount.AutoSize = true;
            lblRemainingAmount.Font = new Font("Bookman Old Style", 12F);
            lblRemainingAmount.Location = new Point(45, 335);
            lblRemainingAmount.Name = "lblRemainingAmount";
            lblRemainingAmount.Size = new Size(94, 27);
            lblRemainingAmount.TabIndex = 13;
            lblRemainingAmount.Text = "Còn nợ";
            // 
            // txtRemainingAmount
            // 
            txtRemainingAmount.Font = new Font("Segoe UI", 12F);
            txtRemainingAmount.Location = new Point(270, 327);
            txtRemainingAmount.Name = "txtRemainingAmount";
            txtRemainingAmount.ReadOnly = true;
            txtRemainingAmount.Size = new Size(320, 39);
            txtRemainingAmount.TabIndex = 14;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(666, 570);
            Controls.Add(lblTitle);
            Controls.Add(lblLoanId);
            Controls.Add(txtLoanId);
            Controls.Add(lblCustomerName);
            Controls.Add(txtCustomerName);
            Controls.Add(lblCCCD);
            Controls.Add(txtCCCD);
            Controls.Add(lblAmountOwed);
            Controls.Add(txtAmountOwed);
            Controls.Add(lblRemainingAmount);
            Controls.Add(txtRemainingAmount);
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
