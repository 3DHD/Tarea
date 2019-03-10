using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ejer16
    {
        public void invento()
        {
            int naci, dia, mes, resul;
            int year2 = 2019;

            Console.WriteLine("ingrese el dia en numeros : ");
            dia = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el mes en numeros : ");
            mes = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el año de nacimiento :");
            naci = int.Parse(Console.ReadLine());
            resul = year2 - naci;



            if (resul == 0 && resul < 1)
            {
                Console.WriteLine("su edad es de : " + resul + " dias: " + dia + " mes: " + mes);
                Console.WriteLine("por lo tanto es un bebe");
                Console.ReadKey();
            }
            else if (resul >= 2 && resul <= 12)
            {
                Console.WriteLine("su edad es " + resul + "dias" + dia + " mes " + mes);
                Console.WriteLine("por lo tanto es un niño");
                Console.ReadKey();
            }
            else if (resul > 13 && resul <= 21)
            {
                Console.WriteLine("su edad es de : " + resul);
                Console.WriteLine("por lo tanto es un joven");
                Console.ReadKey();
            }
            else if (resul > 22 && resul < 40)
            {
                Console.WriteLine("su edad es de :" + resul);
                Console.WriteLine("por lo tanto es un adulto");
                Console.ReadKey();
            }
            else if (resul < 0 && resul > 120)
            {
                Console.WriteLine("Error ");
                Console.ReadKey();
            }

        }
    }
}
