using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.FactoryPattern.Problem
{
    public class Bike : IVehicle
    {
         public void BookRide()
        {
            Console.WriteLine("Bike ride booked from Point A to Point B");
        }
    }
}