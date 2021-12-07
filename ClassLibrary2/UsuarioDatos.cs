 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 
using System.Data.SqlClient;

namespace AccesoAdatos
{
   public class UsuarioDatos:ConexionSQL
    {
        //parametros de la entrada 
        public bool Login(string user, string pass)
        {

            using (var connection = GetConnection()) {

                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandText = "select * from dbo.Usuarios where Usu_Usuario = @Usuario and Usu_Contraseña = @Contraseña";
                    command.Parameters.AddWithValue("@Usuario", user);
                    command.Parameters.AddWithValue("@Contraseña", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)

                    {
                        return true;
                    }
                    else
                        return false;
                    }

            }

        }

    }
}
