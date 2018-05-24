using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibro.Capitulo_12
{
    class Ejercicio2
    {
        public static void Factorial(int N)
        {
            int Fact = 1;
            for (int i = 1; i <= N; i++)
            {
                Fact *= i;
                Console.WriteLine(Fact);
            }
            Console.WriteLine("\nEl Factorial de " + N + " es: " + Fact);
            Console.ReadKey();

        }
    }
}
