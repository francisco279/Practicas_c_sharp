﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CRUD_INENER_JOIN.DATOS
{
    class ClsProductos
    {
        //instanciamos la clase de conexion a la base de datos
        private ConexionBD Conexion = new ConexionBD();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        //listamos la tabla categorias
        public DataTable ListarCategorias()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarCategorias";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable ListarMarcas()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarMarcas";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }

        //En programacionorientada a objetos, estas variables deberia ser iguales a las de mos metodos get 
        //y set para manipularse y no de la misma forma con estos parametros
        public void InsertarProductos(int idCategoria, int idMarca, string descripcion, double precio)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "AgregarProducto";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@idcategoria", idCategoria);
            Comando.Parameters.AddWithValue("@idmarca", idMarca);
            Comando.Parameters.AddWithValue("@descrip", descripcion);
            Comando.Parameters.AddWithValue("@prec", precio);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Conexion.CerrarConexion();
        }

        public DataTable ListarProductos()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarProductos";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }


    }
}
