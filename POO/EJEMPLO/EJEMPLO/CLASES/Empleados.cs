using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEMPLO.CLASES
{
    class Empleados
    {
        private ConexionBD conexion = new ConexionBD();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        DataTable tabla = new DataTable();

        private int clave;
        private string nombre;
        private int edad;
        private string foto;

        public int Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        
        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        private string tipoEmpleado;

        public string TipoEmpleado
        {
            get { return tipoEmpleado; }
            set { tipoEmpleado = value; }
        }

        //Inicializar la clase con el metodo constructor caon
        public Empleados(string nombre, int edad, string foto, string tipoempleado)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Foto = foto;
            this.TipoEmpleado = tipoempleado;
        }

        public Empleados()
        {

        }

        public void Insertar(string escolaridad, string cvu, string licencia)
        {
            if (this.TipoEmpleado == "Profesor")
            {
                
                InsertarEmpleado();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "insertarProfesor";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@escolaridad", escolaridad);
                comando.Parameters.AddWithValue("@cvu", cvu);
                

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            else if (this.TipoEmpleado == "Chofer")
            {
                InsertarEmpleado();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "insertarChofer";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@licencia", licencia);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            
        }



        private void InsertarEmpleado()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insertarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", this.Nombre);
            comando.Parameters.AddWithValue("@edad", this.Edad);
            comando.Parameters.AddWithValue("@foto", this.Foto);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public DataTable Mostrar(int clave)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrarEmpleados";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@clave", clave);
            leer = comando.ExecuteReader();
            tabla.Load(leer);

            conexion.CerrarConexion();
            return tabla;
        }


    }
}
