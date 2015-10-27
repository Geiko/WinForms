using System;
using System.Windows.Forms;

namespace WinForms31
{
    /// <summary>
    /// It is main parent form for starting of a search and refreshing a result.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// It is a reference to child form.
        /// </summary>
        Form2 searchForm;


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
            searchForm = new Form2(this.listBoxFile);
            searchForm.Show();            
        }
    }
}
