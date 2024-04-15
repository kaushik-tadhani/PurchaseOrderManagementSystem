using PurchaseOrder.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrderManagementSystem.ViewModel
{
    public class ProductVM : Utilities.ViewModelBase
    {
        private  ProductModel _pageModel;
        public string ProductName
        {
            get { return _pageModel.ProductName; }
            set { _pageModel.ProductName = value; OnPropertyChanged(); }
        }

        public ProductVM()
        {
            _pageModel = new ProductModel();
            ProductName = "ABC";
        }
    }
}
