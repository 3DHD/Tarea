using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Ejercicio4
    {
        public void distancia()
        {
            int V, T, X;
            Console.WriteLine("ingrese el valor de la velocidad :");
            V = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el valor del tiempo :");
            T = int.Parse(Console.ReadLine());
            X = V * T;
            Console.WriteLine("La distancia recorrida es de : " + X);
            Console.ReadKey();
        }
    }
}
