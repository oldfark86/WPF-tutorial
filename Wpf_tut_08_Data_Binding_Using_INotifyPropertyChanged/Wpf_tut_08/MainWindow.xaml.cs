using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Wpf_tut_08
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }

        private string boundText;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string BoundText
        {
            get { return boundText; }
            set 
            { 
                boundText = value;
                //OnPropertyChanged() !!! == We can separate GUI and code
                // We donot need code like txtInput.Txt = boundText
                // We do not need a code than directly call GUI componet
                // Tha also it means it ccan separately testable!!
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BoundText"));
                OnPropertyChanged();
            }
         }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            BoundText = "set button pressed = from Click event";
        }
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
