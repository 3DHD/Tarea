using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Dividir
    {
        public void divi()
        {
            int n1, n2, resultado;
            Console.WriteLine("Ingrese un valor para n1 :");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un valor para n2 :");
            n2 = int.Parse(Console.ReadLine());

            resultado = n1 / n2;
            Console.WriteLine("El resultado es :" + resultado);
            Console.ReadKey();

        }
    }
}
