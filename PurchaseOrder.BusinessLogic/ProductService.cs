using PurchaseOrder.DataAccess;
using PurchaseOrder.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrder.BusinessLogic
{
    public class ProductService : IProductService
    {
        private readonly IGenericRepository<ProductModel> _productRepository;

        public ProductService()
        {
            _productRepository = new GenericRepository<ProductModel>("Product");
        }

        public void CreateProduct(CreateProductModel createProduct)
        {
            _productRepository.Insert(createProduct);
        }

        public void UpdateProduct(UpdateProductModel updateProduct)
        {
            _productRepository.Update(updateProduct);
        }
    }
}
