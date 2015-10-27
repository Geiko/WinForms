using System.Windows.Forms;

namespace WinForms22.Utilities.Import
{
    /// <summary>
    /// It is interface for loading information about all Persons from a file to ListBox.
    /// </summary>
    public interface IImporter
    {
        /// <summary>
        /// It loads all Person's info from a file.
        /// </summary>
        /// <param name="listBox1">Instance of ListBox.</param>
        void Load(ListBox listBox1);
    }
}
