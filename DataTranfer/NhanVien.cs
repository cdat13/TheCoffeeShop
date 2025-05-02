using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTranfer
{
    public class NhanVien
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public NhanVien(int id, string name )
        {
            Id = id;
            Name = name;

        }
    }
}
