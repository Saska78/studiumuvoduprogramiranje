using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLPisanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlWriter xmlw = XmlWriter.Create("korisnici.xml");

            xmlw.WriteStartDocument();

            xmlw.WriteStartElement("korisnici");

            xmlw.WriteStartElement("korisnik");
            xmlw.WriteAttributeString("dob", "43");
            xmlw.WriteString("Nikola Tesla");
            xmlw.WriteEndElement();

            xmlw.WriteStartElement("korisnik");
            xmlw.WriteAttributeString("dob", "23");
            xmlw.WriteString("Albert Einstein");
            xmlw.WriteEndElement();

            xmlw.WriteEndElement();

            xmlw.WriteEndDocument();
            xmlw.Close();



            XmlDocument xmlDocument = new XmlDocument();
            XmlNode rootNode = xmlDocument.CreateElement("korisnici");
            xmlDocument.AppendChild(rootNode);

            XmlNode korisnik = xmlDocument.CreateElement("korisnik");
            XmlAttribute dob = xmlDocument.CreateAttribute("dob");
            dob.Value = "42";
            korisnik.Attributes.Append(dob);
            korisnik.InnerText = "Nikola Tesla";
            rootNode.AppendChild(korisnik);

            korisnik = xmlDocument.CreateElement("korisnik");
            dob = xmlDocument.CreateAttribute("dob");
            dob.Value = "32";
            korisnik.Attributes.Append(dob);
            korisnik.InnerText = "Albert";
            rootNode.AppendChild(korisnik);

            xmlDocument.Save("korisnici2.xml");
        }
    }
}
