using System.Windows;
using Wpf_tut20_Open_Custom_Window_w_Show_ShowDialog.View;

namespace Wpf_tut20_Open_Custom_Window_w_Show_ShowDialog
{
       public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNormal_Click(object sender, RoutedEventArgs e)
        {
            NormalWindow normalWindow = new NormalWindow();
            normalWindow.Show();
        }

        private void btnModal_Click(object sender, RoutedEventArgs e)
        {
            ModalWindow modalWindow = new ModalWindow(); 
            modalWindow.ShowDialog();
            if (modalWindow.Success)
            {
                txtInput.Text = modalWindow.Input;
            }
        }
    }
}