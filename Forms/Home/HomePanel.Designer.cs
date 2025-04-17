namespace TinDungNganHang.Forms.Home
{
    partial class HomePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePanel));
            SuspendLayout();
            // 
            // HomePanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(1600, 1250);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HomePanel";
            Text = "HomePanel";
            Load += HomePanel_Load;
            ResumeLayout(false);
        }
    }
}