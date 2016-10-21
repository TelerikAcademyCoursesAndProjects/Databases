namespace ProcessingJSON
{
    public class Start
    {
        public static void Main()
        {
            var rssDownloader = new DownloadXMLFile();
            rssDownloader.DownloadXMLFilesMethod();

            var rssXmlToJson = new ConvertRssXmlToJson();
            rssXmlToJson.ConvertXmlToJsonMethod();
        }
    }
}
