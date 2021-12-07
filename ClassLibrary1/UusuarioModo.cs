 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoAdatos;


namespace Dominio
{
    #region Usario 
    public class UsuarioModo

    {
        UsuarioDatos usuarioDatos = new UsuarioDatos();
        public bool InicioSecion(string user, string pass) {

            return usuarioDatos.Login(user, pass);

        }
       
    }
    #endregion
}
