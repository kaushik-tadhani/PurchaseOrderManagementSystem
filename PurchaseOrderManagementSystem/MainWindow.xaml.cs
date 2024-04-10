using PurchaseOrder.BusinessLogic;
using PurchaseOrder.Models;
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

            var _productService = new ProductService();

            var createProduct = new CreateProductModels
            { ProductName = "XYZ" };

            _productService.CreateProduct(createProduct);
            
        }
    }
}