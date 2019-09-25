using Hand_in_Frank.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace Hand_in_Frank.NewFolder1
{
    public class FileView
    {
        ObservableCollection<FileModel> TextFiles
        {
            get;
            set;
        }

         ObservableCollection<FileModel> ImageFiles
        {
            get;
            set;
        }

        /**
         * FolderBrowserDialog FBD = new FolderBrowserDialog();
            DialogResult result = FBD.ShowDialog();
        */

        public void LoadTextFiles()
        {
            ObservableCollection<FileModel> textFiles = new ObservableCollection<FileModel>();

            TextFiles = textFiles;
        }

        public void LoadImages()
        {
            ObservableCollection<FileModel> imageFiles = new ObservableCollection<FileModel>();
            ImageFiles = imageFiles;
        }

    }
}
