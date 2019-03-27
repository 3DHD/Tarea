using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Operaciones
    {
        private double v1, v2, ressultado;

        public double Ressultado
        {
            get { return ressultado; }
            set { ressultado = value; }
        }

        public double V1
        {
            get { return v1; }
            set { v1 = value; }
        }

        public double V2
        {
            get { return v2; }
            set { v2 = value; }
        }

        public Operaciones()
        {
            this.v1 = 0;
            this.v2 = 0;
        }
        public double calcular()
        {
            ressultado = v2 + v1;
            return ressultado;
        }
    }
}
