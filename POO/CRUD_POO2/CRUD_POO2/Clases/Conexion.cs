using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CRUD_POO2.Clases
{
    class Conexion
    {
        public SqlConnection LaConexion = new SqlConnection("Data Source =.; Initial Catalog = PRODUCTOS_WC; Integrated Security = True");

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
