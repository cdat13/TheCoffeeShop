﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataTranfer
{
    public class DataProvider
    {
        private SqlConnection cn;
        SqlCommand cmd;

        public DataProvider()
        {
            string cnStr = "Data Source=LAPTOP-V0546IIT;Initial Catalog=CoffeShop;Integrated Security=True";
            cn = new SqlConnection(cnStr);
        }

        public void Connect()
        {
            try
            {
                if (cn != null && cn.State == System.Data.ConnectionState.Closed)
                {
                    cn.Open();
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public void Disconnect()
        {
            try
            {
                if (cn == null && cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public object MyExecuteScalar(string sql, CommandType type)
        {
            try
            {
                Connect();
                cmd = new SqlCommand(sql, cn);
                cmd.CommandType = type;

                return (cmd.ExecuteScalar());
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

        public SqlDataReader MyExecuteReader(string sql, CommandType type, List<SqlParameter> parameters = null)
        {
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = type;

            if (parameters != null)
            {
                foreach (SqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
            }

            try
            {
                return (cmd.ExecuteReader());
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int MyExecuteNonQuery(string sql, CommandType type, List<SqlParameter> parameters = null)
        {
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = type;

            if (parameters != null)
            {
                foreach (SqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
            }

            try
            {
                Connect();
                return (cmd.ExecuteNonQuery());
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
