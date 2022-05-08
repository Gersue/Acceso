using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Acceso.BD
{
    public class TablaList
    {
        private BD connection = new BD();
        private SqlCommand cmd = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable ListarParentesco()
        {
            DataTable Tabla = new DataTable();
            cmd.Connection = connection.Abrirconexion();
            cmd.CommandText = "listarParentesco";
            cmd.CommandType = CommandType.StoredProcedure;
            LeerFilas = cmd.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            connection.CerrarConexion();
            return Tabla;
        }

        //Vista para guia telefonica
        public DataTable listarCompanyTelefonico()
        {
            DataTable Tabla = new DataTable();
            cmd.Connection = connection.Abrirconexion();
            cmd.CommandText = "listarCompanyTelefonico";
            cmd.CommandType = CommandType.StoredProcedure;
            LeerFilas = cmd.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            connection.CerrarConexion();
            return Tabla;
        }

        //Vista para Jornada Laboral
        public DataTable listarJornadaL()
        {
            DataTable Tabla = new DataTable();
            cmd.Connection = connection.Abrirconexion();
            cmd.CommandText = "listarJornadaL";
            cmd.CommandType = CommandType.StoredProcedure;
            LeerFilas = cmd.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            connection.CerrarConexion();
            return Tabla;
        }
    }
}
