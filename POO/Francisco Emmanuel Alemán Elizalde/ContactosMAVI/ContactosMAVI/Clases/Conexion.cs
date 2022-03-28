using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Data;

namespace ContactosMAVI.Clases
{
    class Conexion
    {
        static private string CadenaConexion = "Data Source=.;Initial Catalog=Contactos;Integrated Security=True";
        private SqlConnection MiConexion = new SqlConnection(CadenaConexion);

        //metodo para abrir conexion
        public SqlConnection AbrirConexion()
        {
            if (MiConexion.State == ConnectionState.Closed)
            {
                MiConexion.Open();
            }
            return MiConexion;
        }

        //metodo para cerra conexion
        public SqlConnection CerraConexion()
        {
            if (MiConexion.State == ConnectionState.Open)
            {
                MiConexion.Close();
            }
            return MiConexion;
        }
    }
}
