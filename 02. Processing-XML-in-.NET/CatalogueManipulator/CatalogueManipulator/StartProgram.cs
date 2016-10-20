namespace CatalogueManipulator
{
    public class StartProgram
    {
        public static void Main()
        {
            var domParsExtract = new DomParserExtractor();
            domParsExtract.DomParserExtractorMethod();

            var xPathExtract = new XPathExtractor();
            xPathExtract.XPathExtractorMethod();

            var albumDelete = new AlbumDeleter();
            albumDelete.AlbumDeleterMethod();

            var xmlReaderTitleExtract = new XMLReaderSongTitleExtractor();
            xmlReaderTitleExtract.XMLReaderTitleExtractor();

            var xDocLinqTitleExtract = new XDocumentAndLINQQueryTitleExtractor();
            xDocLinqTitleExtract.XDocumentAndLINQQuerySongTitleExtractor();
        }
    }
}
