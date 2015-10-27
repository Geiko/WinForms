using System.Windows.Forms;
using System.Xml;
using WinForms22.Entities;

namespace WinForms22.Utilities
{
    /// <summary>
    /// It is for saving all information from ListBox to *.xml file using DOM.
    /// </summary>
    public class XmlDOMExporter : IExporter
    {
        /// <summary>
        /// It creats Xml document and saves it to a file with XmlTextWriter.
        /// </summary>
        /// <param name="listBox1">Instance of ListBox.</param>
        /// <returns></returns>
        public bool Save(ListBox listBox1)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<Persons></Persons>");

            foreach (Person p in listBox1.Items)
            {
                Bild(p, doc);
            }
            XmlTextWriter writer = new XmlTextWriter(@"XMLFile.xml", null);
            writer.Formatting = Formatting.Indented;
            doc.Save(writer);
            writer.Close();
            return true;
        }



        /// <summary>
        /// It bilds nodes of Xml tree.
        /// </summary>
        /// <param name="p">Instance of Person.<param>
        /// <param name="doc">Instance of Xml Document.<param>
        private void Bild(Person p, XmlDocument doc)
        {
            XmlElement StartElement = doc.CreateElement("Person");
            doc.DocumentElement.AppendChild(StartElement);

            XmlElement newElem = doc.CreateElement("FirstName");
            newElem.InnerText = p.FirstName;
            StartElement.AppendChild(newElem);

            newElem = doc.CreateElement("LastName");
            newElem.InnerText = p.LastName;
            StartElement.AppendChild(newElem);

            newElem = doc.CreateElement("EMail");
            newElem.InnerText = p.EMail;
            StartElement.AppendChild(newElem);

            newElem = doc.CreateElement("Phone");
            newElem.InnerText = p.Phone;
            StartElement.AppendChild(newElem);
        }
    }
}
