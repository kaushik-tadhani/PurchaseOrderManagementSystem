using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrder.Models.Product
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public required string ProductName { get; set; }
    }
}
