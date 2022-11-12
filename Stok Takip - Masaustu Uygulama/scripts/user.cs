using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takip___Masaustu_Uygulama.scripts
{
    internal class user
    {
        public int userRegister(string userName, string Password)
        {
            try
            {
                database newConnection = new database();
                newConnection.Connection();
                database.sqlConnection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = database.sqlConnection;
                cmd.CommandText = "insert into users values('@userName','@userPassword',@userAuthorization,@active);";
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@userPassword", Password);
                cmd.Parameters.AddWithValue("@userAuthorization", 0);
                cmd.Parameters.AddWithValue("@active", 0);
                cmd.ExecuteNonQuery();
                database.sqlConnection.Close();
            }
            catch (Exception)
            {
                return 1;
            }
            return 0;
        }
        public void userLogin()
        {

        }
    }
}
