using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ejercicio2
    {
        public void multi()
        {
            int n1, n2, n3, resultado;

            Console.WriteLine("Ingrese un valor para ;");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese un segundo valor : ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese un tercer valor : ");
            n3 = int.Parse(Console.ReadLine());

            resultado = n1 * n2 * n3;
            Console.WriteLine("El resultado es : " + resultado);
            Console.ReadKey();

        }
    }
}
