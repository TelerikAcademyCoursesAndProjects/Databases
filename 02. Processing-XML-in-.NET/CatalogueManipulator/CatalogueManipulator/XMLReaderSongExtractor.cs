using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

namespace CatalogueManipulator
{
    public class XMLReaderSongExtractor
    {
        public void XMLReaderSongTitleExtractor()
        {
            var url = "../../catalog.xml";
            var songTitles = new List<string>();
            Console.WriteLine("Using XmlReader extract all song titles:\n");

            using (XmlReader reader = XmlReader.Create(url))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "title")
                    {
                        songTitles.Add(reader.ReadElementString().Trim());
                    }
                }
            }

            Console.WriteLine(string.Join("\n", songTitles));
            Console.WriteLine();
        }
    }
}
