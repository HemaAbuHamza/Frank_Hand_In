using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Hand_in_Frank.Model;

namespace Hand_in_Frank
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /**
             * When the list gets created all the files will be deleted
             * it prevents the program from crashing when selecting a new folder
             */

            List<FileModel> textList = new List<FileModel>();
            List<FileModel> imageList = new List<FileModel>();

            FolderBrowserDialog FBD = new FolderBrowserDialog();
            DialogResult result = FBD.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string[] textFiles = Directory.GetFiles(FBD.SelectedPath , "*.txt");
                string[] imageFiles = Directory.GetFiles(FBD.SelectedPath, "*.jpg");

                string[] dirs = Directory.GetDirectories(FBD.SelectedPath);

                //Handel the text files
                foreach (string file in textFiles)
                {
                    textList.Add(new FileModel() { MyText = file });

                }

                foreach (string dir in dirs)
                {
                    textList.Add(new FileModel() { MyText = dir });
                }


                //Handel the Image files 
                foreach (string file in imageFiles)
                {
                    imageList.Add(new FileModel() { MyImage = file });

                }

                foreach (string dir in dirs)
                {
                    imageList.Add(new FileModel() { MyImage = dir });
                }
            }

            listbox2.ItemsSource = textList;
            listbox1.ItemsSource = imageList;            
        }

 
    }
}
