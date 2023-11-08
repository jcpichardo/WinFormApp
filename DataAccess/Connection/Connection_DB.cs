using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Connection
{


    public class Connection_DB
    {
        private static string _connectionstring = "Data Source=Server_Name;Initial Catalog = db_ejemplo; User ID = sa; Password=Contraseña;Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private SqlConnection _conn = new SqlConnection(_connectionstring);

        public SqlConnection OpenConnection()
        {
            try
            {
                if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }
                return _conn;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public SqlConnection CloseConnection()
        {
            try
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
                return _conn;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
