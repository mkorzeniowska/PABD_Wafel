using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PABD.UserInterface.Helpers
{
    class ResourcesHelpers
    {
        public const string closeButton = "close.png";
        public static string ResourcesFilePath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), "Resources");

    }
}
