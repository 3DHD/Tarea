using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ejer8
    {
        public void area()
        {
            double A;
            Console.WriteLine("ingrese la base del cuadrado :");
            double B = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del cuadrado :");
            double alt = Convert.ToDouble(Console.ReadLine());

            A = B * alt;
            Console.WriteLine("El area es  : "+ A + ": metros cuadrados");
            Console.ReadKey();
        }
    }
}
