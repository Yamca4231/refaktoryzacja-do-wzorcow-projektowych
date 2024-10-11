using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01LongParameterList
{
    class LongParameterList
    {
        public void RegisterProduct(Product product)
        {
            // Rejestracja produktu
            Console.WriteLine($"Product: {product.productName}, Category: {product.category}, Price: {product.price:C}, Stock: {product.stock}, Supplier: {product.supplierName}, Contact: {product.supplierContact}");
        }
    }
    class Product
    {
        internal string productName { get; set; }
        internal string category { get; set; }
        internal decimal price { get; set; }
        internal int stock { get; set; }
        internal string supplierName { get; set; }
        internal string supplierContact { get; set; }

    }
}
