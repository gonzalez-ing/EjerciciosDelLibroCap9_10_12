using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibro.Capitulo_12
{
    class Ejercicio1
    {
        public static void Factorial(int N)
        {
            int fact = 1;
            for (int i = 1; i <= N; i++)
            {
                fact *= i;
                Console.WriteLine(fact);
            }
            Console.WriteLine("\nEl Factorial de " + N + " es: " + fact);
            Console.ReadKey();

        }
    }
}
