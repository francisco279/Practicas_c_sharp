using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEMPLO.CLASES
{
    class ConexionBD
    {
        public SqlConnection LaConexion = new SqlConnection("Data Source=.;Initial Catalog=Registro;Integrated Security=True");

        public SqlConnection AbrirConexion()
        {
            if (LaConexion.State == ConnectionState.Closed)
            {
                LaConexion.Open();
            }
            return LaConexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (LaConexion.State == ConnectionState.Open)
            {
                LaConexion.Close();
            }
            return LaConexion;
        }
    }
}
