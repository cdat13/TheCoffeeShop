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
    public class WorkDayDL : DataProvider
    {
        public List<WorkDay> GetWorkDays()
        {
            string sql = "SELECT PhanCongCaLam.id, CaLamViec.[name], [User].[name], [User].user_role, PhanCongCaLam.ngayLam\r\nFROM CaLamViec\r\nINNER JOIN PhanCongCaLam ON CaLamViec.id_name = PhanCongCaLam.calam_id\r\nINNER JOIN [User] ON PhanCongCaLam.[user_id] = [User].id";
            string id, workdayName, userName, userRole;
            DateTime workDate;
            List<WorkDay> workDays = new List<WorkDay>();
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    id = reader[0].ToString();
                    workdayName = reader[1].ToString();
                    userName = reader[2].ToString();
                    userRole = reader[3].ToString();
                    workDate = DateTime.Parse(reader[4].ToString());
                    WorkDay workDay = new WorkDay(id, workdayName, userName, userRole, workDate);
                    workDays.Add(workDay);
                }
                reader.Close();
                return workDays;
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

        public int ThemCaLam(int user_id, string calam_id, DateTime date)
        {
            string sql = "PhanCong";
            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@user_id", user_id));
            parameters.Add(new SqlParameter("@ngayLam", date ));
            parameters.Add(new SqlParameter("@calam_id", calam_id));

            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters);
            } 
            catch (SqlException ex)
            {
                throw ex;
            }
        } 

        public int XoaCaLam(int id)
        {
            string sql = "XoaCaLam";

            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@id", id));

            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

        public int SuaCaLam(int id, DateTime date, string workday_name, string user_name)
        {
            string sql = "SuaCaLam";

            List<SqlParameter> parameters = new List<SqlParameter>();

            parameters.Add(new SqlParameter("@id", id));
            parameters.Add(new SqlParameter("@date", date));
            parameters.Add(new SqlParameter("@workday_name", workday_name));
            parameters.Add(new SqlParameter("@user_name", user_name));


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
