using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEMPLO.CLASES
{
    class Chofer : Empleados
    {
        private ConexionBD conexion = new ConexionBD();
        SqlCommand comando = new SqlCommand();
        private string licencia;

        public string Licencia
        {
            get { return licencia; }
            set { licencia = value; }
        }

        //constructor 
        public Chofer(string nombre, int edad, string foto, string tipoempleado, string licencia)
            :base(nombre, edad, foto, tipoempleado)
        {
            this.Licencia = licencia;
        }

        public void EditarChofer(int clave)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "editarChofer";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@licencia", this.Licencia);
            comando.Parameters.AddWithValue("@clave", clave);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

    }
}
