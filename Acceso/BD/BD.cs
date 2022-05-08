using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Acceso.BD
{
    public class BD
    {
        private SqlConnection conexion = new SqlConnection("Server=DESKTOP-7NLEOA0\\SA;DataBase= RECURSOSHUMANOS; Integrated Security=true");

        public SqlConnection Abrirconexion()
        {
            if(conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
    }
}
