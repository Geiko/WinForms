using System;             
using System.IO;
using System.Windows.Forms;

namespace WinForms51
{
    /// <summary>
    /// It is a main form of the Application. The TreeView is situated here.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// It is a constructor.
        /// </summary>
        public Form1 ()
        {
            InitializeComponent ();
        }


        /// <summary>
        /// It is handler of an event - Loading this form.
        /// Thee root folder is determined here.
        /// It is added to the TreeView.
        /// The Recursion function (ProcessDirectory) srarts here.
        /// </summary>
        /// <param name="sender">Form1.</param>
        /// <param name="e">Event arguments are empty.</param>
        private void Form1_Load ( object sender, EventArgs e )
        {
            FolderBrowserDialog folderBrowsDialog = new FolderBrowserDialog ();
            string root = folderBrowsDialog.RootFolder.ToString ();         
            string pathRoot = Directory.GetDirectoryRoot ( root );     

            TreeNode rootNode = new TreeNode ( root );
            this.treeView1.Nodes.Add ( rootNode );
                                                  
            if ( Directory.Exists ( pathRoot ) )
            {                                                            
                ProcessDirectory ( pathRoot, rootNode );
            }
            else
            {
                MessageBox.Show ( string.Format ( "\"{0}\" is not a valid directory.", root ) );
            }    
        }


        /// <summary>                                         
        /// Recursive function traverses through directories.
        /// </summary>
        /// <param name="pathParent"></param>
        /// <param name="parent"></param>                                                                       
        public void ProcessDirectory ( string pathParent, TreeNode parent )
        {
            try
            {                    
                // Recurse into subdirectories of this directory.
                string [] subdirectoryEntries = Directory.GetDirectories ( pathParent );
                TreeNode folderNode;
                foreach ( string subdirectory in subdirectoryEntries )
                {  
                        folderNode = new TreeNode ( new DirectoryInfo ( subdirectory ).Name );
                        parent.Nodes.Add ( folderNode );      
                        ProcessDirectory ( subdirectory, folderNode );                        
                }                             

                // Process the list of files found in the directory.
                string [] fileEntries = Directory.GetFiles ( pathParent );
                TreeNode fileNode;
                foreach ( string fileName in fileEntries )
                {                                                             
                    fileNode = new TreeNode ( Path.GetFileName ( fileName ) );
                    parent.Nodes.Add ( fileNode );
                }
            }                      
            catch ( UnauthorizedAccessException )
            {
                // ok, so we are not allowed to dig into that directory. Move on.
               // http://stackoverflow.com/questions/1393178/unauthorizedaccessexception-cannot-resolve-directory-getfiles-failure
            }
        }


             
    }
}
