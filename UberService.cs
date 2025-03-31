using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ConsoleApp1.FactoryPattern.Problem
{
    public class UberService
    {
        string noOfPassengers = "2";

        VehicleFactory vehicle;
        public void SelectVehicle(){

        if(noOfPassengers == "2"){

        vehicle = new BikeFactory();               // Issue with the code is that as the use cases increases the code will become more bloated
                                    //leading to bugs and violating OCM principle which says a class should be extended 
}
          
        else if(noOfPassengers == "3"){

            vehicle = new AutoFactory();  
        }

        else {

            vehicle =  new CarFactory();
        }

          vehicle.BookRide();
        }
    }
}