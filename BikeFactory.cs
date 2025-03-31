using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.FactoryPattern.Problem
{
    public class BikeFactory : VehicleFactory
    {


        public override IVehicle GetVehicle()
        {
            return new Bike();
        }
    }
}