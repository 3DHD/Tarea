using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class ejer12
    {
        public void cuadrado2()
        {
            int lado, perimetro;
            string linea;

            Console.WriteLine("Ingreseel lado del cuadrado");
            linea = Console.ReadLine();
            lado = int.Parse(linea);
            perimetro = lado + 4;

            Console.WriteLine("El perimetro del cuadrado es : "+ perimetro);
            Console.ReadKey();
        }
    }
}
