using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_tut12_ListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> entries;

        public ObservableCollection<string> Entries
        {
            get { return entries; }
            set { entries = value; }
        }

        public MainWindow()
        {
            DataContext = this;
            entries = new ObservableCollection<string>(); // you must do this before the following InitializeComponent !!!!
            
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Entries.Add(txtEntry.Text);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Entries.Clear();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int index = lvEntries.SelectedIndex;    // Problem !!!!!! --- MVVM
            Entries.RemoveAt(index);
            
        }
    }
}
