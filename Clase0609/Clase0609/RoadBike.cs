using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase0609
{
    public class RoadBike : Bike
    {
        public int AmountOfGears { get; private set; }

        public RoadBike(int amountOfGears)
        {
            this.AmountOfGears = amountOfGears;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Road Bike Data {this.AmountOfGears}");
        }
    }
}
