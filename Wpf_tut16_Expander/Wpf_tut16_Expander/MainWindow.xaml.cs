using System.Windows;

namespace Wpf_tut16_Expander
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDetail_Click(object sender, RoutedEventArgs e)
        {
            expanderDetail.IsExpanded = !expanderDetail.IsExpanded;
        }
    }
}