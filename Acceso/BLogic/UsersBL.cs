using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Acceso.BD;
using Acceso.Model;

namespace Acceso.BLogic
{
    public class UsersBL
    {
		byte[] encrypt(string text)
		{
			MD5 md5 = new MD5CryptoServiceProvider();
			md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(text));

			return md5.Hash;
		}

		public String Login(UserViewModel user)
		{
			User userLogin = new User();
			userLogin.nombreusuario = user.nombreusuario;
			userLogin.contraseña = encrypt(user.contraseña);

			Users users = new Users();
			User userEncontrado = new User();

			userEncontrado = users.Find(userLogin);

			if (userEncontrado == null)
			{
				return "Usuario o contraseña incorrectos";
			}
			else
			{
				return "Bienvenido ";
			}

		}

		public String RegistrarUsuario(UserViewModel user)
		{
			User userInsert = new User();

			userInsert.nombreusuario = user.nombreusuario;
			

			userInsert.contraseña = encrypt(user.contraseña);

			Users users = new Users();

			Boolean inserted = users.Add(userInsert);

			if (inserted)
			{
				return "Usuario insertado";
			}
			else
			{
				return "Error al registrar usuario";
			}

		}
	}
}
