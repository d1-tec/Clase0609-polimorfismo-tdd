using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase0609
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bike bike = new Bike();
            //RideBike(bike);

            //MountainBike mountainBike = new MountainBike();
            //RideBike(mountainBike);

            //Trip trip = new Trip();
            //Meal meal = new Meal();

            //PrepareElement(trip);
            //PrepareElement(meal);

            Cyclist cyclist = new Cyclist();

            Bike bike = new Bike();
            Bike mountainBike = new MountainBike();

            cyclist.RideBike(bike);
            Console.WriteLine("########");
            cyclist.RideBike(mountainBike);

            Console.ReadLine();
        }

        static void RideBike(Bike bike)
        {
            bike.DisplayInfo();
            //if (bike is MountainBike)
            //{
            //    MountainBike mountainBike = (MountainBike)bike;
            //    Console.WriteLine($"Mountain Bike Tyre Size {mountainBike.TyreSize}");
            //} else if (bike is RoadBike)
            //{
            //    RoadBike roadBike = (RoadBike)bike;
            //    Console.WriteLine($"Road Bike Data {roadBike.AmountOfGears}");
            //}
            //throw new Exception("");
        }
    }
}
