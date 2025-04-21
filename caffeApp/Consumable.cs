using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VubCaffe
{
    public abstract class Consumable : IProduct
    {
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }

        public Consumable(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}