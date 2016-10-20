using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CatalogueManipulator
{
    public class AlbumDeleter
    {
        public void AlbumDeleterMethod()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalog.xml");
            XmlNode rootNode = doc.DocumentElement;

            Console.WriteLine("Using other:\n");

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                foreach (XmlNode item in node)
                {
                    var trimedPrice = item["price"].InnerText.Substring(1);
                    if (Decimal.Parse(trimedPrice) > 20.00M)
                    {
                        
                    }

                }
            }

            Console.WriteLine();
        }
    }
}
