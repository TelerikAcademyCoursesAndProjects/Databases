using System;
using System.Collections;
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
            Hashtable artists = new Hashtable();
            var i = 0;

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                foreach (XmlNode item in node)
                {
                    if (!artists.ContainsValue(item["artist"].InnerText))
                    {
                        artists.Add(i++, item["artist"].InnerText);
                    }
                }
                foreach (var item in artists.Values)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
