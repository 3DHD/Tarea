using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ejer11
    {
        public void salario()
        {
            Console.WriteLine("Ingrese el salario diario del empleado");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese los dias trabajados del empelado");
            int dias = int.Parse(Console.ReadLine());

            double total = (salario * dias);
            double totalpension = (total -(total* 0.10));
            double totaliss = (total -(total* 0.15));
            double totalpag = total + totaliss - totalpension;

            Console.WriteLine("El salario  a pagar con descuento de isss y afp es de : "+totalpag);
            Console.ReadKey();
        }
    }
}
