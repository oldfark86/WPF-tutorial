using System.Windows;

namespace Wpf_tut20_Open_Custom_Window_w_Show_ShowDialog.View
{
    public partial class ModalWindow : Window
    {
        public bool Success { get; set; }
        private string input;

        public string Input
        {
            get { return input; }
            set { input = value; }
        }

        public ModalWindow()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            Success = true;
            Input = txtInput.Text;
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Success = false;
            Close();
        }
    }
}
