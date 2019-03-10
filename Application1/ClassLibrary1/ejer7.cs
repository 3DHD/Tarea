using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ejer7
    {
        public void calcu2()
        {
            double resul1, resul2, resul3;

            Console.WriteLine("ingrese un numero");
            // double num = Convert.ToInt32(Console.ReadLine());
            double num = double.Parse(Console.ReadLine());
            resul1 = num * 0.30;
            resul2 = num * 0.60;
            resul3 = num * 0.90;

            Console.WriteLine(" el 30% del numero es : " + resul1);
            Console.WriteLine(" el 60% del numero es : " + resul2);
            Console.WriteLine(" el 90% del numero es : " + resul3);
            Console.ReadKey();
        }
    }
}
