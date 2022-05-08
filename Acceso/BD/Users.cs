using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Acceso.Model;

namespace Acceso.BD
{
    public class Users
    {
		SqlConnection db = BDRecursosHumanos.GetConnection();
		public Boolean Add(User user)
		{
			String sql = $"INSERT INTO Users (nombreusuario, contraseña) " +
				$"VALUES ('{user.nombreusuario}',@contraseña)";

			SqlCommand cmd = new SqlCommand(sql, db);

			var passwordParam = new SqlParameter("@contraseña", System.Data.SqlDbType.VarBinary)
			{
				Value = user.contraseña
			};

			cmd.Parameters.Add(passwordParam);

			try
			{
				db.Open();

				cmd.ExecuteNonQuery();

				return true;
			}
			catch (Exception)
			{
				return false;
			}
			finally
			{
				db.Close();
			}


		}

		public User Find(User user)
		{
			String sql = $"SELECT name FROM Users " +
				$"WHERE nombreusuario = @nombreusuario AND contraseña=@contraseña";

			SqlCommand cmd = new SqlCommand(sql, db);

			var userParam = new SqlParameter("@nombreusuario", System.Data.SqlDbType.VarChar)
			{
				Value = user.nombreusuario
			};
			cmd.Parameters.Add(userParam);

			var passwordParam = new SqlParameter("@contraseña", System.Data.SqlDbType.VarBinary)
			{
				Value = user.contraseña
			};
			cmd.Parameters.Add(passwordParam);

			try
			{
				db.Open();

				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.HasRows)
				{
					reader.Read();

					user.nombreusuario = reader.GetString(0);
				}
				else
				{
					user = null;
				}

				return user;

			}
			catch (Exception)
			{
				return null;
			}
			finally
			{
				db.Close();
			}
		}
	}
}
