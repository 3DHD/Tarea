using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ejercicio1
    {
        public void Sumar()
        {
            int n1, n2, n3;

            Console.WriteLine("Ingrese un valor para n1 : ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un valor para n2 : ");
            n2 = int.Parse(Console.ReadLine());

            n3 = n1 + n2;
            Console.WriteLine("El resultado es : " + n3);
            Console.ReadKey();
        }
    }

}
