using System;           
using System.IO;
using System.Windows.Forms;

namespace WinForms53
{
    public partial class Form1 : Form
    {
        public string BufferText
        {
            get;
            private set;
        }                                



        public Form1 ()
        {
            InitializeComponent ();
            richTextBox1.DetectUrls = true;

            richTextBox1.AllowDrop = true;            
            this.richTextBox1.DragDrop += new DragEventHandler ( _DragDrop );
            this.richTextBox1.DragEnter += new DragEventHandler ( _DragEnter );
        }



        private void _DragEnter ( object sender, DragEventArgs e )
        {
            if ( e.Data.GetDataPresent ( DataFormats.FileDrop ) )
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }



        private void _DragDrop ( object sender, DragEventArgs e )
        {
            if ( e.Data.GetDataPresent ( DataFormats.FileDrop ) )
            {
                string [] filePaths = ( string [] ) ( e.Data.GetData ( DataFormats.FileDrop ) );
                foreach ( string fileLoc in filePaths )
                {
                    if ( File.Exists ( fileLoc ) )
                    {
                        using ( TextReader tr = new StreamReader ( fileLoc ) )
                        {
                            try
                            {
                                richTextBox1.Text = ( tr.ReadToEnd () );
                            }
                            catch ( Exception ex )
                            {
                                MessageBox.Show ( ex.Message );
                            }
                        }
                    }
                }
            }
        }



        private void newToolStripMenuItem_Click_1 ( object sender, EventArgs e )
        {
            richTextBox1.Clear ();
        }



        private void openToolStripMenuItem_Click_1 ( object sender, EventArgs e )
        {                       
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";          
            if ( openFileDialog1.ShowDialog () == DialogResult.OK )
            {                                                                           
                if ( openFileDialog1.FileName.Length == 0 )
                {
                    return;
                }
                else
                {                                                      
                    using ( StreamReader reader = File.OpenText ( openFileDialog1.FileName ) )
                    {
                        richTextBox1.Text = reader.ReadToEnd ();
                        this.Text = openFileDialog1.FileName;
                    }
                } 
            }
        }



        private void saveToolStripMenuItem_Click_1 ( object sender, EventArgs e )
        {                                                                            
            if ( this.Text.Length == 0 )
            {
                return;
            }
            else
            {
                using ( StreamWriter sw = new StreamWriter ( this.Text ) )
                {
                    sw.WriteLine ( richTextBox1.Text );
                }
            }
        }



        private void saveAsToolStripMenuItem_Click_1 ( object sender, EventArgs e )
        {
            saveAs ();
        }



        private void exitToolStripMenuItem_Click_1 ( object sender, EventArgs e )
        {                     
            DialogResult result = MessageBox.Show ( "Do you want to save changes?", "", MessageBoxButtons.YesNo );
            if ( result == DialogResult.Yes )
            {
                saveAs ();
            }
            this.Close ();
        }



        private void saveAs ()
        {
            if ( saveFileDialog1.ShowDialog () == DialogResult.OK )
            {
                using ( StreamWriter writer = new StreamWriter ( saveFileDialog1.FileName ) )
                {
                    writer.Write ( richTextBox1.Text );
                }
            }
        }



        private void cutToolStripMenuItem_Click_1 ( object sender, EventArgs e )
        {
            BufferText = richTextBox1.SelectedText;
            richTextBox1.SelectedText = "";
        }



        private void copyToolStripMenuItem_Click_1 ( object sender, EventArgs e )
        {                               
            BufferText = richTextBox1.SelectedText;
        }



        private void pasteToolStripMenuItem_Click_1 ( object sender, EventArgs e )
        {
            richTextBox1.SelectedText = BufferText;
        }



        private void selectAllToolStripMenuItem_Click_1 ( object sender, EventArgs e )
        {
            richTextBox1.SelectAll ();
        }



        private void undoToolStripMenuItem_Click_1 ( object sender, EventArgs e )
        {                               
            richTextBox1.Undo ();
        }



        private void redoToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            richTextBox1.Redo ();
        }



        private void toolStripMenuItem1_Click ( object sender, EventArgs e )
        {
            if ( richTextBox1.CanRedo == true )
            {
                richTextBox1.Redo ();
            }
        }



        private void customizeToolStripMenuItem_Click ( object sender, EventArgs e )
        {                   
            fontDialog1.ShowColor = true;               
            fontDialog1.Font = richTextBox1.SelectionFont;
            fontDialog1.Color = richTextBox1.SelectionColor;        
            if ( fontDialog1.ShowDialog () == DialogResult.OK )
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
                richTextBox1.SelectionColor = fontDialog1.Color;
            }
        }



        private void optionsToolStripMenuItem_Click ( object sender, EventArgs e )
        {                
            colorDialog1.Color = richTextBox1.SelectionColor;

            if ( colorDialog1.ShowDialog () == DialogResult.OK )
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }



        private void backColorToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            ColorDialog MyDialog = new ColorDialog ();
            if ( MyDialog.ShowDialog () == DialogResult.OK )
            {
                richTextBox1.BackColor = MyDialog.Color;
            }
        }                                     
    }
}
