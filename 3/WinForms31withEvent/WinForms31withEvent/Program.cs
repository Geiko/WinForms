/*
    Разработайте программу, которая позволяет пользователю осуществлять поиск файлов по заданному критерию. 
    Приложение состоит из двух форм – главное окно и окно поиска. 
    Пользователь может открыть сколько угодно окон для поиска. 
    Окно поиска запускается немодально. 
    В окне поиска пользователь выбирает папку, в которой будет идти поиск и вводит маску поиска, например «*.doc». 
    Найденные файлы отображаются в списке.
*/

using System;
using System.Windows.Forms;

namespace WinForms31withEvent
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
            Application.Run(new Form1());
        }
    }
}
