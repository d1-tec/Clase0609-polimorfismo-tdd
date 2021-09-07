using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase0609
{
    public class Cyclist
    {
        public void RideBike(Bike bike)
        {
            // El metodo ride es un metodo polimorfico
            // "tiene varias formas"
            // ya que adopta distintas implementaciones segun el tipo de la variable bike
            bike.Ride();


            // El emisor del mensaje (Cyclist)
            // no siempre conoce el tipo del receptor (la variable bike)
            // que en este caso puede ser de tipo Bike o MountainBike
            // o cualquier otro tipo que herede de Bike
            // Pero es la propia variable la que provee la implementacion
        }
    }
}
