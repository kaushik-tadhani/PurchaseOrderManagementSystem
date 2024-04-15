using PurchaseOrderManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PurchaseOrderManagementSystem.ViewModel
{
    public class NavigationVM : ViewModelBase
    {
        private object _currentView;
        public object CurrentView 
        { 
            get { return _currentView; } 
            set { _currentView = value; OnPropertyChanged(); } 
        }

        public ICommand ProductCommand { get; set; }

        private void Product(object obj) => CurrentView = new ProductVM();

        public NavigationVM() 
        { 
            ProductCommand = new RelayCommand(Product);

            // Startup page
            CurrentView = new ProductVM();
        }
    }
}
