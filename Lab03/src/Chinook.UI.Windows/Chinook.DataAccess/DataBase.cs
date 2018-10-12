using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.DataAccess
{
    public class DataBase
    {
        public IDbConnection CreateConnection()
        {
            string cadenaConexion = "Data Source=.;" +
                                    "Initial Catalog=Chinook; " +
                                    "User ID=sa; Password=sql";

            return new SqlConnection(cadenaConexion);
        }
    }
}
