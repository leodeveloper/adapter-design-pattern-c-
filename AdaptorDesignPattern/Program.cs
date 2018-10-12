using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Export export = new Excel();
            export.Save();

            export = new Pdf();
            export.Save();

            export = new Csv();
            export.Save();
            //Make notcompitable class to compitable, ThirdPart liberary might does not have Save method now here the adaptor pattern comes, please check file Export.cs class name "ThirdPartyExport"
            export = new ThirdPartyExport();
            export.Save();
        }
    }
}
