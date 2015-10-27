/*
        3.Создайте редактор на базе RichTextBox и добавьте в него возможность 
        выбора из каталога и просмотра содержимого файла перетаскиванием 
        файла на поле редактора. 
*/

using System;                 
using System.Windows.Forms;

namespace WinForms53
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main ()
        {
            Application.EnableVisualStyles ();
            Application.SetCompatibleTextRenderingDefault ( false );
            Application.Run ( new Form1 () );
        }
    }
}
