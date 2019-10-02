using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDecorador
{
    class Conexion
    {
        public static string SConexion()
        {
            return "Server=tcp:julietpatrones.database.windows.net,1433;Initial Catalog=decoradorbd;Persist Security Info=False;User ID=juliet;Password=admin#123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        }

    }
}
