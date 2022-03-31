using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    internal class VehicleStore : IStore
    {
        public Product[] Products { get ; set ; }
        public double TotalAmount { get ; set; }

        public void Sell(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
