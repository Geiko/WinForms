using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms14
{
    public partial class MyForm : Form
    {

        public MyStatic label;

        const int minSize = 10;



        public MyForm()
        {
            this.Size = new Size(600, 400);
            this.MouseDown += new MouseEventHandler(MouseDownHandler);
            this.MouseUp += new MouseEventHandler(MousUpHandler);
        }



        private void MouseDownHandler(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                label = new MyStatic();
                label.Location = new Point(e.X, e.Y);
            }
        }



        private void MousUpHandler(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                SetRect(out label, e);
                if (label.Size.Width < minSize || label.Size.Height < minSize)
                {
                    MessageBox.Show("Minimal size of static is 10x10 pixels!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    label.Dispose();
                    return;
                }
                label.BorderStyle = BorderStyle.FixedSingle;
                Controls.Add(label);
            }
        }



        public void SetRect(out MyStatic rect, MouseEventArgs e)
        {
            int left;
            if (this.label.Location.X < e.X)
                left = this.label.Location.X;
            else left = e.X;
            int upper;
            if (this.label.Location.Y < e.Y)
                upper = this.label.Location.Y;
            else upper = e.Y;

            int width = Math.Abs(e.X - this.label.Location.X);
            int height = Math.Abs(e.Y - this.label.Location.Y);

            rect = new MyStatic();
            rect.Location = new Point(left, upper);
            rect.Size = new Size(width, height);
        }
    }
}
