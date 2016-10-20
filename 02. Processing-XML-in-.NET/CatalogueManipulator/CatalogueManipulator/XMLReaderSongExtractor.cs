using System;
using System.Collections;
using System.Xml;

namespace CatalogueManipulator
{
    public class XMLReaderSongExtractor
    {
        public void something()
        {
            var url = "../../catalog.xml";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(url);

            string xPathQuery = "/catalog/albums/album";
            XmlNodeList albumsList = xmlDoc.SelectNodes(xPathQuery);

            Hashtable songs = new Hashtable();
            Console.WriteLine("Using XmlReader:\n");

            foreach (XmlNode artistNode in albumsList)
            {
                foreach (XmlNode song in artistNode)
                {
                    Console.WriteLine(song.InnerText);
                }
                    
                songs.Add(artistNode["name"].InnerText, artistNode["artist"].InnerText);
            }

            foreach (string key in songs.Keys)
            {
                Console.WriteLine("Artist - {0} ---> Album - {1}", songs[key], key);
            }

            Console.WriteLine();
        }
    }
}
