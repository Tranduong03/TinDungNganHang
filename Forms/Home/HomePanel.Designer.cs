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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePanel));
            lblTotalLoans = new Label();
            lblTotalLoanAmount = new Label();
            lblTotalPaid = new Label();
            lblOverdueLoans = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            textBox2 = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            textBox4 = new TextBox();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            panel4 = new Panel();
            textBox3 = new TextBox();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel5 = new Panel();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lblTotalLoans
            // 
            lblTotalLoans.AutoSize = true;
            lblTotalLoans.Font = new Font("Bookman Old Style", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalLoans.Location = new Point(5, 5);
            lblTotalLoans.Name = "lblTotalLoans";
            lblTotalLoans.Size = new Size(249, 31);
            lblTotalLoans.TabIndex = 0;
            lblTotalLoans.Text = "Tổng số khoản vay";
            // 
            // lblTotalLoanAmount
            // 
            lblTotalLoanAmount.AutoSize = true;
            lblTotalLoanAmount.Font = new Font("Bookman Old Style", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalLoanAmount.Location = new Point(5, 5);
            lblTotalLoanAmount.Name = "lblTotalLoanAmount";
            lblTotalLoanAmount.Size = new Size(273, 31);
            lblTotalLoanAmount.TabIndex = 1;
            lblTotalLoanAmount.Text = "Tổng số tiền cho vay";
            // 
            // lblTotalPaid
            // 
            lblTotalPaid.AutoSize = true;
            lblTotalPaid.Font = new Font("Bookman Old Style", 13F);
            lblTotalPaid.Location = new Point(5, 5);
            lblTotalPaid.Name = "lblTotalPaid";
            lblTotalPaid.Size = new Size(224, 31);
            lblTotalPaid.TabIndex = 2;
            lblTotalPaid.Text = "Tổng tiền đã thu";
            // 
            // lblOverdueLoans
            // 
            lblOverdueLoans.AutoSize = true;
            lblOverdueLoans.Font = new Font("Bookman Old Style", 13F);
            lblOverdueLoans.Location = new Point(5, 5);
            lblOverdueLoans.Name = "lblOverdueLoans";
            lblOverdueLoans.Size = new Size(259, 31);
            lblOverdueLoans.TabIndex = 3;
            lblOverdueLoans.Text = "Khoản vay quá hạn";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblTotalLoans);
            panel1.Location = new Point(30, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 200);
            panel1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            textBox1.Location = new Point(14, 55);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 89);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 160);
            label1.Name = "label1";
            label1.Size = new Size(151, 27);
            label1.TabIndex = 2;
            label1.Text = "Since active";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(284, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lblTotalLoanAmount);
            panel2.Location = new Point(430, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 200);
            panel2.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(14, 55);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(264, 89);
            textBox2.TabIndex = 5;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 160);
            label2.Name = "label2";
            label2.Size = new Size(151, 27);
            label2.TabIndex = 4;
            label2.Text = "Since active";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(285, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(lblOverdueLoans);
            panel3.Location = new Point(430, 260);
            panel3.Name = "panel3";
            panel3.Size = new Size(370, 200);
            panel3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            textBox4.Location = new Point(15, 55);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(264, 89);
            textBox4.TabIndex = 11;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 160);
            label4.Name = "label4";
            label4.Size = new Size(151, 27);
            label4.TabIndex = 10;
            label4.Text = "Since active";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(285, 5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(80, 80);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(lblTotalPaid);
            panel4.Location = new Point(30, 260);
            panel4.Name = "panel4";
            panel4.Size = new Size(370, 200);
            panel4.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            textBox3.Location = new Point(14, 55);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(264, 89);
            textBox3.TabIndex = 5;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 160);
            label3.Name = "label3";
            label3.Size = new Size(151, 27);
            label3.TabIndex = 4;
            label3.Text = "Since active";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(285, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(80, 80);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Location = new Point(830, 30);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(720, 1140);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(30, 490);
            panel5.Name = "panel5";
            panel5.Size = new Size(770, 680);
            panel5.TabIndex = 9;
            // 
            // HomePanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1578, 1194);
            Controls.Add(panel5);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "HomePanel";
            Text = "Thống kê";
            Load += HomePanel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel5;
        private TextBox textBox1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
    }
}