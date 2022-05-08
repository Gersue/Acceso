using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Acceso.BD
{
    public class BDRecursosHumanos
    {
		public static SqlConnection GetConnection()
		{
			
			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
			builder.DataSource = "DESKTOP-7NLEOA0\\SA";
			builder.UserID = "sa";
			builder.Password = "isi2022/*";
			builder.InitialCatalog = "RECURSOSHUMANOS";

			SqlConnection connection = new SqlConnection(builder.ConnectionString);
			
			return connection;
		}
		

	}
}
