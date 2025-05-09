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
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime DateJoin { get; set; }
        public NhanVien(int id, string name )
        {
            Id = id;
            Name = name;

        }
        public NhanVien(int id, string username, string password, string role, string name, DateTime dateJoin) : this(id, name)
        {
            Id = id;
            Username = username;
            Password = password;

            Role = role;

            DateJoin = dateJoin;

        }
    }
}
