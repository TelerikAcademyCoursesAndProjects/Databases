using System.Text;
using System.Xml;

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

            // task 9 and 10
            using (var writer = new XmlTextWriter("../../traverseWithXmlWriter.xml", Encoding.UTF8))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("DirectoriesRoot");
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;
                CreateFileSystemXml.CreateFileSystemXmlTreeUsingXmlWriter("../../..", writer);
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }
        }
    }
}
