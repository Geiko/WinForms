using System;
using System.IO;
using System.Windows.Forms;

namespace WinForms31withEvent
{
    /// <summary>
    /// It is main parent form for starting of a search and refreshing a result.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// It is a constructor.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// It is a handler of start click button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void start_Click(object sender, EventArgs e)
        {
            Form2 searchForm = new Form2();
            searchForm.Show();
            searchForm.ReportInfo += new InfoHandler(doWork);
        }


        /// <summary>
        /// It is a handler for information from second window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doWork(object sender, MessageToParentEventArgs e)
        {
            this.listBoxFile.Items.Clear();

            foreach (string filePath in e.UrgentInfo)
            {
                this.listBoxFile.Items.Add(Path.GetFileName(filePath));
            }
        }
    }
}
