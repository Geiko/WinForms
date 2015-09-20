using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Определение дня недели по дате";
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            DayOfWeek res = this.dateTimePicker1.Value.DayOfWeek;
            var culture = new System.Globalization.CultureInfo("ru-RU");
            this.result.Text = culture.DateTimeFormat.GetDayName(res);
        }
    }
}
