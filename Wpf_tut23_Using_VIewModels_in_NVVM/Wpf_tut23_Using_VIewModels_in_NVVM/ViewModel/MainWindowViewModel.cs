using System.Collections.ObjectModel;
using Wpf_tut23_Using_VIewModels_in_NVVM.Model;
using Wpf_tut23_Using_VIewModels_in_NVVM.NVVM;

namespace Wpf_tut23_Using_VIewModels_in_NVVM.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Items { get; set; }

        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Item>();
            Items.Add(new Item
            {
                Name = "Product1",
                SerialNumber = "0001",
                Quantity = 5
            });
            Items.Add(new Item
            {
                Name = "Product2",
                SerialNumber = "0002",
                Quantity = 6
            });
        }

        private Item selectedItem;

        public Item SelectedItem
        {
            get { return selectedItem; }
            set 
            { 
                selectedItem = value; 
                OnPropertyChanged();
            }
        }

        

    }
}
