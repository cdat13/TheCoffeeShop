using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTranfer;
using System.Data.SqlClient;
using System.Data;

namespace DataLayer
{
    public class UserDL : DataProvider 
    {
        public User GetUser(string username, string password)
        {
            string sql = "SELECT * FROM [User] WHERE username = @username AND password = @password";
            List<SqlParameter> prms = new List<SqlParameter>
            {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
            };

            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text, prms);
                if (reader.Read())
                {
                    User user = new User
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        Username = reader["username"].ToString(),
                        Password = reader["password"].ToString(),
                        User_role = reader["user_role"].ToString(),
                        Name = reader["name"].ToString()
                    };
                    reader.Close();
                    return user;
                }
                reader.Close();
                return null;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }
        }      
    }
}
