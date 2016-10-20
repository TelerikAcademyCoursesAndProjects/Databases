using System;
using System.Xml;

namespace CatalogueManipulator
{
    public class XPathExtractor
    {
        public void XPathExtractorMethod()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("../../catalog.xml");
            string xPathQuery = "/catalog/albums/album/name";

            XmlNodeList beersList = xmlDoc.SelectNodes(xPathQuery);

            foreach (XmlNode beerNode in beersList)
            {
                Console.WriteLine(beerNode.InnerText);
            }
        }
    }
}
