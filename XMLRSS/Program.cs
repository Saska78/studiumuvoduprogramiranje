using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLRSS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("http://rss.cnn.com/rss/edition_world.rss");
            XmlNode titleNode = xmlDoc.SelectSingleNode("//rss/channel/title");
            if(titleNode!=null) Console.WriteLine(titleNode.InnerText);

            XmlNodeList items = xmlDoc.SelectNodes("//rss/chanel/item");
            foreach(XmlNode item in items)
            {
                XmlNode title = item.SelectSingleNode("title");
                XmlNode date = item.SelectSingleNode("pubDate");
                if(title!=null && date!=null)
                    Console.WriteLine(date.InnerText+ " : "+title.InnerText);
            }
        }
    }
}
