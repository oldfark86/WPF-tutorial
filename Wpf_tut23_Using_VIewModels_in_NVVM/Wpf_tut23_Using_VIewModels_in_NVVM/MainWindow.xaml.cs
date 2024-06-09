using System.Windows;
using Wpf_tut23_Using_VIewModels_in_NVVM.ViewModel;

namespace Wpf_tut23_Using_VIewModels_in_NVVM
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWindowViewModel vm = new MainWindowViewModel();
            DataContext = vm;
        }
    }
}