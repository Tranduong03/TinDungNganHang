using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinDungNganHang.Forms
{
    internal class BaseForm : Form
    {
        public BaseForm() 
        {
            //this.StartPosition = FormStartPosition.CenterScreen;
        }

        protected virtual void FormSettings()
        {
            this.Width = 2000;
            this.Height = 1250;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            var screen = Screen.PrimaryScreen!.WorkingArea;
            this.Location = new System.Drawing.Point(
                (screen.Width - this.Width) / 2,
                (screen.Height - this.Height) / 2
            );
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            FormSettings(); 
        }
    }
}
