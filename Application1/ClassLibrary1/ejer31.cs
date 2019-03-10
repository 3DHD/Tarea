using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ejer31
    {
        public void deporte()
        {
            Console.WriteLine("Ingrese la edad del depoprtista");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la estatura del depoprtista ");
            double est = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el peso del deportista ");
            double peso = Convert.ToDouble(Console.ReadLine());

            if (edad <= 18)
            {
                if (est > 180)
                {
                    if (peso <= 80)
                    {
                        Console.WriteLine("has sido aceptado");
                    }
                }
            }
            else if (edad <= 18)
            {
              
            }
        }
    }
}
