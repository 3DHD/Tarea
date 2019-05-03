using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaData;

namespace capaNego
{
    public class mantoVendor
    {
        bdconect tes = new bdconect();
        public string prueba()
        {
            String mensaje;
            if (tes.conectar()==true)
            {
                tes.conectar();
                mensaje = "Conexion realizada";
            }
            else
            {
                tes.Desconectar();
                mensaje = "Conexion no realizada";      
            }
            return mensaje;
        }
    }
}
