using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase0609
{
    public class MountainBike : Bike
    {
        public int TyreSize { get; set; }

        public MountainBike()
        {
            this.TyreSize = 40;
        }

        public override void Ride()
        {
            // base.Ride(); para extender el comportamiento del metodo padre
            
            Console.WriteLine($"Riding the Mountain Bike {this.TyreSize}");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Mountain Bike Tyre Size {this.TyreSize}");
        }


        //public void Ride()
        //{
        //    Console.WriteLine("Riding the Mountain Bike");
        //}
    }
}
