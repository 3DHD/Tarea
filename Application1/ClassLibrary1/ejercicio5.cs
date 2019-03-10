using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ejercicio5
    {
        public void Caledad()
        {
            int fecha, year2, naci;

            Console.WriteLine("Ingrese el año actual :");
            year2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la fecha de nacimiento :");
            fecha = int.Parse(Console.ReadLine());

            naci = year2 - fecha;

            Console.WriteLine("Su fecha de nacimiento es : "+naci + "");
            Console.ReadKey();

    

        }
    }
}
