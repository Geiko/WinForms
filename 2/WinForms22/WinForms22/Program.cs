/*
    Задание 2. 

    Написать  приложение – анкету,  которую  предлагается  заполнить пользователю: 
        - имя, 
        - фамилия, 
        - e-mail, 
        - телефон. 

    После нажатия на кнопку «Добавить» Информация о пользователе попадает в ListBox, 
    в котором храниться информация о всех пользователях.
      
    Также, в ListBox,  по клику на строку с информацией о пользователе следует предусмотреть 
    возможность удаления пользователя из коллекции элементов ListBox, 
    а также редактирования. 

    Редактирование информации о пользователе производиться путем подстановки данных из ListBox, 
    в соответствующие поля  для ввода новой информации. 
    
    Предусмотреть:
     - экспорт/импорт всей информации о пользователях в текстовый файл
     - экспорт/импорт всей информации о пользователях в *.xml файл
 
*/

using System;
using System.Windows.Forms;
using WinForms22.Utilities;
using WinForms22.Utilities.Export;
using WinForms22.Utilities.Import;

namespace WinForms22
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IExporter exporter = new XmlDOMExporter();
            IImporter importer = new XmlDOMImporter();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(exporter, importer));
        }
    }
}
