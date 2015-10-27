using System;            
using System.Drawing;
using System.IO;                  
using System.Windows.Forms;

namespace WinForms52
{
    public partial class Form1 : Form
    {   
        string pathParent;
        string root;
                                


        public Form1 ()
        {
            InitializeComponent ();
        }



        private void Form1_Load ( object sender, EventArgs e )
        {
            try
            {
                FolderBrowserDialog folderBrowsDialog = new FolderBrowserDialog ();
                root = folderBrowsDialog.RootFolder.ToString ();
                pathParent = Directory.GetDirectoryRoot ( root );
            }
            catch ( Exception ex)
            {
                MessageBox.Show ( ex.Message );
            }
                                                             
            listView.Items.Add ( new ListViewItem ( root ) );              
            processImage ();            
            processDetailes ();
            listView.View = View.SmallIcon;
        }



        private void processDetailes ()
        {
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Columns.Add ( "Name" );
            listView.Columns.Add ( "Type" );
            listView.Columns.Add ( "Date modified" );
            listView.Columns.Add ( "Size" );
        }



        private void processImage ()
        {
            ImageList imageListSmall = new ImageList ();
            imageListSmall.Images.Add ( Bitmap.FromFile ( @"Images\folder.bmp" ) );
            imageListSmall.Images.Add ( Bitmap.FromFile ( @"Images\file.bmp" ) );
            listView.SmallImageList = imageListSmall;

            ImageList imageListLarge = new ImageList ();
            imageListLarge.Images.Add ( Bitmap.FromFile ( @"Images\largeFolder.bmp" ) );
            imageListLarge.Images.Add ( Bitmap.FromFile ( @"Images\file.bmp" ) );
            imageListLarge.ImageSize = new Size ( 38, 38 );
            listView.LargeImageList = imageListLarge;

            ImageList imageList = new ImageList ();
            imageList.Images.Add ( Bitmap.FromFile ( @"Images\folder.bmp" ) );
            imageList.Images.Add ( Bitmap.FromFile ( @"Images\file.bmp" ) );
            listView.StateImageList = imageList;

            listView.Items [ 0 ].ImageIndex = 0;
        }



        private void listView_MouseDoubleClick ( object sender, MouseEventArgs e )
        {
            try
            {
                if ( listView.SelectedItems.Count == 1 )
                {
                    if ( Directory.Exists ( pathParent ) )
                    {
                        string folderName = listView.SelectedItems [ 0 ].Text;  
                        string temp = Path.Combine ( pathParent, folderName );

                        if ( folderName != root && Directory.Exists( temp ) == true )
                        {
                            pathParent = temp;
                        }

                        if ( Directory.Exists ( pathParent ) )                                                      
                        {                         
                            ProcessDirectory ();
                        }
                    }    
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show ( ex.Message );
            }
        }



        public void ProcessDirectory ( )
        {
            try
            {
                listView.Items.Clear ();

                int i = processFolders ();         

                processFiles ( i );                                    
            }
            catch ( UnauthorizedAccessException )
            { }
        }



        // Process the list of files found in the directory. 
        private void processFiles ( int i )
        {                                                          
            DirectoryInfo di = new DirectoryInfo ( pathParent );
            FileInfo [] fiArr = di.GetFiles ();
            int k = 0;
            string [] fileEntries = Directory.GetFiles ( pathParent );
            foreach ( string file in fileEntries )
            {
                string fileName = Path.GetFileName ( file );
                listView.Items.Add ( new ListViewItem ( fileName ) );
                listView.Items [ i ].ImageIndex = 1;

                listView.Items [ i ].SubItems.Add ( Path.GetExtension ( listView.Items [ i ].Text ) );
                try
                {
                    listView.Items [ i ].SubItems.Add ( ( File.GetLastWriteTime ( pathParent + listView.Items [ i ].Text ) ).ToString () );
                }
                catch { }

                listView.Items [ i ].SubItems.Add ( ( fiArr [ k ].Length ).ToString () );
                k++;
                i++;
            }
        }



        private int processFolders ()
        {
            string [] subdirectoryEntries = Directory.GetDirectories ( pathParent );
            int i = 0;
            foreach ( string subdirectory in subdirectoryEntries )
            {
                string folderName = new DirectoryInfo ( subdirectory ).Name;
                listView.Items.Add ( new ListViewItem ( folderName ) );
                listView.Items [ i ].ImageIndex = 0;
                listView.Items [ i ].SubItems.Add ( Path.GetExtension ( listView.Items [ i ].Text ) );
                try
                {
                    listView.Items [ i ].SubItems.Add ( ( File.GetLastWriteTime ( pathParent + listView.Items [ i ].Text ) ).ToString () );
                }
                catch { }
                i++;
            }
            return i;
        }



        private void buttonUp_Click ( object sender, EventArgs e )
        {
            try
            {
                if ( pathParent != Directory.GetDirectoryRoot ( pathParent ) )
                {
                    pathParent = Directory.GetParent ( pathParent ).FullName;
                    ProcessDirectory ();
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show ( ex.Message );
            }
        }



        private void buttonSmallIcon_Click ( object sender, EventArgs e )
        {                           
            listView.View = View.SmallIcon;
            ProcessDirectory ();
        }



        private void buttonList_Click ( object sender, EventArgs e )
        {
            listView.View = View.List;
            ProcessDirectory ();
        }



        private void buttonTile_Click ( object sender, EventArgs e )
        {
            listView.View = View.Tile;
            ProcessDirectory ();
        }



        private void buttonLargeIcon_Click ( object sender, EventArgs e )
        {
            listView.View = View.LargeIcon;
            ProcessDirectory ();
        }



        private void buttonDetails_Click ( object sender, EventArgs e )
        {
            listView.View = View.Details;

            ProcessDirectory ();
                               
            //listView.Columns [ 0 ].Width = -1;     
            //listView.Columns [ 1 ].Width = -2;
            listView.AutoResizeColumns ( ColumnHeaderAutoResizeStyle.ColumnContent );
            listView.AutoResizeColumns ( ColumnHeaderAutoResizeStyle.HeaderSize );
        }



    }
}
