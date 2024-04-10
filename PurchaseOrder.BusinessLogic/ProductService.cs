using PurchaseOrder.DataAccess;
using PurchaseOrder.Models;
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

        public ProductService(IGenericRepository<ProductModel> productRepository)
        {
            _productRepository = productRepository;
        }

        public void CreateProduct(CreateProductModels createProduct)
        {
            _productRepository.Insert(createProduct);
        }
    }
}
