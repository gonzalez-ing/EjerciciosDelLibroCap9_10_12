using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibro.Capitulo_10
{
    class Ejercicio5
    {
        public class PoligonoToString
        {
            public Double Perimetro { get; set; }
            public Double Apotema { get; set; }
            public PoligonoToString()
            {

            }
            public PoligonoToString(Double Perimetro, Double Apotema)

            {
                this.Perimetro = Perimetro;
                this.Apotema = Apotema;
            }

            public double Area
            {
                get { return Perimetro * Apotema / 2; }
                set { Perimetro = 15; Apotema = 3.25; }
            }


            public static void main()
            {
                PoligonoToString p = new PoligonoToString();
                Console.WriteLine(p.ToString());
            }
        }
    }
}
