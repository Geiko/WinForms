/*
    4.1. Разработать текстовый редактор, 
         организовать открытие \ сохранение текстовых файлов. 

    1.  В панели инструментов расположить кнопки 
    ( 
        Открыть, 
        сохранить, 
        новый документ, 
        копировать, 
        вырезать, 
        вставить, 
        отменить, 
        кнопка настройки редактора 
        (
            цвет шрифта, 
            цвет фона, 
            ШРИФт
        )
    ). 
     
    2.  Меню должно дублировать панель инструментов 
        (
            + выделить всё, 
            + сохранить как
        ). 

    3.  В Заголовке окна находиться полный путь к файлу. 

    4.  Организовать контекстное меню для окна редактора     (         Копировать,         Вырезать,         Вставить,         Отменить    ). */

using System;
using System.Windows.Forms;

namespace WinForms41
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
            Application.Run(new ElementaryEditor());
        }
    }
}
