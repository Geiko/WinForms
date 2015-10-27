/*
    1. Написать  приложение,  которое  отображает  количество  текста,   
    прочитанного из файла с помощью ProgressBar.
*/

using System;
using System.Windows.Forms;

namespace geiko.WF21
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
            Application.Run( new Form1{ Path = @".\cat.txt" });
        }
    }
}

