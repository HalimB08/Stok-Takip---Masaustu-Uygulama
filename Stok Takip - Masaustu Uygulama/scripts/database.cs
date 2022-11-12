using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takip___Masaustu_Uygulama.scripts
{
    internal class database
    {
        public static SqlConnection sqlConnection = new SqlConnection();
        string serverName = "DESKTOP-NJD6BE3\\SQLEXPRESS";
        string databaseName = "stokkayit_bs";
        string username = "admin";
        string password = "123";
        public void Connection()
        {
            string connectionString = @"Data Source=" + serverName + ";Initial Catalog=" + databaseName + ";Persist Security Info=True;User ID=" + username + ";Password=" + password + ";";
            sqlConnection.ConnectionString = connectionString;
        }
    }
}
