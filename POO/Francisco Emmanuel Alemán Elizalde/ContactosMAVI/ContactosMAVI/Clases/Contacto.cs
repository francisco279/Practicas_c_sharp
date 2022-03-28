using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactosMAVI.Clases
{
    class Contacto
    {
        private Conexion conexion = new Conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        
        
        //variables de la clase contacto
        private string nombre;
        private string telefono_fijo;
        private string telefonoMovil;
        private string fecha_Nacimiento;
        private string sexo;
        private int id;
        private string tipoContacto;

        /// Metodos GET y SET

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

       
        public string Telefono_Fijo
        {
            get { return telefono_fijo; }
            set { telefono_fijo = value; }
        }

        

        public string Telefono_Movil
        {
            get { return telefonoMovil; }
            set { telefonoMovil = value; }
        }

        
        public string Fecha_Nacimiento
        {
            get { return fecha_Nacimiento; }
            set { fecha_Nacimiento = value; }
        }

        

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        private string estadoCivil;

        public string EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }

       

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        

        public string TipoContacto
        {
            get { return tipoContacto; }
            set { tipoContacto = value; }
        }


        //Busca un contacto por nombre y lo muestra en un datatable 
        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarContactos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", this.Nombre);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerraConexion();
            return tabla;
        }

        //muestra todos los contactos existentes
        public DataTable MostrarTodos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarTodos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerraConexion();
            return tabla;
        }

        //funcion para eliminar un contacto 
        public void Eliminar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarContacto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", this.id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Insertar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarContacto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@tipo", this.TipoContacto);
            comando.Parameters.AddWithValue("@nombre", this.Nombre);
            comando.Parameters.AddWithValue("@telefonoFijo", this.telefono_fijo);
            comando.Parameters.AddWithValue("@telefonoMovil", this.Telefono_Movil);
            comando.Parameters.AddWithValue("@fecha", this.Fecha_Nacimiento);
            comando.Parameters.AddWithValue("@sexo", this.Sexo);
            comando.Parameters.AddWithValue("@estadoCivil", this.EstadoCivil);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditartarContacto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", this.ID);
            comando.Parameters.AddWithValue("@tipo", this.TipoContacto);
            comando.Parameters.AddWithValue("@nombre", this.Nombre);
            comando.Parameters.AddWithValue("@telefonoFijo", this.telefono_fijo);
            comando.Parameters.AddWithValue("@telefonoMovil", this.Telefono_Movil);
            comando.Parameters.AddWithValue("@fecha", this.Fecha_Nacimiento);
            comando.Parameters.AddWithValue("@sexo", this.Sexo);
            comando.Parameters.AddWithValue("@estadoCivil", this.EstadoCivil);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Buscar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarTodo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", this.ID);
            leer = comando.ExecuteReader();
            if (leer.Read())
            {
                TipoContacto = leer["TipoContacto"].ToString();
                Nombre = leer["Nombre"].ToString();
                Telefono_Fijo = leer["Telefono_fijo"].ToString();
                telefonoMovil = leer["Telefono_movil"].ToString();
                Fecha_Nacimiento = leer["Fecha_nac"].ToString();
                Sexo = leer["Sexo"].ToString();
                EstadoCivil = leer["Estado_civil"].ToString();
            }
            comando.Parameters.Clear();
            conexion.CerraConexion();
        }

        public void BuscarId()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarId";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", this.Nombre);
            leer = comando.ExecuteReader();
            if (leer.Read())
            {
                ID = Convert.ToInt32(leer["idContacto"]);
            }
            comando.Parameters.Clear();
            conexion.CerraConexion();
        }


    }
}

