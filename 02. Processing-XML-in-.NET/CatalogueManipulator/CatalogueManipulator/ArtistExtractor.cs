using System;
using System.Xml;

namespace CatalogueManipulator
{
    public class ArtistExtractor
    {
        public void ExtractorMethod()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalog.xml");
            XmlNode rootNode = doc.DocumentElement;

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                foreach (XmlNode item in node)
                {
                    Console.WriteLine("Album name = {0}",
                        item["name"].InnerText);
                    Console.WriteLine("Artist name = {0}",
                        item["artist"].InnerText);
                    Console.WriteLine("Album price = {0}",
                        item["price"].InnerText);
                    Console.WriteLine();
                }

            }
        }
    }
}
