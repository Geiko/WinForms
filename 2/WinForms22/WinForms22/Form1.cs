using System;
using System.Windows.Forms;
using WinForms22.Entities;
using WinForms22.Utilities;
using WinForms22.Utilities.Import;

namespace WinForms22
{
    /// <summary>
    /// This is main place to communicate with a user.
    /// </summary>
    public partial class Form1 : Form
    { 
        /// <summary>
        /// This is object to export of person's data.
        /// </summary>
        public IExporter exporter;
        /// <summary>
        /// This is object to import of person's data.
        /// </summary>
        public IImporter importer;


        /// <summary>
        /// This is constructor of Form1 instance.
        /// </summary>
        /// <param name="exporter"></param>
        /// <param name="importer"></param>
        public Form1(IExporter exporter, IImporter importer)
        {
            InitializeComponent();
            this.exporter = exporter;
            this.importer = importer;
        }


        /// <summary>
        /// This button handler creates instance of Person, validates it, 
        /// adds instance to ListBox, clears TextBoxes.
        /// </summary>
        /// <param name="sender">Object that generates this event.</param>
        /// <param name="e">Arguments.</param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person
            {
                FirstName = textFirstName.Text,
                LastName = textLastName.Text,
                EMail = textEMail.Text,
                Phone = textPhone.Text
            };

            Validator validator = new Validator();
            try
            {
                validator.Validate(person);
            }
            catch (Exception ex)
            {
                person = null;
                GC.Collect();
                MessageBox.Show(ex.Message);
                return;
            }
            listBox1.DisplayMember = "LastName";         
            listBox1.Items.Add(person);
            ClearTextBoxes();            
        }


        /// <summary>
        /// It clears fildes of TextBoxes.
        /// </summary>
        private void ClearTextBoxes()
        {
            textFirstName.Clear();
            textLastName.Clear();
            textEMail.Clear();
            textPhone.Clear();
        }


        /// <summary>
        /// It deletes or edits the clicked item of  ListBox.
        /// </summary>
        /// <param name="sender">Object that generates this event.</param>
        /// <param name="e">Arguments.</param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox1.Items.Count != 0)
            {
                if (this.listBox1.SelectedItem != null)
                {
                    DialogResult result = MessageBox.Show("Whould you like delete this item?", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        DeleteItem();
                    }
                    else
                    {
                        DialogResult res = MessageBox.Show("Are you going to edit this item?", "", MessageBoxButtons.YesNo);
                        if (res == DialogResult.Yes)
                        {
                            AssignTextBoxes();
                            DeleteItem();
                        }
                    }
                }
            }
        }



        private void DeleteItem()
        {
            //var p = listBox1.SelectedItem;
            listBox1.Items.Remove(listBox1.SelectedItem);
            //p = null;
            //GC.Collect();
        }


        /// <summary>
        /// It assigns fields of TextBoxes with Person's instance.
        /// </summary>
        private void AssignTextBoxes()
        {
            Person p = ((Person)listBox1.SelectedItem);
            this.textFirstName.Text = p.FirstName;
            this.textLastName.Text = p.LastName;
            this.textEMail.Text = p.EMail;
            this.textPhone.Text = p.Phone;
        }


        /// <summary>
        /// It loads Person's data from a file.
        /// </summary>
        /// <param name="sender">Object that generates this event.</param>
        /// <param name="e">Arguments.</param>
        private void buttonImport_Click(object sender, EventArgs e)
        {
            try
            {
                importer.Load(listBox1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// It saves Person's data to a file.
        /// </summary>
        /// <param name="sender">Object that generates this event.</param>
        /// <param name="e">Arguments.</param>
        private void buttonExport_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = exporter.Save(listBox1);
                if (result == true)
                    MessageBox.Show("Data is saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
