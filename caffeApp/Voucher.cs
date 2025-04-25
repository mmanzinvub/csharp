using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VubCaffe
{
    public class Voucher : IProduct
    {
        public string Name { get; } = "Voucher";
        public double Price { get; } = 100.0;

        public Voucher()
        {
            
        }

        public double TotalPrice() => -Price;
    }
}
