using geiko.WF21.Utilities;
using System;
using System.IO;
using System.Windows.Forms;

namespace geiko.WF21
{
    /// <summary>
    /// This main place to communicate with user.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// It is path to the tested file.
        /// </summary>
        public string Path { get; set; }


        /// <summary>
        /// It is constructor of this form.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
        }


        /// <summary>
        /// It handles beginning of file reading, subscribes for events of 
        /// reading progress and finish of reading, catches exceptions of reading 
        /// and reports about exceptions to user.
        /// </summary>
        /// <param name="sender">Object that generates this event.</param>
        /// <param name="e">Arguments.</param>
        private void start_Click(object sender, EventArgs e)
        {
            FileReader fr = new FileReader();
            fr.ReportProgress += new ProgressBarHandler(Read_ReportProgress2);
            fr.ReportSuccess += new SuccessHandler(Read_Success);
            try
            {
                fr.Read(Path);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// It handles progress for 1%.
        /// </summary>
        /// <param name="sender">Object that generates this event.</param>
        /// <param name="e">Arguments.</param>
        private void Read_ReportProgress(object sender, ProgressBarEventArgs e)
        {
            progressBar1.Value = e.Stage;
            Text = e.Stage + "%";
        }


        /// <summary>
        /// Other way to handle progress for 1%.
        /// </summary>
        /// <param name="sender">Object that generates this event.</param>
        /// <param name="e">Arguments.</param>
        private void Read_ReportProgress2(object sender, ProgressBarEventArgs e)
        {
            progressBar1.Increment(1);
            Text = progressBar1.Value + "%";
        }


        /// <summary>
        /// It handles end of reading by reporting to a user.
        /// </summary>
        /// <param name="sender">Object that generates this event.</param>
        /// <param name="e">Arguments.</param>
        private void Read_Success(object sender, EventArgs e)
        {
            MessageBox.Show("Reading is completed successfully.");
        }
    }
}
