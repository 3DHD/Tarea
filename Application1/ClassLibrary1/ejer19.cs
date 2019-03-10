using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ejer19
    {
        public void refrigerio()
        {
            Console.WriteLine("Desean refrigerio los alumnos  si(1) /no(2) ? ");
            int respuesta = int.Parse(Console.ReadLine());

            Console.WriteLine("que grado desea el refrigerio ?");
            int resp = int.Parse(Console.ReadLine());

            if (respuesta == 1 && resp <= 6)
            {
                Console.WriteLine("Su refrigerio va en camino!!!");
                Console.ReadKey();
            }
            else if (respuesta == 2 && resp <= 6)
            {
                Console.WriteLine("Por favor no este molestando");
                Console.ReadKey();
            }
            else if (respuesta == 2 && resp >= 6 )
            {
                Console.WriteLine("bueno y entonces, que quiere?");
                Console.ReadKey();
            }
            else if (respuesta == 1 && resp >= 6)
            {
                Console.WriteLine("Lo sentimos solo de 6° se les permite ");
                Console.ReadKey();
            }

        }
    }
}
