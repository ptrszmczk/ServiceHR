using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHR.UserInterface.Helpers
{
    public static class ResourcesHelper
    {
        private const string closeButtonName = "close.png";
        private static string resourceFilePath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), "Resources");

        public static string CloseButtonName
        {
            get { return closeButtonName; }
        }

        public static string ResourceFilePath
        {
            get { return resourceFilePath; }
        }
    }
}
