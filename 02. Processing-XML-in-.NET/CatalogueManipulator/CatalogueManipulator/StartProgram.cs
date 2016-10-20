namespace CatalogueManipulator
{
    public class StartProgram
    {
        public static void Main()
        {
            var extract = new DomParserExtractor();
            extract.DomParserExtractorMethod();

            var test = new XPathExtractor();
            test.XPathExtractorMethod();

            var test1 = new AlbumDeleter();
            test1.AlbumDeleterMethod();
        }
    }
}
