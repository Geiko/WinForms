using System.IO;
using System.Text;
using System.Windows.Forms;
using WinForms22.Entities;

namespace WinForms22.Utilities.Export
{
    /// <summary>
    /// It is for saving all information from ListBox to *.txt file.
    /// </summary>
    class TextExporter : IExporter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listBox1">Instance of ListBox.</param>
        /// <returns></returns>
        public bool Save(ListBox listBox1)
        {
            using (StreamWriter writer = new StreamWriter(@"TXTFile.txt", false, Encoding.GetEncoding(1251)))
            {
                writer.WriteLine("List of Persons");
                foreach (Person person in listBox1.Items)
                {
                    writer.WriteLine("{");
                    writer.WriteLine("     " + person.FirstName);
                    writer.WriteLine("     " + person.LastName);
                    writer.WriteLine("     " + person.EMail);
                    writer.WriteLine("     " + person.Phone);
                    writer.WriteLine("}");
                }
            }
            return true;
        }
    }
}
