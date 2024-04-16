using PurchaseOrder.Models.Product;
using PurchaseOrder.Models.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrderManagementSystem.ViewModel
{
    public class VendorVM : Utilities.ViewModelBase
    {
        private VendorModel _pageModel;
        public string ProductName
        {
            get { return _pageModel.VendorName; }
            set { _pageModel.VendorName = value; OnPropertyChanged(); }
        }

        public VendorVM()
        {
            _pageModel = new VendorModel();
            ProductName = "ABC";
        }
    }
}
