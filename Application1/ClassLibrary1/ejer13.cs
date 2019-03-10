using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ejer13
    {
        public void numeros()
        {
            Console.WriteLine("Ingrese 5 numeros");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            int num5 = Convert.ToInt32(Console.ReadLine());

            int suma = num1 + num2;
            int producto = suma * num3;
            int multi = producto * num4;
            int divi = multi / num5;

            Console.WriteLine("La suma de los num1 y num2 es : "+ suma);
            Console.WriteLine("El producto de num3 es: "+producto);
            Console.WriteLine("El resultado dela multiplicacion con num4 es : "+multi);
            Console.WriteLine("El resultado de la division de num5 es de : "+divi);
            Console.ReadKey();
        }
    }
}
