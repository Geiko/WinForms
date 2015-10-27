using System;
using System.IO;
using System.Windows.Forms;

namespace WinForms31
{
    /// <summary>
    /// It is child form to determine a folder and a file mask, and to find those files.
    /// </summary>
    public partial class Form2 : Form
    {
        /// <summary>
        /// It is reference to parent listbox.
        /// </summary>
        ListBox parentListBox;


        /// <summary>
        /// It is a constructor.
        /// </summary>
        /// <param name="parentListBox">It is reference to parent listbox.</param>
        public Form2(ListBox parentListBox)
        {
            InitializeComponent();
            this.parentListBox = parentListBox;
        }


        /// <summary>
        /// It determins pattern of a mask when form loading.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxMask.Text = "*.*";
        }



        /// <summary>
        /// It determins a folder.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowsDialog = new FolderBrowserDialog();
            folderBrowsDialog.ShowNewFolderButton = false;

            if (folderBrowsDialog.ShowDialog() == DialogResult.OK)
            {
                labelFolder.Text = folderBrowsDialog.SelectedPath;
            }
        }



        /// <summary>
        /// It finds an array of paths to the files.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(labelFolder.Text))
            {
                MessageBox.Show("Please, choose a folder.");
                return;
            }

            string[] FilePaths = null;

            try
            {
                FilePaths = Directory.GetFiles(labelFolder.Text, textBoxMask.Text,
                    SearchOption.AllDirectories);

                parentListBox.Items.Clear();

                foreach (string filePath in FilePaths)
                {
                    parentListBox.Items.Add(Path.GetFileName(filePath));
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show( ex.ToString());
            }
            finally
            {
                this.Close();
            }
        }


        /// <summary>
        /// It is a handler for cancel click button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}