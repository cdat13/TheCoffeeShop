using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataLayer;
using DataTranfer;

namespace BusinessLayer
{
    public class WorkDayBL
    {
        private WorkDayDL workDayDL;
        public WorkDayBL()
        {
            workDayDL = new WorkDayDL();
        }
        public List<WorkDay> GetWorkDays()
        {
            try
            {
                return (workDayDL.GetWorkDays());
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
