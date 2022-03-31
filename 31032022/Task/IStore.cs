using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    internal interface IStore
    {
        Product[] Products { get; set; }
        double TotalAmount { get; set; }
        void Sell(Product product);
    }
}
