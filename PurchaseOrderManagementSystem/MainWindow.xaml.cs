using PurchaseOrder.BusinessLogic;
using PurchaseOrder.Models.Product;
using System.Windows;

namespace PurchaseOrderManagementSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

            var createProduct = new CreateProductModels
            { ProductName = "XYZ" };

            _productService.CreateProduct(createProduct);
            
        }
    }
}