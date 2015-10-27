/*
5. Разработать приложение "убегающий статик" :). 
Суть приложения: 
на форме расположен статический элемент управления ("статик"). 
Пользователь пытается подвести курсор мыши к "статику", и, если 
курсор находиться близко со статиком, элемент управления "убегает". 
Предусмотреть перемещение "статика" только в пределах формы. 
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms15
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
