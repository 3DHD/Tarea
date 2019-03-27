using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Multi
    {
        private double valor1, valor2, resultado;

        public double Resultado
        {
            get
            {
                return resultado;
            }

            set
            {
                resultado = value;
            }
        }

        public double Valor1
        {
            get
            {
                return valor1;
            }

            set
            {
                valor1 = value;
            }
        }

        public double Valor2
        {
            get
            {
                return valor2;
            }

            set
            {
                valor2 = value;
            }
           
        }
        public Multi()
        {
           this.valor1 = 0;
            this.valor2 = 0;
        }
        public double calcular()
        {
            resultado = valor1 * valor2;
            return resultado;
        }
    }
}
