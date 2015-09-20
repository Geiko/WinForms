using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms14
{
    public class MyStatic : Label
    {
        public MyStatic()
        {
            this.MouseDown += MyStatic_MouseDown;
            this.MouseDoubleClick += MyStatic_DoubleClick;
        }



        private void MyStatic_DoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Dispose();
            }
        }



        private void MyStatic_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.Parent.Text = "This static's square : " + 
                    (this.Size.Width * this.Size.Height).ToString() + 
                    " & location :  " + this.Location.ToString();
            }
        }

    }
}
