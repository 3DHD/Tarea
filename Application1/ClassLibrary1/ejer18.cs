using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ejer18
    {
        public void mayor()
        {
            Console.WriteLine("Ingrese un numero :");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("El primer numero ingresado es mayor : "+num1);
                Console.ReadLine();
            }
            else if (num1 < num2)
            {
                Console.WriteLine("El segundo numero ingresado es mayor : "+num2);
                Console.ReadLine();
            }
            else if(num1 == num2)
            {
                Console.WriteLine(" Error, los dos numeros son iguales");
                Console.ReadKey();
            }

        }
    }
}
