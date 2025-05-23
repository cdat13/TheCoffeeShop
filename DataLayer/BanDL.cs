﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataTranfer;

namespace DataLayer
{
    public class BanDL : DataProvider
    {
        public List<Ban> GetBans()
        {
            string sql = "SELECT * FROM [Table]"; // Dung bang Table phai bo vao []
            int id;
            bool status;
            DateTime datetime;
            List<Ban> bans = new List<Ban>();
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    id = (int)reader[0];
                    status = (bool)reader[1];
                    datetime = (DateTime)reader[2];
                    Ban ban = new Ban(id, status, datetime);
                    bans.Add(ban);
                }
                reader.Close();
                return bans;
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

        public int Update(Ban ban)
        {
            string sql = "UpdateTable";
            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@table_id", ban.Id));

            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        
    }
}
