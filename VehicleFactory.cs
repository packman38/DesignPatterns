using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.FactoryPattern.Problem
{
    public abstract class VehicleFactory
    {
         public void BookRide(){

            var vehicle = GetVehicle();
            vehicle.BookRide();
         }
         public abstract IVehicle GetVehicle();    // Client interacts with IVehicle
    }

}