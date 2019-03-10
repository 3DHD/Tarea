using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ejer10
    {
        public void tienda()
        {
            Console.WriteLine("precio unitario del articulo");
            double art = double.Parse(Console.ReadLine());

            Console.WriteLine("Cantidad de articulos comprados");
            int prec = Convert.ToInt32(Console.ReadLine());

            double total = prec * art;
            double totalpag = (prec * art * 0.13)+total;

            Console.WriteLine("El total a pagar sin iva es de : "+total);
            Console.WriteLine("El total a pagar con el iva (13%) es de :"+totalpag);
            Console.ReadKey();
        }
    }
}
