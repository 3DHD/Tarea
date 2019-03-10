using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ejer9
    {
        public void prome()
        {
            Console.WriteLine("Ingrese 5 numeros:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double num3 = Convert.ToDouble(Console.ReadLine());
            double num4 = Convert.ToDouble(Console.ReadLine());
            double num5 = Convert.ToDouble(Console.ReadLine());

            double resultado = (num1 + num2 + num3 + num4 + num5) / 5;
            Console.WriteLine("El resultado es : "+resultado);
            Console.ReadKey();

        }
    }
}
