using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AccesoAdatos
{
    public abstract class ConexionSQL
    {
        private readonly string connectionstring;

        public ConexionSQL() {

            connectionstring = "Server= DESKTOP-HK7TVHQ; DataBase= DBConsultorioClinico; integrated security= true";

        }
        protected SqlConnection GetConnection() {

            return new SqlConnection(connectionstring);
        }


    }
}
