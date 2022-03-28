using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.CLASES
{
    class Conexion
    {
        static private string CadenaConexion = "Data Source=.;Initial Catalog=MyCompany;Integrated Security=True";
        private SqlConnection ConexionBD = new SqlConnection(CadenaConexion);
        public SqlConnection AbrirConexion()
        {
            if (ConexionBD.State == ConnectionState.Closed)
                ConexionBD.Open();
            return ConexionBD;
        }
        public SqlConnection CerrarConexion()
        {
            if (ConexionBD.State == ConnectionState.Open)
                ConexionBD.Close();
            return ConexionBD;
        }
    }
}

