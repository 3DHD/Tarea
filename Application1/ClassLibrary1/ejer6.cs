using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class ejer6
    {
       public  void calcular()
        {
            double num, resul;
            Console.WriteLine("ingrese un numero por favor : ");
           num =Convert.ToInt32(Console.ReadLine());
            resul = num * 0.20;

            Console.WriteLine("el 20% del numero ingresado es : " + resul);
            Console.ReadKey();
        }
    }
}
