using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace XMLUvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = true;
            try
            {
                doc.Load("books.xml");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(doc);

            //XmlReader xmlReader = XmlReader.Create(new FileStream("books.xml", FileMode.Open));
            XmlReader xmlReader = XmlReader.Create("http://www.ecb.int/stats/eurofxref/eurofxref-daily.xml");
            Console.WriteLine(xmlReader);
            while (xmlReader.Read())
            {
                if(xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "Cube")
                {
                    if(xmlReader.HasAttributes)
                    {
                        Console.WriteLine(xmlReader.GetAttribute("curency") + ":"
                            + xmlReader.GetAttribute("rate"));
                    }
                }
            }

            Console.WriteLine("XmlDocument klasa čitanje istih podataka: ");

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("http://www.ecb.int/stats/eurofxref/eurofxref-daily.xml");
            foreach(XmlNode node in xmlDocument.DocumentElement.ChildNodes[2].ChildNodes[0].ChildNodes)
            {
                Console.WriteLine(node.OuterXml);
                //Console.WriteLine(node.Attributes["currency"].Value+ ":"
                 // + node.Attributes["rate"].Value);   
            }
        }
    }
}
