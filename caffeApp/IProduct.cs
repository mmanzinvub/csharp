﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VubCaffe
{
    public interface IProduct
    {
        string Name { get; }
        double Price { get; }
        double TotalPrice();
    }
}
