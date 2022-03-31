using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Bicycle :Product, IVehicle, IDriveable
    {
        double _millage;
        public string Model { get ; set; }
        public string Brand { get ; set ; }

        public double Millage { get => _millage; }

        public void Drive(double km)
        {
            if (km > 0)
                _millage += km;
        }
    }
}
