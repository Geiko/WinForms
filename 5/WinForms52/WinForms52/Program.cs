/*
    Задание 2. 
    Создайте приложение на базе ListView для просмотра каталога файлов в 5-ти вариантах, 
    для вариантов иконки-плитка-список_изображений отображать содержимое графических файлов.  
*/


using System;                  
using System.Windows.Forms;

namespace WinForms52
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
