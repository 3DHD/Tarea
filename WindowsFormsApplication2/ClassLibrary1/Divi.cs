using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Divi
    {
        private double campo1, campo2, resultado;

        public double Campo1
        {
            get
            {
                return campo1;
            }

            set
            {
                campo1 = value;
            }
        }

        public double Campo2
        {
            get
            {
                return campo2;
            }

            set
            {
                campo2 = value;
            }
        }

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

        public Divi()
        {
            this.campo1 = 0;
            this.campo2 = 0;
        }
        public double calcular()
        {
            resultado = campo1 / campo2;
            return resultado;
        }
    }
}
