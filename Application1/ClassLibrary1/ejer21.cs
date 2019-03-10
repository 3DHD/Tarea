using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ejer21
    {
        public void  numero()
        {
            Console.WriteLine("Ingrese 2 numero :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2 ) 
            {
                int resul = num1 - num2;
                Console.WriteLine("La resta de los numeros es : "+resul);
                Console.ReadKey();
            }
            else 
            {
                int resul = num1 + num2;
                Console.WriteLine("La suma de los numeros es : "+resul);
                Console.ReadKey();
            }

        }
    }
}
