using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Car :Product, IVehicle,IDriveable
    {
        double _millage;
        public string Model { get ; set ; }
        public string Brand { get ; set; }
        public double Millage {  get=>_millage; }
        public double CurrentFuel { get; set; }
        public double FuelForKm { get; set; }


        public void Drive(double km)
        {
            if(km>0 && FuelForKm * km <= CurrentFuel)
            {
                _millage += km;
                CurrentFuel -= FuelForKm * km;
            }
        }
    }
}
