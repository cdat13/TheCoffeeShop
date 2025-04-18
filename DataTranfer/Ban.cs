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
        public string Datatime { get; set; }
        public Ban(int id, bool status, string datatime)
        {
            Id = id;
            Status = status;
            Datatime = datatime;
        }
    }
}
