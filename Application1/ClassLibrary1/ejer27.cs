using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ejer27
    {
        public void compras()
        {
            Console.WriteLine("Ingrese el valor de la compra");
            double comp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de articulos ");
            int cant = int.Parse(Console.ReadLine());

            double total = comp * cant;


            if (total < 20000)
            {
                double desc = (total - (total * 0.15));
                Console.WriteLine("Felicidaedes uted tiene un descuento de 15 %"+desc);
                Console.ReadKey();
            }
            else
            {
                double desc = (total - (total * 0.35));
                Console.WriteLine("Felicidades usted tiene un descuento de 20 %" +desc);
                Console.ReadKey();
            }

        }
    }
}
