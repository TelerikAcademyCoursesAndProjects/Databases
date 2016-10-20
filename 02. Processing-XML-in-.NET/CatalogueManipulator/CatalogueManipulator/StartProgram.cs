using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogueManipulator
{
    public class StartProgram
    {
        public static void Main()
        {
            var extract = new ArtistExtractor();
            extract.ExtractorMethod();
        }
    }
}
