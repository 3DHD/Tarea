using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ejer17
    {
        public void lecto()
        {
            Console.WriteLine("ingrese un numero ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1<0)
            {
                Console.WriteLine("El numero ingresado es negativo "+ num1);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El numero ingresado es positivo : "+num1);
                Console.ReadKey();
            }
        }
    }
}
