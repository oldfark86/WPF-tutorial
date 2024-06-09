using System.Windows;

namespace Wpf_tut_09 
{ 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Could not open file","Error!", MessageBoxButton.OKCancel,MessageBoxImage.Error);
            MessageBoxResult result = MessageBox.Show("Could not open file", "Error!", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            if (result == MessageBoxResult.OK)
            {
                
            }
            else
            {

            }
        }
    }
}
