using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IVehicle
    {
        string Model { get; set; }
        string Brand { get; set; }
        double Millage { get; }
    }
}
