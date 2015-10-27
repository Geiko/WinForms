using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms13
{
    /// <summary>
    /// This class represents work of mouse.
    /// </summary>
    public partial class MouseWork : Form
    {
        /// <summary>
        /// This is constructor.
        /// </summary>
        public MouseWork()
        {
            this.Size = new Size(500, 300);
            this.MouseDown += new MouseEventHandler(MouseButtonHandler);
            this.MouseMove += new MouseEventHandler(ShowMouseCoordinates);
        }

        /// <summary>
        /// This handles mouse buttons clics.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MouseButtonHandler(object sender, MouseEventArgs e)
        {
            int indent = 10;
            if (e.Button == MouseButtons.Left)
            {
                if (e.X == ClientSize.Width - indent && e.Y > indent && e.Y < ClientSize.Height ||
                    e.X == indent+1 && e.Y > indent && e.Y < ClientSize.Height ||
                    e.Y == ClientSize.Height - indent && e.X > indent && e.X < ClientSize.Width ||
                    e.Y == indent+1 && e.X > indent && e.X < ClientSize.Width)
                    Text = "Mouse is ON A BOUNDARY of Rectangle.";
                else if (e.X < indent+1 || e.X >= ClientSize.Width - indent || e.Y < indent+1 || e.Y >= ClientSize.Height - indent)
                    Text = "Mouse is OUT of Rectangle.";
                else if (e.X >= indent+1 && e.X < ClientSize.Width - indent && e.Y >= indent+1 && e.Y < ClientSize.Height - indent)
                    Text = "Mouse is IN of Rectangle.";

                if (Form.ModifierKeys == Keys.Control)
                    Application.ExitThread();
            }
            if (e.Button == MouseButtons.Right)
            {
                Text = "Client scope window size : " + ClientSize.ToString();
            }
        }

        /// <summary>
        /// This handles movements of mouse and shows mouse coordinates.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowMouseCoordinates(object sender, MouseEventArgs e)
        {
            Text = "Mouse position: х=" + e.X.ToString() + "; y=" + e.Y.ToString();
        }
    }
}
