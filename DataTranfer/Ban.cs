using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTranfer
{
    public class Ban
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public DateTime Datetime { get; set; }
        public Ban(int id, bool status, DateTime datetime)
        {
            Id = id;
            Status = status;
            Datetime = datetime;
        }
    }
}
