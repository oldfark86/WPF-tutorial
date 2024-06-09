using System.Collections.ObjectModel;
using Wpf_tut23_Using_VIewModels_in_NVVM.Model;
using Wpf_tut23_Using_VIewModels_in_NVVM.NVVM;

namespace Wpf_tut23_Using_VIewModels_in_NVVM.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Items { get; set; }

        public RelayCommand AddCommand => new RelayCommand(excute => AddItem());
        public RelayCommand DeleteCommand => new RelayCommand(excute => DeleteItem(), canExecute => SelectedItem != null);
        public RelayCommand SaveCommand => new RelayCommand(excute => Save(), canExecute => CanSave());


        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Item>();
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

        private void AddItem()
        {
            Items.Add( new Item 
            {
                Name = "NEW ITEM",
                SerialNumber = "XXXX",
                Quantity = 0
            });
        }

        private void DeleteItem()
        {
            Items.Remove(selectedItem);
        }
        private void Save()
        {
            //save to file/db

        }

        private bool CanSave()
        {
            return true;
        }

        
    }
}
