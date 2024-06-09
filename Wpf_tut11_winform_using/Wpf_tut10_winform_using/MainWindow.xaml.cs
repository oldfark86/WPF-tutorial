using System.Windows;
using WinForms = System.Windows.Forms;

namespace Wpf_tut10_winform_using
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            WinForms.FolderBrowserDialog dialog = new WinForms.FolderBrowserDialog();
            dialog.InitialDirectory = "c:\\temp";
            WinForms.DialogResult result = dialog.ShowDialog();
            
            if(result== WinForms.DialogResult.OK)
            {
                string folder = dialog.SelectedPath;
            }

            //MessageBox.Show("WPF message Box");
        }
    }
}
