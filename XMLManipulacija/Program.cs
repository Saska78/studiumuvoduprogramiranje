using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLManipulacija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml("<korisnik ime=\"Nikola Tesla\">Čvor korisnika</korisnik>");

            Console.WriteLine(xmlDoc.OuterXml);

            Console.WriteLine("InnerXml: "+xmlDoc.InnerXml);
            Console.WriteLine("InnerText: "+xmlDoc.InnerText);

            xmlDoc = new XmlDocument();
            xmlDoc.LoadXml("<korisnici>" +
                "<korisnik ime=\"Nikola Tesla\">Čvor korisnika</korisnik>" +
                "</korisnici>");

            Console.WriteLine("OuterXml: " + xmlDoc.DocumentElement.OuterXml);
            Console.WriteLine("InnerXml: "+xmlDoc.DocumentElement.InnerXml);
            Console.WriteLine("InnerText: "+ xmlDoc.DocumentElement.InnerText);
           

        }
    }
}
