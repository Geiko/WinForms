/*
    1. Вывести на экран свое (краткое !!!) резюме с помощью последова-
    тельности MessageBox'ов (числом не менее трех). 

    Причем на заголовке последнего должно отобразиться среднее число символов на странице   
    (общее   количество   символов   в   резюме   /   количество MessageBox'ов). 
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geiko.WinForm11
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyCV("Curriculum Vitae"));
        }
    }
}
