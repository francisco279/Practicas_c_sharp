using System.Data;
using System.Data.SqlClient;

namespace Login.CLASES
{
    class UserDao : Conexion
    {

        //instanciamos la clase de conexion a la base de datos
        private Conexion Conexion = new Conexion();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader reader;
        public void Login(string user, string pass)
        {
     
                Comando.Connection = Conexion.AbrirConexion();
                Comando.CommandText = "Buscar";
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@usu", user);
                Comando.Parameters.AddWithValue("@pas", pass);

                reader = Comando.ExecuteReader();
                
                    if (reader.Read())
                    {
                    
                        //Asignamos los valores encontrados que se leen a las variables del Usuario
                        
                        UserCache.IdUser      = reader.GetInt32(0);
                        UserCache.LoginName   = reader.GetString(1);
                        UserCache.Password    = reader.GetString(2);
                        UserCache.FirstName   = reader.GetString(3);
                        UserCache.LastName    = reader.GetString(4);
                        UserCache.Position    = reader.GetString(5);
                        UserCache.Email       = reader.GetString(6);

                  
                    }

                    Comando.Parameters.Clear();
                    Conexion.CerrarConexion();

        }
    }
}
