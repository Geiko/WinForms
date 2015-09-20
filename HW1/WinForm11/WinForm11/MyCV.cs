using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geiko.WinForm11
{
    /// <summary>
    /// This is class of my cucurriculum vitae.
    /// </summary>
    public partial class MyCV : Form
    {

        Button button;



        /// <summary>
        /// This is a constructor.
        /// </summary>
        /// <param name="caption">title of the windows</param>
        public MyCV(string caption)
        {
            Text = caption;
            StartPosition = FormStartPosition.Manual;
            Size = new System.Drawing.Size(300, 150);
            Opacity = .85;
            BackColor = Color.GreenYellow;

            button = new Button();
            button.Text = "Read";
            button.Location = new System.Drawing.Point(30, 30);
            AcceptButton = button;
            Controls.Add(button);
            button.BackColor = Color.Coral;

            button.Click += new EventHandler(button_Click);
        }


        /// <summary>
        /// It shows my CV.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, EventArgs e)
        {
            string cv1 = "Hello! My name is Kostiantyn Geiko. \nI am glad to see you on my cv's page. \n\nTECHNOLOGY SUMMARY:\n- OOP, C++, WinAPI; \n- .NET Framework programming with C# , WinForms; \n- MS SQL Server, ADO.NET; \n- JavaScript, HTML, XML, CSS; \n- VisualStudio 2015, TFS, Scrum, GitHub; \n- Windows Vista/7/8.1/10.";
            string cv2 = "\n\nPROFESSIONAL SUMMARY: \n- Object oriented programming, \n- Working with design patterns, \n- Practice with MS SQL Server \nat computer academy for 1.5 year.";
            string cv3 = "\n\nEDUCATION:\nUndergraduate, Computer Software Engineering \nComputer Academy, Dnepropetrovsk, Ukraine\n\nPhD, Science of material \nEngineer's degree, Metallurgy - Tube production";
            string cv4 = "\n\nMY PROJECTS - https://github.com/geiko \nUpper intermediate English. \nI am open to any kind of cooperation.";

            string[] cv = { cv1, cv2, cv3, cv4 };

            int SymbolsNumber = 0;
            foreach (string str in cv)
            {
                if (str == null)
                    continue;
                SymbolsNumber += str.Length;
            }
            int averageSymbolsNumber = SymbolsNumber / cv.Length;
            string title = "Average messageBox symbol's number is " + averageSymbolsNumber as string +
                "  ( " + SymbolsNumber as string + " / " + cv.Length as string + " )";

            for (int i = 0; i < cv.Length; i++)
            {
                if (cv[i] == null)
                    cv[i] = "";
                if (i < cv.Length - 1)
                    MessageBox.Show(cv[i], "Curriculum Vitae");
                else
                    MessageBox.Show(cv[i], title);
            }
        }
    }
}
