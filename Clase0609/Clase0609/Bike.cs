using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase0609
{
    public class Bike
    {
        public virtual void Ride()
        {
            Console.WriteLine("Riding the Bike");
        }

        public virtual void DisplayInfo() { }
    }
}
