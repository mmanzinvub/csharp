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
        public double Price { get; protected set; }

        public Consumable(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual double TotalPrice() => Price;
    }
}