using System.Windows.Forms;

namespace WinForms22.Utilities
{
    /// <summary>
    /// It is interface for saving information about all Persons to a file.
    /// </summary>
    public interface IExporter
    {
        /// <summary>
        /// It saves all Person's info to a file.
        /// </summary>
        /// <param name="listBox1">Instance of ListBox.</param>
        /// <returns></returns>
        bool Save(ListBox listBox1);
    }
}
