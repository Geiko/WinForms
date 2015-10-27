/*
3. Представьте, что у вас на форме есть прямоугольник, границы 
которого на 10 пикселей отстоят от границ рабочей области формы. 

Необходимо создать следующие обработчики: 

a. Обработчик нажатия левой кнопки мыши , который выводит 
сообщение о том, где находится текущая точка: внутри пря-
моугольника, снаружи, на границе прямоугольника. Если при 
нажатии  левой  кнопки  мыши  была нажата  кнопка Control 
(Ctrl), то приложение должно закрываться. 

b. Обработчик нажатия правой кнопки мыши, который выводит 
в заголовок окна информацию о размере клиентской (рабо-
чей) области окна в виде: Ширина = x, Высота = y, где x и y 
- соответствующие параметры вышего окна. 

c. Обработчик перемещения указателя мыши в пределах рабо-
чей области, который должен выводить в заголовок окна те-
кущие координаты мыши x и y. 
*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms13
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
            Application.Run(new MouseWork());
        }
    }
}
