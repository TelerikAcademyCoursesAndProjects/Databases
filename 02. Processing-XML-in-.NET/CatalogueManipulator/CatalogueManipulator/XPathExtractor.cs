using System;
using System.Xml;

namespace CatalogueManipulator
{
    class XPathExtractor
    {
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load("../../catalog.xml");
        string xPathQuery = "/items/item[@type='beer']";

        XmlNodeList beersList = xmlDoc.SelectNodes(xPathQuery);
        foreach (XmlNode beerNode in beersList)
        {
            string beerName = beerNode.SelectSingleNode("name").InnerText;
        Console.WriteLine(beerName);
        }
}
}
