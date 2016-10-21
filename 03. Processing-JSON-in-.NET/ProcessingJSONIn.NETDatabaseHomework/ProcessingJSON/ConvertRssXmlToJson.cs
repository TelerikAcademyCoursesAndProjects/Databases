using System;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.IO;

namespace ProcessingJSON
{
    class ConvertRssXmlToJson
    {
        public void ConvertXmlToJsonMethod()
        {
            var url = "../../rss.xml";
            var urlJson = "../../rssJson.json";
            XDocument rss = XDocument.Load(url);

            var jsonFromXml = JsonConvert.SerializeObject(rss, Formatting.Indented);

            File.WriteAllText(urlJson, jsonFromXml);
            
            Console.WriteLine(jsonFromXml);
        }
    }
}
