using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTranfer
{
  
        public class User
        {
            public int Id { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string User_role { get; set; } 
            public string Name { get; set; }

            public User() { }

            public User(int id, string username, string password, string user_role, string name)
            {
                Id = id;
                Username = username;
                Password = password;
                User_role = user_role;
                Name = name;
            }
        }
    }

