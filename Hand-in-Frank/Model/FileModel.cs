using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hand_in_Frank.Model;

namespace Hand_in_Frank.Model
{
    class FileModel : IFile
    {
        public string FilePath()
        {
            /**
             * Select a path to the folder which content should be shown
             */
            StreamReader sr = new StreamReader("C:\\Users\\Mathias\\Desktop\\test");
            String locationPath = sr.ToString();
            return locationPath;
        }

        public string MyText { get; set; }
        public string MyImage { get; set; }
    }
}
