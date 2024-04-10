using PurchaseOrder.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrder.BusinessLogic
{
    public interface IProductService
    {
        void CreateProduct(CreateProductModel createProduct);
        void UpdateProduct(UpdateProductModel updateProduct);
    }
}
