/*
    2. Написать   функцию,   которая   "угадывает"   задуманное   пользователем число от 1 до 2000. 

    Для запроса к пользователю использовать MessageBox. 

    После того, как число отгадано, необходимо вывести количество запросов, потребовавшихся для этого,
    и предоставить пользователю возможность сыграть еще раз, не выходя из программы. 

    (MessageBox'ы оформляются кнопками и значками соответственно ситуации).
*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geiko.WinForms12
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
            Application.Run(new Guesswork());
        }
    }
}
