using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public abstract class Product
    {
        public double Price { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
    }

}
