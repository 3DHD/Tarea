using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ejer15
    {
        public void compra()
        {
            int cant;
            float prec, import;
            string linea;

            Console.WriteLine("Ingrese la cantidad del articulo a llevar :");
            linea = Console.ReadLine();
            cant = int.Parse(linea);

            Console.WriteLine("Ingrese el valor unitario del producto :");
            linea = Console.ReadLine();

            prec = float.Parse(linea);
            import = prec * cant;
            Console.WriteLine("El importe a pagar es de :"+ import);
            Console.ReadKey();

        }
    }
}
