using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ejer38
    {
        public void Impares()
        {
            int  impar = 0;
           
            for (int i = 201; i < 500; i++)
            {
                if (i % 2 !=0)
                {
                    Console.WriteLine("{0}",i);
                   impar++;
                }
            }
            Console.WriteLine("\n");
        }
    }
}
