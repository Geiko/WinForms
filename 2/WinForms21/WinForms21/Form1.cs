using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms21
{
    public partial class Form1 : Form
    {
        string path;
        public Form1(string path)
        {
            InitializeComponent();
            this.path = path;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(this.path))
            {
                using (FileStream cat = File.OpenRead(this.path))
                {
                    long size = cat.Length;
                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = 100;
                    progressBar1.Step = 1;

                    int i = 1;
                    while (cat.ReadByte() >= 0)
                    {
                        if (cat.Position >= size / 100 * i)
                        {
                            i++;
                            progressBar1.PerformStep();
                        }
                    }
                }
                start.Text = "8=)";
            }
            else
                start.Text = "8=(";
        }
    }
}
