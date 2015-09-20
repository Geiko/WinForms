using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            date.CustomFormat = "HH : mm : ss, MMMM dd, yyyy - dddd";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = date.Value - DateTime.Now;

            if (year.Checked == true)
                result.Text = (((float)elapsedTime.Days) / 365).ToString("0.0");

            else if (month.Checked == true)
                result.Text = (((float)elapsedTime.Days) / 30.5).ToString("0.0");

            else if (day.Checked == true)
                result.Text = elapsedTime.TotalDays.ToString("0.0");

            else if (hour.Checked == true)
                result.Text = elapsedTime.TotalHours.ToString("0.0");

            else if (min.Checked == true)
                result.Text = elapsedTime.TotalMinutes.ToString("0.0");

            else if (sec.Checked == true)
                result.Text = elapsedTime.TotalSeconds.ToString("0");
        }
    }
}
