using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso.Model
{
    public class User
    {
        public int codigousuario { get; set; }
        public string nombreusuario { get; set; }
        public byte[] contraseña { get; set; }
    }
}
