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
        
    }
}
