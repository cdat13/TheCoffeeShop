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
            string sql = "SELECT CaLamViec.id, CaLamViec.[name],[User].[name], [User].user_role ,CaLamViec.[date] " +
                "FROM CaLamViec " +
                "INNER JOIN PhanCongCaLam ON CaLamViec.id = PhanCongCaLam.calam_id " +
                "INNER JOIN [User] ON PhanCongCaLam.[user_id] = [User].id";
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
            catch (SqlException)
            {

                throw;
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
