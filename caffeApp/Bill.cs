using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VubCaffe
{
    public class Bill
    {
        private List<IProduct> products = new List<IProduct>();

        public void AddProduct(IProduct product)
        {
            products.Add(product);
        }

        public double Total()
        {
            double total = 0.0;
            foreach (var product in products)
            {
                total += product.TotalPrice();
            }
            return total;
        }

        public List<IProduct> Products => products;
    }
}
