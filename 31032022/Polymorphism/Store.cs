using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    internal class Store
    {
        public Product[] Products { get; set; }

        public double CalcAllPrice()
        {
            double total = 0;

            foreach (var pr in Products)
                total += pr.Price;

            return total;
        }

    }
}
