using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace capaData
{
    public class bdconect
    {
        SqlDataAdapter adaptador;
        SqlCommand comm;
        SqlConnection conexion = new SqlConnection();
        SqlConnection comando;

        public SqlConnection Comando
        {
            get { return comando; }
            set { comando = value; }
        }
        String cadenaConexion = "Data Source=.;Initial Catalog=DBFACTURAS;User ID=juan_perez02;Password=hoy123";

        public bool conectar()
        {
            bool conn = false;
            {
                try
                {
                    conexion.ConnectionString = cadenaConexion;
                    conexion.Open();
                    conn = true;

                }
                catch (Exception)
                {
                    conn = false;
                    
                }
                return conn;
            }
        }
        public void Desconectar() 
        {
            conexion.Close();
        }

    }

}
