using Login.DS.DSAplicacionComercialTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.DS
{
    public class CADUsuario
    {
     
        private static UsuarioTableAdapter adapater = new UsuarioTableAdapter();

        public static bool ValidarUsuario(string IDUsuario, string Clave)
        {
            if ((adapater.ValidaUsuario(IDUsuario, Clave) == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
