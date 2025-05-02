using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTranfer
{
    public class WorkDay
    {
        public string Id { get; set; }
        public string WorkDay_Name { get; set; }
        public string User_Name { get; set; }
        public string User_Role { get; set; }
        public DateTime Date { get; set; }
        public int User_Id { get; set; }

        public WorkDay(string id, string workDay_Name, string user_Name, string user_Role, DateTime date)
        {
            Id = id;
            WorkDay_Name = workDay_Name;
            User_Name = user_Name;
            User_Role = user_Role;
            Date = date;
        }

        public WorkDay(int user_id, string calam_id, DateTime date)
        {
            Id = calam_id;
            Date = date;
            User_Id = user_id;
        }
    

    }
}
