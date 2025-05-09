using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataTranfer;

namespace DataLayer
{
    public class NhanVienDL : DataProvider
    {
        public List<NhanVien> GetNhanViens()
        {
            string sql = "SELECT id, [username]\r\nFROM [USER]";
            int id;
            string name;
            List<NhanVien> nhanViens = new List<NhanVien>();
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    id = (int)reader[0];
                    name = reader[1].ToString();
                    NhanVien nhanVien = new NhanVien(id, name);
                    nhanViens.Add(nhanVien);
                }
                reader.Close();
                return nhanViens;
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

        public List<NhanVien> GetNhanViens_Full()
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            string sql = "SELECT id, username, password, user_role, name, date_join FROM [User]";

            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string username = reader["username"].ToString();
                    string password = reader["password"].ToString();
                    string role = reader["user_role"].ToString();
                    string name = reader["name"].ToString();
                    DateTime dateJoin = (DateTime)reader["date_join"];

                    NhanVien nv = new NhanVien(id, username, password, role, name, dateJoin);
                    nhanViens.Add(nv);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }

            return nhanViens;
        }

        public bool UpdateUser(int id, string password, string role, string name)
        {
            string sql = "UPDATE [User] SET password = @password, user_role = @role,name = @name WHERE id = @id";

            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);

                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
            catch
            {
                return false;
            }
            finally
            {
                Disconnect();
            }
        }

        public bool DeleteUser(int id)
        {
            string sql = "DELETE FROM [User] WHERE id = @id";

            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id", id);

                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
            catch
            {
                return false;
            }
            finally
            {
                Disconnect();
            }
        }

        //Kiểm tra đã tồn tại username
        public bool IsUsernameExists(string username)
        {
            string sql = "SELECT COUNT(*) FROM [User] WHERE username = @username";

            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@username", username);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch
            {
                return true; // phòng trường hợp lỗi thì không thêm
            }
            finally
            {
                Disconnect();
            }
        }

        public bool InsertUser(string username, string password, string role, string name)
        {
            string sql = "INSERT INTO [User] (username, password, user_role,name, date_join) " +
                         "VALUES (@username, @password, @role,@name, GETDATE())";

            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@name", name);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch
            {
                return false;
            }
            finally
            {
                Disconnect();
            }
        }

    }
}
