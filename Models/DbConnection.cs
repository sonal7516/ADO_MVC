using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SonalCRUD_ADO.Models
{
    public class DbConnection
    {
        public SqlConnection Connection;
        public DbConnection()
        {
            Connection = new SqlConnection(DBConfig.ConnectionStr);
        }
    }
}
