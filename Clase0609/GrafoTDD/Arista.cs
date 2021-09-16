using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafoTDD
{
    public class Arista
    {
        // https://blog.cleancoder.com/uncle-bob/2017/03/03/TDD-Harms-Architecture.html

        public string Origen { get; set; }
        public string Destino { get; set; }

        public override bool Equals(object obj)
        {
            Arista otra = obj as Arista;

            // if (otra == null) return false;

            return this.Origen.Equals(otra.Origen) && this.Destino.Equals(otra.Destino);
        }
    }
}
