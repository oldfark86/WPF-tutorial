using Microsoft.Win32;
using System.Windows;

namespace Wpf_tut_09_Filedialog
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.FileName = "*.md";   // = "";
            //fileDialog.InitialDirectory = "c:\\temp";
            fileDialog.Title = "Pick Markdown file";
            fileDialog.Multiselect = true;

            bool? success  = fileDialog.ShowDialog();
            if(success == true)
            {
                //string path = fileDialog.FileName;
                //string fileName = fileDialog.SafeFileName;
                string[] path = fileDialog.FileNames;
                string[] fileName = fileDialog.SafeFileNames;

                //tbInfo.Text = fileName;
            }
            
        }
    }
}
