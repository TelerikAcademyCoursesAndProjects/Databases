namespace CatalogueManipulator
{
    public class StartProgram
    {
        public static void Main()
        {
            // task 1 and 2
            var domParsExtract = new DomParserExtractor();
            domParsExtract.DomParserExtractorMethod();

            // task 3
            var xPathExtract = new XPathExtractor();
            xPathExtract.XPathExtractorMethod();

            // task 4
            var albumDelete = new AlbumDeleter();
            albumDelete.AlbumDeleterMethod();

            // task 5
            var xmlReaderTitleExtract = new XMLReaderSongTitleExtractor();
            xmlReaderTitleExtract.XMLReaderTitleExtractor();

            // task 6
            var xDocLinqTitleExtract = new XDocumentAndLINQQueryTitleExtractor();
            xDocLinqTitleExtract.XDocumentAndLINQQuerySongTitleExtractor();

            // task 8
            var albumsCreator = new XmlReaderAndXmlWriter();
            albumsCreator.CreateAlbumsXml();  
        }
    }
}
