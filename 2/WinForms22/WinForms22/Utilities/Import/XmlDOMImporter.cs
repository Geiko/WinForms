using System.IO;
using System.Windows.Forms;
using System.Xml;
using WinForms22.Entities;
using WinForms22.Utilities.Import;

namespace WinForms22.Utilities
{
    /// <summary>
    /// It loads all Person's info from *.xml file to ListBox using DOM.
    /// </summary>
    class XmlDOMImporter : IImporter
    {
        /// <summary>
        /// It fildes of reference to xml document.
        /// </summary>
        private XmlDocument doc;

        /// <summary>
        /// It loads info from *.xml file.
        /// </summary>
        /// <param name="listBox1">Instance of ListBox.</param>
        public void Load(ListBox listBox1)
        {
            doc = new XmlDocument();

            string file = @"XMLFile.xml";
            if (File.Exists(file))
                doc.Load(file);
            else throw new FileNotFoundException("This file not found - " + file);

            listBox1.Items.Clear();
            XmlNodeList elemList = doc.GetElementsByTagName("Person");
            for (int i = 0; i < elemList.Count; i++)
            {
                CreatePerson(elemList[i], listBox1);
            }
        }


        /// <summary>
        /// It creates Person's instance, assigns it's fields, adds it to ListBox.
        /// </summary>
        /// <param name="node">Node of Xml document.</param>
        /// <param name="listBox1">Instance of ListBox.</param>
        private void CreatePerson(XmlNode node, ListBox listBox1)
        {
            if (node.HasChildNodes)
            {
                XmlNodeList children = node.ChildNodes;
                Person person = new Person
                {
                    FirstName = children[0].InnerText,
                    LastName = children[1].InnerText,
                    EMail = children[2].InnerText,
                    Phone = children[3].InnerText,
                };
                listBox1.DisplayMember = "LastName";
                listBox1.Items.Add(person);
            }            
        }
    }
}
