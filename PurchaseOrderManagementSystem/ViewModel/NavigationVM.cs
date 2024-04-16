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

        public ICommand VendorCommand { get; set; }

        private void Product(object obj) => CurrentView = new ProductVM();

        private void Vendor(object obj) => CurrentView = new VendorVM();

        public NavigationVM() 
        { 
            ProductCommand = new RelayCommand(Product);
            VendorCommand = new RelayCommand(Vendor);

            // Startup page
            CurrentView = new ProductVM();
        }
    }
}
