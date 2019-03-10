using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ejer14
    {
        public void cuatro()
        {
            Console.WriteLine("Digite 4 numeros ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());

            int suma = num1 + num2 + num3 + num4;
            int promedio = suma / 4;

            Console.WriteLine("La sumatoria de los 4 numeros es : "+ suma);
            Console.WriteLine("El promedio de los 4 numeros es : "+promedio);
            Console.ReadKey();
        }
    }
}
