using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WinForms22.Entities;

namespace WinForms22.Utilities.Import
{
    /// <summary>
    /// It is for loading all information from *.txt file to ListBox.
    /// </summary>
    class TextImporter : IImporter
    {
        /// <summary>
        /// It loads Person's info from *.txt file to ListBox.
        /// </summary>
        /// <param name="listBox1">Instance of ListBox.</param>
        public void Load(ListBox listBox1)
        {
            Regex regex = new Regex(@"{");
            StreamReader reader = null;
            using (reader = new StreamReader(@"TXTFile.txt", Encoding.GetEncoding(1251)))
            {
                listBox1.Items.Clear();
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if(regex.IsMatch(line))
                    {
                        CreatePerson(reader, listBox1);
                    }
                }
            }
        }


        /// <summary>
        /// It creates Person's instance and adds it to ListBox.
        /// </summary>
        /// <param name="reader">Stream Reader.</param>
        /// <param name="listBox1">Instance of ListBox.</param>
        private void CreatePerson(StreamReader reader, ListBox listBox1)
        {
            Person person = new Person
            {
                FirstName = reader.ReadLine().Trim(),
                LastName = reader.ReadLine().Trim(),
                EMail = reader.ReadLine().Trim(),
                Phone = reader.ReadLine().Trim()
            };
            listBox1.DisplayMember = "LastName";
            listBox1.Items.Add(person);
        }
    }
}
