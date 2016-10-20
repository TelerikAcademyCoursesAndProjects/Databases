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
        }
    }
}
