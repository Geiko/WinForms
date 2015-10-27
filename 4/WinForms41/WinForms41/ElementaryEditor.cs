using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WinForms41
{
    /// <summary>
    /// It represents a Text Editor.
    /// </summary>
    public partial class ElementaryEditor : Form
    {
        /// <summary>
        /// It is container for changes of the text.
        /// </summary>
        public Queue<String> textModifications;

        /// <summary>
        /// It is a size of the container.
        /// </summary>
        private const int limit = 2;


        /// <summary>
        /// It is a constructor.
        /// </summary>
        public ElementaryEditor()
        {
            InitializeComponent();
            textModifications = new Queue<string>(limit);
        }
        

        /// <summary>
        /// It is a handler for opening a file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog(); 
            open.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt||";
            open.FilterIndex = 2;
            if (open.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = File.OpenText(open.FileName))
                {
                    textBox1.Text = reader.ReadToEnd();
                    this.Text = open.FileName;
                }
            }
        }


        /// <summary>
        /// It is a handler for saving a file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(this.Text))
            {
                writer.Write(textBox1.Text);
            }
        }


        /// <summary>
        /// It is a handler for new document.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewDoc_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }


        /// <summary>
        /// It is a handler for copying a selected text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Copy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.SelectedText) == false)
            {
                Clipboard.SetText(textBox1.SelectedText);
            }
            else
            {
                MessageBox.Show("No text selected in textBox1");
            }
        }


        /// <summary>
        /// It is a handler for pasting  text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Paste_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Insert(textBox1.SelectionStart, Clipboard.GetText());
        }


        /// <summary>
        /// It is handler for cutting text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.SelectedText) == false)
            {
                Clipboard.SetText(textBox1.SelectedText);
                textBox1.Text = textBox1.Text.Remove(textBox1.SelectionStart, textBox1.SelectionLength);
            }
            else
            {
                MessageBox.Show("No text selected in textBox1");
            }
        }


        /// <summary>
        /// It is handler for saving the last text change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _TextChanged(object sender, EventArgs e)
        {
            if(textModifications.Count >= limit)
            {
                textModifications.Dequeue();
            }
            textModifications.Enqueue(textBox1.Text);
        }


        /// <summary>
        /// It is handler for saving the last text change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Undo_Click(object sender, EventArgs e)
        {
            if(textModifications.Count >= limit)
                textBox1.Text = textModifications.Dequeue();
        }


        /// <summary>
        /// It is a handler for painting of letters.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void foreColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = MyDialog.Color;
            }
        }


        /// <summary>
        /// It is color for painting of text background.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = MyDialog.Color;
            }
        }


        /// <summary>
        ///It is a handler for changing a font.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void font_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();
            fontDialog1.Font = textBox1.Font;
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }


        /// <summary>
        /// It is a handler for saving with new name.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAs_Click(object sender, EventArgs e)
        {
            saveAs();
        }


        /// <summary>
        /// It is a handler for saving with new name.
        /// </summary>
        private void saveAs()
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(save.FileName))
                {
                    writer.Write(textBox1.Text);
                }
            }
        }


        /// <summary>
        /// It is a handler for exiting.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save changes?", "", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                saveAs();
            }
            this.Close();
        }


        /// <summary>
        /// It is a handler for selecting all text in the window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
                textBox1.SelectAll();
        }
        
    }
}
